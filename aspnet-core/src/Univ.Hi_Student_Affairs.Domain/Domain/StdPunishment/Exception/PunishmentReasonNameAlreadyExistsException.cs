using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain.StdPunishment.Exception
{
    public class PunishmentReasonNameAlreadyExistsException : BusinessException
    {
        public PunishmentReasonNameAlreadyExistsException(string Name)
            : base(Hi_Student_AffairsDomainErrorCodes.PunishmentReasonNameAlreadyExists)
        {
            WithData("Name", Name);
        }
    }

}
