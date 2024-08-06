using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univ.Hi_Student_Affairs;
using Univ.Hi_Student_Affairs.Dtos;
using Univ.Hi_Student_Affairs.Dtos.PunishmentStage;
using Univ.Hi_Student_Affairs.Dtos.Respond;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Univ.Hi_Student_Affairs.Base;

namespace Univ.Hi_Student_Affairs
{
    public class PunishmentStageService :GenericAppService<PunishmentStage, PunishmentStageDto, int, PunishmentStagePagedAndSortedResultRequestDto, CreatePunishmentStageDto, UpdatePunishmentStageDto>, IPunishmentStageService
    {
        private readonly PunishmentStageManager _Manager;
        public PunishmentStageService(IRepository<PunishmentStage, int> repository,
            PunishmentStageManager Manager)
        : base(repository)
        { this._Manager = Manager; }




        [HttpPost("api/app/punishment-stage/filterdata")]
        public async Task<RespondDto>
                FilterDataAsync(PunishmentStagePagedAndSortedResultRequestDto input)
        {
            //Set a default sorting, if not provIded
            if (input.Sorting.IsNullOrWhiteSpace())
            {
                input.Sorting = nameof(input.Name );
            }
            //Get the IQueryable<Book> from the repository
            var queryable = await Repository.GetQueryableAsync();

            //Get the list
            var arr = await AsyncExecuter.ToListAsync(
                queryable
                    .WhereIf(input.Id != null, x => x.Id.ToString().Contains(input.Id.ToString()))
                    .WhereIf(input.Name  != null && !input.Name .IsNullOrEmpty(), x => x.Name  != null && x.Name .ToString().Contains(input.Name ))

                    //.OrderBy(input.Sorting)
                    .Skip(input.SkipCount)
                    .Take(input.MaxResultCount)
            );

            //Convert to DTOs
            var arrDtos = ObjectMapper.Map<List<PunishmentStage>, List<PunishmentStageDto>>(arr);


            //Get the total count with another query (required for the paging)
            var totalCount = await Repository.GetCountAsync();

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = new PagedResultDto<PunishmentStageDto>(
                totalCount,
                arrDtos
            );
            return respond;

        }






        [HttpPost("api/app/punishment-stage/check")]
        public async Task<RespondDto>
       CheckAsync(CheckPunishmentStageDto input)
        {
            RespondDto respond = new RespondDto();
            List<string> errors = new List<string>();
            var queryable = await Repository.GetQueryableAsync();


            //Get the arr
            var arr = await AsyncExecuter.ToListAsync(
                queryable
                    .WhereIf(input.Id != null && input.Id != 0, x => x.Id.ToString().Contains(input.Id.ToString()))
                    .WhereIf(input.Name  != null && !input.Name .IsNullOrEmpty(), x => x.Name  != null && x.Name .ToString().Contains(input.Name ))
            );

            //Convert to DTOs
            var Dtos = ObjectMapper.Map<List<PunishmentStage>, List<PunishmentStageDto>>(arr);

            if (Dtos != null && Dtos.Count() > 0)
            {
                respond.IsSuccess = false;
                respond.Error = "Name _is_not_uniqe";
                errors.Add("Name _is_not_uniqe");
                return respond;

            }


            respond.IsSuccess = true;
            respond.Result = true;
            return respond;
        }





        [HttpPost("api/app/punishment-stage/postdata")]
        public async Task<RespondDto> PostDataAsync(CreatePunishmentStageDto input)
        {

            var obj = await _Manager.CreateAsync(
                input.Name ,
                input.StageState,
                input.Ord
            );

            var newObj = await Repository.InsertAsync(obj);
            await CurrentUnitOfWork.SaveChangesAsync(); // Ensure saving changes
            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<PunishmentStage, PunishmentStageDto>(newObj);

            return respond;
        }



        [HttpPut("api/app/punishment-stage/modifydata/{Id}")]
        public async Task<RespondDto> ModifyDataAsync(int Id, UpdatePunishmentStageDto input)
        {
            var obj = ObjectMapper.Map<UpdatePunishmentStageDto, PunishmentStage>(input);


            obj = await _Manager.UpdateAsync(Id, obj);

            await Repository.UpdateAsync(obj);
            await CurrentUnitOfWork.SaveChangesAsync(); // Ensure saving changes
            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<PunishmentStage, PunishmentStageDto>(obj);
            return respond;
        }




        [HttpDelete("api/app/punishment-stage/removedata/{Id}")]
        public async Task<RespondDto> RemoveDataAsync(int Id)
        {
            var obj = await Repository.FindAsync(Id);
            if (obj != null)
            {
                await Repository.DeleteAsync(obj);
                await CurrentUnitOfWork.SaveChangesAsync(); // Ensure saving changes
            }
            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = true;
            return respond;

        }



    }
}
