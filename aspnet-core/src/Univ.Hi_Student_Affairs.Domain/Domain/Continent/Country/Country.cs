using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Volo.Abp;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs
{
    public class Country : Entity<int>
    {
        [ForeignKey("ContinentId")]
        public virtual Continent Continent { get; set; }
        public int ContinentId { get; private set; }

        //اسم البلد
        public string NameAr { get; set; }

        //اسم البلد باللغة الانكليزية
        public string? NameEn { get; set; }

        //الترتيب
        public int? Ord { get; set; }



        //رمز الفرع بوزارة التعليم
        public virtual int? MinistryEncode { get; set; }


        public virtual string? Barcode { get; set; }


        public virtual ICollection<City>? Cities { get; protected set; } //Sub collection

        public Country()
        {
            NameAr = "";
            Cities = new Collection<City>();
        }

        public Country(int id,int continentId , string nameAr, string? nameEn, int? ministryEncode, string? barcode, int? ord, ICollection<City>? cities)
            :base(id)
        {
            NameAr = Check.NotNullOrWhiteSpace(nameAr, nameof(nameAr),CountryConsts.MaxNameArLength,2);
            NameEn =  Check.NotNullOrWhiteSpace(nameEn, nameof(nameEn), CountryConsts.MaxNameArLength, 2);
            ContinentId = continentId;
            Ord = ord;
            MinistryEncode = ministryEncode;
            Barcode = barcode;
            if (cities is not null &&
                cities.Count > 0)
                this.Cities = cities;
            else
                this.Cities = new Collection<City>();
        }



        public Country RemoveCity(int cityId)
        {
            if (Cities is null ||
                Cities.Count == 0)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryZeroLengthOrNullCitiesList);


            var City = Cities.SingleOrDefault(x => x.Id == cityId);
            if (City is null)
            {
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNotExists);
            }
            Cities.Remove(City);

            return this;
        }


        public Country AddCity(
             string nameAr, string nameEn, int? ord, string? phoneCode, string? barcode, int? ministryEncode
             )
        {
            if (Cities is null ||
                Cities.Count() == 0)
                Cities = new Collection<City>();


            if (Cities.Where(x => x.NameAr != null && x.NameAr.Equals(nameAr)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameArAlreadyExists);


            if (Cities.Where(x => x.NameEn != null && x.NameEn.Equals(nameAr)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);

            if (!string.IsNullOrWhiteSpace(barcode) &&
                Cities.Where(x => x.Barcode != null && x.Barcode.Equals(barcode)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityBarcodeAlreadyExists);

            if (ministryEncode != null &&
                Cities.Where(x => x.MinistryEncode != null && x.MinistryEncode == ministryEncode).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityMinistryAlreadyExists);


            Cities.Add(new City(0,0, nameAr, nameEn, ord,phoneCode,  barcode , ministryEncode));

            return this;
        }



        public Country UpdateCity(
             int cityId,           
             string nameAr, string nameEn, int? ord, string? phoneCode, string? barcode, int? ministryEncode
            )
        {
            if (Cities is null ||
                Cities.Count() == 0)
                Cities = new Collection<City>();

            var City = Cities.Where(x => x.Id == cityId).FirstOrDefault();
            if (City is null)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNotExists);




            if (Cities.Where(x => x.NameAr != null &&  x.Id != cityId   && x.NameAr.Equals(nameAr)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameArAlreadyExists);


            if (Cities.Where(x => x.NameEn != null && x.Id != cityId && x.NameEn.Equals(nameAr)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);


            if (!string.IsNullOrWhiteSpace(barcode) &&
                Cities.Where(x => !string.IsNullOrWhiteSpace(x.Barcode)  && x.Id != cityId && x.Barcode.Equals(barcode)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityBarcodeAlreadyExists);



            if (ministryEncode != null &&
                Cities.Where(x => x.MinistryEncode != null && x.Id != cityId && x.MinistryEncode == ministryEncode).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityMinistryAlreadyExists);


            if (!string.IsNullOrWhiteSpace(phoneCode) &&  
                Cities.Where(x => !string.IsNullOrWhiteSpace(x.PhoneCode)  && x.Id != cityId && x.PhoneCode == phoneCode).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityMinistryAlreadyExists);





            City.NameAr = nameAr;
            City.NameEn = nameEn;
            City.Ord = ord;
            City.MinistryEncode = ministryEncode;
            City.Barcode = barcode;


            return this;
        }



        public City GetCity(int cityId)
        {
            if (Cities is null ||
                Cities.Count == 0)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryZeroLengthOrNullCitiesList);


            var City = Cities.Single(x => x.Id == cityId);
            if (City is null)
            {
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNotExists);
            }
            return City;
        }


    }
}

