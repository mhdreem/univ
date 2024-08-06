using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain.CollType.Exception
{
    public class CollTypeNameAlreadyExistsException : BusinessException
    {
        public CollTypeNameAlreadyExistsException(string Name)
            : base(Hi_Student_AffairsDomainErrorCodes.CollTypeNameAlreadyExists)
        {
            WithData("Name", Name);
        }
    }

}