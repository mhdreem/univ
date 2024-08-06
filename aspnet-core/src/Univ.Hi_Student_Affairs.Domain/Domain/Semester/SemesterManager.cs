using JetBrains.Annotations;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using Volo.Abp;
using Univ.Hi_Student_Affairs.Domain.Semester.Exception;
using Univ.Hi_Student_Affairs.Domain.AverageCalc.Exception;

namespace Univ.Hi_Student_Affairs
{
    public class SemesterManager : DomainService
    {

        private readonly IRepository<Semester, int> _Repository;


        public SemesterManager(IRepository<Semester, int> Repository)
        {
            _Repository = Repository;

        }



        public async Task<Semester> CreateAsync(
            [NotNull] string nameAr,
            [NotNull] string nameEn,
            [CanBeNull] int? ord = null,
            [CanBeNull] string? grade_Name_Ar = null,
            [CanBeNull] string? grade_Name_En = null
            )
        {
            Check.NotNullOrWhiteSpace(nameAr, nameof(nameAr));
            Check.NotNullOrWhiteSpace(nameEn, nameof(nameEn));


            var Existing_NameAr = await _Repository.FindAsync(x => x.NameAr == nameAr);
            if (Existing_NameAr != null)
            {
                throw new SemesterNameArAlreadyExistsException(nameAr);
            }


            var Existing_NameEn = await _Repository.FindAsync(x => x.NameEn == nameEn);
            if (Existing_NameEn != null)
            {
                throw new SemesterNameEnAlreadyExistsException(nameEn);
            }


            return new Semester(
                0,
                nameAr,
                nameEn,
                grade_Name_Ar,
                grade_Name_En,
                ord

            );
        }

        public async Task<Semester> UpdateAsync(
            [NotNull] int id,
            [NotNull] Semester input
            )
        {
            Check.NotNullOrWhiteSpace(input.NameAr, nameof(input.NameAr));
            Check.NotNullOrWhiteSpace(input.NameEn, nameof(input.NameEn));


            var Old = await _Repository.FindAsync(x => x.Id == id);
            if (Old == null)
            {
                throw new SemesterNotExistsException();
            }

            var Existing_NameAr = await _Repository.FindAsync(x => x.NameAr == input.NameAr && x.Id != id);
            if (Existing_NameAr != null)
            {
                throw new SemesterNameArAlreadyExistsException(input.NameAr);
            }

            if (!string.IsNullOrEmpty(input.NameEn))
            {
                var Existing_NameEn = await _Repository.FindAsync(x => x.NameEn == input.NameEn && x.Id != id);
                if (Existing_NameEn != null)
                {
                    throw new SemesterNameEnAlreadyExistsException(input.NameEn);
                }

            }



            Old.NameAr = input.NameAr;
            Old.NameEn = input.NameEn;
            Old.Ord = input.Ord;


            return Old;
        }
    }
}