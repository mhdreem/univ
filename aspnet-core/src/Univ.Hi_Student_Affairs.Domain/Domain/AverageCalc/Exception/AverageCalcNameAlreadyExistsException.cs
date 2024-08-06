using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain.AverageCalc.Exception
{
    public class AverageCalcNameAlreadyExistsException : BusinessException
    {
        public AverageCalcNameAlreadyExistsException(string Name)
            : base(Hi_Student_AffairsDomainErrorCodes.AverageCalcNameAlreadyExists)
        {
            WithData("Name", Name);
        }
    }

}
