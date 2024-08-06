using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain
{
    public class MilitaryNotExistsException : BusinessException
    {
        public MilitaryNotExistsException()
            : base(Hi_Student_AffairsDomainErrorCodes.MilitaryNotExists)
        {

        }
    }
}
