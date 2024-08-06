using JetBrains.Annotations;
using System.Threading.Tasks;
using Volo.Abp.Domain.Services;
using Volo.Abp;
using Volo.Abp.Domain.Repositories;
using Univ.Hi_Student_Affairs.Domain.Admission;

namespace Univ.Hi_Student_Affairs
{
    public class AbsenceStageManager : DomainService
    {
        private readonly IRepository<AbsenceStage, int> _Repository;
        public AbsenceStageManager(IRepository<AbsenceStage, int> Repository)
        {
            _Repository = Repository;
        }

        public async Task<AbsenceStage> CreateAsync(
            [NotNull] string name,
            [NotNull] StageState? StageState = null,
            [CanBeNull] int? ord = null
            )
        {
            Check.NotNullOrWhiteSpace(name, nameof(name));

            var ExistingName = await _Repository.FindAsync(x => x.Name == name);
            if (ExistingName != null)
            {
                throw new AbsenceStageNameAlreadyExistsException(name);
            }

            var AbsenceStage = new AbsenceStage();
            AbsenceStage.Name = name;
            AbsenceStage.Ord= ord;
            AbsenceStage.StageState = StageState;
            return AbsenceStage;


        }

        public async Task<AbsenceStage> UpdateAsync(
            [NotNull] int id ,
            [NotNull] AbsenceStage updateAbsenceStage
            )
        {
            Check.NotNull(updateAbsenceStage, nameof(updateAbsenceStage));
            Check.NotNullOrWhiteSpace(updateAbsenceStage.Name, nameof(updateAbsenceStage.Name));


            var OldAbsenceStage = await _Repository.FindAsync(x => x.Id==  id);
            if (OldAbsenceStage == null )
            {
                throw new AbsenceStageNotExistsException();
            }                

            var Existing_Admission_Name = await _Repository.FindAsync(x => x.Name== updateAbsenceStage.Name && x.Id!= id);            
            if (Existing_Admission_Name != null )
            {
                throw new AbsenceStageNameAlreadyExistsException(OldAbsenceStage.Name);
            }


            OldAbsenceStage.Name =  updateAbsenceStage.Name;
            OldAbsenceStage.Ord = updateAbsenceStage.Ord;
            OldAbsenceStage.StageState = updateAbsenceStage.StageState;

            return OldAbsenceStage;
        }
    }
}
