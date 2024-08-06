using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain.IdentifierType.Exception
{
    public class IdentifierTypeNameArAlreadyExistsException : BusinessException
    {
        public IdentifierTypeNameArAlreadyExistsException(string NameAr)
            : base(Hi_Student_AffairsDomainErrorCodes.IdentifierTypeNameArAlreadyExists)
        {
            WithData("NameAr", NameAr);
        }
    }

}
