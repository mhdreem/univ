
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using System.Linq;
using Univ.Hi_Student_Affairs.Dtos.Respond;
using Microsoft.AspNetCore.Mvc;
using Univ.Hi_Student_Affairs.Dtos.StudyPlan;
using System.Security.Cryptography;
using System.Xml.Linq;
using Univ.Hi_Student_Affairs.Dtos.AdmissionKind;
using Univ.Hi_Student_Affairs.Dtos;
using Univ.Hi_Student_Affairs.Base;

namespace Univ.Hi_Student_Affairs
{
    
    public class StudyPlanService :GenericAppService<StudyPlan, StudyPlanDto, int, StudyPlanPagedAndSortedResultRequestDto, CreateStudyPlanDto,UpdateStudyPlanDto>, IStudyPlanService
    {
        private readonly StudyPlanManager _Manager;
        public StudyPlanService(IRepository<StudyPlan, int> repository,
            StudyPlanManager Manager)
        : base(repository)
        { this._Manager = Manager; }

            
        

        [HttpPost("api/app/StudyPlan/FilterData")]
        public async  Task<RespondDto>
                FilterDataAsync(StudyPlanPagedAndSortedResultRequestDto input)
        {
            //Set a default sorting, if not provided
            if (input.Sorting.IsNullOrWhiteSpace())
            {
                input.Sorting = nameof(StudyPlan.Name);
            }

            //Get the IQueryable<Book> from the repository


            var queryable = await Repository.GetQueryableAsync();

            //Get the books
            var books = await AsyncExecuter.ToListAsync(
                queryable
                    .WhereIf(input.Id != null, x => x.Id.ToString().Contains(input.Id.ToString()))
                    .WhereIf(input.Name != null && !input.Name.IsNullOrEmpty(), x => x.Name != null && x.Name.ToString().Contains(input.Name))
                    //.OrderBy(input.Sorting)
                    .Skip(input.SkipCount)
                    .Take(input.MaxResultCount)
            );

            //Convert to DTOs
            var bookDtos = ObjectMapper.Map<List<StudyPlan>, List<StudyPlanDto>>(books);


            //Get the total count with another query (required for the paging)
            var totalCount = await Repository.GetCountAsync();

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = new PagedResultDto<StudyPlanDto>(
                totalCount,
                bookDtos
            );
            return respond;

        }


        [HttpPost("api/app/StudyPlan/check")]
        public async Task<RespondDto>
    CheckAsync(CheckStudyPlanDto input)
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
            var StudyPlanDtos = ObjectMapper.Map<List<StudyPlan>, List<StudyPlanDto>>(books);

            if (StudyPlanDtos != null && StudyPlanDtos.Count() > 0)
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




            respond.IsSuccess = true;
            respond.Result = true;
            return respond;
        }

        [HttpPost("api/app/StudyPlan/PostData")]
        public  async Task<RespondDto> PostDataAsync(CreateStudyPlanDto input)
        {
            var admission = await _Manager.CreateAsync(

                input.Name,
            input.Description ,
            input.FireDate ,
            input.Ord 

            );

           var newAdmission = await Repository.InsertAsync(admission);

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<StudyPlan, StudyPlanDto>(newAdmission);

            return respond;
        }



        [HttpPut("api/app/StudyPlan/ModifyData/{Id}")]
        public async Task<RespondDto> ModifyDataAsync(int Id, UpdateStudyPlanDto input)
        {
            var admission = ObjectMapper.Map<UpdateStudyPlanDto, StudyPlan>(input);


            admission= await _Manager.UpdateAsync(Id, admission);

            await Repository.UpdateAsync(admission);

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<StudyPlan, StudyPlanDto>(admission); 
            return respond;
        }



      
        [HttpDelete("api/app/StudyPlan/RemoveData/{Id?}")]
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
