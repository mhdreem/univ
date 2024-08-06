using JetBrains.Annotations;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using Volo.Abp;
using Univ.Hi_Student_Affairs.Domain;


namespace Univ.Hi_Student_Affairs
{
    public class DeprivationManager : DomainService
    {

        private readonly IRepository<Deprivation, int> _Repository;


        public DeprivationManager(IRepository<Deprivation, int> Repository)
        {
            _Repository = Repository;

        }



        public async Task<Deprivation> CreateAsync(
        [NotNull] string? Name,int? Number,DeprivationType? DeprivationType
            )
        {
            Check.NotNullOrWhiteSpace(Name, nameof(Name));
            

            var ExistingDeprivationName = await _Repository.FindAsync(x => x.Name == Name);
            if (ExistingDeprivationName != null)
            {
                throw new DeprivationNameAlreadyExistsException(Name);
            }





            var Deprivation  = new Deprivation();
            Deprivation.Name = Name;
         

            return Deprivation;

        }

        public async Task<Deprivation> UpdateAsync(
            [NotNull] int id,
            [NotNull] Deprivation input
            )
        {
            Check.NotNull(input, nameof(input));
            Check.NotNullOrWhiteSpace(input.Name, nameof(input.Name));



            var Old = await _Repository.FindAsync(x => x.Id == id);
            if (Old== null)
            {
                throw new DeprivationNotExistsException();
            }

            var Existing_Name = await _Repository.FindAsync(x => x.Name == input.Name && x.Id != id);
            if (Existing_Name != null)
            {
                throw new DeprivationNameAlreadyExistsException(input.Name);
            }



            Old.Name = input.Name;
        

            return Old;
        }
    }
}