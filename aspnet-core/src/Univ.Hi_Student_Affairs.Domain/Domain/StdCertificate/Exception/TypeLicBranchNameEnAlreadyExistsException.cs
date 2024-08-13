using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain
{
    internal class TypeLicBranchNameEnAlreadyExistsException : BusinessException
    {
        public TypeLicBranchNameEnAlreadyExistsException(string Name)
            : base(Hi_Student_AffairsDomainErrorCodes.TypeLicBranchNameEnAlreadyExists)
        {
            WithData("Name", Name);
        }
    }

}