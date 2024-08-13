using Volo.Abp.Application.Services;

namespace Univ.Hi_Student_Affairs.Dtos.Univ
{
    public interface ICollageService : ICrudAppService<CollageDto, int, CollagePagedAndSortedResultRequestDto, CreateCollageDto, UpdateCollageDto>
    {

    }
}
