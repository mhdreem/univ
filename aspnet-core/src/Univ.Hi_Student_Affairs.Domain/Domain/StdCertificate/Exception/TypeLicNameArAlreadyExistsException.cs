using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain
{
    public class TypeLicNameArAlreadyExistsException : BusinessException
    {
        public TypeLicNameArAlreadyExistsException(string NameAr)
            : base(Hi_Student_AffairsDomainErrorCodes.TypeLicNameArAlreadyExists)
        {
            WithData("NameAr", NameAr);
        }
    }

}
