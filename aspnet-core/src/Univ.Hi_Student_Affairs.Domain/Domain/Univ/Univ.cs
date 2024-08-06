using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Http.Headers;
using Volo.Abp;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs
{
    public class Univ : BasicAggregateRoot<int>
    {


        //اسم الجامعة        
        public string NameAr { get; set; }
        public string? NameEn { get; set; }

        //الترتيب
        public int? Ord { get; set; }


        //رمز الجامعة بوزرارة التعليم
        public virtual int? MinistryEncode { get; set; }

        public virtual string? Barcode { get; set; }

        public virtual Collection<UnivSection>? UnivSections { get;  set; } //Sub collection


        [ForeignKey("UnivTypeId")]       
        public virtual int? UnivTypeId { get; set; }
        public virtual UnivType? UnivType{ get; set; }


    public Univ()
        {
            NameAr = "";
            UnivSections = new Collection<UnivSection>();
        }

        public Univ(
            string NameAr,
            string NameEn,
            int? Ord,
            int? MinistryEncode ,
            string? Barcode,
            Collection<UnivSection>? UnivSections
            )
        {
            this.NameAr = NameAr;
            this.NameEn = NameEn;
            this.Ord = Ord;
            this.MinistryEncode = MinistryEncode;
            this.Barcode = Barcode;
            this.UnivSections = UnivSections;
        }

        ////////////////////////////////////
        ///UnivSection
        ////////////////////////////////////

        public Univ AddUnivSection(
             string name_ar, string name_en, int? ord, int? ministry_encode, string? barcode, Collection<Collage>? collages
             )
        {
            if (UnivSections is null ||
                UnivSections.Count() == 0)
                UnivSections = new Collection<UnivSection>();


            if (UnivSections.Where(x => x.NameAr != null && x.NameAr.Equals(name_ar)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameArAlreadyExists);


            if (UnivSections.Where(x => x.NameEn != null && x.NameEn.Equals(name_en)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);


            if (ministry_encode != null &&
                UnivSections.Where(x => x.MinistryEncode != null && x.MinistryEncode == ministry_encode).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityMinistryAlreadyExists);



            UnivSections.Add(new UnivSection(name_ar, name_en, ord, ministry_encode, barcode, collages, this.Id));

            return this;
        }



        public Univ UpdateUnivSection(
             int UnivSectionId,
             string name_ar, string name_en, int? ord, int? ministry_encode, string? barcode, ICollection<Collage>? collages
            )
        {
            if (UnivSections is null ||
                UnivSections.Count() == 0)
                UnivSections = new Collection<UnivSection>();

            var UnivSection = UnivSections.Where(x => x.Id == UnivSectionId).FirstOrDefault();
            if (UnivSection is null)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNotExists);




            if (UnivSections.Where(x => x.NameAr != null && x.Id != UnivSectionId && x.NameAr.Equals(name_ar)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameArAlreadyExists);


            if (UnivSections.Where(x => x.NameEn != null && x.Id != UnivSectionId && x.NameEn.Equals(name_en)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);



            if (ministry_encode != null &&
                UnivSections.Where(x => x.MinistryEncode != null && x.Id != UnivSectionId && x.MinistryEncode == ministry_encode).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityMinistryAlreadyExists);

            UnivSection.NameAr = name_ar;
            UnivSection.NameEn = name_en;
            UnivSection.Ord = ord;
            UnivSection.MinistryEncode = ministry_encode;



            return this;
        }


        public Univ RemoveUnivSection(int UnivSectionId)
        {
            if (UnivSections is null ||
                UnivSections.Count == 0)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryZeroLengthOrNullCitiesList);


            var UnivSection = UnivSections.SingleOrDefault(x => x.Id == UnivSectionId);
            if (UnivSection is null)
            {
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNotExists);
            }
            UnivSections.Remove(UnivSection);

            return this;
        }




        public UnivSection GetUnivSection(int UnivSectionId)
        {
            if (UnivSections is null ||
                UnivSections.Count == 0)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryZeroLengthOrNullCitiesList);


            var UnivSection = UnivSections.Single(x => x.Id == UnivSectionId);
            if (UnivSection is null)
            {
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNotExists);
            }
            return UnivSection;
        }


        ////////////////////////////////////
        ///Collage
        ////////////////////////////////////


        public Univ RemoveCollage(int UnivSectionId, int collageId)
        {
            if (this.UnivSections is null ||
                this.UnivSections.Count == 0)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryZeroLengthOrNullCitiesList);            

            var UnivSection = this.UnivSections.SingleOrDefault(x => x.Id == UnivSectionId);
            if (UnivSection is null)
            {
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNotExists);
            }

            if (UnivSection is null ||
                UnivSection.Collages is null ||
                UnivSection.Collages.Count == 0)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryZeroLengthOrNullCitiesList);


            var Collage = UnivSection.Collages.SingleOrDefault(x => x.Id == collageId);
            if (Collage is null )
            {
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNotExists);
            }
            UnivSection.Collages.Remove(Collage);

            return this;
        }


        public Univ AddCollage(
                int UnivSectionId, 
                string NameAr,
                string NameEn,
                string? DeanAr,
                string? DeanEn,
                int? NumYear,
                int? Ord,
                string? DegreeNameAr,
                string? DegreeNameEn,
                int? MinistryEncode,
                string? Barcode
             )
        {
            if (this.UnivSections is null ||
                this.UnivSections.Count == 0)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryZeroLengthOrNullCitiesList);

            var UnivSection = this.UnivSections.SingleOrDefault(x => x.Id == UnivSectionId);
            if (UnivSection is null)
            {
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNotExists);
            }

            if (UnivSection.Collages is null )
                UnivSection.Collages = new Collection<Collage>();

            UnivSection.Collages.Add(new Collage(NameAr,
                                                NameEn,
                                                DeanAr,
                                                DeanEn,
                                                NumYear,
                                                Ord,
                                                DegreeNameAr,
                                                DegreeNameEn,
                                                MinistryEncode,
                                                Barcode,
                                                UnivSection.Id
                                                ));





           
            return this;
        }



        public Univ UpdateCollage(
              int UnivSectionId, 
              int CollageId,
              string NameAr,
              string NameEn,
              string? DeanAr,
              string? DeanEn,
              int? NumYear,
              int? Ord,
              string? DegreeNameAr,
              string? DegreeNameEn,
              int? MinistryEncode,
              string? Barcode
            )
        {

            if (this.UnivSections is null ||
               this.UnivSections.Count == 0)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryZeroLengthOrNullCitiesList);

            var UnivSection = this.UnivSections.SingleOrDefault(x => x.Id == UnivSectionId);
            if (UnivSection is null)
            {
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNotExists);
            }

            if (UnivSection.Collages is null ||
                UnivSection.Collages.Count == 0 )
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryZeroLengthOrNullCitiesList);


          
          

            if (UnivSection.Collages.Where(x => x.NameAr != null && x.Id != CollageId && x.NameAr.Equals(NameAr)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameArAlreadyExists);


            if (UnivSection.Collages.Where(x => x.NameEn != null && x.Id != CollageId && x.NameEn.Equals(NameEn)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);





            if (MinistryEncode != null &&
                UnivSection.Collages.Where(x => x.MinistryEncode != null && x.Id != CollageId && x.MinistryEncode == MinistryEncode).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityMinistryAlreadyExists);



            var Collage = UnivSection.Collages.SingleOrDefault(x => x.Id == CollageId);
            if (Collage is null)
            {
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNotExists);
            }


            Collage.NameAr = NameAr;
            Collage.NameEn = NameEn;
            Collage.Ord = Ord;
            Collage.MinistryEncode = MinistryEncode;
            Collage.DeanEn = DeanEn;
            Collage.DeanAr = DeanAr;
            Collage.Barcode = Barcode;
            Collage.DegreeNameAr = DegreeNameAr;
            Collage.DegreeNameEn = DegreeNameEn;
            Collage.NumYear = NumYear;


            return this;

          


         
        }



        ///////////////////////////////////
        ///Department
        //////////////////////////////////
        public Univ RemoveDepartment(int UnivSectionId, int collageId,int DepartmentId)
        {

            var UnivSection = this.UnivSections.SingleOrDefault(x => x.Id == UnivSectionId);
            if (UnivSection is null)
            {
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNotExists);
            }

            if (UnivSection is null ||
                UnivSection.Collages is null ||
                UnivSection.Collages.Count == 0)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryZeroLengthOrNullCitiesList);


            var Collage = UnivSection.Collages.SingleOrDefault(x => x.Id == collageId);
            if (Collage is null)
            {
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNotExists);
            }


            if (Collage.Departments is null ||
                Collage.Departments.Count == 0)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryZeroLengthOrNullCitiesList);


            var Department = Collage.Departments.SingleOrDefault(x => x.Id == DepartmentId);
            if (Department is null)
            {
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNotExists);
            }
            Collage.Departments.Remove(Department);

            return this;
        }


        public Univ AddDepartment(
              int UnivSectionId, int collageId, 
              string NameAr,
              string NameEn,
              int? Ord,
              string? DegreeNameAr,
              string? DegreeNameEn,
              int? MinistryEncode,
              string? Barcode
             )
        {

           
            if (
                this.UnivSections is null ||
                this.UnivSections.Count == 0)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryZeroLengthOrNullCitiesList);


            //الحصول على فرع الجامعة
            var UnivSection = this.UnivSections.SingleOrDefault(x => x.Id == UnivSectionId);
            if (UnivSection is null)
            {
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNotExists);
            }

            if (UnivSection is null ||
                UnivSection.Collages is null ||
                UnivSection.Collages.Count == 0)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryZeroLengthOrNullCitiesList);

            //الحصول على فرع الكلية
            var Collage = UnivSection.Collages.SingleOrDefault(x => x.Id == collageId);
            if (Collage is null)
            {
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNotExists);
            }


            if (Collage.Departments is null)
                Collage.Departments = new Collection<Department>();





            //فحص لاقسام
            if (Collage.Departments.Where(x => x.NameAr != null && x.NameAr.Equals(NameAr)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameArAlreadyExists);


            if (Collage.Departments.Where(x => x.NameEn != null && x.NameEn.Equals(NameEn)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);


            if (MinistryEncode != null &&
                Collage.Departments.Where(x => x.MinistryEncode != null && x.MinistryEncode == MinistryEncode).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityMinistryAlreadyExists);



            Collage.Departments.Add(new Department(NameAr, NameEn, Ord, DegreeNameAr, DegreeNameEn, MinistryEncode, Barcode, Collage.Id));

            return this;
        }



        public Univ UpdateDepartment(
              int UnivSectionId, int collageId, int DepartmentId,
              string NameAr,
              string NameEn,
              int? Ord,
              string? DegreeNameAr,
              string? DegreeNameEn,
              int? MinistryEncode,
              string? Barcode
            )
        {

            if (
              this.UnivSections is null ||
              this.UnivSections.Count == 0)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryZeroLengthOrNullCitiesList);


            //الحصول على فرع الجامعة
            var UnivSection = this.UnivSections.SingleOrDefault(x => x.Id == UnivSectionId);
            if (UnivSection is null)
            {
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNotExists);
            }

            if (UnivSection is null ||
                UnivSection.Collages is null ||
                UnivSection.Collages.Count == 0)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryZeroLengthOrNullCitiesList);

            //الحصول على فرع الكلية
            var Collage = UnivSection.Collages.SingleOrDefault(x => x.Id == collageId);
            if (Collage is null)
            {
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNotExists);
            }




            if (Collage.Departments is null ||
                Collage.Departments.Count() == 0)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNotExists);


            //الحصول على فرع القسم
            var Department = Collage.Departments.Where(x => x.Id == DepartmentId).FirstOrDefault();
            if (Department is null)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNotExists);




            if (Collage.Departments.Where(x => x.NameAr != null && x.Id != DepartmentId && x.NameAr.Equals(NameAr)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameArAlreadyExists);


            if (Collage.Departments.Where(x => x.NameEn != null && x.Id != DepartmentId && x.NameEn.Equals(NameEn)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);





            if (MinistryEncode != null &&
                Collage.Departments.Where(x => x.MinistryEncode != null && x.Id != DepartmentId && x.MinistryEncode == MinistryEncode).Any())
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

        ///////////////////////////
        /// الفرع
        //////////////////////////////
        public Univ RemoveBranch(int UnivSectionId, int collageId, int DepartmentId,int BranchId)
        {

            //الحصول على فرع الجامعة
            var UnivSection = this.UnivSections.SingleOrDefault(x => x.Id == UnivSectionId);
            if (UnivSection is null)
            {
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNotExists);
            }

            if (UnivSection is null ||
                UnivSection.Collages is null ||
                UnivSection.Collages.Count == 0)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryZeroLengthOrNullCitiesList);


            //الحصول على الجامعة
            var Collage = UnivSection.Collages.SingleOrDefault(x => x.Id == collageId);
            if (Collage is null)
            {
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNotExists);
            }


            if (Collage.Departments is null ||
                Collage.Departments.Count == 0)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryZeroLengthOrNullCitiesList);


            //الحصول على القسم
            var Department = Collage.Departments.SingleOrDefault(x => x.Id == DepartmentId);
            if (Department is null)
            {
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNotExists);
            }

            //الحصول على الفرع
            if (Department.Branchs is null ||
                Department.Branchs.Count == 0)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryZeroLengthOrNullCitiesList);


            var Branch = Department.Branchs.SingleOrDefault(x => x.Id == DepartmentId);
            if (Branch is null)
            {
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNotExists);
            }


            Department.Branchs.Remove(Branch);
            return this;
        }


        public Univ AddBranch(
              int UnivSectionId, int collageId, int DepartmentId,
              string name_Ar, string name_En, int? ord, string? barcode, int? ministry_Encode
             )
        {
            //الحصول على فرع الجامعة
            var UnivSection = this.UnivSections.SingleOrDefault(x => x.Id == UnivSectionId);
            if (UnivSection is null)
            {
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNotExists);
            }

            if (UnivSection is null ||
                UnivSection.Collages is null ||
                UnivSection.Collages.Count == 0)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryZeroLengthOrNullCitiesList);


            //الحصول على الجامعة
            var Collage = UnivSection.Collages.SingleOrDefault(x => x.Id == collageId);
            if (Collage is null)
            {
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNotExists);
            }


            if (Collage.Departments is null ||
                Collage.Departments.Count == 0)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryZeroLengthOrNullCitiesList);


            //الحصول على القسم
            var Department = Collage.Departments.SingleOrDefault(x => x.Id == DepartmentId);
            if (Department is null)
            {
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNotExists);
            }

            if (Department.Branchs is null)
                Department.Branchs = new Collection<Branch>();


            if (Department is null ||
                Department.Branchs is null ||
                Department.Branchs.Count() == 0)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNotExists);


            //فحص عدم التكرار



            if (Department.Branchs.Where(x => x.NameAr != null && x.NameAr.Equals(name_Ar)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameArAlreadyExists);


            if (Department.Branchs.Where(x => x.NameEn != null && x.NameEn.Equals(name_En)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);


            if (MinistryEncode != null &&
                Department.Branchs.Where(x => x.MinistryEncode != null && x.MinistryEncode == ministry_Encode).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityMinistryAlreadyExists);

      

            Department.Branchs.Add(new Branch(name_Ar, name_En, ord, barcode, ministry_Encode, Department.Id));

            return this;
        }



        public Univ UpdateBranch(
              int UnivSectionId, int collageId, int DepartmentId, int BranchId,
              string name_Ar, string name_En, int? ord, string? barcode, int? ministry_Encode
            )
        {
            //الحصول على فرع الجامعة
            var UnivSection = this.UnivSections.SingleOrDefault(x => x.Id == UnivSectionId);
            if (UnivSection is null)
            {
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNotExists);
            }

            if (UnivSection is null ||
                UnivSection.Collages is null ||
                UnivSection.Collages.Count == 0)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryZeroLengthOrNullCitiesList);


            //الحصول على الجامعة
            var Collage = UnivSection.Collages.SingleOrDefault(x => x.Id == collageId);
            if (Collage is null)
            {
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNotExists);
            }


            if (Collage.Departments is null ||
                Collage.Departments.Count == 0)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryZeroLengthOrNullCitiesList);


            //الحصول على القسم
            var Department = Collage.Departments.SingleOrDefault(x => x.Id == DepartmentId);
            if (Department is null)
            {
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNotExists);
            }

            if (Department is null ||
                Department.Branchs is null ||
                Department.Branchs.Count() == 0)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNotExists);


            var Branch = Department.Branchs.Where(x => x.Id == BranchId).FirstOrDefault();
            if (Branch is null)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNotExists);




            if (Department.Branchs.Where(x => x.NameAr != null && x.Id != BranchId && x.NameAr.Equals(name_Ar)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameArAlreadyExists);


            if (Department.Branchs.Where(x => x.NameEn != null && x.Id != BranchId && x.NameEn.Equals(name_En)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);





            if (ministry_Encode != null &&
                Department.Branchs.Where(x => x.MinistryEncode != null && x.Id != BranchId && x.MinistryEncode == ministry_Encode).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityMinistryAlreadyExists);


            Branch.NameAr = name_Ar;
            Branch.NameEn = name_En;
            Branch.Ord = ord;
            Branch.MinistryEncode = ministry_Encode;
            Branch.Barcode = barcode;
            

            return this;
        }




    }
}
