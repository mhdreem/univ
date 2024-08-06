using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain.Jender.Exception
{
    public class JenderNameEnAlreadyExistsException : BusinessException
    {
        public JenderNameEnAlreadyExistsException(string NameAr)
            : base(Hi_Student_AffairsDomainErrorCodes.JenderNameEnAlreadyExists)
        {
            WithData("NameAr", NameAr);
        }
    }

}
