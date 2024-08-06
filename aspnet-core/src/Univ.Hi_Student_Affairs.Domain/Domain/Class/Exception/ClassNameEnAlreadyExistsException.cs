using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain.Class
{
    internal class ClassNameEnAlreadyExistsException: BusinessException
    {
        public ClassNameEnAlreadyExistsException(string NameEn)
            : base(Hi_Student_AffairsDomainErrorCodes.ClassNameEnAlreadyExists)
        {
            WithData("NameEn", NameEn);
        }
    }

}
