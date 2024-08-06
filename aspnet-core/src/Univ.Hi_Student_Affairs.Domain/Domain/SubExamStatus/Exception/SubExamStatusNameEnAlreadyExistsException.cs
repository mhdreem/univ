using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain
{
    public class SubExamStatusNameEnAlreadyExistsException : BusinessException
    {
        public SubExamStatusNameEnAlreadyExistsException(string Name)
            : base(Hi_Student_AffairsDomainErrorCodes.SubExamStatusNameEnAlreadyExists)
        {
            WithData("Name", Name);
        }
    }

}
