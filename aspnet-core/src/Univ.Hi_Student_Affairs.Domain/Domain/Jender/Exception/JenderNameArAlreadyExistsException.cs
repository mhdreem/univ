using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain.Jender
{
    public class JenderNameArAlreadyExistsException : BusinessException
    {
        public JenderNameArAlreadyExistsException(string NameAr)
            : base(Hi_Student_AffairsDomainErrorCodes.JenderNameArAlreadyExists)
        {
            WithData("NameAr", NameAr);
        }
    }

}
