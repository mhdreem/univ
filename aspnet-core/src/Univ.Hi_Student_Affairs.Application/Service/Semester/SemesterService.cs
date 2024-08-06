
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using System.Linq;
using Univ.Hi_Student_Affairs.Dtos.Respond;
using Microsoft.AspNetCore.Mvc;
using Univ.Hi_Student_Affairs.Dtos.Semester;
using Univ.Hi_Student_Affairs.Dtos.AdmissionKind;
using Univ.Hi_Student_Affairs.Dtos;
using Univ.Hi_Student_Affairs.Base;

namespace Univ.Hi_Student_Affairs
{
    //[Route("/api/services/app/baz/[controller]")]
    public class SemesterService :GenericAppService<Semester, SemesterDto, int, SemesterPagedAndSortedResultRequestDto, CreateSemesterDto, UpdateSemesterDto>, ISemesterService
    {
        private readonly SemesterManager _Manager;
        public SemesterService(IRepository<Semester, int> repository,
            SemesterManager Manager)
        : base(repository)
        { this._Manager = Manager; }

            
        

        [HttpPost("api/app/Semester/FilterData")]
        public async  Task<RespondDto>
                FilterDataAsync(SemesterPagedAndSortedResultRequestDto input)
        {
            //Set a default sorting, if not provided
            if (input.Sorting.IsNullOrWhiteSpace())
            {
                input.Sorting = nameof(Semester.NameAr);
            }

            //Get the IQueryable<Book> from the repository


            var queryable = await Repository.GetQueryableAsync();

            //Get the books
            var books = await AsyncExecuter.ToListAsync(
                queryable
                    .WhereIf(input.Id != null, x => x.Id.ToString().Contains(input.Id.ToString()))
                    .WhereIf(input.NameAr != null && !input.NameAr.IsNullOrEmpty(), x => x.NameAr != null && x.NameAr.ToString().Contains(input.NameAr))
                    .WhereIf(input.NameEn != null && !input.NameEn.IsNullOrEmpty(), x => x.NameEn != null && x.NameEn.ToString().Contains(input.NameEn))
                    //.OrderBy(input.Sorting)
                    .Skip(input.SkipCount)
                    .Take(input.MaxResultCount)
            );

            //Convert to DTOs
            var bookDtos = ObjectMapper.Map<List<Semester>, List<SemesterDto>>(books);


            //Get the total count with another query (required for the paging)
            var totalCount = await Repository.GetCountAsync();

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = new PagedResultDto<SemesterDto>(
                totalCount,
                bookDtos
            );
            return respond;

        }

        [HttpPost("api/app/Semester/check")]
        public async Task<RespondDto>
       CheckAsync(CheckSemesterDto input)
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
            var SemesterDtos = ObjectMapper.Map<List<Semester>, List<SemesterDto>>(books);

            if (SemesterDtos != null && SemesterDtos.Count() > 0)
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
            SemesterDtos = ObjectMapper.Map<List<Semester>, List<SemesterDto>>(books);

            if (SemesterDtos != null && SemesterDtos.Count() > 0)
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


        [HttpPost("api/app/Semester/PostData")]
        public  async Task<RespondDto> PostDataAsync(CreateSemesterDto input)
        {
            var admission = await _Manager.CreateAsync(

                input.NameAr,
                input.NameEn,
                input.Ord
            );

           var newAdmission = await Repository.InsertAsync(admission);

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<Semester, SemesterDto>(newAdmission);

            return respond;
        }



        [HttpPut("api/app/Semester/ModifyData/{Id}")]
        public async Task<RespondDto> ModifyDataAsync(int Id, UpdateSemesterDto input)
        {
            var admission = ObjectMapper.Map<UpdateSemesterDto, Semester>(input);


            admission= await _Manager.UpdateAsync(Id, admission);

            await Repository.UpdateAsync(admission);

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<Semester, SemesterDto>(admission); 
            return respond;
        }



       
        [HttpDelete("api/app/Semester/RemoveData/{Id?}")]
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
