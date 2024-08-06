using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using Volo.Abp;
using Univ.Hi_Student_Affairs.Domain;


namespace Univ.Hi_Student_Affairs
{
    public class TypeLicBranchManager : DomainService
    {

        private readonly IRepository<TypeLicBranch, int> _Repository;


        public TypeLicBranchManager(IRepository<TypeLicBranch, int> Repository)
        {
            _Repository = Repository;

        }



        public async Task<TypeLicBranch> CreateAsync(
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
                throw new TypeLicBranchNameArAlreadyExistsException(nameAr);
            }


            var Existing_NameEn = await _Repository.FindAsync(x => x.NameEn == nameEn);
            if (Existing_NameEn != null)
            {
                throw new TypeLicBranchNameEnAlreadyExistsException(nameEn);
            }


            return new TypeLicBranch(
                0,
                nameAr,
                nameEn,
                ministryEncode,
                barcode,
                ord

            );
        }

        public async Task<TypeLicBranch> UpdateAsync(
            [NotNull] int id,
            [NotNull] TypeLicBranch input
            )
        {
            Check.NotNullOrWhiteSpace(input.NameAr, nameof(input.NameAr));
            Check.NotNullOrWhiteSpace(input.NameEn, nameof(input.NameEn));


            var Old = await _Repository.FindAsync(x => x.Id == id);
            if (Old == null)
            {
                throw new TypeLicBranchNotExistsException();
            }

            var Existing_NameAr = await _Repository.FindAsync(x => x.NameAr == input.NameAr && x.Id != id);
            if (Existing_NameAr != null)
            {
                throw new TypeLicBranchNameArAlreadyExistsException(input.NameAr);
            }


            var Existing_NameEn = await _Repository.FindAsync(x => x.NameEn == input.NameEn && x.Id != id);
            if (Existing_NameEn != null)
            {
                throw new TypeLicBranchNameEnAlreadyExistsException(input.NameEn);
            }



            Old.NameAr = input.NameAr;
            Old.NameEn = input.NameEn;
            Old.Ord = input.Ord;
            Old.MinistryEncode = input.MinistryEncode;
            Old.Barcode = input.Barcode;


            return Old;
        }
    }
}