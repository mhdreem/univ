using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace Univ.Hi_Student_Affairs
{
    internal class AbsenceStageNameAlreadyExistsException : BusinessException
    {
        public AbsenceStageNameAlreadyExistsException(string Name)
            : base(Hi_Student_AffairsDomainErrorCodes.AbsenceStageNameAlreadyExists)
        {
            WithData("Name", Name);
        }
    }

}
