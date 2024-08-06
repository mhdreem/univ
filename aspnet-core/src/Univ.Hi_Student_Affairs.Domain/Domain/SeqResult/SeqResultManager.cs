using JetBrains.Annotations;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using Volo.Abp;
using Univ.Hi_Student_Affairs.Domain;

namespace Univ.Hi_Student_Affairs
{
    public class SeqResultManager : DomainService
    {

        private readonly IRepository<SeqResult, int> _Repository;


        public SeqResultManager(IRepository<SeqResult, int> Repository)
        {
            _Repository = Repository;

        }



        public async Task<SeqResult> CreateAsync(
            [NotNull] string? NameAr,
            [CanBeNull] string? NameEn = null,
            [CanBeNull] int? Ord = null
            )
        {
            Check.NotNullOrWhiteSpace(NameAr, nameof(NameAr));


            var ExistingNameAr = await _Repository.FindAsync(x => x.NameAr == NameAr);
            if (ExistingNameAr != null)
            {
                throw new SeqResultNameArAlreadyExistsException(NameAr);
            }

            if (!string.IsNullOrEmpty(NameEn))
            {
                var ExistingNameEn = await _Repository.FindAsync(x => x.NameEn == NameEn);
                if (ExistingNameEn != null)
                {
                    throw new SeqResultNameArAlreadyExistsException(NameEn);
                }
            }


            var SeqResult = new SeqResult();
            SeqResult.NameAr = NameAr;
            SeqResult.NameEn = NameEn;
            SeqResult.Ord = Ord;


            return SeqResult;

        }

        public async Task<SeqResult> UpdateAsync(
            [NotNull] int id,
            [NotNull] SeqResult input
            )
        {
            Check.NotNull(input, nameof(input));
            Check.NotNullOrWhiteSpace(input.NameAr, nameof(input.NameAr));



            var Old = await _Repository.FindAsync(x => x.Id == id);
            if (Old == null)
            {
                throw new SeqResultNotExistsException();
            }

            var Existing_NameAr = await _Repository.FindAsync(x => x.NameAr == input.NameAr && x.Id != id);
            if (Existing_NameAr != null)
            {
                throw new SeqResultNameArAlreadyExistsException(input.NameAr);
            }

            if (!string.IsNullOrEmpty(input.NameEn))
            {
                var ExistingNameEn = await _Repository.FindAsync(x => x.NameEn == input.NameEn && x.Id != id);
                if (ExistingNameEn != null)
                {
                    throw new SeqResultNameArAlreadyExistsException(input.NameEn);
                }
            }

            Old.NameAr = input.NameAr;
            Old.NameEn = input.NameEn;



            return Old;
        }
    }
}