using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain
{
    internal class TypeLicNameEnAlreadyExistsException : BusinessException
    {
        public TypeLicNameEnAlreadyExistsException(string NameEn)
            : base(Hi_Student_AffairsDomainErrorCodes.TypeLicNameEnAlreadyExists)
        {
            WithData("NameEn", NameEn);
        }
    }
}
