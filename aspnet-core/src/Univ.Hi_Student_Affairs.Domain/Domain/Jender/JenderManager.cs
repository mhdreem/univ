using JetBrains.Annotations;
using System.Threading.Tasks;
using Univ.Hi_Student_Affairs.Domain.Jender;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using Volo.Abp;
using Univ.Hi_Student_Affairs.Domain.Jender.Exception;
using Univ.Hi_Student_Affairs.Domain.AverageCalc.Exception;

namespace Univ.Hi_Student_Affairs
{
    public class JenderManager : DomainService
    {

        private readonly IRepository<Jender, int> _Repository;


        public JenderManager(IRepository<Jender, int> Repository)
        {
            _Repository = Repository;

        }



        public async Task<Jender> CreateAsync(
            [NotNull] string nameAr,
            [NotNull] string nameEn,
            [CanBeNull] int? ministryEncode = null,
            [CanBeNull] string? barcode= null,
            [CanBeNull] int? ord = null
            )
        {
            Check.NotNullOrWhiteSpace(nameAr, nameof(nameAr));
            Check.NotNullOrWhiteSpace(nameEn, nameof(nameEn));


            var Existing_NameAr = await _Repository.FindAsync(x => x.NameAr == nameAr);
            if (Existing_NameAr != null)
            {
                throw new JenderNameArAlreadyExistsException(nameAr);
            }


            var Existing_NameEn = await _Repository.FindAsync(x => x.NameEn == nameEn);
            if (Existing_NameEn != null)
            {
                throw new JenderNameEnAlreadyExistsException(nameEn);
            }


            return new Jender(
                0,
                nameAr,
                nameEn,
                ministryEncode,
                barcode,
                ord

            );
        }

        public async Task<Jender> UpdateAsync(
            [NotNull] int id,
            [NotNull] Jender input
            )
        {
            Check.NotNullOrWhiteSpace(input.NameAr, nameof(input.NameAr));
            Check.NotNullOrWhiteSpace(input.NameEn, nameof(input.NameEn));


            var Old = await _Repository.FindAsync(x => x.Id == id);
            if (Old == null)
            {
                throw new JenderNotExistsException();
            }

            var Existing_NameAr = await _Repository.FindAsync(x => x.NameAr == input.NameAr && x.Id != id);
            if (Existing_NameAr != null)
            {
                throw new JenderNameArAlreadyExistsException(input.NameAr);
            }


            var Existing_NameEn = await _Repository.FindAsync(x => x.NameEn == input.NameEn && x.Id != id);
            if (Existing_NameEn != null)
            {
                throw new JenderNameEnAlreadyExistsException(input.NameEn);
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