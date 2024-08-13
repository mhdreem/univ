using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Univ.Hi_Student_Affairs.Domain.Abstruct;
using Univ.Hi_Student_Affairs.enums;
using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain.Univ
{
    public class Collage : TEncodeTableEntity<int>
    {
        [ForeignKey("UnivSectionId")]
        public int UnivSectionId { get; private set; }


        //اسم العميد
        public virtual string? DeanAr { get; private set; }
        public virtual string? DeanEn { get; private set; }



        //عدد السنوات الدراسية 
        public virtual int? NumYear { get; private set; }

        public virtual Degree Degree { get; private set; }


        //اسم الاجازة الممنوحة للطالب
        public virtual string? DegreeNameAr { get; private set; }


        //اسم الاجازة الممنوحة للطالب باللغة الانكليزية
        public virtual string? DegreeNameEn { get; private set; }






        public virtual ColType ColType { get; private set; }

        public virtual ColClassification ColClassification { get; private set; }


        public virtual ICollection<Department>? Departments { get; private set; } //sub collection

        public virtual ICollection<StudyPlan>? StudyPlans { get; private set; } //sub collection



        private void SetDeanAr(string? deanAr)
        {
            DeanAr = deanAr;
        }

        public void UpdateDeanAr(string deanAr)
        {
            SetDeanAr(deanAr);
        }

        private void SetDeanEn(string? deanEn)
        {
            DeanEn = deanEn;
        }

        public void UpdateDeanEn(string deanEn)
        {
            SetDeanEn(deanEn);
        }


        private void SetDegree(Degree Degree)
        {
            Degree = Degree;
        }

        public void UpdateDegree(Degree Degree)
        {
            SetDegree(Degree);
        }



        private void SetDegreeNameAr(string? degreeNameAr)
        {
            DegreeNameAr = degreeNameAr;
        }

        public void UpdateDegreeNameAr(string? degreeNameAr)
        {
            SetDegreeNameAr(degreeNameAr);
        }

        private void SetDegreeNameEn(string? degreeNameEn)
        {
            DegreeNameEn = degreeNameEn;
        }

        public void UpdateDegreeNameEn(string? degreeNameEn)
        {
            SetDegreeNameEn(degreeNameEn);
        }

        private void SetUnivSectionId(int univSectionId)
        {
            UnivSectionId = univSectionId;
        }

        public void UpdateUnivSectionId(int univSectionId)
        {
            SetUnivSectionId(univSectionId);
        }


        private void SetCollType(ColType colType)
        {
            ColType = colType;
        }

        public void UpdateCollType(ColType colType)
        {
            SetCollType(colType);
        }


        private void SetCollType(ColClassification colClassification)
        {
            ColClassification = colClassification;
        }

        public void UpdateCollType(ColClassification colClassification)
        {
            SetCollType(colClassification);
        }



        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var other = (Collage)obj;
            return Id == other.Id &&
                   UnivSectionId == other.UnivSectionId &&
            NameAr == other.NameAr &&
                   NameEn == other.NameEn &&
                   Ord == other.Ord &&
                   Barcode == other.Barcode &&
                   UnivSectionId == other.UnivSectionId &&
                   DegreeNameAr == other.DegreeNameAr &&
                   DegreeNameEn == other.DegreeNameEn
            ;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, UnivSectionId, NameAr, NameEn, Ord, Barcode, Departments, StudyPlans);
        }

        public override string ToString()
        {
            return $"[Collage: Id={Id}, UnivSectionId={UnivSectionId}, NameAr={NameAr}, NameEn={NameEn}, Ord={Ord},Barcode={Barcode},DegreeNameAr={DegreeNameAr},DegreeNameEn={DegreeNameEn} ,Departments={Departments},StudyPlans={StudyPlans}]";
        }

        public Collage(string nameAr, string? nameEn, int? ord, string? barcode, int univSectionId, string? deanAr, string? deanEn, int? numYear, Degree degree, string? degreeNameAr, string? degreeNameEn, ColType colType, ColClassification colClassification)
          : base(nameAr, nameEn, ord, barcode)

        {
            SetUnivSectionId(univSectionId);
            SetDeanAr(deanAr);
            SetDeanEn(DeanEn);
            SetDegree(degree);
            SetDegreeNameAr(degreeNameAr);
            SetDegreeNameEn(degreeNameEn);

        }


        public Collage(string nameAr, string? nameEn, int? ord, string? barcode, int univSectionId, string? deanAr, string? deanEn, int? numYear, Degree degree, string? degreeNameAr, string? degreeNameEn, ColType colType, ColClassification colClassification, ICollection<Department>? departments, ICollection<StudyPlan>? studyPlans)
            : base(nameAr, nameEn, ord, barcode)

        {
            SetUnivSectionId(univSectionId);
            SetDeanAr(deanAr);
            SetDeanEn(DeanEn);
            SetDegree(degree);
            SetDegreeNameAr(degreeNameAr);
            SetDegreeNameEn(degreeNameEn);
            Departments = departments ?? new List<Department>();
            StudyPlans = studyPlans ?? new List<StudyPlan>();
        }

        public Collage(int id, string nameAr, string? nameEn, int? ord, string? barcode, int univSectionId, string? deanAr, string? deanEn, int? numYear, Degree degree, string? degreeNameAr, string? degreeNameEn, ColType colType, ColClassification colClassification, ICollection<Department>? departments, ICollection<StudyPlan>? studyPlans)
           : base(id, nameAr, nameEn, ord, barcode)
        {
            SetUnivSectionId(univSectionId);
            SetDeanAr(deanAr);
            SetDeanEn(DeanEn);
            SetDegree(degree);
            SetDegreeNameAr(degreeNameAr);
            SetDegreeNameEn(degreeNameEn);
            Departments = departments ?? new List<Department>();
            StudyPlans = studyPlans ?? new List<StudyPlan>();
        }


        public Collage RemoveDepartment(int branchId)
        {
            if (Departments is null ||
                Departments.Count == 0)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);

            var Department = Departments.SingleOrDefault(x => x.Id == branchId);
            if (Department is null)
            {
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);
            }
            Departments.Remove(Department);

            return this;
        }





        public Collage AddDepartment(
             string nameAr, string? nameEn, int? ord, string? barcode, ICollection<Branch>? branchs
             )
        {
            if (Departments is null ||
                Departments.Count() == 0)
                Departments = new List<Department>();


            if (Departments.Where(x => x.NameAr != null && x.NameAr.Equals(nameAr)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);


            if (Departments.Where(x => x.NameEn != null && x.NameEn.Equals(nameAr)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);

            if (!string.IsNullOrWhiteSpace(barcode) &&
                Departments.Where(x => x.Barcode != null && x.Barcode.Equals(barcode)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);


            Departments.Add(new Department(nameAr, nameEn, ord, barcode, this.Id, branchs));

            // Raise domain event
            //AddDomainEvent(new DepartmentAddedDomainEvent(this, city));

            return this;
        }



        public Collage UpdateDepartment(
             int departmentId,
              string nameAr, string? nameEn, int? ord, string? barcode, ICollection<Branch>? branchs
            )
        {
            if (Departments is null ||
                Departments.Count() == 0)
                Departments = new List<Department>();

            var Department = Departments.Where(x => x.Id == departmentId).FirstOrDefault();
            if (Department is null)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);



            if (Departments.Where(x => x.NameAr != null && x.Id != departmentId && x.NameAr.Equals(nameAr)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);

            if (Departments.Where(x => x.NameEn != null && x.Id != departmentId && x.NameEn.Equals(nameAr)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);

            if (!string.IsNullOrWhiteSpace(barcode) &&
                Departments.Where(x => !string.IsNullOrWhiteSpace(x.Barcode) && x.Id != departmentId && x.Barcode.Equals(barcode)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);



            Department.UpdateNameAr(nameAr);
            Department.UpdateNameEn(nameEn);
            Department.SetNameEn(nameEn);
            Department.SetOrd(ord);
            Department.SetBarcode(barcode);


            // Raise domain event
            //AddDomainEvent(new DepartmentUpdateDomainEvent(this, city));

            return this;
        }



        public Department GetDepartment(int branchId)
        {
            if (Departments is null ||
                Departments.Count == 0)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);


            var Department = Departments.Single(x => x.Id == branchId);
            if (Department is null)
            {
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);
            }
            return Department;
        }


        public Collage RemoveStudyPlan(int branchId)
        {
            if (StudyPlans is null ||
                StudyPlans.Count == 0)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);


            var StudyPlan = StudyPlans.SingleOrDefault(x => x.Id == branchId);
            if (StudyPlan is null)
            {
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.StudyPlanNotExists);
            }
            StudyPlans.Remove(StudyPlan);

            return this;
        }

        public Collage AddStudyPlan(
             string name, int? ord, string? description, DateTime? FireDate
             )
        {
            if (StudyPlans is null ||
                StudyPlans.Count() == 0)
                StudyPlans = new List<StudyPlan>();


            if (StudyPlans.Where(x => x.Name != null && x.Name.Equals(name)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);



            StudyPlans.Add(new StudyPlan(name, ord, this.Id, description, FireDate));

            // Raise domain event
            //AddDomainEvent(new StudyPlanAddedDomainEvent(this, city));

            return this;
        }

        public Collage UpdateStudyPlan(
             int studyPlanId,
              string name, int? ord, string? description, DateTime? FireDate
            )
        {
            if (StudyPlans is null ||
                StudyPlans.Count() == 0)
                StudyPlans = new List<StudyPlan>();

            var StudyPlan = StudyPlans.Where(x => x.Id == studyPlanId).FirstOrDefault();
            if (StudyPlan is null)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.StudyPlanNotExists);




            if (StudyPlans.Where(x => x.Name != null && x.Id != studyPlanId && x.Name.Equals(name)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);



            StudyPlan.SetName(name);
            StudyPlan.SetOrd(ord);



            // Raise domain event
            //AddDomainEvent(new StudyPlanUpdateDomainEvent(this, city));

            return this;
        }



        public StudyPlan GetStudyPlan(int branchId)
        {
            if (StudyPlans is null ||
                StudyPlans.Count == 0)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.AbsenceOrderNotExists);


            var StudyPlan = StudyPlans.Single(x => x.Id == branchId);
            if (StudyPlan is null)
            {
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.StudyPlanNotExists);
            }
            return StudyPlan;
        }


    }
}

