using Univ.Hi_Student_Affairs.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Univ.Hi_Student_Affairs.Dtos.Continent
{
    public interface ICityService : ICrudAppService<CityDto, int, PagedAndSortedResultRequestDto, CreateCityDto, UpdateCityDto>
    {
    }
}


