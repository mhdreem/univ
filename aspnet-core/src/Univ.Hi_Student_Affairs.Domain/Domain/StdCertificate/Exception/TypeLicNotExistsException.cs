using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain
{
    public class TypeLicNotExistsException : BusinessException
    {
        public TypeLicNotExistsException()
            : base(Hi_Student_AffairsDomainErrorCodes.TypeLicNotExists)
        {

        }
    }
}