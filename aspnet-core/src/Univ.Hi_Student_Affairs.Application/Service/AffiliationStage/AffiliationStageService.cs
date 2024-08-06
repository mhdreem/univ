using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univ.Hi_Student_Affairs.Base;
using Univ.Hi_Student_Affairs.Dtos;
using Univ.Hi_Student_Affairs.Dtos.AffiliationStage;
using Univ.Hi_Student_Affairs.Dtos.Respond;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Univ.Hi_Student_Affairs.Service
{
    public class AffiliationStageService :GenericAppService<AffiliationStage, AffiliationStageDto,int, AffiliationStagePagedAndSortedResultRequestDto, CreateAffiliationStageDto, UpdateAffiliationStageDto>, IAffiliationStageService
    {
        private readonly AffiliationStageManager _Manager;
        public AffiliationStageService(IRepository<AffiliationStage, int> repository,
            AffiliationStageManager Manager)
        : base(repository)
        { this._Manager = Manager; }



        
        [HttpPost("api/app/affiliation-stage/filterdata")]
        public async Task<RespondDto>
                FilterDataAsync(AffiliationStagePagedAndSortedResultRequestDto input)
        {
            //Set a default sorting, if not provided
            if (input.Sorting.IsNullOrWhiteSpace())
            {
                input.Sorting = nameof(input.Name);
            }
            //Get the IQueryable<Book> from the repository
            var queryable = await Repository.GetQueryableAsync();

            //Get the list
            var arr = await AsyncExecuter.ToListAsync(
                queryable
                    .WhereIf(input.Id != null, x => x.Id.ToString().Contains(input.Id.ToString()))
                    .WhereIf(input.Name != null && !input.Name.IsNullOrEmpty(), x => x.Name != null && x.Name.ToString().Contains(input.Name))

                    //.OrderBy(input.Sorting)
                    .Skip(input.SkipCount)
                    .Take(input.MaxResultCount)
            );

            //Convert to DTOs
            var arrDtos = ObjectMapper.Map<List<AffiliationStage>, List<AffiliationStageDto>>(arr);


            //Get the total count with another query (required for the paging)
            var totalCount = await Repository.GetCountAsync();

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = new PagedResultDto<AffiliationStageDto>(
                totalCount,
                arrDtos
            );
            return respond;

        }






        [HttpPost("api/app/affiliation-stage/check")]
        public async Task<RespondDto>
       CheckAsync(CheckAffiliationStageDto input)
        {
            RespondDto respond = new RespondDto();
            List<string> errors = new List<string>();
            var queryable = await Repository.GetQueryableAsync();


            //Get the arr
            var arr = await AsyncExecuter.ToListAsync(
                queryable
                    .WhereIf(input.Id != null && input.Id != 0, x => x.Id!=input.Id)
                    .WhereIf(input.Name != null && !input.Name.IsNullOrEmpty(), x => x.Name != null && x.Name.ToString().Contains(input.Name))
            );

            //Convert to DTOs
            var Dtos = ObjectMapper.Map<List<AffiliationStage>, List<AffiliationStageDto>>(arr);

            if (Dtos != null && Dtos.Count() > 0)
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





        [HttpPost("api/app/affiliation-stage/postdata")]
        public async Task<RespondDto> PostDataAsync(CreateAffiliationStageDto input)
        {

            var obj = await _Manager.CreateAsync(
                input.Name,
                input.StageState,
                input.Ord
            );

            var newObj = await Repository.InsertAsync(obj);

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<AffiliationStage, AffiliationStageDto>(newObj);

            return respond;
        }



        [HttpPut("api/app/affiliation-stage/modifydata/{id}")]
        public async Task<RespondDto> ModifyDataAsync(int id, UpdateAffiliationStageDto input)
        {
            var obj = ObjectMapper.Map<UpdateAffiliationStageDto, AffiliationStage>(input);


            obj = await _Manager.UpdateAsync(id, obj);

            await Repository.UpdateAsync(obj);

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<AffiliationStage, AffiliationStageDto>(obj);
            return respond;
        }




        [HttpDelete("api/app/affiliation-stage/removedata/{id}")]
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

