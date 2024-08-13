using Volo.Abp.Application.Services;

namespace Univ.Hi_Student_Affairs.Dtos.CollType
{
    public interface ICollTypeService : ICrudAppService<CollTypeDto, int, CollTypePagedAndSortedResultRequestDto, CreateCollTypeDto, UpdateCollTypeDto>
    {

    }
}