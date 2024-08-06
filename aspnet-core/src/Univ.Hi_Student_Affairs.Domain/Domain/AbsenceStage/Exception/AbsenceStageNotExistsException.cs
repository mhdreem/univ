using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain.Admission
{
    internal class AbsenceStageNotExistsException : BusinessException
    {
        public AbsenceStageNotExistsException()
            : base(Hi_Student_AffairsDomainErrorCodes.AbsenceStageNotExists)
        {
            
        }
    }

}