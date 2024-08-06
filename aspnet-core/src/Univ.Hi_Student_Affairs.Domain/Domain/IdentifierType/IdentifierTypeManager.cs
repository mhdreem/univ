using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univ.Hi_Student_Affairs.Domain.IdentifierType;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using Volo.Abp;
using Univ.Hi_Student_Affairs.Domain.AverageCalc.Exception;
using Univ.Hi_Student_Affairs.Domain.IdentifierType.Exception;

namespace Univ.Hi_Student_Affairs
{
    public class IdentifierTypeManager : DomainService
    {

        private readonly IRepository<IdentifierType, int> _Repository;


        public IdentifierTypeManager(IRepository<IdentifierType, int> Repository)
        {
            _Repository = Repository;

        }



        public async Task<IdentifierType> CreateAsync(
            [NotNull] string nameAr,
            [NotNull] string nameEn,
            [CanBeNull] int? ord = null
            )
        {
            Check.NotNullOrWhiteSpace(nameAr, nameof(nameAr));
            Check.NotNullOrWhiteSpace(nameEn, nameof(nameEn));


            var Existing_NameAr = await _Repository.FindAsync(x => x.NameAr == nameAr);
            if (Existing_NameAr != null)
            {
                throw new IdentifierTypeNameArAlreadyExistsException(nameAr);
            }


            var Existing_NameEn = await _Repository.FindAsync(x => x.NameEn == nameEn);
            if (Existing_NameEn != null)
            {
                throw new IdentifierTypeNameEnAlreadyExistsException(nameEn);
            }


            return new IdentifierType(
                0,
                nameAr,
                nameEn,
                ord
            );
        }

        public async Task<IdentifierType> UpdateAsync(
            [NotNull] int id,
            [NotNull] IdentifierType input
            )
        {
            Check.NotNullOrWhiteSpace(input.NameAr, nameof(input.NameAr));
            Check.NotNullOrWhiteSpace(input.NameEn, nameof(input.NameEn));


            var Old = await _Repository.FindAsync(x => x.Id == id);
            if (Old == null)
            {
                throw new IdentifierTypeNotExistsException();
            }

            var Existing_NameAr = await _Repository.FindAsync(x => x.NameAr == input.NameAr && x.Id != id);
            if (Existing_NameAr != null)
            {
                throw new IdentifierTypeNameArAlreadyExistsException(input.NameAr);
            }


            var Existing_NameEn = await _Repository.FindAsync(x => x.NameEn == input.NameEn && x.Id != id);
            if (Existing_NameEn != null)
            {
                throw new IdentifierTypeNameEnAlreadyExistsException(input.NameEn);
            }



            Old.NameAr = input.NameAr;
            Old.NameEn = input.NameEn;
            Old.Ord = input.Ord;


            return Old;
        }
    }
}