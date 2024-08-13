using Volo.Abp.Application.Services;

namespace Univ.Hi_Student_Affairs.Dtos.Nationality
{
    public interface INationalityService : ICrudAppService<NationalityDto, int, NationalityPagedAndSortedResultRequestDto, CreateNationalityDto, UpdateNationalityDto>
    {
    }
}

