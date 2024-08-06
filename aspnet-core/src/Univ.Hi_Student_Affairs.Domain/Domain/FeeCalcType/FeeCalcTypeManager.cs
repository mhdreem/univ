using JetBrains.Annotations;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using Volo.Abp;
using Univ.Hi_Student_Affairs.Domain.AverageCalc.Exception;

namespace Univ.Hi_Student_Affairs
{
    public class FeeCalcTypeManager : DomainService
    {

        private readonly IRepository<FeeCalcType, int> _Repository;


        public FeeCalcTypeManager(IRepository<FeeCalcType, int> Repository)
        {
            _Repository = Repository;

        }



        public async Task<FeeCalcType> CreateAsync(
            [NotNull] string name,           
            [CanBeNull] int? ord = null
            )
        {
            Check.NotNullOrWhiteSpace(name, nameof(name));
           

            var Existing_NameAr = await _Repository.FindAsync(x => x.Name == name);
            if (Existing_NameAr != null)
            {
                throw new FeeCalcTypeNameAlreadyExistsException(name);
            }


           


            return new FeeCalcType(
                0,
                name,
                ord

            );
        }

        public async Task<FeeCalcType> UpdateAsync(
            [NotNull] int id,
            [NotNull] FeeCalcType input
            )
        {
            Check.NotNullOrWhiteSpace(input.Name, nameof(input.Name));


            var Old = await _Repository.FindAsync(x => x.Id == id);
            if (Old == null)
            {
                throw new FeeCalcTypeNotExistsException();
            }

            var Existing_NameAr = await _Repository.FindAsync(x => x.Name == input.Name && x.Id != id);
            if (Existing_NameAr != null)
            {
                throw new FeeCalcTypeNameAlreadyExistsException(input.Name);
            }




            Old.Name = input.Name;
         
            Old.Ord = input.Ord;


            return Old;
        }
    }
}