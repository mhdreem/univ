using JetBrains.Annotations;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using Volo.Abp;
using Univ.Hi_Student_Affairs.Domain;


namespace Univ.Hi_Student_Affairs
{
    public class MinistryManager : DomainService
    {

        private readonly IRepository<Ministry, int> _Repository;


        public MinistryManager(IRepository<Ministry, int> Repository)
        {
            _Repository = Repository;

        }



        public async Task<Ministry> CreateAsync(
            [NotNull] string? NameAr,
            [CanBeNull] string? NameEn = null
            )
        {
            Check.NotNullOrWhiteSpace(NameAr, nameof(NameAr));
            

            var Existing_Admission_NameAr = await _Repository.FindAsync(x => x.NameAr == NameAr);
            if (Existing_Admission_NameAr != null)
            {
                throw new MinistryNameArAlreadyExistsException(NameAr);
            }





            var Ministry  = new Ministry();
            Ministry.NameAr = NameAr;
            Ministry.NameEn = NameEn;

            return Ministry;

        }

        public async Task<Ministry> UpdateAsync(
            [NotNull] int id,
            [NotNull] Ministry input
            )
        {
            Check.NotNull(input, nameof(input));
            Check.NotNullOrWhiteSpace(input.NameAr, nameof(input.NameAr));



            var Old = await _Repository.FindAsync(x => x.Id == id);
            if (Old== null)
            {
                throw new MinistryNotExistsException();
            }

            var Existing_NameAr = await _Repository.FindAsync(x => x.NameAr == input.NameAr && x.Id != id);
            if (Existing_NameAr != null)
            {
                throw new MinistryNameArAlreadyExistsException(input.NameAr);
            }



            Old.NameAr = input.NameAr;
            Old.NameEn = input.NameEn;


            return Old;
        }
    }
}