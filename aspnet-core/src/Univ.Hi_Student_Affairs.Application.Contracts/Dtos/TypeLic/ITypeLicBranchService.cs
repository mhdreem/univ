using Volo.Abp.Application.Services;

namespace Univ.Hi_Student_Affairs.Dtos.TypeLic
{
    public interface ITypeLicBranchService : ICrudAppService<TypeLicBranchDto, int, TypeLicBranchPagedAndSortedResultRequestDto, CreateTypeLicBranchDto, UpdateTypeLicBranchDto>
    {

    }
}
