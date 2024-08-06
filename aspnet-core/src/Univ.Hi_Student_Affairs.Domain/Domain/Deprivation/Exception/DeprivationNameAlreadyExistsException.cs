using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain
{
    public class DeprivationNameAlreadyExistsException : BusinessException
    {
        public DeprivationNameAlreadyExistsException(string Name)
            : base(Hi_Student_AffairsDomainErrorCodes.DeprivationNameAlreadyExists)
        {
            WithData("Name", Name);
        }
    }

}
