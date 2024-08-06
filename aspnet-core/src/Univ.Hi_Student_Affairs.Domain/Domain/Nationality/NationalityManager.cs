using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univ.Hi_Student_Affairs.Domain.Nationality;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using Volo.Abp;
using Univ.Hi_Student_Affairs.Domain.Nationality.Exception;

namespace Univ.Hi_Student_Affairs
{
    public class NationalityManager : DomainService
    {

        private readonly IRepository<Nationality, int> _Repository;


        public NationalityManager(IRepository<Nationality, int> Repository)
        {
            _Repository = Repository;

        }



        public async Task<Nationality> CreateAsync(
            [NotNull] string nameAr,
            [NotNull] string nameEn,
            [NotNull] int? ministry_Encode = null,
            [NotNull] string? barcode = null,
            [CanBeNull] int? ord = null
            )
        {
            Check.NotNullOrWhiteSpace(nameAr, nameof(nameAr));
            Check.NotNullOrWhiteSpace(nameEn, nameof(nameEn));


            var Existing_NameAr = await _Repository.FindAsync(x => x.NameAr == nameAr);
            if (Existing_NameAr != null)
            {
                throw new NationalityNameArAlreadyExistsException(nameAr);
            }


            var Existing_NameEn = await _Repository.FindAsync(x => x.NameEn == nameEn);
            if (Existing_NameEn != null)
            {
                throw new NationalityNameEnAlreadyExistsException(nameEn);
            }


            return new Nationality(
                0,
                nameAr,
                nameEn,                
                ord,
                ministry_Encode,
                barcode

            );
        }

        public async Task<Nationality> UpdateAsync(
            [NotNull] int id,
            [NotNull] Nationality input
            )
        {
            Check.NotNullOrWhiteSpace(input.NameAr, nameof(input.NameAr));
            Check.NotNullOrWhiteSpace(input.NameEn, nameof(input.NameEn));


            var Old = await _Repository.FindAsync(x => x.Id == id);
            if (Old == null)
            {
                throw new NationalityNotExistsException();
            }

            var Existing_NameAr = await _Repository.FindAsync(x => x.NameAr == input.NameAr && x.Id != id);
            if (Existing_NameAr != null)
            {
                throw new NationalityNameArAlreadyExistsException(input.NameAr);
            }


            var Existing_NameEn = await _Repository.FindAsync(x => x.NameEn == input.NameEn && x.Id != id);
            if (Existing_NameEn != null)
            {
                throw new NationalityNameEnAlreadyExistsException(input.NameEn);
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