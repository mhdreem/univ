
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using System.Linq;
using Univ.Hi_Student_Affairs.Dtos.Respond;
using Microsoft.AspNetCore.Mvc;
using Univ.Hi_Student_Affairs.Base;
using Univ.Hi_Student_Affairs.Dtos.Continent;

namespace Univ.Hi_Student_Affairs
{

    public class ContinentService :GenericAppService<Continent, ContinentDto, int, ContinentPagedAndSortedResultRequestDto, CreateContinentDto,UpdateContinentDto>, IContinentService
    {
        private readonly ContinentManager _Manager;
       

        public ContinentService(IContinentRepository repository,
            ContinentManager Manager)
        : base(repository)
        { this._Manager = Manager;
           
        }

        


        [HttpPost("api/app/continent/filterdata")]
        public async  Task<RespondDto>
                FilterDataAsync(ContinentPagedAndSortedResultRequestDto input)
        {
            //Set a default sorting, if not provided
            if (input.Sorting.IsNullOrWhiteSpace())
            {
                input.Sorting = nameof(Continent.NameAr);
            }

           


            //Get a IQueryable<T> by including sub collections
            var queryable = await Repository.WithDetailsAsync();




           // var queryable = await Repository.GetQueryableAsync();

            
            //Get the books
            var books = await AsyncExecuter                
                .ToListAsync(
                queryable   
                
                    .WhereIf(input.Id != null, x => x.Id.ToString().Contains(input.Id.ToString()))
                    .WhereIf(input.NameAr != null && !input.NameAr.IsNullOrEmpty(), x => x.NameAr != null && x.NameAr.ToString().Contains(input.NameAr))
                    .WhereIf(input.NameEn != null && !input.NameEn.IsNullOrEmpty(), x => x.NameEn != null && x.NameEn.ToString().Contains(input.NameEn))
                    //.OrderBy(input.Sorting)
                    .Skip(input.SkipCount)
                    .Take(input.MaxResultCount)
            );

            //Convert to DTOs
            var bookDtos = ObjectMapper.Map<List<Continent>, List<ContinentDto>>(books);


            //Get the total count with another query (required for the paging)
            var totalCount = await Repository.GetCountAsync();

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = new PagedResultDto<ContinentDto>(
                totalCount,
                bookDtos
            );
            return respond;

        }



        [HttpPost("api/app/continent/check-continent")]
        public async Task<RespondDto>
         CheckContinentAsync(CheckContinentDto input)
        {
            RespondDto respond = new RespondDto();
            //Get the IQueryable<Book> from the repository
            List<string> errors = new List<string>();


            var queryable = await Repository.GetQueryableAsync();


            //Get the books
            var books = await AsyncExecuter.ToListAsync(
                queryable
                    .WhereIf(input.Id != null && input.Id != 0, x => x.Id.ToString().Contains(input.Id.ToString()))
                    .WhereIf(input.NameAr != null && !input.NameAr.IsNullOrEmpty(), x => x.NameAr != null && x.NameAr.ToString().Contains(input.NameAr))
            );

            //Convert to DTOs
            var AdmissionKindDtos = ObjectMapper.Map<List<Continent>, List<ContinentDto>>(books);

            if (AdmissionKindDtos != null && AdmissionKindDtos.Count() > 0)
            {
                respond.IsSuccess = false;
                respond.Error = "ar_name_is_not_uniqe";
                errors.Add("ar_name_is_not_uniqe");
                return respond;
                /*
                throw new UserFriendlyException(
                        "Arabic Name is Not unique!",""
                    );
                */
            }

            //Get the books
            books = await AsyncExecuter.ToListAsync(
                queryable
                    .WhereIf(input.Id != null && input.Id != 0, x => x.Id.ToString().Contains(input.Id.ToString()))
                    .WhereIf(input.NameEn != null && !input.NameEn.IsNullOrEmpty(), x => x.NameEn != null && x.NameEn.ToString().Contains(input.NameEn))
            );

            //Convert to DTOs
            AdmissionKindDtos = ObjectMapper.Map<List<Continent>, List<ContinentDto>>(books);

            if (AdmissionKindDtos != null && AdmissionKindDtos.Count() > 0)
            {
                respond.IsSuccess = false;
                respond.Error = "en_name_is_not_uniqe";
                errors.Add("en_name_is_not_uniqe");
                return respond;
                /*
                throw new UserFriendlyException(
                        "English Name is Not unique!"
                    );
                */
            }



            respond.IsSuccess = true;
            respond.Result = true;
            return respond;
        }

        [HttpPost("api/app/continent/check-country")]
        public async Task<RespondDto>
        CheckCountryAsync(CheckCountryDto  input)
        {
            RespondDto respond = new RespondDto();
            //Get the IQueryable<Book> from the repository
            List<string> errors = new List<string>();


            var queryable = await Repository.GetQueryableAsync();

            respond.IsSuccess = true;
            respond.Result = true;
            return respond;
        }

        [HttpPost("api/app/continent/check-city")]
        public async Task<RespondDto>
        CheckCityAsync(CheckCityDto input)
        {
            RespondDto respond = new RespondDto();
            //Get the IQueryable<Book> from the repository
            List<string> errors = new List<string>();


            var queryable = await Repository.GetQueryableAsync();

            respond.IsSuccess = true;
            respond.Result = true;
            return respond;
        }



        [HttpPost("api/app/continent/addcontinent")]
        public async Task<RespondDto> AddContinentAsync(CreateContinentDto input)
        {

             //Map entities to DTOs

            var @continent = await _Manager.CreateAsync(
                input.NameAr,
                input.NameEn,
                input.MinistryEncode,
                input.Barcode,
                input.Ord, null 
            );

            await Repository.InsertAsync(@continent);

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<Continent, ContinentDto>(@continent);

            return respond;
        }




        [HttpPut("api/app/continent/modifycontinent/{Id}")]
        public async Task<RespondDto> ModifyContinentAsync(int Id, UpdateContinentDto input)
        {
            var @continent = ObjectMapper.Map<UpdateContinentDto, Continent>(input);


            await _Manager.UpdateAsync(Id, @continent);

            await Repository.UpdateAsync(@continent);

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<Continent, ContinentDto>(@continent); 
            return respond;
        }



        [HttpDelete("api/app/continent/removecontinent/{Id}")]
        public async Task<RespondDto> RemoveContinentAsync(int Id)
        {
            var obj = await Repository.GetAsync(Id,true);
            await Repository.DeleteAsync(obj);
            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = true ;
            respond.Total_Result_Count = 1;
            return respond;
        }




        [HttpPost("api/app/continent/addcountry/{Id}")]
        public async Task<RespondDto> AddCountryAsync(int Id,CreateCountryDto countryDto)
        {
            var @continent = await Repository.GetAsync(Id, true);

            
             _Manager.AddCountry(@continent, countryDto.NameAr, countryDto.NameEn, countryDto.MinistryEncode, countryDto.Barcode, countryDto.Ord, null);

            await Repository.UpdateAsync(@continent);

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<Continent, ContinentDto>(@continent);

            return respond;

        }




        [HttpPost("api/app/continent/removecountry/{Id}/{countryid}")]
        public async Task<RespondDto> RemoveCountryAsync(int Id, int countryid)
        {
            var @continent = await Repository.GetAsync(Id, true);


            _Manager.RemoveCountry( @continent, countryid);

            await Repository.UpdateAsync(@continent);

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<Continent, ContinentDto>(@continent);

            return respond;
        }



        [HttpPost("api/app/continent/updatecountry/{Id}/{countryId}")]
        public async Task<RespondDto> UpdateCountryAsync(int Id,int countryId, UpdateCountryDto dto )
        {
            var @Country = ObjectMapper.Map<UpdateCountryDto, Country>(dto);


            var @continent = await Repository.GetAsync(Id, true);


            _Manager.UpdateCountry(@continent,  countryId, dto.NameAr, dto.NameEn,   dto.MinistryEncode, dto.Barcode,dto.Ord , @Country.Cities);

            //_Manager.UpdateCountry(@continent, Id, countryId , dto.NameAr, dto.NameEn,dto.Ord,dto.PhoneCode,dto.Barcode,dto.MinistryEncode);

            await Repository.UpdateAsync(@continent);

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<Continent, ContinentDto>(@continent);

            return respond;
        }



        [HttpPost("api/app/continent/addcity/{Id}")]
        public async Task<RespondDto> AddCityAsync(int Id, CreateCityDto dto)
        {
            var @continent = await Repository.GetAsync(Id,true);

         

            _Manager.AddCity(@continent,  dto.CountryId, dto.NameAr, dto.NameEn, dto.Ord, dto.PhoneCode, dto.Barcode, dto.MinistryEncode);

            await Repository.UpdateAsync(@continent);

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<Continent, ContinentDto>(@continent);

            return respond;
        }







        [HttpDelete("api/app/continent/removecity/{Id}/{countryid}/{cityId}")]
        public async Task<RespondDto> RemoveCityAsync(int Id, int countryid, int cityId)
        {
            var @continent = await Repository.FindAsync(Id,true);
            @continent.RemoveCity(countryid, cityId);

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = true;
            return respond;

        }





        [HttpPut("api/app/continent/updatecity/{Id}")]
        public async Task<RespondDto> UpdateCityAsync(int Id, UpdateCityDto dto)
        {
            RespondDto respond = new RespondDto();
            var @continent = await Repository.GetAsync(Id, true);
            if (@continent == null)
            {
                
                respond.IsSuccess = false;
                respond.Result = false ;
                return respond;
            }
            @continent.UpdateCity(dto.Id, dto.CountryId, dto.NameAr, dto.NameEn, dto.Ord, dto.PhoneCode, dto.Barcode, dto.MinistryEncode);

            await Repository.UpdateAsync(@continent);

            
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<Continent, ContinentDto>(@continent);

            return respond;

            

        }




    }
}
