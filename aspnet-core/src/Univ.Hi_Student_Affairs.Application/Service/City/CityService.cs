
using Univ.Hi_Student_Affairs.Base;
using Univ.Hi_Student_Affairs.Dtos.Continent;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;

namespace Univ.Hi_Student_Affairs.Service
{
    public class CityService :GenericAppService<City, CityDto, int, PagedAndSortedResultRequestDto, CreateCityDto, UpdateCityDto>, ICityService
    {

        public CityService(IRepository<City, int> repository
            )
        : base(repository)
        { }


    }

}
