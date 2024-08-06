using JetBrains.Annotations;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using Volo.Abp;
using Univ.Hi_Student_Affairs.Domain;
using Univ.Hi_Student_Affairs.Domain.CivilReg.Exception;

namespace Univ.Hi_Student_Affairs
{
    public class SeqStatusManager : DomainService
    {

        private readonly IRepository<SeqStatus, int> _Repository;

        public SeqStatusManager(IRepository<SeqStatus, int> Repository)
        {
            _Repository = Repository;

        }


        public async Task<SeqStatus> CreateAsync(
            [NotNull] string? NameAr,
            [CanBeNull] string? NameEn = null,
            [CanBeNull] int? Ord = null
            )
        {
            Check.NotNullOrWhiteSpace(NameAr, nameof(NameAr));


            var ExistingNameAr = await _Repository.FindAsync(x => x.NameAr == NameAr);
            if (ExistingNameAr != null)
            {
                throw new SeqStatusNameArAlreadyExistsException(NameAr);
            }

            if (!string.IsNullOrEmpty(NameEn))
            {
                var ExistingNameEn = await _Repository.FindAsync(x => x.NameEn == NameEn);
                if (ExistingNameEn != null)
                {
                    throw new SeqStatusNameArAlreadyExistsException(NameEn);
                }
            }


            var SeqStatus = new SeqStatus();
            SeqStatus.NameAr = NameAr;
            SeqStatus.NameEn = NameEn;
            SeqStatus.Ord = Ord;


            return SeqStatus;

        }

        public async Task<SeqStatus> UpdateAsync(
            [NotNull] int id,
            [NotNull] SeqStatus input
            )
        {
            Check.NotNull(input, nameof(input));
            Check.NotNullOrWhiteSpace(input.NameAr, nameof(input.NameAr));



            var Old = await _Repository.FindAsync(x => x.Id == id);
            if (Old == null)
            {
                throw new SeqStatusNotExistsException();
            }

            var Existing_NameAr = await _Repository.FindAsync(x => x.NameAr == input.NameAr && x.Id != id);
            if (Existing_NameAr != null)
            {
                throw new SeqStatusNameArAlreadyExistsException(input.NameAr);
            }

            if (!string.IsNullOrEmpty(input.NameEn))
            {
                var ExistingNameEn = await _Repository.FindAsync(x => x.NameEn == input.NameEn && x.Id != id);
                if (ExistingNameEn != null)
                {
                    throw new SeqStatusNameArAlreadyExistsException(input.NameEn);
                }
            }

            Old.NameAr = input.NameAr;
            Old.NameEn = input.NameEn;



            return Old;
        }
    }
}