using System;
using System.Threading.Tasks;
using Univ.Hi_Student_Affairs.Domain.Country;
using Univ.Hi_Student_Affairs.Dtos.DomainCountry;
using Univ.Hi_Student_Affairs.Dtos.Respond;
using Univ.Hi_Student_Affairs.Service.BaseService;
using Volo.Abp;
using Volo.Abp.Domain.Repositories;

namespace Univ.Hi_Student_Affairs.Service.DomainCountry
{
    public class CountryAppService : CustomCrudAppService<Country, CountryDto, int, CreateCountryDto, UpdateCountryDto>, ICountryAppService
    {
        private readonly CountryManager _countryManager;

        public CountryAppService(
            IRepository<Country, int> countryRepository,
            CountryManager countryManager)
            : base(countryRepository)
        {
            _countryManager = countryManager;
        }



        public override async Task<RespondDto> CreateCustomAsync(CreateCountryDto input)
        {
            var country = await _countryManager.CreateAsync(
                input.Continent,
                input.NameAr,
                input.NameEn,
                input.Barcode,
                input.Ord
            );

            await Repository.InsertAsync(country);

            var result = ObjectMapper.Map<Country, CountryDto>(country);

            return new RespondDto
            {
                IsSuccess = true,
                Result = result
            };
        }



        public override async Task<RespondDto> UpdateCustomAsync(int id, UpdateCountryDto input)
        {
            var country = await _countryManager.UpdateAsync(
                id,
                input.Continent,
                input.NameAr,
                input.NameEn,
                input.Barcode,
                input.Ord
            );

            await Repository.UpdateAsync(country);

            var result = ObjectMapper.Map<Country, CountryDto>(country);

            return new RespondDto
            {
                IsSuccess = true,
                Result = result
            };
        }



        public async Task<RespondDto> AddCityAsync(CreateCityDto input)
        {
            try
            {
                var SelectedCountry = await Repository.FindAsync(input.CountryId);
                if (SelectedCountry == null)
                    throw new UserFriendlyException("Country is Not Exist");
                await _countryManager.AddCityAsync(SelectedCountry, input.NameAr, input.NameEn, input.Ord, input.Barcode, input.PhoneCode);

                await Repository.UpdateAsync(SelectedCountry);

                return new RespondDto
                {
                    IsSuccess = true
                };
            }
            catch (Exception ex)
            {
                return new RespondDto
                {
                    IsSuccess = false,
                    Error = ex.Message
                };
            }
        }

        public async Task<RespondDto> RemoveCityAsync(int countryId, int cityId)
        {
            try
            {
                var SelectedCountry = await Repository.FindAsync(countryId);
                if (SelectedCountry == null)
                    throw new UserFriendlyException("Country is Not Exist");

                _countryManager.RemoveCity(SelectedCountry, cityId);

                await Repository.UpdateAsync(SelectedCountry);

                return new RespondDto
                {
                    IsSuccess = true
                };
            }
            catch (Exception ex)
            {
                return new RespondDto
                {
                    IsSuccess = false,
                    Error = ex.Message
                };
            }


        }

        public async Task<RespondDto> UpdateCityAsync(UpdateCityDto input)
        {

            try
            {
                var SelectedCountry = await Repository.FindAsync(input.CountryId);
                if (SelectedCountry == null)
                    throw new UserFriendlyException("Country is Not Exist");

                await _countryManager.UpdateCityAsync(SelectedCountry, input.Id, input.NameAr, input.NameEn, input.Ord, input.Barcode, input.PhoneCode);

                await Repository.UpdateAsync(SelectedCountry);

                return new RespondDto
                {
                    IsSuccess = true
                };
            }
            catch (Exception ex)
            {
                return new RespondDto
                {
                    IsSuccess = false,
                    Error = ex.Message
                };
            }



        }




    }


}
