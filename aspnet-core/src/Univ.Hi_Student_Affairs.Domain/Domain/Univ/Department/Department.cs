using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Volo.Abp;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs
{

    public class Department : BasicAggregateRoot<int>
    {


        //اسم القسم

        public virtual string NameAr { get; set; }
        public virtual string NameEn { get; set; }




        //الترتيب
        public virtual int? Ord { get; set; }

        //اسم القسم باللغة الانكليزية



        //اسم القسم بالاجازة الممنوحة للطالب

        public virtual string? DegreeNameAr { get; set; }
        public virtual string? DegreeNameEn { get; set; }


        //رمز القسم بوزراة التعليم
        public virtual int? MinistryEncode { get; set; }


        //رمز القسم بوزراة التعليم
        public virtual string? Barcode { get; set; }


        [ForeignKey("CollageId")]
        public int CollageId { get; set; }
        public virtual Collage? Collage{ get; set; }

        public virtual Collection<Branch>? Branchs { get; set; }


        public Department()
        {
            NameAr = "";
            NameEn = "";
            Branchs = new Collection<Branch>();

        }
        public Department(
              string NameAr,
              string NameEn,
              int? Ord,
              string? DegreeNameAr,
              string? DegreeNameEn,
              int? MinistryEncode,
              string? Barcode,
              int CollageId)
        {
            this.Barcode = Barcode;
            this.Ord = Ord;
            this.NameAr = NameAr;   
            this.NameEn = NameEn;
            this.DegreeNameAr = DegreeNameAr;
            this.DegreeNameEn = DegreeNameEn;
            this.MinistryEncode = MinistryEncode;
            this.CollageId = CollageId;
        }





        public Department RemoveBranch(int BranchId)
        {
            if (this.Branchs is null ||
                this.Branchs.Count == 0)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryZeroLengthOrNullCitiesList);


            var Department = this.Branchs.SingleOrDefault(x => x.Id == BranchId);
            if (Department is null)
            {
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNotExists);
            }
            this.Branchs.Remove(Department);

            return this;
        }


        public Department AddBranch(
            string name_Ar, string name_En, int? ord, string? barcode, int? ministry_Encode
             )
        {
            if (this.Branchs is null ||
                this.Branchs.Count() == 0)
                this.Branchs = new Collection<Branch>();


            if (this.Branchs.Where(x => x.NameAr != null && x.NameAr.Equals(name_Ar)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameArAlreadyExists);


            if (this.Branchs.Where(x => x.NameEn != null && x.NameEn.Equals(name_En)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);


            if (ministry_Encode != null &&
                this.Branchs.Where(x => x.MinistryEncode != null && x.MinistryEncode == ministry_Encode).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityMinistryAlreadyExists);


            this.Branchs.Add(new Branch(name_Ar, name_En, ord, barcode, ministry_Encode, this.Id));

            return this;
        }



        public Department UpdateBranch(
             int BranchId,
            string name_Ar, string name_En, int? ord, string? barcode, int? ministry_Encode
            )
        {
            if (this.Branchs is null ||
                this.Branchs.Count() == 0)
                this.Branchs = new Collection<Branch>();

            var Branch = this.Branchs.Where(x => x.Id == BranchId).FirstOrDefault();
            if (Branch is null)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNotExists);




            if (this.Branchs.Where(x => x.NameAr != null && x.Id != BranchId && x.NameAr.Equals(name_Ar)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameArAlreadyExists);


            if (this.Branchs.Where(x => x.NameEn != null && x.Id != BranchId && x.NameEn.Equals(name_En)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);





            if (ministry_Encode != null &&
                this.Branchs.Where(x => x.MinistryEncode != null && x.Id != BranchId && x.MinistryEncode == ministry_Encode).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityMinistryAlreadyExists);






            Branch.NameAr = name_Ar;
            Branch.NameEn = name_En;
            Branch.Ord = ord;
            Branch.MinistryEncode = ministry_Encode;
            Branch.Barcode = barcode;


            return this;
        }



        public Branch GetBranch(int BranchId)
        {
            if (this.Branchs is null ||
                this.Branchs.Count == 0)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryZeroLengthOrNullCitiesList);


            var Branch = this.Branchs.Single(x => x.Id == BranchId);
            if (Branch is null)
            {
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNotExists);
            }
            return Branch;
        }


    }
}
