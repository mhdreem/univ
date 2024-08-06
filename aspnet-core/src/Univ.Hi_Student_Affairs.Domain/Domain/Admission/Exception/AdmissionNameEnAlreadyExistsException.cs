using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain.Admission
{
    internal class AdmissionNameEnAlreadyExistsException : BusinessException
    {
        public AdmissionNameEnAlreadyExistsException(string NameEn)
            : base(Hi_Student_AffairsDomainErrorCodes.AdmissionNameEnAlreadyExists)
        {
            WithData("NameEn", NameEn);
        }
    }

}
