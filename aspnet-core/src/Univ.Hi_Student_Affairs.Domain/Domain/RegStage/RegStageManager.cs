using JetBrains.Annotations;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using Volo.Abp;
using Univ.Hi_Student_Affairs.Domain;

namespace Univ.Hi_Student_Affairs
{
    public class RegStageManager : DomainService
    {


        private readonly IRepository<RegStage, int> _Repository;

        public RegStageManager(IRepository<RegStage, int> Repository)
        {
            _Repository = Repository;
        }

        public async Task<RegStage> CreateAsync(
            [NotNull] string? Name,
            [CanBeNull] StageState? StageState = null,
            [CanBeNull] int? Ord = null
            )
        {
            Check.NotNullOrWhiteSpace(Name, nameof(Name));
            var ExistingName = await _Repository.FindAsync(x => x.Name == Name);
            if (ExistingName != null)
            {
                throw new RegStageNameArAlreadyExistsException(Name);
            }

            var RegStage = new RegStage();
            RegStage.Name = Name;
            RegStage.StageState = StageState;
            RegStage.Ord = Ord;
            return RegStage;
        }

        public async Task<RegStage> UpdateAsync(
            [NotNull] int id,
            [NotNull] RegStage input
            )
        {
            Check.NotNull(input, nameof(input));
            Check.NotNullOrWhiteSpace(input.Name, nameof(input.Name));



            var Old = await _Repository.FindAsync(x => x.Id == id);
            if (Old == null)
            {
                throw new RegStageNotExistsException();
            }

            var Existing_Name = await _Repository.FindAsync(x => x.Name == input.Name && x.Id != id);
            if (Existing_Name != null)
            {
                throw new RegStageNameArAlreadyExistsException(input.Name);
            }



            Old.Name = input.Name;
            Old.StageState = input.StageState;
            Old.Ord = input.Ord;



            return Old;
        }
    }
}