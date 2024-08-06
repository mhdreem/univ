using JetBrains.Annotations;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using Volo.Abp;
using System.Collections.ObjectModel;
using Univ.Hi_Student_Affairs.Domain;
using System.Security.Cryptography;

namespace Univ.Hi_Student_Affairs
{
    public class TypeLicManager : DomainService
    {

        private readonly IRepository<TypeLic, int> _Repository;


        public TypeLicManager(IRepository<TypeLic, int> Repository)
        {
            _Repository = Repository;

        }



        public async Task<TypeLic> CreateAsync(
            [NotNull] string nameAr,
            [NotNull] string nameEn,
            [CanBeNull] int? ministryEncode = null,
            [CanBeNull] string? barcode = null,
            [CanBeNull] int? ord = null
            )
        {
            Check.NotNullOrWhiteSpace(nameAr, nameof(nameAr));
            Check.NotNullOrWhiteSpace(nameEn, nameof(nameEn));


            var Existing_NameAr = await _Repository.FindAsync(x => x.NameAr == nameAr);
            if (Existing_NameAr != null)
            {
                throw new TypeLicNameArAlreadyExistsException(nameAr);
            }


            var Existing_NameEn = await _Repository.FindAsync(x => x.NameEn == nameEn);
            if (Existing_NameEn != null)
            {
                throw new TypeLicBranchNameEnAlreadyExistsException(nameEn);
            }


            return new TypeLic(
             
                nameAr,
                nameEn,
                ministryEncode,
                barcode,
                ord

            );
        }

        public async Task<TypeLic> UpdateAsync(
            [NotNull] int id,
            [NotNull] TypeLic input
            )
        {
            Check.NotNullOrWhiteSpace(input.NameAr, nameof(input.NameAr));
            Check.NotNullOrWhiteSpace(input.NameEn, nameof(input.NameEn));


            var Old = await _Repository.FindAsync(x => x.Id == id);
            if (Old == null)
            {
                throw new TypeLicNotExistsException();
            }

            var Existing_NameAr = await _Repository.FindAsync(x => x.NameAr == input.NameAr && x.Id != id);
            if (Existing_NameAr != null)
            {
                throw new TypeLicNameArAlreadyExistsException(input.NameAr);
            }


            var Existing_NameEn = await _Repository.FindAsync(x => x.NameEn == input.NameEn && x.Id != id);
            if (Existing_NameEn != null)
            {
                throw new TypeLicNameEnAlreadyExistsException(input.NameEn);
            }



            Old.NameAr = input.NameAr;
            Old.NameEn = input.NameEn;
            Old.Ord = input.Ord;
            Old.MinistryEncode = input.MinistryEncode;
            Old.Barcode = input.Barcode;


            return Old;
        }
        
        /*  TypeLicBranch  */
        public void AddTypeLicBranch(TypeLic @TypeLic,
         TypeLicBranch input
         )
        {
            @TypeLic.AddTypeLicBranch(input);
        }


        public void UpdateTypeLicBranch(
            TypeLic @TypeLic,
            int TypeLicBranchId,
                 TypeLicBranch typeLicBranch)
        {
            @TypeLic.UpdateTypeLicBranch(TypeLicBranchId, typeLicBranch);
        }



        public void RemoveTypeLicBranch(TypeLic @TypeLic,
            [NotNull] int TypeLicBranchId)
        {
            @TypeLic.RemoveTypeLicBranch(TypeLicBranchId);
        }


    }
}