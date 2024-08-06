using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Univ.Hi_Student_Affairs;
using Univ.Hi_Student_Affairs.Dtos;
using Univ.Hi_Student_Affairs.Dtos.Respond;
using Univ.Hi_Student_Affairs.Dtos.TerminationStage;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Univ.Hi_Student_Affairs.Base;

namespace Univ.Hi_Student_Affairs.Service
{
    public class TerminationStageService :GenericAppService<TerminationStage, TerminationStageDto, int, TerminationStagePagedAndSortedResultRequestDto, CreateTerminationStageDto, UpdateTerminationStageDto>, ITerminationStageService
    {
        private readonly TerminationStageManager _Manager;
        public TerminationStageService(IRepository<TerminationStage, int> repository,
            TerminationStageManager Manager)
        : base(repository)
        { this._Manager = Manager; }


        

        [HttpPost("api/app/termination-stage/filterdata")]
        public async Task<RespondDto>
                FilterDataAsync(TerminationStagePagedAndSortedResultRequestDto input)
        {
            //Set a default sorting, if not provIded
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
                    .WhereIf(input.Name!= null && !input.Name.IsNullOrEmpty(), x => x.Name!= null && x.Name.ToString().Contains(input.Name))
                   
                    //.OrderBy(input.Sorting)
                    .Skip(input.SkipCount)
                    .Take(input.MaxResultCount)
            );

            //Convert to DTOs
            var arrDtos = ObjectMapper.Map<List<TerminationStage>, List<TerminationStageDto>>(arr);


            //Get the total count with another query (required for the paging)
            var totalCount = await Repository.GetCountAsync();

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = new PagedResultDto<TerminationStageDto>(
                totalCount,
                arrDtos
            );
            return respond;

        }






        [HttpPost("api/app/termination-stage/check")]
        public async Task<RespondDto>
       CheckAsync(CheckTerminationStageDto input)
        {
            RespondDto respond = new RespondDto();
            List<string> errors = new List<string>();
            var queryable = await Repository.GetQueryableAsync();


            //Get the arr
            var arr = await AsyncExecuter.ToListAsync(
                queryable
                    .WhereIf(input.Id != null && input.Id != 0, x => x.Id.ToString().Contains(input.Id.ToString()))
                    .WhereIf(input.Name != null && !input.Name.IsNullOrEmpty(), x => x.Name!= null && x.Name.ToString().Contains(input.Name))
            );

            //Convert to DTOs
            var Dtos = ObjectMapper.Map<List<TerminationStage>, List<TerminationStageDto>>(arr);

            if (Dtos != null && Dtos.Count() > 0)
            {
                respond.IsSuccess = false;
                respond.Error = "Name_is_not_uniqe";
                errors.Add("Name_is_not_uniqe");
                return respond;
               
            }


            respond.IsSuccess = true;
            respond.Result = true;
            return respond;
        }





        [HttpPost("api/app/termination-stage/postdata")]
        public async Task<RespondDto> PostDataAsync(CreateTerminationStageDto input)
        {

            var obj = await _Manager.CreateAsync(
                input.Name,
                input.StageState,
                input.Ord
            );

            var newObj = await Repository.InsertAsync(obj);

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<TerminationStage, TerminationStageDto>(newObj);

            return respond;
        }



        [HttpPut("api/app/termination-stage/modifydata/{Id}")]
        public async Task<RespondDto> ModifyDataAsync(int Id, UpdateTerminationStageDto input)
        {
            var obj = ObjectMapper.Map<UpdateTerminationStageDto, TerminationStage>(input);


            obj = await _Manager.UpdateAsync(Id, obj);

            await Repository.UpdateAsync(obj);

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<TerminationStage, TerminationStageDto>(obj);
            return respond;
        }




        [HttpDelete("api/app/termination-stage/removedata/{Id}")]
        public async Task<RespondDto> RemoveDataAsync(int Id)
        {
            var obj = await Repository.FindAsync(Id);
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
