using JetBrains.Annotations;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using Volo.Abp;
using System.ComponentModel.DataAnnotations.Schema;
using Univ.Hi_Student_Affairs.Domain;


namespace Univ.Hi_Student_Affairs
{
    public class MilitaryManager : DomainService
    {

        private readonly IRepository<Military, int> _Repository;


        public MilitaryManager(IRepository<Military, int> Repository)
        {
            _Repository = Repository;

        }

        public string? Name { get; set; }





        public async Task<Military> CreateAsync(
            [NotNull] string? Name,
            [CanBeNull] int? CityId = null
            )
        {
            Check.NotNullOrWhiteSpace(Name, nameof(Name));
            

            var ExistingMilitaryName = await _Repository.FindAsync(x => x.Name == Name);
            if (ExistingMilitaryName != null)
            {
                throw new MilitaryNameAlreadyExistsException(Name);
            }





            var Military  = new Military();
            Military.Name = Name;
            Military.CityId = CityId;
            

            return Military;

        }

        public async Task<Military> UpdateAsync(
            [NotNull] int id,
            [NotNull] Military input
            )
        {
            Check.NotNull(input, nameof(input));
            Check.NotNullOrWhiteSpace(input.Name, nameof(input.Name));



            var Old = await _Repository.FindAsync(x => x.Id == id);
            if (Old== null)
            {
                throw new MilitaryNotExistsException();
            }

            var Existing_Name = await _Repository.FindAsync(x => x.Name == input.Name && x.Id != id);
            if (Existing_Name != null)
            {
                throw new MilitaryNameAlreadyExistsException(input.Name);
            }



            Old.Name = input.Name;
       
            Old.CityId = input.CityId;
          


            return Old;
        }
    }
}