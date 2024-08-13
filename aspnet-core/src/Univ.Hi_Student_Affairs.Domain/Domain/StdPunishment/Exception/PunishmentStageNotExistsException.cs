using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain.StdPunishment.Exception
{
    public class PunishmentStageNotExistsException : BusinessException
    {
        public PunishmentStageNotExistsException()
            : base(Hi_Student_AffairsDomainErrorCodes.PunishmentStageNotExists)
        {

        }
    }
}
