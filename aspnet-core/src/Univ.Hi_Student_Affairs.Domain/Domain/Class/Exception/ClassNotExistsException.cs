using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain.Class
{
    public class ClassNotExistsException : BusinessException
    {
        public ClassNotExistsException()
            : base(Hi_Student_AffairsDomainErrorCodes.ClassNotExists)
        {

        }
    }

}