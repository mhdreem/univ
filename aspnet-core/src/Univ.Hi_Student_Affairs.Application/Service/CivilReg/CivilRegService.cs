using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Univ.Hi_Student_Affairs.Base;
using Univ.Hi_Student_Affairs.Dtos.CivilReg;
using Univ.Hi_Student_Affairs.Dtos.Respond;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;


namespace Univ.Hi_Student_Affairs.Service
{
    public class  CivilRegService :GenericAppService<CivilReg, CivilRegDto, int, CivilRegPagedAndSortedResultRequestDto, CreateCivilRegDto,UpdateCivilRegDto>, ICivilRegService
    {
        private readonly CivilRegManager _Manager;
        public CivilRegService(IRepository<CivilReg, int> repository,
            CivilRegManager Manager)
        : base(repository)
        { this._Manager = Manager; }




        [HttpPost("api/app/civil-reg/filterdata")]
        public async Task<RespondDto>
                FilterDataAsync(CivilRegPagedAndSortedResultRequestDto input)
        {
            //Set a default sorting, if not provided
            if (input.Sorting.IsNullOrWhiteSpace())
            {
                input.Sorting = nameof(input.NameAr);
            }
            //Get the IQueryable<Book> from the repository
            var queryable = await Repository.GetQueryableAsync();

            //Get the list
            var arr = await AsyncExecuter.ToListAsync(
                queryable
                    .WhereIf(input.Id != null, x => x.Id.ToString().Contains(input.Id.ToString()))
                    .WhereIf(input.NameAr != null && !input.NameAr.IsNullOrEmpty(), x => x.NameAr != null && x.NameAr.ToString().Contains(input.NameAr))
                    .WhereIf(input.NameEn != null && !input.NameEn.IsNullOrEmpty(), x => x.NameEn != null && x.NameEn.ToString().Contains(input.NameEn))
                    //.OrderBy(input.Sorting)
                    .Skip(input.SkipCount)
                    .Take(input.MaxResultCount)
            );

            //Convert to DTOs
            var arrDtos = ObjectMapper.Map<List<CivilReg>, List<CivilRegDto>>(arr);


            //Get the total count with another query (required for the paging)
            var totalCount = await Repository.GetCountAsync();

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = new PagedResultDto<CivilRegDto>(
                totalCount,
                arrDtos
            );
            return respond;

        }






        [HttpPost("api/app/civil-reg/check")]
        public async Task<RespondDto>
       CheckAsync(CheckCivilRegDto input)
        {
            RespondDto respond = new RespondDto();
            List<string> errors = new List<string>();
            var queryable = await Repository.GetQueryableAsync();


            //Get the arr
            var arr = await AsyncExecuter.ToListAsync(
                queryable
                    .WhereIf(input.Id != null && input.Id != 0, x => x.Id.ToString().Contains(input.Id.ToString()))
                    .WhereIf(input.NameAr != null && !input.NameAr.IsNullOrEmpty(), x => x.NameAr != null && x.NameAr.ToString().Contains(input.NameAr))
            );


            if (arr != null && arr.Count() > 0)
            {
                respond.IsSuccess = false;
                respond.Error = "name_is_not_uniqe";
                errors.Add("name_is_not_uniqe");
                return respond;

            }


            //Get the arr
            arr = await AsyncExecuter.ToListAsync(
                queryable
                    .WhereIf(input.Id != null && input.Id != 0, x => x.Id.ToString().Contains(input.Id.ToString()))
                    .WhereIf(input.NameEn != null && !input.NameEn.IsNullOrEmpty(), x => x.NameEn != null && x.NameEn.ToString().Contains(input.NameEn))
            );


            if (arr != null && arr.Count() > 0)
            {
                respond.IsSuccess = false;
                respond.Error = "name_is_not_uniqe";
                errors.Add("name_is_not_uniqe");
                return respond;

            }

            respond.IsSuccess = true;
            respond.Result = true;
            return respond;
        }





        [HttpPost("api/app/civil-reg/postdata")]
        public async Task<RespondDto> PostDataAsync(CreateCivilRegDto input)
        {

            var obj = await _Manager.CreateAsync(
                input.NameAr,
                input.NameEn,
                input.CountryId,
                input.CityId
            );

            var newObj = await Repository.InsertAsync(obj);

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<CivilReg, CivilRegDto>(newObj);

            return respond;
        }



        [HttpPut("api/app/civil-reg/modifydata/{id}")]
        public async Task<RespondDto> ModifyDataAsync(int id, UpdateCivilRegDto input)
        {
            var obj = ObjectMapper.Map<UpdateCivilRegDto, CivilReg>(input);


            obj = await _Manager.UpdateAsync(id, obj);

            await Repository.UpdateAsync(obj);

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<CivilReg, CivilRegDto>(obj);
            return respond;
        }




        [HttpDelete("api/app/civil-reg/removedata/{id}")]
        public async Task<RespondDto> RemoveDataAsync(int id)
        {
            var obj = await Repository.FindAsync(id);
            if (obj != null)
            {
                await Repository.DeleteAsync(obj);
            }
            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = true;
            return respond;

        }



    }
}
