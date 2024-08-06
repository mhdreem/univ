using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Volo.Abp;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Uow;

namespace Univ.Hi_Student_Affairs
{
    public class Continent : BasicAggregateRoot<int>
    {


        //اسم القارة
        public string NameAr { get; set; }

        //اسم القارة
        public string NameEn { get; set; }


        //الترتيب
        public int? Ord { get; set; }


        //رمز الفرع بوزارة التعليم
        public virtual int? MinistryEncode { get; set; }


        public virtual string? Barcode { get; set; }




        public virtual ICollection<Country>? Countries { get; protected set; } //Sub collection


        
        public Continent()
        {
            NameAr = "";
            NameEn = "";            
            this.Countries = new Collection<Country>();
        }

        public Continent(int id,string nameAr, string nameEn,  int? ministryEncode, string? barcode, int? ord,ICollection<Country>? countries)
            :base(id)
        {
            try {
                NameAr = Check.NotNullOrWhiteSpace(nameAr, nameof(nameAr), ContinentConsts.MaxNameArLength, 0);
                NameEn = Check.NotNullOrWhiteSpace(nameEn, nameof(nameEn), ContinentConsts.MaxNameEnLength, 0);
                MinistryEncode = ministryEncode;
                Barcode = barcode;
                Ord = ord;

                if (countries is not null &&
                    countries.Count > 0)
                    this.Countries = countries;
                else
                    this.Countries = new Collection<Country>();
                
            } catch (Exception ex){
            }

        }

        public Continent RemoveCountry(int CountryId)
        {
            if (Countries is null ||
                Countries.Count() == 0)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.ContinentZeroLengthOrNullCountriesList);


            var Country = Countries.SingleOrDefault(x => x.Id == CountryId);
            if (Country is null)
            {
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNotExists);
            }
            Countries.Remove(Country);

            return this;
        }


        public Continent AddCountry(                         
             string? nameAr, string? nameEn, int? ministryEncode, string? barcode, int? ord,
             ICollection<City>? cities)
        {
            if (Countries is null ||
                Countries.Count() == 0)
                Countries = new Collection<Country>();


          if (Countries.Where(x=>x.NameAr != null && x.NameAr.Equals(nameAr)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNameArAlreadyExists);


            if (Countries.Where(x => x.NameEn != null && x.NameEn.Equals(nameAr)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNameEnAlreadyExists);

            if (!string.IsNullOrWhiteSpace(barcode) && 
                Countries.Where(x => x.Barcode != null && x.Barcode.Equals(barcode)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryBarcodeAlreadyExists);

            if (ministryEncode != null &&
                Countries.Where(x => x.MinistryEncode != null && x.MinistryEncode == ministryEncode).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryMinistryAlreadyExists);

            
            Countries.Add(new Country(0, 0, nameAr, nameEn, ministryEncode,barcode, ord, cities));
            
            return this;
        }



        public Continent UpdateCountry(
             int countryId,            
             string nameAr, string? nameEn, int? ministryEncode, string? barcode, int? ord,
             ICollection<City> cities)
        {
            if (Countries is null ||
                Countries.Count() == 0)
                Countries = new Collection<Country>();


            var Country= Countries.Single(x => x.Id == countryId);
            if (Country is null)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNotExists);



            if (Countries.Where(x => x.NameAr != null && x.Id!= countryId && x.NameAr.Equals(nameAr)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNameArAlreadyExists);


            if (Countries.Where(x => x.NameEn != null && x.Id != countryId && x.NameEn.Equals(nameAr)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNameEnAlreadyExists);

            if (!string.IsNullOrWhiteSpace(barcode) &&
                Countries.Where(x => x.Barcode != null && x.Id != countryId && x.Barcode.Equals(barcode)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryBarcodeAlreadyExists);

            if (ministryEncode != null &&
                Countries.Where(x => x.MinistryEncode != null && x.Id != countryId && x.MinistryEncode == ministryEncode).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryMinistryAlreadyExists);

            Country.NameAr = nameAr;
            Country.NameEn= nameEn;
            Country.Ord= ord;
            Country.MinistryEncode = ministryEncode;
            Country.Barcode = barcode;
     

            return this;
        }



        public Continent AddCity(
            int countryId,
            string nameAr, string nameEn, int? ord, string? phoneCode, string? barcode, int? ministryEncode
            )
        {            
            var Country = GetCountry(countryId);

            Country.AddCity(nameAr, nameEn, ord, phoneCode, barcode, ministryEncode);
            return this;
        }

        public Continent RemoveCity(
           int countryId,
           int cityId             
           )
        {
            var Country = GetCountry(countryId);
            Country.RemoveCity(cityId);
            return this;
        }

        public Continent UpdateCity(
            int cityId,
            int countryId,            
            string nameAr, string nameEn, int? ord, string? phoneCode, string? barcode, int? ministryEncode
          )
        {
            var Country = GetCountry(countryId);

            Country.UpdateCity(cityId, nameAr, nameEn, ord, phoneCode, barcode,ministryEncode);

           
            return this;
        }



        public Country GetCountry(int countryId)
        {
            if (Countries is null ||
                Countries.Count() == 0)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.ContinentZeroLengthOrNullCountriesList);


            var Country = Countries.Single(x => x.Id == countryId);
            if (Country is null)
            {
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNotExists);
            }
            return Country;
        }



      

        
    }



}
