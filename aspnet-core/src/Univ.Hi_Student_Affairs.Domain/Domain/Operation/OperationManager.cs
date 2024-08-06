using JetBrains.Annotations;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using Volo.Abp;
using Univ.Hi_Student_Affairs.Domain;


namespace Univ.Hi_Student_Affairs
{
    public class OperationManager : DomainService
    {

        private readonly IRepository<Operation, int> _Repository;


        public OperationManager(IRepository<Operation, int> Repository)
        {
            _Repository = Repository;

        }



        public async Task<Operation> CreateAsync(
            [NotNull] string? Name
            )
        {
            Check.NotNullOrWhiteSpace(Name, nameof(Name));
            

            var ExistingOperationName = await _Repository.FindAsync(x => x.Name == Name);
            if (ExistingOperationName != null)
            {
                throw new OperationNameAlreadyExistsException(Name);
            }





            var Operation  = new Operation();
            Operation.Name = Name;
         

            return Operation;

        }

        public async Task<Operation> UpdateAsync(
            [NotNull] int id,
            [NotNull] Operation input
            )
        {
            Check.NotNull(input, nameof(input));
            Check.NotNullOrWhiteSpace(input.Name, nameof(input.Name));



            var Old = await _Repository.FindAsync(x => x.Id == id);
            if (Old== null)
            {
                throw new OperationNotExistsException();
            }

            var Existing_Name = await _Repository.FindAsync(x => x.Name == input.Name && x.Id != id);
            if (Existing_Name != null)
            {
                throw new OperationNameAlreadyExistsException(input.Name);
            }



            Old.Name = input.Name;
        

            return Old;
        }
    }
}