using JetBrains.Annotations;
using System.Threading.Tasks;

using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using Volo.Abp;
using Univ.Hi_Student_Affairs.Domain.City;

namespace Univ.Hi_Student_Affairs
{
    public class CityManager : DomainService
    {

        private readonly IRepository<City, int> _Repository;


        public CityManager(IRepository<City, int> Repository)
        {
            _Repository = Repository;

        }



        public async Task<City> CreateAsync(
            [NotNull] int countryId ,
            [NotNull] string nameAr,
            [NotNull] string nameEn,
            [CanBeNull] string? phoneCode = null,
            [CanBeNull] string? barcode = null,
            [CanBeNull] int? ministryEncode = null,
            
            [CanBeNull] int? ord = null 
            )
        {
            Check.NotNullOrWhiteSpace(nameAr, nameof(nameAr));
            Check.NotNullOrWhiteSpace(nameEn, nameof(nameEn));


            var Existing_Admission_NameAr = await _Repository.FindAsync(x => x.NameAr == nameAr);
            if (Existing_Admission_NameAr != null)
            {
                throw new CityNameArAlreadyExistsException(nameAr);
            }


            var Existing_Admission_NameEn = await _Repository.FindAsync(x => x.NameEn == nameEn);
            if (Existing_Admission_NameEn != null)
            {
                throw new CityNameEnAlreadyExistsException(nameEn);
            }


            return new City(
                0,
                countryId,
                nameAr,
                nameEn,
                ord,
                phoneCode,
                barcode,
                ministryEncode
            );
        }

        public async Task<City> UpdateAsync(
            [NotNull] int id,
            [NotNull] City input
            )
        {
            Check.NotNullOrWhiteSpace(input.NameAr, nameof(input.NameAr));
            Check.NotNullOrWhiteSpace(input.NameEn, nameof(input.NameEn));


            var Old = await _Repository.FindAsync(x => x.Id == id);
            if (Old == null)
            {
                throw new CityNotExistsException();
            }

            var Existing_Admission_NameAr = await _Repository.FindAsync(x => x.NameAr == input.NameAr && x.Id!= id);
            if (Existing_Admission_NameAr != null)
            {
                throw new CityNameArAlreadyExistsException(input.NameAr);
            }


            var Existing_Admission_NameEn = await _Repository.FindAsync(x => x.NameEn == input.NameEn && x.Id != id);
            if (Existing_Admission_NameEn != null)
            {
                throw new CityNameEnAlreadyExistsException(input.NameEn);
            }



            Old.NameAr = input.NameAr;
            Old.NameEn = input.NameEn;
            Old.PhoneCode = input.PhoneCode;
            Old.Barcode= input.Barcode;
            Old.MinistryEncode= input.MinistryEncode;

            return Old;
        }
    }
}