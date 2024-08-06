using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univ.Hi_Student_Affairs.Domain.Continent;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using Volo.Abp;
using System.Collections.ObjectModel;
using Microsoft.Extensions.Logging;
using System.Security.Cryptography;
using System.Net.Mime;
using System.Net.Http.Headers;

namespace Univ.Hi_Student_Affairs
{
    public class UnivManager : DomainService
    {

        private readonly IUnivRepository _Repository;
        public UnivManager(IUnivRepository Repository)
        {
            _Repository = Repository;
        }

        


        public async Task<Univ> CreateAsync(
            [NotNull] string NameAr,
            [NotNull] string NameEn,
            [CanBeNull] int? Ord,
            [CanBeNull] int? MinistryEncode = null,
            [CanBeNull] string? UnivEncode = null,                          
            [CanBeNull] Collection<UnivSection>? UnivSections = null 
            )
        {
            Check.NotNullOrWhiteSpace(NameAr, nameof(NameAr), ContinentConsts.MaxNameArLength, 2);

            Check.NotNullOrWhiteSpace(NameEn, nameof(NameEn), ContinentConsts.MaxNameArLength, 2);



            var Existing_NameAr = await _Repository.FindAsync(x => x.NameAr == NameAr);
            if (Existing_NameAr != null)
            {
                throw new ContinentNameArAlreadyExistsException(NameAr);
            }


            var Existing_NameEn = await _Repository.FindAsync(x => x.NameEn == NameEn);
            if (Existing_NameEn != null)
            {
                throw new ContinentNameEnAlreadyExistsException(NameEn);
            }


            var @Univ =  new Univ(               
                NameAr,
                NameEn,
                Ord,
                MinistryEncode,
                UnivEncode,
                null 
            );

            return @Univ;
        }


       
        public async Task<Univ> UpdateAsync(
            [NotNull] int id,
            [NotNull] Univ input
            )
        {
            Check.NotNullOrWhiteSpace(input.NameAr, nameof(input.NameAr));
            Check.NotNullOrWhiteSpace(input.NameEn, nameof(input.NameEn));


            var Old = await _Repository.FindAsync(x => x.Id == id);
            if (Old == null)
            {
                throw new ContinentNotExistsException();
            }

            var Existing_NameAr = await _Repository.FindAsync(x => x.NameAr == input.NameAr && x.Id != id);
            if (Existing_NameAr != null)
            {
                throw new ContinentNameArAlreadyExistsException(input.NameAr);
            }


            var Existing_NameEn = await _Repository.FindAsync(x => x.NameEn == input.NameEn && x.Id != id);
            if (Existing_NameEn != null)
            {
                throw new ContinentNameEnAlreadyExistsException(input.NameEn);
            }



            Old.NameAr = input.NameAr;
            Old.NameEn = input.NameEn;
            Old.Ord = input.Ord;
            Old.Barcode = input.Barcode;
            Old.MinistryEncode = input.MinistryEncode;

            return Old;
        }



        /*  UnivSection  */
        public void AddUnivSection(Univ @Univ,
         string name_ar, string name_en, int? ord, int? ministry_encode, string? barcode, Collection<Collage>? collages
         )
        {
            @Univ.AddUnivSection(name_ar, name_en, ord, ministry_encode, barcode, collages);
        }


        public void UpdateUnivSection(
            Univ @Univ,
            int UnivSectionId,
                 string name_ar, string name_en, int? ord, int? ministry_encode, string? barcode, Collection<Collage>? collages)
        {
            @Univ.UpdateUnivSection(UnivSectionId, name_ar, name_en, ord, ministry_encode, barcode, collages);
        }



        public void RemoveUnivSection(Univ @Univ,
            [NotNull]  int UnivSectionId)
        {
            @Univ.RemoveUnivSection(UnivSectionId);        
        }




        /*  Collage  */
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






        /*  Department  */
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


        /*  Branch  */
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
}