using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Univ.Hi_Student_Affairs.Domain.Abstruct;
using Univ.Hi_Student_Affairs.enums;
using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain.Country
{
    public class Country : TEncodeTableAggregateRoot<int>
    {

        public Continent Continent { get; private set; }


        public virtual ICollection<City>? Cities { get; protected private set; } //Sub collection

        private void SetContinent(Continent continent)
        {
            Continent = continent;
        }

        public void UpdateContinent(Continent continent)
        {
            SetContinent(continent);
        }






        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var other = (Country)obj;
            return Id == other.Id &&
                   Continent == other.Continent &&
                   NameAr == other.NameAr &&
                   NameEn == other.NameEn &&
                   Ord == other.Ord &&
                   Barcode == other.Barcode;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Continent, NameAr, NameEn, Ord, Barcode, Cities);
        }

        public override string ToString()
        {
            return $"[Country: Id={Id}, Continent={Continent}, NameAr={NameAr}, NameEn={NameEn}, Ord={Ord},Barcode={Barcode} ,Cities={Cities}]";
        }

        public Country(string nameAr, string? nameEn, int? ord, string? barcode, Continent continent)
         : base(nameAr, nameEn, ord, barcode)

        {
            SetContinent(continent);

        }

        public Country(string nameAr, string? nameEn, int? ord, string? barcode, Continent continent, ICollection<City>? cities)
            : base(nameAr, nameEn, ord, barcode)

        {
            SetContinent(continent);
            Cities = cities ?? new List<City>();
        }

        public Country(int id, string nameAr, string nameEn, int? ord, string barcode, Continent continent, ICollection<City>? cities)
           : base(id, nameAr, nameEn, ord, barcode)
        {
            SetContinent(continent);
            Cities = cities ?? new List<City>();
        }


        public Country RemoveCity(int cityId)
        {
            if (Cities is null ||
                Cities.Count == 0)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryZeroLengthOrNullCitiesList);


            var City = Cities.SingleOrDefault(x => x.Id == cityId);
            if (City is null)
            {
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNotExists);
            }
            Cities.Remove(City);

            return this;
        }





        public Country AddCity(
             string nameAr, string nameEn, int? ord, string? barcode, string? phoneCode
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


            Cities.Add(new City(Id, nameAr, nameEn, ord, barcode, phoneCode));

            // Raise domain event
            //AddDomainEvent(new CityAddedDomainEvent(this, city));

            return this;
        }



        public Country UpdateCity(
             int cityId,
              string nameAr, string nameEn, int? ord, string? barcode, string? phoneCode
            )
        {
            if (Cities is null ||
                Cities.Count() == 0)
                Cities = new Collection<City>();

            var City = Cities.Where(x => x.Id == cityId).FirstOrDefault();
            if (City is null)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNotExists);




            if (Cities.Where(x => x.NameAr != null && x.Id != cityId && x.NameAr.Equals(nameAr)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameArAlreadyExists);


            if (Cities.Where(x => x.NameEn != null && x.Id != cityId && x.NameEn.Equals(nameAr)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);


            if (!string.IsNullOrWhiteSpace(barcode) &&
                Cities.Where(x => !string.IsNullOrWhiteSpace(x.Barcode) && x.Id != cityId && x.Barcode.Equals(barcode)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityBarcodeAlreadyExists);




            if (!string.IsNullOrWhiteSpace(phoneCode) &&
                Cities.Where(x => !string.IsNullOrWhiteSpace(x.PhoneCode) && x.Id != cityId && x.PhoneCode == phoneCode).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityMinistryAlreadyExists);



            City.UpdateNameAr(nameAr);
            City.SetNameEn(nameEn);
            City.SetOrd(ord);
            City.SetBarcode(barcode);
            City.SetPhoneCode(phoneCode);

            // Raise domain event
            //AddDomainEvent(new CityUpdateDomainEvent(this, city));

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
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNotExists);
            }
            return City;
        }


    }
}

