using Volo.Abp.Application.Services;

namespace Univ.Hi_Student_Affairs.Dtos.Univ
{
    public interface IBranchService : ICrudAppService<BranchDto, int, BranchPagedAndSortedResultRequestDto, BranchDto>
    {

    }
}

