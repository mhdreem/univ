using JetBrains.Annotations;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using Volo.Abp;
using Univ.Hi_Student_Affairs.Domain;

namespace Univ.Hi_Student_Affairs
{
    public class DegreeManager : DomainService
    {

        private readonly IRepository<Degree, int> _Repository;


        public DegreeManager(IRepository<Degree, int> Repository)
        {
            _Repository = Repository;

        }



        public async Task<Degree> CreateAsync(
               [NotNull] string? NameAr,
               [CanBeNull] string? NameEn,
               [CanBeNull] int? Ord
            )
        {
            Check.NotNullOrWhiteSpace(NameAr, nameof(NameAr));
            

            var Existing_Degree_NameAr = await _Repository.FindAsync(x => x.NameAr == NameAr);
            if (Existing_Degree_NameAr != null)
            {
                throw new DegreeNameArAlreadyExistsException(NameAr);
            }

            var Existing_Degree_NameEn = await _Repository.FindAsync(x => x.NameEn == NameEn);
            if (Existing_Degree_NameEn != null)
            {
                throw new DegreeNameEnAlreadyExistsException(NameEn);
            }
            var Degree  = new Degree();
            Degree.NameAr = NameAr;
            Degree.NameEn = NameEn;
            Degree.Ord = Ord;
            return Degree;
        }

        public async Task<Degree> UpdateAsync(
            [NotNull] int id,
            [NotNull] Degree input
            )
        {
            Check.NotNull(input, nameof(input));
            Check.NotNullOrWhiteSpace(input.NameAr, nameof(input.NameAr));



            var Old = await _Repository.FindAsync(x => x.Id == id);
            if (Old== null)
            {
                throw new DegreeNotExistsException();
            }

            var Existing_NameAr = await _Repository.FindAsync(x => x.NameAr == input.NameAr && x.Id != id);
            if (Existing_NameAr != null)
            {
                throw new DegreeNameArAlreadyExistsException(input.NameAr);
            }



            Old.NameAr = input.NameAr;
            Old.NameEn = input.NameEn;
            Old.Ord = input.Ord;



            return Old;
        }
    }
}