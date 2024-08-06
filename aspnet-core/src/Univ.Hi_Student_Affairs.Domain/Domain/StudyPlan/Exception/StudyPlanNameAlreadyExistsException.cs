using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain.StudyPlan.Exception
{
    public class StudyPlanNameAlreadyExistsException : BusinessException
    {
        public StudyPlanNameAlreadyExistsException(string Name)
            : base(Hi_Student_AffairsDomainErrorCodes.StudyPlanNameAlreadyExists)
        {
            WithData("Name", Name);
        }
    }

}
