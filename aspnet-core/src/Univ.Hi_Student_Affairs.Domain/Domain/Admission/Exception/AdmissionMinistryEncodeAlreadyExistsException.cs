using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain.Admission
{
    internal class AdmissionMinistryEncodeAlreadyExistsException : BusinessException
    {
        public AdmissionMinistryEncodeAlreadyExistsException(int? MinistryEncode)
            : base(Hi_Student_AffairsDomainErrorCodes.AdmissionMinistryEncodeAlreadyExists)
        {
            WithData("MinistryEncode", MinistryEncode);
        }
    }

}
