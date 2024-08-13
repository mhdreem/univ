using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain
{
    public class TypeLicBranchNotExistsException : BusinessException
    {
        public TypeLicBranchNotExistsException()
            : base(Hi_Student_AffairsDomainErrorCodes.TypeLicBranchNotExists)
        {

        }
    }
}
