using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace Univ.Hi_Student_Affairs
{
    internal class AffiliationStageNameAlreadyExistsException : BusinessException
    {
        public AffiliationStageNameAlreadyExistsException(string Name)
            : base(Hi_Student_AffairsDomainErrorCodes.AffiliationStageNameAlreadyExists)
        {
            WithData("Name", Name);
        }
    }

}
