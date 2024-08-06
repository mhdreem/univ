using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace Univ.Hi_Student_Affairs
{
    internal class AbsenceOrderNameAlreadyExistsException : BusinessException
    {
        public AbsenceOrderNameAlreadyExistsException(string NameAr)
            : base(Hi_Student_AffairsDomainErrorCodes.AbsenceOrderNameAlreadyExists)
        {
            WithData("NameAr", NameAr);
        }
    }

}
