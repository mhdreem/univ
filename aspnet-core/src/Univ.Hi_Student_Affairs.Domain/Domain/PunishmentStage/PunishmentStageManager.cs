using JetBrains.Annotations;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using Volo.Abp;
using Univ.Hi_Student_Affairs.Domain;

namespace Univ.Hi_Student_Affairs
{
    public class PunishmentStageManager : DomainService
    {

        private readonly IRepository<PunishmentStage, int> _Repository;

        public PunishmentStageManager(IRepository<PunishmentStage, int> Repository)
        {
            _Repository = Repository;
        }

        public async Task<PunishmentStage> CreateAsync(
            [NotNull] string? Name,
            [CanBeNull] StageState? StageState = null,
            [CanBeNull] int? Ord = null
            )
        {
            Check.NotNullOrWhiteSpace(Name, nameof(Name));            
            var ExistingName = await _Repository.FindAsync(x => x.Name == Name);
            if (ExistingName != null)
            {
                throw new PunishmentStageNameAlreadyExistsException(Name);
            }

            var PunishmentStage  = new PunishmentStage();
            PunishmentStage.Name = Name;
            PunishmentStage.StageState = StageState;
            PunishmentStage.Ord = Ord;        
            return PunishmentStage;
        }

        public async Task<PunishmentStage> UpdateAsync(
            [NotNull] int id,
            [NotNull] PunishmentStage input
            )
        {
            Check.NotNull(input, nameof(input));
            Check.NotNullOrWhiteSpace(input.Name, nameof(input.Name));



            var Old = await _Repository.FindAsync(x => x.Id == id);
            if (Old== null)
            {
                throw new PunishmentStageNotExistsException();
            }

            var Existing_Name = await _Repository.FindAsync(x => x.Name == input.Name && x.Id != id);
            if (Existing_Name != null)
            {
                throw new PunishmentStageNameAlreadyExistsException(input.Name);
            }



            Old.Name = input.Name;
            Old.StageState = input.StageState;
            Old.Ord = input.Ord;



            return Old;
        }
    }
}