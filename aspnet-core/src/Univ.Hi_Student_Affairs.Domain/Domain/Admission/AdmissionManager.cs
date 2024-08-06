using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Services;
using Volo.Abp.Guids;
using Volo.Abp;
using Volo.Abp.Domain.Repositories;
using Microsoft.IdentityModel.Tokens;
using Univ.Hi_Student_Affairs.Domain.Admission;

namespace Univ.Hi_Student_Affairs
{
    public class AdmissionManager : DomainService
    {

        private readonly IRepository<Admission, int> _admissionRepository;


        public AdmissionManager(IRepository<Admission, int> admissionRepository)
        {
            _admissionRepository = admissionRepository;

        }



        public async Task<Admission> CreateAsync(
            [NotNull] string nameAr,
            [NotNull] string? nameEn = null,
            [CanBeNull] int? ministryEncode = null,
            [CanBeNull] string? barcode = null,
            [CanBeNull] int? ord = null
            )
        {
            Check.NotNullOrWhiteSpace(nameAr, nameof(nameAr));
            Check.NotNullOrWhiteSpace(nameEn, nameof(nameEn));

            var Existing_Admission_NameAr = await _admissionRepository.FindAsync(x => x.NameAr == nameAr);
            if (Existing_Admission_NameAr != null)
            {
                throw new AdmissionNameArAlreadyExistsException(nameAr);
            }
         
            var Existing_Admission_NameEn = await _admissionRepository.FindAsync(x => x.NameEn == nameEn );
            if (!string.IsNullOrEmpty(nameEn) &&
                Existing_Admission_NameEn != null)
            {
                throw new AdmissionNameEnAlreadyExistsException(nameEn);
            }


            var Existing_Admission_MinistryEncode = await _admissionRepository.FindAsync(x => x.MinistryEncode == ministryEncode );
            if (ministryEncode != null &&
                Existing_Admission_MinistryEncode != null)
            {
                throw new AdmissionMinistryEncodeAlreadyExistsException(ministryEncode);
            }

            var Existing_Admission_Barcode = await _admissionRepository.FindAsync(x => x.Barcode == barcode );
            if (!string.IsNullOrEmpty(barcode) &&
                  Existing_Admission_Barcode != null)
            {
                throw new AdmissionBarcodeAlreadyExistsException(barcode);
            }

            return new Admission(
                0
                ,
                nameAr,
                nameEn,
                ministryEncode,
                barcode,
                ord
            );
        }

        public async Task<Admission> UpdateAdmissionAsync(
            [NotNull] int id ,
            [NotNull] Admission updateAmission
            )
        {
            Check.NotNull(updateAmission, nameof(updateAmission));
            Check.NotNullOrWhiteSpace(updateAmission.NameAr, nameof(updateAmission.NameAr));
            Check.NotNullOrWhiteSpace(updateAmission.NameEn, nameof(updateAmission.NameEn));


            var Old_Admission = await _admissionRepository.FindAsync(x => x.Id==  id);
            if (Old_Admission== null )
            {
                throw new AdmissionNotExistsException(updateAmission.NameAr);
            }                

            var Existing_Admission_NameAr = await _admissionRepository.FindAsync(x => x.NameAr== updateAmission.NameAr && x.Id!= id);            
            if (Existing_Admission_NameAr != null )
            {
                throw new AdmissionNameArAlreadyExistsException(updateAmission.NameAr);
            }


            if (!string.IsNullOrEmpty(updateAmission.NameEn) )
            {

                var Existing_Admission_NameEn = await _admissionRepository.FindAsync(x => x.NameEn == updateAmission.NameEn && x.Id != id);
                if (Existing_Admission_NameEn != null)
                {
                    throw new AdmissionNameEnAlreadyExistsException(updateAmission.NameEn);
                }
            }


            if (updateAmission.MinistryEncode != null)
            {
                var Existing_Admission_MinistryEncode = await _admissionRepository.FindAsync(x => x.MinistryEncode == updateAmission.MinistryEncode && x.Id != id);
                if (Existing_Admission_MinistryEncode != null)
                {
                    throw new AdmissionMinistryEncodeAlreadyExistsException(updateAmission.MinistryEncode);
                }
            }


            if (!string.IsNullOrEmpty(updateAmission.Barcode))
            {

                var Existing_Admission_Barcode = await _admissionRepository.FindAsync(x => x.Barcode == updateAmission.Barcode && x.Id != id);
                if (Existing_Admission_Barcode != null)
                {
                    throw new AdmissionBarcodeAlreadyExistsException(updateAmission.Barcode);
                }
            }

            Old_Admission.ChangeNameAr(updateAmission.NameAr);

            Old_Admission.ChangeNameEn(updateAmission.NameEn);

            Old_Admission.Ord = updateAmission.Ord;
            Old_Admission.MinistryEncode= updateAmission.MinistryEncode;
            Old_Admission.Barcode = updateAmission.Barcode;

            return Old_Admission;
        }
    }
}
