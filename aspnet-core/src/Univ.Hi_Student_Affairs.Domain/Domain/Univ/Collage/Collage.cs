using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Volo.Abp;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs
{
    public class Collage : BasicAggregateRoot<int>
    {


        //اسم الكلية 
        public virtual string NameAr { get; set; }

        //اسم الكلية 
        public virtual string NameEn { get; set; }


        //اسم العميد
        public virtual string? DeanAr { get; set; }
        public virtual string? DeanEn { get; set; }



        //عدد السنوات الدراسية 
        public virtual int? NumYear { get; set; }


        //الترتيب
        public virtual int? Ord { get; set; }


        [ForeignKey("DegreeId")]
        public virtual int? DegreeId { get; set; }
        public virtual Degree? Degree { get; set; }


        //اسم الاجازة الممنوحة للطالب
        public virtual string? DegreeNameAr { get; set; }


        //اسم الاجازة الممنوحة للطالب باللغة الانكليزية
        public virtual string? DegreeNameEn { get; set; }



        //رمز الكلية بوزراة التعليم
        public virtual int? MinistryEncode { get; set; }


        //رمز الكلية بوزراة التعليم
        public virtual string? Barcode { get; set; }


        [ForeignKey("UnivSectionId")]
        public int UnivSectionId { get; set; }
        public virtual UnivSection? UnivSection { get; set; }


        [ForeignKey("CollTypeId")]
        public virtual int? CollTypeId { get; set; }
        public virtual CollType? CollType { get; set; }

        


        public virtual Collection<Department>? Departments { get;  set; } //sub collection


        public Collage()
        {
            NameAr = "";
            NameEn = "";
            Departments = new Collection<Department>();
        }


        public Collage(
            string NameAr,
string NameEn,
            string? DeanAr,
string? DeanEn,
int? NumYear,
int? Ord,
string? DegreeNameAr,
string? DegreeNameEn,
int? MinistryEncode,
string? Barcode,
int UnivSectionId)
        {
            this.NameAr = NameAr;
            this.NameEn = NameEn;
            this.DeanAr = DeanAr;
this.DeanEn = DeanEn;
this.NumYear = NumYear;
this.Ord = Ord;
this.DegreeNameAr = DegreeNameAr;
this.DegreeNameEn = DegreeNameEn;
this.MinistryEncode = MinistryEncode;
this.Barcode = Barcode;
this.UnivSectionId = UnivSectionId;

            Departments = new Collection<Department>();
        }



        public Collage RemoveDepartment(int DepartmentId)
        {
            if (Departments is null ||
                Departments.Count == 0)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryZeroLengthOrNullCitiesList);


            var Department = Departments.SingleOrDefault(x => x.Id == DepartmentId);
            if (Department is null)
            {
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNotExists);
            }
            Departments.Remove(Department);

            return this;
        }


        public Collage AddDepartment(
              string NameAr,
              string NameEn,
              int? Ord,
              string? DegreeNameAr,
              string? DegreeNameEn,
              int? MinistryEncode,
              string? Barcode            
             )
        {
            if (Departments is null ||
                Departments.Count() == 0)
                Departments = new Collection<Department>();


            if (Departments.Where(x => x.NameAr != null && x.NameAr.Equals(NameAr)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameArAlreadyExists);


            if (Departments.Where(x => x.NameEn != null && x.NameEn.Equals(NameEn)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);


            if (MinistryEncode != null &&
                Departments.Where(x => x.MinistryEncode != null && x.MinistryEncode == MinistryEncode).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityMinistryAlreadyExists);



            Departments.Add(new Department(NameAr, NameEn, Ord, DegreeNameAr, DegreeNameEn, MinistryEncode, Barcode, this.Id));

            return this;
        }



        public Collage UpdateDepartment(
             int DepartmentId,
              string NameAr,
              string NameEn,
              int? Ord,
              string? DegreeNameAr,
              string? DegreeNameEn,
              int? MinistryEncode,
              string? Barcode
            )
        {
            if (Departments is null ||
                Departments.Count() == 0)
                Departments = new Collection<Department>();

            var Department = Departments.Where(x => x.Id == DepartmentId).FirstOrDefault();
            if (Department is null)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNotExists);




            if (Departments.Where(x => x.NameAr != null && x.Id != DepartmentId && x.NameAr.Equals(NameAr)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameArAlreadyExists);


            if (Departments.Where(x => x.NameEn != null && x.Id != DepartmentId && x.NameEn.Equals(NameEn)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);





            if (MinistryEncode != null &&
                Departments.Where(x => x.MinistryEncode != null && x.Id != DepartmentId && x.MinistryEncode == MinistryEncode).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityMinistryAlreadyExists);






            Department.NameAr = NameAr;
            Department.NameEn = NameEn;
            Department.Ord = Ord;
            Department.MinistryEncode = MinistryEncode;         
            Department.Barcode = Barcode;
            Department.DegreeNameAr = DegreeNameAr;
            Department.DegreeNameEn = DegreeNameEn;


            return this;
        }



        public Department GetDepartment(int DepartmentId)
        {
            if (Departments is null ||
                Departments.Count == 0)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryZeroLengthOrNullCitiesList);


            var Department = Departments.Single(x => x.Id == DepartmentId);
            if (Department is null)
            {
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNotExists);
            }
            return Department;
        }


    }
}
