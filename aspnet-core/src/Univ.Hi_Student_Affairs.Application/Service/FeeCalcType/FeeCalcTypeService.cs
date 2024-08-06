
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using System.Linq;
using Univ.Hi_Student_Affairs.Dtos.Respond;
using Microsoft.AspNetCore.Mvc;
using Univ.Hi_Student_Affairs.Dtos.FeeCalcType;
using Univ.Hi_Student_Affairs.Dtos;
using Univ.Hi_Student_Affairs;
using Univ.Hi_Student_Affairs.Base;

namespace Univ.Hi_Student_Affairs
{
   
    public class FeeCalcTypeService :GenericAppService<FeeCalcType, FeeCalcTypeDto, int, FeeCalcTypePagedAndSortedResultRequestDto, CreateFeeCalcTypeDto, UpdateFeeCalcTypeDto>, IFeeCalcTypeService
    {
        private readonly FeeCalcTypeManager _Manager;
        public FeeCalcTypeService(IRepository<FeeCalcType, int> repository,
            FeeCalcTypeManager Manager)
        : base(repository)
        { this._Manager = Manager; }

            
        

        [HttpPost("api/app/FeeCalcType/FilterData")]
        public async  Task<RespondDto>
                FilterDataAsync(FeeCalcTypePagedAndSortedResultRequestDto input)
        {
            //Set a default sorting, if not provIded
            if (input.Sorting.IsNullOrWhiteSpace())
            {
                input.Sorting = nameof(FeeCalcType.Name);
            }

            //Get the IQueryable<Book> from the repository


            var queryable = await Repository.GetQueryableAsync();

            //Get the books
            var books = await AsyncExecuter.ToListAsync(
                queryable
                    .WhereIf(input.Id != null, x => x.Id.ToString().Contains(input.Id.ToString()))
                    .WhereIf(input.Name!= null && !input.Name.IsNullOrEmpty(), x => x.Name != null && x.Name.ToString().Contains(input.Name))
                    
                    //.OrderBy(input.Sorting)
                    .Skip(input.SkipCount)
                    .Take(input.MaxResultCount)
            );

            //Convert to DTOs
            var bookDtos = ObjectMapper.Map<List<FeeCalcType>, List<FeeCalcTypeDto>>(books);


            //Get the total count with another query (required for the paging)
            var totalCount = await Repository.GetCountAsync();

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = new PagedResultDto<FeeCalcTypeDto>(
                totalCount,
                bookDtos
            );
            return respond;

        }

        [HttpPost("api/app/FeeCalcType/check")]
        public async Task<RespondDto>
     CheckAsync(CheckFeeCalcTypeDto input)
        {
            RespondDto respond = new RespondDto();
            //Get the IQueryable<Book> from the repository
            List<string> errors = new List<string>();


            var queryable = await Repository.GetQueryableAsync();


            //Get the books
            var books = await AsyncExecuter.ToListAsync(
                queryable
                    .WhereIf(input.Id != null && input.Id != 0, x => x.Id.ToString().Contains(input.Id.ToString()))
                    .WhereIf(input.Name != null && !input.Name.IsNullOrEmpty(), x => x.Name != null && x.Name.ToString().Contains(input.Name))
            );

            //Convert to DTOs
            var AdmissionKindDtos = ObjectMapper.Map<List<FeeCalcType>, List<FeeCalcTypeDto>>(books);

            if (AdmissionKindDtos != null && AdmissionKindDtos.Count() > 0)
            {
                respond.IsSuccess = false;
                respond.Error = "Name_is_not_uniqe";
                errors.Add("Name_is_not_uniqe");
                return respond;
                /*
                throw new UserFriendlyException(
                        "Arabic Name is Not unique!",""
                    );
                */
            }



            respond.IsSuccess = true;
            respond.Result = true;
            return respond;
        }



        [HttpPost("api/app/FeeCalcType/PostData")]
        public  async Task<RespondDto> PostDataAsync(FeeCalcTypeDto input)
        {
            var admission = await _Manager.CreateAsync(
                input.Name,
                input.Ord
            );

           var newAdmission = await Repository.InsertAsync(admission);

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<FeeCalcType, FeeCalcTypeDto>(newAdmission);

            return respond;
        }



        [HttpPut("api/app/FeeCalcType/ModifyData/{Id}")]
        public async Task<RespondDto> ModifyDataAsync(int Id, FeeCalcTypeDto input)
        {
            var admission = ObjectMapper.Map<FeeCalcTypeDto , FeeCalcType>(input);


            admission= await _Manager.UpdateAsync(Id, admission);

            await Repository.UpdateAsync(admission);

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<FeeCalcType, FeeCalcTypeDto>(admission); 
            return respond;
        }



        [HttpDelete("api/app/FeeCalcType/RemoveData/{Id?}")]
        public async Task<RespondDto> RemoveDataAsync(int Id)
        {
            var obj = await Repository.FindAsync(Id);
            if (obj != null)
            {
                await Repository.DeleteAsync(obj);
            }
            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = true ;
            return respond;

        }

    }
}
