using JetBrains.Annotations;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using Volo.Abp;
using Univ.Hi_Student_Affairs.Domain.CollType.Exception;

namespace Univ.Hi_Student_Affairs
{
    public class CollTypeManager : DomainService
    {

        private readonly IRepository<CollType, int> _Repository;


        public CollTypeManager(IRepository<CollType, int> Repository)
        {
            _Repository = Repository;

        }



        public async Task<CollType> CreateAsync(
            [NotNull] string name,
            [CanBeNull] int? ministryEncode,
            [CanBeNull] string? barcode,

            [CanBeNull] int? ord = null
            )
        {
            Check.NotNullOrWhiteSpace(name, nameof(name));


            var Existing_Name = await _Repository.FindAsync(x => x.Name == name);
            if (Existing_Name != null)
            {
                throw new CollTypeNameAlreadyExistsException(name);
            }


            return new CollType(               
                name,
                ord,
                ministryEncode,
                barcode
 

            );
        }

        public async Task<CollType> UpdateAsync(
            [NotNull] int id,
            [NotNull] CollType input
            )
        {
            Check.NotNullOrWhiteSpace(input.Name, nameof(input.Name));



            var Old = await _Repository.FindAsync(x => x.Id == id);
            if (Old == null)
            {
                throw new CollTypeNotExistsException();
            }

            var Existing_Name = await _Repository.FindAsync(x => x.Name == input.Name && x.Id != id);
            if (Existing_Name != null)
            {
                throw new CollTypeNameAlreadyExistsException(input.Name);
            }


            Old.Name = input.Name;
            Old.Ord = input.Ord;
            Old.Barcode = input.Barcode;
            Old.MinistryEncode = input.MinistryEncode;


            return Old;
        }
    }
}