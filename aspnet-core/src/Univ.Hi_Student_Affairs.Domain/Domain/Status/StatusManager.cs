using JetBrains.Annotations;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using Volo.Abp;
using Univ.Hi_Student_Affairs.Domain;


namespace Univ.Hi_Student_Affairs
{
    public class StatusManager : DomainService
    {

        private readonly IRepository<Status, int> _Repository;


        public StatusManager(IRepository<Status, int> Repository)
        {
            _Repository = Repository;

        }



        public async Task<Status> CreateAsync(
            [NotNull] string? NameAr,
            [CanBeNull] string? NameEn = null,
            [CanBeNull] int? Ord = null
            )
        {
            Check.NotNullOrWhiteSpace(NameAr, nameof(NameAr));


            var ExistingNameAr = await _Repository.FindAsync(x => x.NameAr == NameAr);
            if (ExistingNameAr != null)
            {
                throw new StatusNameArAlreadyExistsException(NameAr);
            }

            if (!string.IsNullOrEmpty(NameEn))
            {
                var ExistingNameEn = await _Repository.FindAsync(x => x.NameEn == NameEn);
                if (ExistingNameEn != null)
                {
                    throw new StatusNameArAlreadyExistsException(NameEn);
                }
            }


            var Status = new Status();
            Status.NameAr = NameAr;
            Status.NameEn = NameEn;
            Status.Ord = Ord;


            return Status;

        }

        public async Task<Status> UpdateAsync(
            [NotNull] int id,
            [NotNull] Status input
            )
        {
            Check.NotNull(input, nameof(input));
            Check.NotNullOrWhiteSpace(input.NameAr, nameof(input.NameAr));



            var Old = await _Repository.FindAsync(x => x.Id == id);
            if (Old == null)
            {
                throw new StatusNotExistsException();
            }

            var Existing_NameAr = await _Repository.FindAsync(x => x.NameAr == input.NameAr && x.Id != id);
            if (Existing_NameAr != null)
            {
                throw new StatusNameArAlreadyExistsException(input.NameAr);
            }

            if (!string.IsNullOrEmpty(input.NameEn))
            {
                var ExistingNameEn = await _Repository.FindAsync(x => x.NameEn == input.NameEn && x.Id != id);
                if (ExistingNameEn != null)
                {
                    throw new StatusNameArAlreadyExistsException(input.NameEn);
                }
            }

            Old.NameAr = input.NameAr;
            Old.NameEn = input.NameEn;



            return Old;
        }
    }
}