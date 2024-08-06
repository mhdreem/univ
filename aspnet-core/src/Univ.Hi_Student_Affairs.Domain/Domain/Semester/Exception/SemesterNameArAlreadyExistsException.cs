using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain.Semester.Exception
{
    public class SemesterNameArAlreadyExistsException : BusinessException
    {
        public SemesterNameArAlreadyExistsException(string NameAr)
            : base(Hi_Student_AffairsDomainErrorCodes.SemesterNameArAlreadyExists)
        {
            WithData("NameAr", NameAr);
        }
    }

}
