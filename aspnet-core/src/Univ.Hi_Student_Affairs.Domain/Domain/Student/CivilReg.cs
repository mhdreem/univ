
using System;
using System.ComponentModel.DataAnnotations.Schema;
using Univ.Hi_Student_Affairs.Domain.Abstruct;

namespace Univ.Hi_Student_Affairs.Domain.Student
{
    public class CivilReg : TEncodeTableEntity<int>
    {
        [ForeignKey("CountryId")]
        public int CountryId { get; private set; }




        [ForeignKey("CityId")]
        public int CityId { get; private set; }



        private void SetCountryId(int countryId)
        {
            CountryId = countryId;
        }

        public void UpdateCountryId(int countryId)
        {
            SetCountryId(countryId);
        }

        private void SetCityId(int cityId)
        {
            CityId = cityId;
        }

        public void UpdateCityId(int cityId)
        {
            SetCityId(cityId);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var other = (CivilReg)obj;
            return Id == other.Id &&
                   CountryId == other.CountryId &&
                   CityId == other.CityId &&
                   NameAr == other.NameAr &&
                   NameEn == other.NameEn &&
                   Ord == other.Ord &&
                   Barcode == other.Barcode;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, NameAr, NameEn, Ord, Barcode, CountryId, CityId);
        }

        public override string ToString()
        {
            return $"[CivilReg: Id={Id},NameAr={NameAr}, NameEn={NameEn}, Ord={Ord},Barcode={Barcode} ,CountryId={CountryId},CityId={CityId}]";
        }


        public CivilReg(string nameAr, string? nameEn, int? ord, string? barcode, int countryId, int cityId)
       : base(nameAr, nameEn, ord, barcode)

        {
            SetCountryId(countryId);
            SetCityId(cityId);

        }

        public CivilReg(int id, string nameAr, string? nameEn, int? ord, string? barcode, int countryId, int cityId)
           : base(id, nameAr, nameEn, ord, barcode)
        {
            SetCountryId(countryId);
            SetCityId(cityId);

        }





    }

}