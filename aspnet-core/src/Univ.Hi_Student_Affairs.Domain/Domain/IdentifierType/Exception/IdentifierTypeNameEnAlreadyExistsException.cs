using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain.IdentifierType.Exception
{
    internal class IdentifierTypeNameEnAlreadyExistsException : BusinessException
    {
        public IdentifierTypeNameEnAlreadyExistsException(string NameEn)
            : base(Hi_Student_AffairsDomainErrorCodes.IdentifierTypeNameEnAlreadyExists)
        {
            WithData("NameEn", NameEn);
        }
    }

}
