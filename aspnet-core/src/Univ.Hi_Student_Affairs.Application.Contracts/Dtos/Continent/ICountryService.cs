using System.Diagnostics.Metrics;
using Volo.Abp.Application.Services;



namespace Univ.Hi_Student_Affairs.Dtos.Continent
{
    public interface ICountryService : ICrudAppService<CountryDto, int, CountryPagedAndSortedResultRequestDto, CreateCountryDto, UpdateCountryDto>
    {
    }
}
