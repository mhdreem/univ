using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain.StdPunishment.Exception
{
    public class PunishmentNameAlreadyExistsException : BusinessException
    {
        public PunishmentNameAlreadyExistsException(string Name)
            : base(Hi_Student_AffairsDomainErrorCodes.PunishmentNameAlreadyExists)
        {
            WithData("Name", Name);
        }
    }

}
