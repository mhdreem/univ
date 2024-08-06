using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain.CollType.Exception
{
    public class CollTypeNotExistsException : BusinessException
    {
        public CollTypeNotExistsException()
            : base(Hi_Student_AffairsDomainErrorCodes.CollTypeNotExists)
        {

        }
    }

}