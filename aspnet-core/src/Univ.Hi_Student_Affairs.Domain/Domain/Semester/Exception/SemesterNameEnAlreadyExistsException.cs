using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain.Semester.Exception
{
    internal class SemesterNameEnAlreadyExistsException : BusinessException
    {
        public SemesterNameEnAlreadyExistsException(string NameAr)
            : base(Hi_Student_AffairsDomainErrorCodes.SemesterNameEnAlreadyExists)
        {
            WithData("NameAr", NameAr);
        }
    }

}
