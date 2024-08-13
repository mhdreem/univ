using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain.StdPunishment.Exception
{
    public class PunishmentNotExistsException : BusinessException
    {
        public PunishmentNotExistsException()
            : base(Hi_Student_AffairsDomainErrorCodes.PunishmentNotExists)
        {

        }
    }
}
