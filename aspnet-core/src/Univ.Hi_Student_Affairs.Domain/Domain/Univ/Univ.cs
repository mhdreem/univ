using System;
using System.Collections.Generic;
using System.Linq;
using Univ.Hi_Student_Affairs.Domain.Abstruct;
using Univ.Hi_Student_Affairs.enums;
using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain.Univ
{
    public class Univ : TEncodeTableAggregateRoot<int>
    {
        public virtual UnivType UnivType { get; private set; }
        public virtual ICollection<UnivSection>? UnivSections { get; protected private set; }


        public Univ(string nameAr, string? nameEn, int? ord, string? barcode, UnivType univType)
           : base(nameAr, nameEn, ord, barcode)
        {
            SetUnivType(univType);

        }

        public Univ(string nameAr, string? nameEn, int? ord, string? barcode, UnivType univType, ICollection<UnivSection>? univSections = null)
            : base(nameAr, nameEn, ord, barcode)
        {
            SetUnivType(univType);
            UnivSections = univSections ?? new List<UnivSection>();
        }

        public Univ(int id, string nameAr, string nameEn, int? ord, string barcode, UnivType univType, ICollection<UnivSection>? univSections = null)
           : base(id, nameAr, nameEn, ord, barcode)
        {
            SetUnivType(univType);
            UnivSections = univSections ?? new List<UnivSection>();
        }

        private void SetUnivType(UnivType univType)
        {
            UnivType = univType;
        }

        public void UpdateUnivType(UnivType univType)
        {
            SetUnivType(univType);
        }

        public Univ AddUnivSection(string nameAr, string nameEn, int? ord, string? barcode)
        {
            if (UnivSections == null)
                UnivSections = new List<UnivSection>();

            if (UnivSections.Any(x => x.NameAr == nameAr || x.NameEn == nameEn || x.Barcode == barcode))
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);

            UnivSections.Add(new UnivSection(nameAr, nameEn, ord, barcode, this.Id, null));
            return this;
        }

        public Univ RemoveUnivSection(int univSectionId)
        {
            var univSection = UnivSections?.SingleOrDefault(x => x.Id == univSectionId);
            if (univSection == null)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);

            UnivSections.Remove(univSection);
            return this;
        }

        public Univ UpdateUnivSection(int univSectionId, string nameAr, string nameEn, int? ord, string? barcode)
        {
            var univSection = UnivSections?.SingleOrDefault(x => x.Id == univSectionId);
            if (univSection == null)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);

            if (UnivSections.Any(x => x.Id != univSectionId && (x.NameAr == nameAr || x.NameEn == nameEn || x.Barcode == barcode)))
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);

            univSection.UpdateNameAr(nameAr);
            univSection.UpdateNameEn(nameEn);
            univSection.SetOrd(ord);
            univSection.SetBarcode(barcode);

            return this;
        }

        public UnivSection GetUnivSection(int univSectionId)
        {
            var univSection = UnivSections?.SingleOrDefault(x => x.Id == univSectionId);
            if (univSection == null)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);

            return univSection;
        }

        public UnivSection AddCollage(string nameAr, string? nameEn, int? ord, string? barcode, int univSectionId, string? deanAr, string? deanEn, int? numYear, Degree degree, string? degreeNameAr, string? degreeNameEn, ColType colType, ColClassification colClassification, ICollection<Department>? departments, ICollection<StudyPlan>? studyPlans)
        {
            var univSection = GetUnivSection(univSectionId);
            univSection.AddCollage(nameAr, nameEn, ord, barcode, univSectionId, deanAr, deanEn, numYear, degree, degreeNameAr, degreeNameEn, colType, colClassification, departments, studyPlans);

            return univSection;
        }

        public UnivSection RemoveCollage(int univSectionId, int collageId)
        {
            var univSection = GetUnivSection(univSectionId);
            univSection.RemoveCollage(collageId);

            return univSection;
        }

        public UnivSection UpdateCollage(int univSectionId, int collageId, string nameAr, string nameEn, int? ord, string? barcode, string? deanAr, string? deanEn, int? numYear, Degree degree, string? degreeNameAr, string? degreeNameEn, ColType colType, ColClassification colClassification, ICollection<Department>? departments, ICollection<StudyPlan>? studyPlans)
        {
            var univSection = GetUnivSection(univSectionId);
            univSection.UpdateCollage(collageId,
              nameAr, nameEn, ord, barcode, univSectionId, deanAr, deanEn, numYear, degree, degreeNameAr, degreeNameEn, colType, colClassification, departments, studyPlans);

            return univSection;
        }

        public Collage GetCollage(int univSectionId, int collageId)
        {
            var univSection = GetUnivSection(univSectionId);
            return univSection.GetCollage(collageId);
        }

        public Collage AddDepartment(int univSectionId, int collageId, string nameAr, string nameEn, int? ord, string? barcode, ICollection<Branch>? branchs)
        {
            var collage = GetCollage(univSectionId, collageId);
            collage.AddDepartment(nameAr, nameEn, ord, barcode, branchs);

            return collage;
        }

        public Collage RemoveDepartment(int univSectionId, int collageId, int departmentId)
        {
            var collage = GetCollage(univSectionId, collageId);
            collage.RemoveDepartment(departmentId);

            return collage;
        }

        public Collage UpdateDepartment(int univSectionId, int collageId, int departmentId, string nameAr, string nameEn, int? ord, string? barcode, ICollection<Branch>? branchs)
        {
            var collage = GetCollage(univSectionId, collageId);
            collage.UpdateDepartment(departmentId,
              nameAr, nameEn, ord, barcode, branchs);

            return collage;
        }

        public Department GetDepartment(int univSectionId, int collageId, int departmentId)
        {
            var collage = GetCollage(univSectionId, collageId);
            return collage.GetDepartment(departmentId);
        }



        public Department AddBranch(int univSectionId, int collageId, int departmentId, string nameAr, string nameEn, int? ord, string? barcode)
        {
            var department = GetDepartment(univSectionId, collageId, departmentId);
            department.AddBranch(nameAr, nameEn, ord, barcode);

            return department;
        }

        public Department RemoveBranch(int univSectionId, int collageId, int departmentId, int branchId)
        {
            var department = GetDepartment(univSectionId, collageId, departmentId);
            department.RemoveBranch(branchId);

            return department;
        }

        public Department UpdateBranch(int univSectionId, int collageId, int departmentId, int branchId,
            string nameAr, string nameEn, int? ord, string? barcode)
        {
            var department = GetDepartment(univSectionId, collageId, departmentId);
            department.UpdateBranch(branchId, nameAr, nameEn, ord, barcode);

            return department;
        }

        public Branch GetBranch(int univSectionId, int collageId, int departmentId, int branchId)
        {
            var department = GetDepartment(univSectionId, collageId, departmentId);
            return department.GetBranch(branchId);
        }














        public Collage AddStudyPlan(int univSectionId, int collageId, string name, int? ord, string? description, DateTime? fireDate)
        {
            var collage = GetCollage(univSectionId, collageId);
            collage.AddStudyPlan(name, ord, description, fireDate);

            return collage;
        }

        public Collage RemoveStudyPlan(int univSectionId, int collageId, int studyPlanId)
        {
            var collage = GetCollage(univSectionId, collageId);
            collage.RemoveStudyPlan(studyPlanId);

            return collage;
        }

        public Collage UpdateStudyPlan(int univSectionId, int collageId, int studyPlanId, string name, int? ord, string? description, DateTime? fireDate)
        {
            var collage = GetCollage(univSectionId, collageId);
            collage.UpdateStudyPlan(studyPlanId, name, ord, description, fireDate);

            return collage;
        }

        public StudyPlan GetStudyPlan(int univSectionId, int collageId, int studyPlanId)
        {
            var collage = GetCollage(univSectionId, collageId);
            return collage.GetStudyPlan(studyPlanId);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            var other = (Univ)obj;
            return Id == other.Id &&
                   UnivType == other.UnivType &&
                   NameAr == other.NameAr &&
                   NameEn == other.NameEn &&
                   Ord == other.Ord &&
                   Barcode == other.Barcode &&
                   UnivSections == other.UnivSections;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, UnivType, NameAr, NameEn, Ord, Barcode, UnivSections);
        }

        public override string ToString()
        {
            return $"[Univ: Id={Id}, UnivType={UnivType}, NameAr={NameAr}, NameEn={NameEn}, Ord={Ord}, Barcode={Barcode}, UnivSections={UnivSections.Count}]";
        }
    }

    /*
    public class Univ : TEncodeTableAggregateRoot<int>
    {
        public virtual UnivType? UnivType { get; private set; }

        public virtual ICollection<UnivSection>? UnivSections { get; protected private set; } //Sub collection

        private void SetUnivType(UnivType univType)
        {
            UnivType = univType;
        }

        public void UpdateUnivType(UnivType univType)
        {
            SetUnivType(univType);
        }

   




        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var other = (Univ)obj;
            return Id == other.Id &&
                   UnivType == other.UnivType &&
                   NameAr == other.NameAr &&
                   NameEn == other.NameEn &&
                   Ord == other.Ord &&
                   Barcode == other.Barcode &&
                   UnivType == other.UnivType;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, UnivType, NameAr, NameEn, Ord, Barcode, UnivSections);
        }

        public override string ToString()
        {
            return $"[Univ: Id={Id}, UnivType={UnivType}, NameAr={NameAr}, NameEn={NameEn}, Ord={Ord},Barcode={Barcode},UnivSections={UnivSections}]";
        }



        public Univ(string nameAr, string? nameEn, int? ord, string? barcode, UnivType univType, ICollection<UnivSection>? univSections)
            : base(nameAr, nameEn, ord, barcode)

        {
            SetUnivType(univType);
            UnivSections = univSections ?? new List<UnivSection>();
        }

        public Univ(int id, string nameAr, string nameEn, int? ord, string barcode, UnivType univType, ICollection<UnivSection>? univSections)
           : base(id, nameAr, nameEn, ord, barcode)
        {
            SetUnivType(univType);
            UnivSections = univSections ?? new List<UnivSection>();
        }


        public Univ RemoveUnivSection(int univSectionId)
        {
            if (UnivSections is null ||
                UnivSections.Count == 0)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);

            var UnivSection = UnivSections.SingleOrDefault(x => x.Id == univSectionId);
            if (UnivSection is null)
            {
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);
            }
            UnivSections.Remove(UnivSection);

            return this;
        }





        public Univ AddUnivSection(
             string nameAr, string nameEn, int? ord, string? barcode
             )
        {
            if (UnivSections is null ||
                UnivSections.Count() == 0)
                UnivSections = new List<UnivSection>();


            if (UnivSections.Where(x => x.NameAr != null && x.NameAr.Equals(nameAr)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);


            if (UnivSections.Where(x => x.NameEn != null && x.NameEn.Equals(nameAr)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);

            if (!string.IsNullOrWhiteSpace(barcode) &&
                UnivSections.Where(x => x.Barcode != null && x.Barcode.Equals(barcode)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);


            UnivSections.Add(new UnivSection(nameAr, nameEn, ord, barcode, this.Id,null));

            // Raise domain event
            //AddDomainEvent(new UnivSectionAddedDomainEvent(this, city));

            return this;
        }



        public Univ UpdateUnivSection(
             int univSectionId,
              string nameAr, string nameEn, int? ord, string? barcode
            )
        {
            if (UnivSections is null ||
                UnivSections.Count() == 0)
                UnivSections = new List<UnivSection>();

            var UnivSection = UnivSections.Where(x => x.Id == univSectionId).FirstOrDefault();
            if (UnivSection is null)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);



            if (UnivSections.Where(x => x.NameAr != null && x.Id != univSectionId && x.NameAr.Equals(nameAr)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);

            if (UnivSections.Where(x => x.NameEn != null && x.Id != univSectionId && x.NameEn.Equals(nameAr)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);

            if (!string.IsNullOrWhiteSpace(barcode) &&
                UnivSections.Where(x => !string.IsNullOrWhiteSpace(x.Barcode) && x.Id != univSectionId && x.Barcode.Equals(barcode)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);


            UnivSection.UpdateNameAr(nameAr);
            UnivSection.UpdateNameEn(nameEn);
            UnivSection.SetNameEn(nameEn);
            UnivSection.SetOrd(ord);
            UnivSection.SetBarcode(barcode);


            // Raise domain event
            //AddDomainEvent(new UnivSectionUpdateDomainEvent(this, city));

            return this;
        }



        public UnivSection GetUnivSection(int univSectionId)
        {
            if (UnivSections is null ||
                UnivSections.Count == 0)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);

            var UnivSection = UnivSections.Single(x => x.Id == univSectionId);
            if (UnivSection is null)
            {
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);
            }
            return UnivSection;
        }



        public UnivSection RemoveCollage(int collageId,int univSectionId)
        {
          
        }





        public UnivSection AddCollage(
            int collageId, int univSectionId,
             string nameAr, string? nameEn, int? ord, string? barcode, string? deanAr, string? deanEn, int? numYear, Degree degree, string? degreeNameAr, string? degreeNameEn, ColType colType, ColClassification colClassification, ICollection<Department>? departments, ICollection<StudyPlan>? studyPlans
             )
        {

        }



        public UnivSection UpdateCollage(
            int collageId, int univSectionId,int collageId,
             string nameAr, string? nameEn, int? ord, string? barcode, string? deanAr, string? deanEn, int? numYear, Degree degree, string? degreeNameAr, string? degreeNameEn, ColType colType, ColClassification colClassification, ICollection<Department>? departments, ICollection<StudyPlan>? studyPlans
            )
        {

        }



        public Collage GetCollage(int collageId, int univSectionId)
        {
            
        }


        public Collage RemoveDepartment(int collageId, int univSectionId,int departmentId)
        {

        }





        public Collage AddDepartment(
            int collageId, int univSectionId, 
             string nameAr, string? nameEn, int? ord, string? barcode,  ICollection<Branch>? branchs
             )
        {

        }



        public Collage UpdateDepartment(
   int collageId, int univSectionId,int departmentId,
             string nameAr, string? nameEn, int? ord, string? barcode, ICollection<Branch>? branchs
            )
        {
           
        }



        public Department GetDepartment(int collageId, int univSectionId, int departmentId)
        {
           
        }


        public Collage RemoveStudyPlan(int collageId, int univSectionId)
        {
           
        }

        public Collage AddStudyPlan(int collageId, int univSectionId,
             string name, int? ord, string? description, DateTime? FireDate
             )
        {

        }

        public Collage UpdateStudyPlan(int collageId, int univSectionId,
             int studyPlanId,
              string name, int? ord, string? description, DateTime? FireDate
            )
        {
           
        }



        public StudyPlan GetStudyPlan(int collageId, int univSectionId,
             int studyPlanId)
        {
          
        }

        public Department AddBranch(
           string nameAr, string nameEn, int? ord, string? barcode
           )
        {
            if (Branchs is null ||
                Branchs.Count() == 0)
                Branchs = new List<Branch>();


            if (Branchs.Where(x => x.NameAr != null && x.NameAr.Equals(nameAr)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);


            if (Branchs.Where(x => x.NameEn != null && x.NameEn.Equals(nameAr)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);

            if (!string.IsNullOrWhiteSpace(barcode) &&
                Branchs.Where(x => x.Barcode != null && x.Barcode.Equals(barcode)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);


            Branchs.Add(new Branch(nameAr, nameEn, ord, barcode, this.Id));

            // Raise domain event
            //AddDomainEvent(new BranchAddedDomainEvent(this, city));

            return this;
        }



        public Department UpdateBranch(
             int branchId,
              string nameAr, string nameEn, int? ord, string? barcode, string? phoneCode
            )
        {
            if (Branchs is null ||
                Branchs.Count() == 0)
                Branchs = new List<Branch>();

            var Branch = Branchs.Where(x => x.Id == branchId).FirstOrDefault();
            if (Branch is null)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);




            if (Branchs.Where(x => x.NameAr != null && x.Id != branchId && x.NameAr.Equals(nameAr)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);


            if (Branchs.Where(x => x.NameEn != null && x.Id != branchId && x.NameEn.Equals(nameAr)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);


            if (!string.IsNullOrWhiteSpace(barcode) &&
                Branchs.Where(x => !string.IsNullOrWhiteSpace(x.Barcode) && x.Id != branchId && x.Barcode.Equals(barcode)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);




            Branch.UpdateNameAr(nameAr);
            Branch.UpdateNameEn(nameEn);
            Branch.SetNameEn(nameEn);
            Branch.SetOrd(ord);
            Branch.SetBarcode(barcode);


            // Raise domain event
            //AddDomainEvent(new BranchUpdateDomainEvent(this, city));

            return this;
        }



        public Branch GetBranch(int branchId)
        {
            if (Branchs is null ||
                Branchs.Count == 0)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);


            var Branch = Branchs.Single(x => x.Id == branchId);
            if (Branch is null)
            {
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);
            }
            return Branch;
        }
    }
    */
}

