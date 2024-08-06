using JetBrains.Annotations;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using Volo.Abp;
using Univ.Hi_Student_Affairs.Domain;

namespace Univ.Hi_Student_Affairs
{
    public class TerminationOrderManager : DomainService
    {

        private readonly IRepository<TerminationOrder, int> _Repository;


        public TerminationOrderManager(IRepository<TerminationOrder, int> Repository)
        {
            _Repository = Repository;

        }



        public async Task<TerminationOrder> CreateAsync(
            [NotNull] string? Name,
            [CanBeNull] TerminationType? TerminationType = null,
            [CanBeNull] int? Ord = null
            )
        {
            Check.NotNullOrWhiteSpace(Name, nameof(Name));
            

            var ExistingName = await _Repository.FindAsync(x => x.Name == Name);
            if (ExistingName != null)
            {
                throw new TerminationOrderNameAlreadyExistsException(Name);
            }





            var TerminationOrder  = new TerminationOrder();
            TerminationOrder.Name = Name;
            TerminationOrder.TerminationType = TerminationType;
            TerminationOrder.Ord = Ord;

            return TerminationOrder;

        }

        public async Task<TerminationOrder> UpdateAsync(
            [NotNull] int id,
            [NotNull] TerminationOrder input
            )
        {
            Check.NotNull(input, nameof(input));
            Check.NotNullOrWhiteSpace(input.Name, nameof(input.Name));



            var Old = await _Repository.FindAsync(x => x.Id == id);
            if (Old== null)
            {
                throw new TerminationOrderNotExistsException();
            }

            var Existing_Name = await _Repository.FindAsync(x => x.Name == input.Name && x.Id != id);
            if (Existing_Name != null)
            {
                throw new TerminationOrderNameAlreadyExistsException(input.Name);
            }



            Old.Name = input.Name;
            Old.TerminationType = input.TerminationType;
            Old.Ord= input.Ord;


            return Old;
        }
    }
}