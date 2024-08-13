using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Univ.Hi_Student_Affairs.Domain.Abstruct;
using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain.TypeLic
{
    public class TypeLic : TEncodeTableAggregateRoot<int>
    {

        public virtual ICollection<TypeLicBranch>? TypeLicBranchs { get; protected set; } //Sub collection

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var other = (TypeLic)obj;
            return Id == other.Id &&
                   NameAr == other.NameAr &&
                   NameEn == other.NameEn &&
                   Ord == other.Ord &&
                   Barcode == other.Barcode;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, NameAr, NameEn, Ord, Barcode, TypeLicBranchs);
        }

        public override string ToString()
        {
            return $"[TypeLic: Id={Id},  NameAr={NameAr}, NameEn={NameEn}, Ord={Ord},Barcode={Barcode} ,TypeLicBranchs={TypeLicBranchs}]";
        }

        public TypeLic(string nameAr, string? nameEn, int? ord, string? barcode)
          : base(nameAr, nameEn, ord, barcode)

        {


        }

        public TypeLic(string nameAr, string? nameEn, int? ord, string? barcode, ICollection<TypeLicBranch>? typeLicBranch)
            : base(nameAr, nameEn, ord, barcode)

        {

            TypeLicBranchs = typeLicBranch ?? new List<TypeLicBranch>();
        }

        public TypeLic(int id, string nameAr, string nameEn, int? ord, string barcode, ICollection<TypeLicBranch>? typeLicBranch)
           : base(id, nameAr, nameEn, ord, barcode)
        {

            TypeLicBranchs = typeLicBranch ?? new List<TypeLicBranch>();
        }



        public TypeLic AddTypeLicBranch(
            string nameAr, string nameEn, int? ord, string? barcode

             )
        {


            if (TypeLicBranchs is null ||
                TypeLicBranchs.Count == 0)
                TypeLicBranchs = new Collection<TypeLicBranch>();


            if (TypeLicBranchs.Where(x => x.NameAr != null && x.NameAr.Equals(nameAr)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.TypeLicBranchNameArAlreadyExists);


            if (TypeLicBranchs.Where(x => x.NameEn != null && x.NameEn.Equals(nameEn)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);





            TypeLicBranchs.Add(new TypeLicBranch(this.Id, nameAr, nameAr, ord, barcode));

            return this;
        }



        public TypeLic UpdateTypeLicBranch(
             int TypeLicBranchId,
           string nameAr, string nameEn, int? ord, string? barcode
            )
        {
            if (TypeLicBranchs is null ||
                TypeLicBranchs.Count() == 0)
                TypeLicBranchs = new Collection<TypeLicBranch>();

            var TypeLicBranch = TypeLicBranchs.Where(x => x.Id == TypeLicBranchId).FirstOrDefault();
            if (TypeLicBranch is null)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNotExists);




            if (TypeLicBranchs.Where(x => x.NameAr != null && x.Id != TypeLicBranchId && x.NameAr.Equals(nameAr)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameArAlreadyExists);


            if (TypeLicBranchs.Where(x => x.NameEn != null && x.Id != TypeLicBranchId && x.NameEn.Equals(nameEn)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);




            return this;
        }


        public TypeLic RemoveTypeLicBranch(int TypeLicBranchId)
        {
            if (TypeLicBranchs is null ||
                TypeLicBranchs.Count == 0)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryZeroLengthOrNullCitiesList);


            var TypeLicBranch = TypeLicBranchs.SingleOrDefault(x => x.Id == TypeLicBranchId);
            if (TypeLicBranch is null)
            {
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.TypeLicBranchNotExists);
            }
            TypeLicBranchs.Remove(TypeLicBranch);

            return this;
        }




        public TypeLicBranch GetTypeLicBranch(int TypeLicBranchId)
        {
            if (TypeLicBranchs is null ||
                TypeLicBranchs.Count == 0)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryZeroLengthOrNullCitiesList);


            var TypeLicBranch = TypeLicBranchs.Single(x => x.Id == TypeLicBranchId);
            if (TypeLicBranch is null)
            {
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNotExists);
            }
            return TypeLicBranch;
        }
    }
}


