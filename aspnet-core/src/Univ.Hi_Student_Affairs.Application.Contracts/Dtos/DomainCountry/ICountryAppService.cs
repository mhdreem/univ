using System.Threading.Tasks;
using Univ.Hi_Student_Affairs.Dtos.Respond;
using Volo.Abp.Application.Dtos;



namespace Univ.Hi_Student_Affairs.Dtos.DomainCountry
{
    public interface ICountryAppService
    {
        Task<RespondDto> CreateCustomAsync(CreateCountryDto input);
        Task<RespondDto> UpdateCustomAsync(int id, UpdateCountryDto input);
        Task<RespondDto> DeleteCustomAsync(int id);
        Task<RespondDto> GetCustomAsync(int id);
        Task<RespondDto> GetAllCustomAsync(PagedAndSortedResultRequestDto input);
        Task<RespondDto> AddCityAsync(CreateCityDto input);
        Task<RespondDto> RemoveCityAsync(int countryId, int cityId);
        Task<RespondDto> UpdateCityAsync(UpdateCityDto input);
    }

}
