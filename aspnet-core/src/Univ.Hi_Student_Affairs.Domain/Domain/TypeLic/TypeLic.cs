using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Volo.Abp;
using Volo.Abp.Domain.Entities;


namespace Univ.Hi_Student_Affairs

{

    public class TypeLic : BasicAggregateRoot<int>
    {



        //الشهادة الثانوية
        public virtual string NameAr { get; set; }


        //الشهادة باللغة الاجنبية
        public virtual string NameEn { get; set; }




        //رمز الفرع بوزارة التعليم
        public virtual int? MinistryEncode { get; set; }


        public virtual string? Barcode { get; set; }


        public virtual int? Ord { get; set; }



        public virtual Collection<TypeLicBranch>? TypeLicBranchs { get; protected set; } //Sub collection


        public TypeLic()
        {
            NameAr = "";
            NameEn = "";
            TypeLicBranchs = new Collection<TypeLicBranch>();
        }

        public TypeLic(string? nameAr, string? nameEn, int? ministryEncode, string? barcode, int? ord )
        {
            NameAr = nameAr;
            NameEn = nameEn;
            MinistryEncode = ministryEncode;
            Barcode = barcode;
            this.Ord = ord;
            TypeLicBranchs = new Collection<TypeLicBranch>();


        }


        ////////////////////////////////////
        ///TypeLicBranch
        ////////////////////////////////////

        public TypeLic AddTypeLicBranch(
            TypeLicBranch TypeLicBranch

             )
        {
            

            if (TypeLicBranchs is null ||
                TypeLicBranchs.Count == 0)
                TypeLicBranchs = new Collection<TypeLicBranch>();


            if (TypeLicBranchs.Where(x => x.NameAr != null && x.NameAr.Equals(TypeLicBranch.NameAr)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.TypeLicBranchNameArAlreadyExists);


            if (TypeLicBranchs.Where(x => x.NameEn != null && x.NameEn.Equals(TypeLicBranch.NameEn)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);





            TypeLicBranchs.Add(new TypeLicBranch(0,TypeLicBranch.NameAr, TypeLicBranch.NameEn, TypeLicBranch.MinistryEncode, TypeLicBranch.Barcode,  TypeLicBranch.Ord));

            return this;
        }



        public TypeLic UpdateTypeLicBranch(
             int TypeLicBranchId,
             TypeLicBranch input
            )
        {
            if (TypeLicBranchs is null ||
                TypeLicBranchs.Count() == 0)
                TypeLicBranchs = new Collection<TypeLicBranch>();

            var TypeLicBranch = TypeLicBranchs.Where(x => x.Id == TypeLicBranchId).FirstOrDefault();
            if (TypeLicBranch is null)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNotExists);




            if (TypeLicBranchs.Where(x => x.NameAr != null && x.Id != TypeLicBranchId && x.NameAr.Equals(input.NameAr)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameArAlreadyExists);


            if (TypeLicBranchs.Where(x => x.NameEn != null && x.Id != TypeLicBranchId && x.NameEn.Equals(input.NameEn)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);





            TypeLicBranch.NameAr = input.NameAr;
            TypeLicBranch.NameEn = input.NameEn;
            TypeLicBranch.Ord = input.Ord;
            TypeLicBranch.MinistryEncode = input.MinistryEncode;



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
