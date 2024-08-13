using Volo.Abp.Application.Services;

namespace Univ.Hi_Student_Affairs.Dtos.Status
{
    public interface IStatusService : ICrudAppService<StatusDto, int, StatusPagedAndSortedResultRequestDto, CreateStatusDto, UpdateStatusDto>
    {

    }
}
