using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain.Grade.Exception
{
    internal class GradeNameEnAlreadyExistsException : BusinessException
    {
        public GradeNameEnAlreadyExistsException(string NameEn)
            : base(Hi_Student_AffairsDomainErrorCodes.GradeNameEnAlreadyExists)
        {
            WithData("NameEn", NameEn);
        }
    }

}
