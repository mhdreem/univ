using System;
using System.ComponentModel.DataAnnotations.Schema;
using Univ.Hi_Student_Affairs.Domain.Abstruct;



namespace Univ.Hi_Student_Affairs.Domain.TypeLic
{

    public class TypeLicBranch : TEncodeTableEntity<int>
    {

        [ForeignKey("TypeLicId")]
        public int? TypeLicId { get; private set; }



        public TypeLicBranch(int id, int? typeLicId, string nameAr, string nameEn, int? ord, string barcode)
            : base(id, nameAr, nameEn, ord, barcode)
        {
            SetTypeLicId(typeLicId);

        }

        public TypeLicBranch(int typeLicId, string nameAr, string nameEn, int? ord, string barcode)
         : base(nameAr, nameEn, ord, barcode)
        {
            SetTypeLicId(typeLicId);

        }


        private void SetTypeLicId(int? typeLicId)
        {
            if (typeLicId <= 0)
            {
                throw new ArgumentException("Invalid TypeLic ID", nameof(typeLicId));
            }
            TypeLicId = typeLicId;
        }


        public void ChangeTypeLicId(int newTypeLicId)
        {
            SetTypeLicId(newTypeLicId);

        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var other = (TypeLicBranch)obj;
            return Id == other.Id &&
                   TypeLicId == other.TypeLicId &&
                   NameAr == other.NameAr &&
                   NameEn == other.NameEn &&
                   Ord == other.Ord &&
                   Barcode == other.Barcode;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, TypeLicId, NameAr, NameEn, Ord, Barcode);
        }

        public override string ToString()
        {
            return $"[TypeLicBranch: Id={Id}, TypeLicId={TypeLicId}, NameAr={NameAr}, NameEn={NameEn}, Ord={Ord},Barcode={Barcode} ]";
        }


    }

}

