using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain.UnivType.Exception
{
    public class UnivTypeNameEnAlreadyExistsException : BusinessException
    {
        public UnivTypeNameEnAlreadyExistsException(string NameEn)
            : base(Hi_Student_AffairsDomainErrorCodes.UnivTypeNameEnAlreadyExists)
        {
            WithData("NameEn", NameEn);
        }
    }

}