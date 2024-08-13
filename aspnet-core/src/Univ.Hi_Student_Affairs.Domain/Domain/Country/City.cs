using System;
using System.ComponentModel.DataAnnotations.Schema;
using Univ.Hi_Student_Affairs.Domain.Abstruct;
namespace Univ.Hi_Student_Affairs.Domain.Country
{

    public class City : TEncodeTableEntity<int>
    {
        [ForeignKey("CountryId")]
        public int CountryId { get; private set; }

        // رمز نداء المدينة
        public string? PhoneCode { get; private set; }

        public City(int id, int countryId, string nameAr, string nameEn, int? ord, string barcode, string? phoneCode)
            : base(id, nameAr, nameEn, ord, barcode)
        {
            SetCountryId(countryId);
            SetPhoneCode(phoneCode);
        }

        public City(int countryId, string nameAr, string nameEn, int? ord, string barcode, string? phoneCode)
         : base(nameAr, nameEn, ord, barcode)
        {
            SetCountryId(countryId);
            SetPhoneCode(phoneCode);
        }


        private void SetCountryId(int countryId)
        {
            if (countryId <= 0)
            {
                throw new ArgumentException("Invalid Country ID", nameof(countryId));
            }
            CountryId = countryId;
        }

        public void SetPhoneCode(string? phoneCode)
        {
            PhoneCode = phoneCode;
        }

        public void UpdateNameAr(string nameAr)
        {
            SetNameAr(nameAr);
        }

        public void UpdatePhoneCode(string? phoneCode)
        {
            SetPhoneCode(phoneCode);
        }

        public void ChangeCountry(int newCountryId)
        {
            SetCountryId(newCountryId);

        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var other = (City)obj;
            return Id == other.Id &&
                   CountryId == other.CountryId &&
                   NameAr == other.NameAr &&
                   NameEn == other.NameEn &&
                   Ord == other.Ord &&
                   Barcode == other.Barcode &&
                   PhoneCode == other.PhoneCode;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, CountryId, NameAr, NameEn, Ord, Barcode, PhoneCode);
        }

        public override string ToString()
        {
            return $"[City: Id={Id}, CountryId={CountryId}, NameAr={NameAr}, NameEn={NameEn}, Ord={Ord},Barcode={Barcode} ,PhoneCode={PhoneCode}]";
        }


    }

}
