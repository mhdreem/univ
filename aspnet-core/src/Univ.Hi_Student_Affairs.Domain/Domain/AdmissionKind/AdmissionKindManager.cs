using JetBrains.Annotations;
using System.Threading.Tasks;
using Univ.Hi_Student_Affairs.Domain.Admission;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using Volo.Abp;

namespace Univ.Hi_Student_Affairs
{
    public class AdmissionKindManager : DomainService
    {
        private readonly IRepository<AdmissionKind, int> _Repository;


        public AdmissionKindManager(IRepository<AdmissionKind, int> Repository)
        {
            _Repository = Repository;

        }



        public async Task<AdmissionKind> CreateAsync(
            [NotNull] string nameAr,
            [NotNull] string? nameEn = null,
            [CanBeNull] int? ord = null
            )
        {
            Check.NotNullOrWhiteSpace(nameAr, nameof(nameAr));
            Check.NotNullOrWhiteSpace(nameEn, nameof(nameEn));

            var Existing_Admission_NameAr = await _Repository.FindAsync(x => x.NameAr == nameAr);
            if (Existing_Admission_NameAr != null)
            {
                throw new AdmissionKindNameArAlreadyExistsException(nameAr);
            }

            var Existing_Admission_NameEn = await _Repository.FindAsync(x => x.NameEn == nameEn);
            if (!string.IsNullOrEmpty(nameEn) &&
                Existing_Admission_NameEn != null)
            {
                throw new AdmissionKindNameEnAlreadyExistsException(nameEn);
            }




            return new AdmissionKind(
                0
                ,
                nameAr,
                nameEn,
                ord
            );
        }

        public async Task<AdmissionKind> UpdateAdmissionAsync(
            [NotNull] int id,
            [NotNull] AdmissionKind updateAmissionKind
            )
        {
            Check.NotNull(updateAmissionKind, nameof(updateAmissionKind));
            Check.NotNullOrWhiteSpace(updateAmissionKind.NameAr, nameof(updateAmissionKind.NameAr));
            Check.NotNullOrWhiteSpace(updateAmissionKind.NameEn, nameof(updateAmissionKind.NameEn));


            var Old_AdmissionKind = await _Repository.FindAsync(x => x.Id == id);
            if (Old_AdmissionKind == null)
            {
                throw new AdmissionNotExistsException(updateAmissionKind.NameAr);
            }

            var Existing_AdmissionKind_NameAr = await _Repository.FindAsync(x => x.NameAr == updateAmissionKind.NameAr && x.Id != id);
            if (Existing_AdmissionKind_NameAr != null)
            {
                throw new AdmissionNameArAlreadyExistsException(updateAmissionKind.NameAr);
            }


            if (!string.IsNullOrEmpty(updateAmissionKind.NameEn))
            {

                var Existing_AdmissionKind_NameEn = await _Repository.FindAsync(x => x.NameEn == updateAmissionKind.NameEn && x.Id != id);
                if (Existing_AdmissionKind_NameEn != null)
                {
                    throw new AdmissionKindNameEnAlreadyExistsException(updateAmissionKind.NameEn);
                }
            }




            Old_AdmissionKind.NameAr = updateAmissionKind.NameAr;
            Old_AdmissionKind.NameEn = updateAmissionKind.NameEn;
            Old_AdmissionKind.Ord = updateAmissionKind.Ord;


            return Old_AdmissionKind;
        }
    }
}
