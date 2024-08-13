using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Univ.Hi_Student_Affairs.enums;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;

namespace Univ.Hi_Student_Affairs.Domain.Univ
{

    public class UnivManager : DomainService
    {
        private readonly IRepository<Univ, int> _univRepository;
        private readonly IRepository<UnivSection, int> _univSectionRepository;
        private readonly IRepository<Collage, int> _collageRepository;
        private readonly IRepository<Department, int> _departmentRepository;
        private readonly IRepository<Branch, int> _branchRepository;
        private readonly IRepository<StudyPlan, int> _studyPlanRepository;

        public UnivManager(
            IRepository<Univ, int> univRepository,
            IRepository<UnivSection, int> univSectionRepository,
            IRepository<Collage, int> collageRepository,
            IRepository<Department, int> departmentRepository,
            IRepository<Branch, int> branchRepository,
            IRepository<StudyPlan, int> studyPlanRepository)
        {
            _univRepository = univRepository;
            _univSectionRepository = univSectionRepository;
            _collageRepository = collageRepository;
            _departmentRepository = departmentRepository;
            _branchRepository = branchRepository;
            _studyPlanRepository = studyPlanRepository;
        }

        public async Task<Univ> CreateUnivAsync(
            string nameAr, string nameEn, int? ord, string barcode, UnivType univType, ICollection<UnivSection> univSections)
        {
            var univ = new Univ(nameAr, nameEn, ord, barcode, univType, univSections);
            await _univRepository.InsertAsync(univ);
            return univ;
        }

        public async Task<Univ> UpdateUnivAsync(
            int id, string nameAr, string nameEn, int? ord, string barcode, UnivType univType)
        {
            var univ = await _univRepository.GetAsync(id);

            univ.UpdateUnivType(univType);
            // Update other properties here as needed...

            await _univRepository.UpdateAsync(univ);
            return univ;
        }

        public async Task<Univ> AddUnivSectionAsync(int univId, string nameAr, string nameEn, int? ord, string barcode)
        {
            var univ = await _univRepository.GetAsync(univId);
            var univSection = univ.AddUnivSection(nameAr, nameEn, ord, barcode);

            await _univRepository.UpdateAsync(univ);
            return univ;
        }

        public async Task RemoveUnivSectionAsync(int univId, int univSectionId)
        {
            var univ = await _univRepository.GetAsync(univId);
            univ.RemoveUnivSection(univSectionId);

            await _univRepository.UpdateAsync(univ);
        }

        public async Task<UnivSection> AddCollageAsync(
            int univId, int univSectionId, string nameAr, string nameEn, int? ord, string barcode, string deanAr,
            string deanEn, int? numYear, Degree degree, string degreeNameAr, string degreeNameEn,
            ColType colType, ColClassification colClassification, ICollection<Department> departments,
            ICollection<StudyPlan> studyPlans)
        {
            var univ = await _univRepository.GetAsync(univId);
            var univSection = univ.GetUnivSection(univSectionId);
            univSection = univSection.AddCollage(
                nameAr, nameEn, ord, barcode, univSectionId, deanAr, deanEn, numYear, degree, degreeNameAr, degreeNameEn, colType, colClassification, departments, studyPlans
                );

            await _univSectionRepository.UpdateAsync(univSection);
            return univSection;
        }

        public async Task RemoveCollageAsync(int univId, int univSectionId, int collageId)
        {
            var univ = await _univRepository.GetAsync(univId);
            var univSection = univ.GetUnivSection(univSectionId);
            univSection.RemoveCollage(collageId);

            await _univSectionRepository.UpdateAsync(univSection);
        }

        public async Task<Collage> AddDepartmentAsync(
            int univId, int univSectionId, int collageId, string nameAr, string nameEn, int? ord, string barcode,
            ICollection<Branch> branches)
        {
            var univ = await _univRepository.GetAsync(univId);
            var univSection = univ.GetUnivSection(univSectionId);
            var collage = univSection.GetCollage(collageId);
            collage = collage.AddDepartment(nameAr, nameEn, ord, barcode, branches);

            await _collageRepository.UpdateAsync(collage);
            return collage;
        }

        public async Task RemoveDepartmentAsync(int univId, int univSectionId, int collageId, int departmentId)
        {
            var univ = await _univRepository.GetAsync(univId);
            var univSection = univ.GetUnivSection(univSectionId);
            var collage = univSection.GetCollage(collageId);
            collage.RemoveDepartment(departmentId);

            await _collageRepository.UpdateAsync(collage);
        }

        public async Task<Collage> AddStudyPlanAsync(
            int univId, int univSectionId, int collageId, string name, int? ord, string description, DateTime fireDate)
        {
            var univ = await _univRepository.GetAsync(univId);
            var univSection = univ.GetUnivSection(univSectionId);
            var collage = univSection.GetCollage(collageId);
            var studyPlan = collage.AddStudyPlan(name, ord, description, fireDate);

            await _collageRepository.UpdateAsync(collage);
            return collage;
        }

        public async Task RemoveStudyPlanAsync(int univId, int univSectionId, int collageId, int studyPlanId)
        {
            var univ = await _univRepository.GetAsync(univId);
            var univSection = univ.GetUnivSection(univSectionId);
            var collage = univSection.GetCollage(collageId);
            collage.RemoveStudyPlan(studyPlanId);

            await _collageRepository.UpdateAsync(collage);
        }

        public async Task<Department> AddBranchAsync(
            int univId, int univSectionId, int collageId, int departmentId, string nameAr, string nameEn, int? ord, string barcode)
        {
            var univ = await _univRepository.GetAsync(univId);
            var univSection = univ.GetUnivSection(univSectionId);
            var collage = univSection.GetCollage(collageId);
            var department = collage.GetDepartment(departmentId);
            var branch = department.AddBranch(nameAr, nameEn, ord, barcode);

            await _departmentRepository.UpdateAsync(department);
            return department;
        }

        public async Task<Department> UpdateBranchAsync(
          int univId, int univSectionId, int collageId, int departmentId, int branchId, string nameAr, string nameEn, int? ord, string barcode)
        {
            var univ = await _univRepository.GetAsync(univId);
            var univSection = univ.GetUnivSection(univSectionId);
            var collage = univSection.GetCollage(collageId);
            var department = collage.GetDepartment(departmentId);

            department = department.UpdateBranch(branchId, nameAr, nameEn, ord, barcode);

            await _departmentRepository.UpdateAsync(department);
            return department;
        }


        public async Task RemoveBranchAsync(int univId, int univSectionId, int collageId, int departmentId, int branchId)
        {
            var univ = await _univRepository.GetAsync(univId);
            var univSection = univ.GetUnivSection(univSectionId);
            var collage = univSection.GetCollage(collageId);
            var department = collage.GetDepartment(departmentId);
            department.RemoveBranch(branchId);

            await _departmentRepository.UpdateAsync(department);
        }
    }


    /*
    public class UnivManager : DomainService
    {

        private readonly IUnivRepository _Repository;
        public UnivManager(IUnivRepository Repository)
        {
            _Repository = Repository;
        }

        private async Task ValidateUnivAsync(string nameAr, string nameEn, string? barcode, int? id = null)
        {
            var existingNameAr = await _Repository.FindAsync(x => x.NameAr == nameAr && (!id.HasValue || x.Id != id));
            if (existingNameAr != null)
            {
                throw new CountryNameArAlreadyExistsException(nameAr);
            }

            var existingNameEn = await _Repository.FindAsync(x => x.NameEn == nameEn && (!id.HasValue || x.Id != id));
            if (existingNameEn != null)
            {
                throw new CountryNameArAlreadyExistsException(nameEn);
            }

            var existingBarcode = await _Repository.FindAsync(x => x.Barcode == barcode && (!id.HasValue || x.Id != id));
            if (existingBarcode != null)
            {
                throw new UserFriendlyException("Barcode is exist");
            }
        }



        public async Task<Univ> CreateAsync(
           string nameAr, string? nameEn, int? ord, string? barcode, UnivType univType, ICollection<UnivSection>? univSections
            )
        {
            Check.NotNullOrWhiteSpace(nameAr, nameof(nameAr), ContinentConsts.MaxNameArLength, 2);

            Check.NotNullOrWhiteSpace(nameEn, nameof(nameEn), ContinentConsts.MaxNameArLength, 2);


            await ValidateUnivAsync(nameAr, nameEn, barcode);


                        var @Univ =  new Univ(
                nameAr, nameEn, ord, barcode, univType, null
            );

            return @Univ;
        }


       
        public async Task<Univ> UpdateAsync(
            [NotNull] int id,
            string nameAr, string? nameEn, int? ord, string? barcode, UnivType univType, ICollection<UnivSection>? univSections
            )
        {
            Check.NotNullOrWhiteSpace(nameAr, nameof(nameAr));
            


            await ValidateUnivAsync(nameAr, nameEn, barcode, id);


            var Old = await _Repository.FindAsync(x => x.Id == id);
            if (Old == null)
            {
                throw new System.Exception();
            }

            


            Old.SetNameAr(nameAr);
            Old.SetNameEn(nameEn);
            Old.SetBarcode(barcode);
            Old.SetOrd(ord);
         

          

            return Old;
        }



     
        public void AddUnivSection(Univ @Univ,
         string nameAr, string nameEn, int? ord, string? barcode
         )
        {
            @Univ.AddUnivSection(nameAr, nameEn, ord, barcode);
        }


        public void UpdateUnivSection(
            Univ @Univ,
            int UnivSectionId,
                   string nameAr, string nameEn, int? ord, string? barcode)
        {
            @Univ.UpdateUnivSection(UnivSectionId, nameAr, nameEn, ord, barcode);
        }



        public void RemoveUnivSection(Univ @Univ,
            [NotNull]  int UnivSectionId)
        {
            @Univ.RemoveUnivSection(UnivSectionId);        
        }




       
        public void AddCollage(
            Univ @Univ,
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
            string? Barcode,
            Collection<Department> Departments
            )
        {
            
            @Univ.AddCollage(
                UnivSectionId,
            NameAr,
            NameEn,
            DeanAr,
            DeanEn,
            NumYear,
            Ord,
            DegreeNameAr,
            DegreeNameEn,
            MinistryEncode,
            Barcode);


        }

        public void UpdateCollage(
            Univ @Univ,
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
            @Univ.UpdateCollage(
                UnivSectionId,
            CollageId,
            NameAr,
            NameEn,
            DeanAr,
            DeanEn,
            NumYear,
            Ord,
            DegreeNameAr,
            DegreeNameEn,
            MinistryEncode,
            Barcode);
        }


        public void  RemoveCollage(
            Univ @Univ,
            int UnivSectionId,
           int CollageId
           
           )
        {
            @Univ.RemoveCollage(UnivSectionId, CollageId);
        }






     
        public void AddDepartment(
              Univ @Univ,
              int UnivSectionId,
              int CollageId,
              string NameAr,
              string NameEn,
              int? Ord,
              string? DegreeNameAr,
              string? DegreeNameEn,
              int? MinistryEncode,
              string? Barcode,
              Collection<Branch> Branchs
            )
        {

            @Univ.AddDepartment(
                UnivSectionId,
                CollageId,
                NameAr,
                NameEn,
                Ord,
                DegreeNameAr,
                DegreeNameEn,
                MinistryEncode,
                Barcode);


        }

        public void UpdateDepartment(
            Univ @Univ,
            int UnivSectionId,
            int CollageId,
            int departmentId,             
            string NameAr,
            string NameEn,
            int? Ord,
            string? DegreeNameAr,
            string? DegreeNameEn,
            int? MinistryEncode,
            string? Barcode

  )
        {
            @Univ.UpdateDepartment(
                UnivSectionId,
                CollageId,
                departmentId,
                NameAr,
                NameEn,
                Ord,
                DegreeNameAr,
                DegreeNameEn,
                MinistryEncode,
                Barcode);
        }


        public void RemoveDeparment(
            Univ @Univ,
            int UnivSectionId,
            int CollageId,
            int departmentId
           )
        {
            @Univ.RemoveDepartment(UnivSectionId, CollageId, departmentId);
        }


        
        public void AddBranch(
              Univ @Univ,
              int UnivSectionId,
              int CollageId,
              int DepartmentId,
              string name_Ar, 
              string name_En, 
              int? ord, 
              string? barcode, 
              int? ministry_Encode
            )
        {

            @Univ.AddBranch(
                UnivSectionId,
                CollageId,
                DepartmentId,
                name_Ar,
                name_En,
                ord,
                barcode,
                ministry_Encode);


        }

        public void UpdateBranch(
            Univ @Univ,
            int UnivSectionId,
            int CollageId,
            int departmentId,
            int BranchId,
            string name_Ar,
              string name_En,
              int? ord,
              string? barcode,
              int? ministry_Encode
            )
        {

            @Univ.UpdateBranch(
                UnivSectionId,
                CollageId,
                departmentId,
                BranchId,
                name_Ar,
                name_En,
                ord,
                barcode,
                ministry_Encode);

        }


        public void RemoveBranch(
            Univ @Univ,
            int UnivSectionId,
            int CollageId,
            int departmentId,
            int BranchId
           )
        {
            @Univ.RemoveBranch(UnivSectionId, CollageId, departmentId, BranchId);
        }



    }
    */
}