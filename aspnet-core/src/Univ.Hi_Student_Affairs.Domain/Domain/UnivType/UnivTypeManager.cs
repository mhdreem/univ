using JetBrains.Annotations;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using Volo.Abp;
using Univ.Hi_Student_Affairs.Domain.UnivType.Exception;

namespace Univ.Hi_Student_Affairs
{
    public class UnivTypeManager : DomainService
    {

        private readonly IRepository<UnivType, int> _Repository;


        public UnivTypeManager(IRepository<UnivType, int> Repository)
        {
            _Repository = Repository;

        }



        public async Task<UnivType> CreateAsync(
            [NotNull] string nameAr,
            [NotNull] string nameEn,        
            [CanBeNull] int? ord = null
            )
        {
            Check.NotNullOrWhiteSpace(nameAr, nameof(nameAr));
            Check.NotNullOrWhiteSpace(nameEn, nameof(nameEn));


            var Existing_Admission_NameAr = await _Repository.FindAsync(x => x.NameAr == nameAr);
            if (Existing_Admission_NameAr != null)
            {
                throw new UnivTypeNameArAlreadyExistsException(nameAr);
            }


            var Existing_NameEn = await _Repository.FindAsync(x => x.NameEn == nameEn);
            if (Existing_NameEn != null)
            {
                throw new UnivTypeNameEnAlreadyExistsException(nameEn);
            }


            return new UnivType(
                
                nameAr,
                nameEn,
                ord
                
            );
        }

        public async Task<UnivType> UpdateAsync(
            [NotNull] int id,
            [NotNull] UnivType input
            )
        {
            Check.NotNullOrWhiteSpace(input.NameAr, nameof(input.NameAr));
            Check.NotNullOrWhiteSpace(input.NameEn, nameof(input.NameEn));


            var Old = await _Repository.FindAsync(x => x.Id == id);
            if (Old == null)
            {
                throw new UnivTypeNotExistsException();
            }

            var Existing_NameAr = await _Repository.FindAsync(x => x.NameAr == input.NameAr && x.Id != id);
            if (Existing_NameAr != null)
            {
                throw new UnivTypeNameArAlreadyExistsException(input.NameAr);
            }


            var Existing_NameEn = await _Repository.FindAsync(x => x.NameEn == input.NameEn && x.Id != id);
            if (Existing_NameEn != null)
            {
                throw new UnivTypeNameEnAlreadyExistsException(input.NameEn);
            }

            Old.NameAr = input.NameAr;
            Old.NameEn = input.NameEn;            
            Old.Ord = input.Ord;


            return Old;
        }
    }
}