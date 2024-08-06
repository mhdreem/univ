using JetBrains.Annotations;
using System.Threading.Tasks;
using Volo.Abp.Domain.Services;
using Volo.Abp;
using Volo.Abp.Domain.Repositories;
using Univ.Hi_Student_Affairs.Domain.Admission;

namespace Univ.Hi_Student_Affairs
{
    public class AffiliationOrderManager : DomainService
    {
        private readonly IRepository<AffiliationOrder, int> _Repository;
        public AffiliationOrderManager(IRepository<AffiliationOrder, int> Repository)
        {
            _Repository = Repository;
        }

        public async Task<AffiliationOrder> CreateAsync(
            [NotNull] string name,
            [NotNull] AffiliationType? AffiliationType = null,
            [CanBeNull] int? ord = null
            )
        {
            Check.NotNullOrWhiteSpace(name, nameof(name));

            var ExistingName = await _Repository.FindAsync(x => x.Name == name);
            if (ExistingName != null)
            {
                throw new AffiliationOrderNameAlreadyExistsException(name);
            }

            var AffiliationOrder = new AffiliationOrder();
            AffiliationOrder.Name = name;
            AffiliationOrder.Ord= ord;
            AffiliationOrder.AffiliationType = AffiliationType;
            return AffiliationOrder;


        }

        public async Task<AffiliationOrder> UpdateAsync(
            [NotNull] int id ,
            [NotNull] AffiliationOrder updateAffiliationOrder
            )
        {
            Check.NotNull(updateAffiliationOrder, nameof(updateAffiliationOrder));
            Check.NotNullOrWhiteSpace(updateAffiliationOrder.Name, nameof(updateAffiliationOrder.Name));


            var OldAffiliationOrder = await _Repository.FindAsync(x => x.Id==  id);
            if (OldAffiliationOrder == null )
            {
                throw new AffiliationOrderNotExistsException();
            }                

            var Existing_Admission_Name = await _Repository.FindAsync(x => x.Name== updateAffiliationOrder.Name && x.Id!= id);            
            if (Existing_Admission_Name != null )
            {
                throw new AffiliationOrderNameAlreadyExistsException(OldAffiliationOrder.Name);
            }


            OldAffiliationOrder.Name =  updateAffiliationOrder.Name;
            OldAffiliationOrder.Ord = updateAffiliationOrder.Ord;
            OldAffiliationOrder.AffiliationType = updateAffiliationOrder.AffiliationType;

            return OldAffiliationOrder;
        }
    }
}
