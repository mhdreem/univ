using Volo.Abp.Application.Services;
namespace Univ.Hi_Student_Affairs.Dtos.Military
{
    public interface IMilitaryService : ICrudAppService<MilitaryDto, int, MilitaryPagedAndSortedResultRequestDto, CreateMilitaryDto, UpdateMilitaryDto>
    {

    }
}
