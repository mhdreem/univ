using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univ.Hi_Student_Affairs.Domain.AverageCalc.Exception;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using Volo.Abp;
using Univ.Hi_Student_Affairs.Domain.Continent;

namespace Univ.Hi_Student_Affairs
{
    public class CountryManager : DomainService
    {

        private readonly IRepository<Country, int> _Repository;


        public CountryManager(IRepository<Country, int> Repository)
        {
            _Repository = Repository;

        }



        public async Task<Country> CreateAsync(
            [NotNull] int continentId,
            [NotNull] string nameAr,
            [NotNull] string nameEn,
            [CanBeNull] int? MinistryEncode ,
            [CanBeNull] string? Barcode ,
            [CanBeNull] int? ord = null
            )
        {
            Check.NotNullOrWhiteSpace(nameAr, nameof(nameAr));
            Check.NotNullOrWhiteSpace(nameEn, nameof(nameEn));


            var Existing_NameAr = await _Repository.FindAsync(x => x.NameAr == nameAr);
            if (Existing_NameAr != null)
            {
                throw new CountryNameArAlreadyExistsException(nameAr);
            }

            var Existing_NameEn = await _Repository.FindAsync(x => x.NameEn == nameEn);
            if (Existing_NameEn != null)
            {
                throw new CountryNameArAlreadyExistsException(nameEn);
            }



            return new Country(
                0,
                continentId,
                nameAr,
                nameEn,
                MinistryEncode,
                Barcode,                
                ord,
                null 
            );
        }

        public async Task<Country> UpdateAsync(
            [NotNull] int id,
            [NotNull] Country input
            )
        {
            Check.NotNullOrWhiteSpace(input.NameAr, nameof(input.NameAr));
            Check.NotNullOrWhiteSpace(input.NameEn, nameof(input.NameEn));


            var Old = await _Repository.FindAsync(x => x.Id == id);
            if (Old == null)
            {
                throw new CountryNotExistsException();
            }

            var Existing_NameAr = await _Repository.FindAsync(x => x.NameAr == input.NameAr && x.Id != id);
            if (Existing_NameAr != null)
            {
                throw new CountryNameArAlreadyExistsException(input.NameAr);
            }



            var Existing_NameEn = await _Repository.FindAsync(x => x.NameEn == input.NameEn && x.Id != id);
            if (Existing_NameAr != null)
            {
                throw new CountryNameArAlreadyExistsException(input.NameEn);
            }


            Old.NameAr = input.NameAr;
            Old.NameEn = input.NameEn;
            Old.Ord = input.Ord;
            Old.MinistryEncode = input.MinistryEncode;
            


            return Old;
        }
    }
}