using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain
{
    public class StatusNameEnAlreadyExistsException : BusinessException
    {
        public StatusNameEnAlreadyExistsException(string NameEn)
            : base(Hi_Student_AffairsDomainErrorCodes.StatusNameEnAlreadyExists)
        {
            WithData("NameEn", NameEn);
        }
    }

}
