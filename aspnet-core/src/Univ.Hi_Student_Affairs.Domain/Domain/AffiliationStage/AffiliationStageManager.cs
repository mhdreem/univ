using JetBrains.Annotations;
using System.Threading.Tasks;
using Volo.Abp.Domain.Services;
using Volo.Abp;
using Volo.Abp.Domain.Repositories;
using Univ.Hi_Student_Affairs.Domain.Admission;

namespace Univ.Hi_Student_Affairs
{
    public class AffiliationStageManager : DomainService
    {
        private readonly IRepository<AffiliationStage, int> _Repository;
        public AffiliationStageManager(IRepository<AffiliationStage, int> Repository)
        {
            _Repository = Repository;
        }

        public async Task<AffiliationStage> CreateAsync(
            [NotNull] string name,
            [NotNull] StageState? StageState = null,
            [CanBeNull] int? ord = null
            )
        {
            Check.NotNullOrWhiteSpace(name, nameof(name));

            var ExistingName = await _Repository.FindAsync(x => x.Name == name);
            if (ExistingName != null)
            {
                throw new AffiliationStageNameAlreadyExistsException(name);
            }

            var AffiliationStage = new AffiliationStage();
            AffiliationStage.Name = name;
            AffiliationStage.Ord= ord;
            AffiliationStage.StageState = StageState;
            return AffiliationStage;


        }

        public async Task<AffiliationStage> UpdateAsync(
            [NotNull] int id ,
            [NotNull] AffiliationStage updateAffiliationStage
            )
        {
            Check.NotNull(updateAffiliationStage, nameof(updateAffiliationStage));
            Check.NotNullOrWhiteSpace(updateAffiliationStage.Name, nameof(updateAffiliationStage.Name));


            var OldAffiliationStage = await _Repository.FindAsync(x => x.Id==  id);
            if (OldAffiliationStage == null )
            {
                throw new AffiliationStageNotExistsException();
            }                

            var Existing_Admission_Name = await _Repository.FindAsync(x => x.Name== updateAffiliationStage.Name && x.Id!= id);            
            if (Existing_Admission_Name != null )
            {
                throw new AffiliationStageNameAlreadyExistsException(OldAffiliationStage.Name);
            }


            OldAffiliationStage.Name =  updateAffiliationStage.Name;
            OldAffiliationStage.Ord = updateAffiliationStage.Ord;
            OldAffiliationStage.StageState = updateAffiliationStage.StageState;

            return OldAffiliationStage;
        }
    }
}
