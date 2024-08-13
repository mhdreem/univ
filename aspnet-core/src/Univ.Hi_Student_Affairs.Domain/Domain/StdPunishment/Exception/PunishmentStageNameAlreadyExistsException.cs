using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain.StdPunishment.Exception
{
    public class PunishmentStageNameAlreadyExistsException : BusinessException
    {
        public PunishmentStageNameAlreadyExistsException(string Name)
            : base(Hi_Student_AffairsDomainErrorCodes.PunishmentStageNameAlreadyExists)
        {
            WithData("Name", Name);
        }
    }

}
