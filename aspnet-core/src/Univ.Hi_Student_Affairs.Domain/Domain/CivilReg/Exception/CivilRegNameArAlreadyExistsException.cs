using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain.CivilReg.Exception
{
    public class CivilRegNameArAlreadyExistsException : BusinessException
    {
        public CivilRegNameArAlreadyExistsException(string Name)
            : base(Hi_Student_AffairsDomainErrorCodes.CivilRegNameArAlreadyExists)
        {
            WithData("Name", Name);
        }
    }

}
