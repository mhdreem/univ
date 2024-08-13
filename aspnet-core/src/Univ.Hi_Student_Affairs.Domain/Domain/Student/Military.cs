using System;
using System.ComponentModel.DataAnnotations.Schema;
using Univ.Hi_Student_Affairs.Domain.Abstruct;

namespace Univ.Hi_Student_Affairs.Domain.Student
{
    public class Military : TEncodeTableEntity<int>
    {

        [ForeignKey("CityId")]
        public int CityId { get; private set; }

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

            var other = (Military)obj;
            return Id == other.Id &&
                   CityId == other.CityId &&
            NameAr == other.NameAr &&
                   NameEn == other.NameEn &&
                   Ord == other.Ord &&
                   Barcode == other.Barcode;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, NameAr, NameEn, Ord, Barcode, CityId);
        }

        public override string ToString()
        {
            return $"[Military: Id={Id},NameAr={NameAr}, NameEn={NameEn}, Ord={Ord},Barcode={Barcode} ,CityId={CityId}]";
        }


        public Military(string nameAr, string? nameEn, int? ord, string? barcode, int cityId)
       : base(nameAr, nameEn, ord, barcode)

        {
            SetCityId(cityId);

        }

        public Military(int id, string nameAr, string? nameEn, int? ord, string? barcode, int cityId)
           : base(id, nameAr, nameEn, ord, barcode)
        {
            SetCityId(cityId);

        }

    }

}

