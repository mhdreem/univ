using JetBrains.Annotations;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using Volo.Abp;
using Univ.Hi_Student_Affairs.Domain;


namespace Univ.Hi_Student_Affairs
{
    public class SubExamStatusManager : DomainService
    {

        private readonly IRepository<SubExamStatus, int> _Repository;


        public SubExamStatusManager(IRepository<SubExamStatus, int> Repository)
        {
            _Repository = Repository;

        }



        public async Task<SubExamStatus> CreateAsync(
            [NotNull] string? NameAr,
            [CanBeNull] string? NameEn = null,                 
            [CanBeNull] int? Ord = null
            )
        {
            Check.NotNullOrWhiteSpace(NameAr, nameof(NameAr));
            

            var ExistingNameAr = await _Repository.FindAsync(x => x.NameAr == NameAr);
            if (ExistingNameAr != null)
            {
                throw new SubExamStatusNameArAlreadyExistsException(NameAr);
            }

            if (!string.IsNullOrEmpty(NameEn) )
            {
                var ExistingNameEn = await _Repository.FindAsync(x => x.NameEn == NameEn);
                if (ExistingNameEn != null)
                {
                    throw new SubExamStatusNameArAlreadyExistsException(NameEn);
                }
            }


            var SubExamStatus  = new SubExamStatus();
            SubExamStatus.NameAr = NameAr;
            SubExamStatus.NameEn = NameEn;
            SubExamStatus.Ord = Ord;


            return SubExamStatus;

        }

        public async Task<SubExamStatus> UpdateAsync(
            [NotNull] int id,
            [NotNull] SubExamStatus input
            )
        {
            Check.NotNull(input, nameof(input));
            Check.NotNullOrWhiteSpace(input.NameAr, nameof(input.NameAr));



            var Old = await _Repository.FindAsync(x => x.Id == id);
            if (Old== null)
            {
                throw new SubExamStatusNotExistsException();
            }

            var Existing_NameAr = await _Repository.FindAsync(x => x.NameAr == input.NameAr && x.Id != id);
            if (Existing_NameAr != null)
            {
                throw new SubExamStatusNameArAlreadyExistsException(input.NameAr);
            }

            if (!string.IsNullOrEmpty(input.NameEn))
            {
                var ExistingNameEn = await _Repository.FindAsync(x => x.NameEn == input.NameEn && x.Id != id);
                if (ExistingNameEn != null)
                {
                    throw new SubExamStatusNameArAlreadyExistsException(input.NameEn);
                }
            }

            Old.NameAr = input.NameAr;
            Old.NameEn = input.NameEn;
        


            return Old;
        }
    }
}