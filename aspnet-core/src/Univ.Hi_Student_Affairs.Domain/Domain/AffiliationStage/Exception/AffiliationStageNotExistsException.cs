using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain.Admission
{
    internal class AffiliationStageNotExistsException : BusinessException
    {
        public AffiliationStageNotExistsException()
            : base(Hi_Student_AffairsDomainErrorCodes.AbsenceStageNotExists)
        {
            
        }
    }

}