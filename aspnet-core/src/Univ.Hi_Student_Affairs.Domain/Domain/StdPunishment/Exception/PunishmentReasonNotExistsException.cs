using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain.StdPunishment.Exception
{
    public class PunishmentReasonNotExistsException : BusinessException
    {
        public PunishmentReasonNotExistsException()
            : base(Hi_Student_AffairsDomainErrorCodes.PunishmentReasonNotExists)
        {

        }
    }
}
