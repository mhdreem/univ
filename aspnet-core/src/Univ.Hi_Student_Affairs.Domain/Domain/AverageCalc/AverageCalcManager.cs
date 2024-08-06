using JetBrains.Annotations;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using Volo.Abp;
using Univ.Hi_Student_Affairs.Domain.AverageCalc.Exception;

namespace Univ.Hi_Student_Affairs
{
    public class AverageCalcManager : DomainService
    {

        private readonly IRepository<AverageCalc, int> _Repository;


        public AverageCalcManager(IRepository<AverageCalc, int> Repository)
        {
            _Repository = Repository;

        }



        public async Task<AverageCalc> CreateAsync(
            [NotNull] string name,
            [CanBeNull] string? Desc = null,           
            [CanBeNull] int? ord = null
            )
        {
            Check.NotNullOrWhiteSpace(name, nameof(name));
            

            var Existing_Admission_NameAr = await _Repository.FindAsync(x => x.Name == name);
            if (Existing_Admission_NameAr != null)
            {
                throw new AverageCalcNameAlreadyExistsException(name);
            }

           

         

            return new AverageCalc(
                0
                ,
                name,
                Desc,                                
                ord
            );
        }

        public async Task<AverageCalc> UpdateAsync(
            [NotNull] int id,
            [NotNull] AverageCalc input
            )
        {
            Check.NotNull(input, nameof(input));
            Check.NotNullOrWhiteSpace(input.Name, nameof(input.Name));



            var Old = await _Repository.FindAsync(x => x.Id == id);
            if (Old== null)
            {
                throw new TypeLicNotExistsException();
            }

            var Existing_NameAr = await _Repository.FindAsync(x => x.Name == input.Name && x.Id != id);
            if (Existing_NameAr != null)
            {
                throw new AverageCalcNameAlreadyExistsException(input.Name);
            }



            Old.Name = input.Name;
            Old.Desc = input.Desc;
            Old.Ord = input.Ord;

            return Old;
        }
    }
}