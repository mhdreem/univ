using JetBrains.Annotations;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using Volo.Abp;
using Univ.Hi_Student_Affairs.Domain;

namespace Univ.Hi_Student_Affairs
{
    public class TerminationStageManager : DomainService
    {

        private readonly IRepository<TerminationStage, int> _Repository;

        public TerminationStageManager(IRepository<TerminationStage, int> Repository)
        {
            _Repository = Repository;
        }

        public async Task<TerminationStage> CreateAsync(
            [NotNull] string? Name,
            [CanBeNull] StageState? StageState = null,
            [CanBeNull] int? Ord = null
            )
        {
            Check.NotNullOrWhiteSpace(Name, nameof(Name));            
            var ExistingName = await _Repository.FindAsync(x => x.Name == Name);
            if (ExistingName != null)
            {
                throw new TerminationStageNameAlreadyExistsException(Name);
            }

            var TerminationStage  = new TerminationStage();
            TerminationStage.Name = Name;
            TerminationStage.StageState = StageState;
            TerminationStage.Ord = Ord;        
            return TerminationStage;
        }

        public async Task<TerminationStage> UpdateAsync(
            [NotNull] int id,
            [NotNull] TerminationStage input
            )
        {
            Check.NotNull(input, nameof(input));
            Check.NotNullOrWhiteSpace(input.Name, nameof(input.Name));



            var Old = await _Repository.FindAsync(x => x.Id == id);
            if (Old== null)
            {
                throw new TerminationStageNotExistsException();
            }

            var Existing_Name = await _Repository.FindAsync(x => x.Name == input.Name && x.Id != id);
            if (Existing_Name != null)
            {
                throw new TerminationStageNameAlreadyExistsException(input.Name);
            }



            Old.Name = input.Name;
            Old.StageState = input.StageState;
            Old.Ord = input.Ord;



            return Old;
        }
    }
}