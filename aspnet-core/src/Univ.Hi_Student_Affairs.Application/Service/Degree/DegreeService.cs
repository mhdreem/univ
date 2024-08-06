using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univ.Hi_Student_Affairs.Dtos;
using Univ.Hi_Student_Affairs.Dtos.Degree;
using Univ.Hi_Student_Affairs.Dtos.Respond;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Univ.Hi_Student_Affairs.Base;

namespace Univ.Hi_Student_Affairs.Service
{
    public class  DegreeService :GenericAppService<Degree, DegreeDto, int, DegreePagedAndSortedResultRequestDto, CreateDegreeDto, UpdateDegreeDto>, IDegreeService
    {
        private readonly DegreeManager _Manager;
        public DegreeService(IRepository<Degree, int> repository,
            DegreeManager Manager)
        : base(repository)
        { this._Manager = Manager; }




        [HttpPost("api/app/degree/filterdata")]
        public async Task<RespondDto>
                FilterDataAsync(DegreePagedAndSortedResultRequestDto input)
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
            var arrDtos = ObjectMapper.Map<List<Degree>, List<DegreeDto>>(arr);


            //Get the total count with another query (required for the paging)
            var totalCount = await Repository.GetCountAsync();

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = new PagedResultDto<DegreeDto>(
                totalCount,
                arrDtos
            );
            return respond;

        }






        [HttpPost("api/app/degree/check")]
        public async Task<RespondDto>
       CheckAsync(CheckDegreeDto input)
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





        [HttpPost("api/app/degree/postdata")]
        public async Task<RespondDto> PostDataAsync(CreateDegreeDto input)
        {

            var obj = await _Manager.CreateAsync(
                input.NameAr,
                input.NameEn,
                input.Ord
            );

            var newObj = await Repository.InsertAsync(obj);
            await CurrentUnitOfWork.SaveChangesAsync(); // Ensure saving changes

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;

            //ObjectMapper.Map<DegreeDto>(newObj);

            respond.Result = ObjectMapper.Map<Degree, DegreeDto>(newObj);

            return respond;
        }



        [HttpPut("api/app/degree/modifydata/{id}")]
        public async Task<RespondDto> ModifyDataAsync(int id, UpdateDegreeDto input)
        {
            var obj = ObjectMapper.Map<UpdateDegreeDto, Degree>(input);


            obj = await _Manager.UpdateAsync(id, obj);

            await Repository.UpdateAsync(obj);
            await CurrentUnitOfWork.SaveChangesAsync(); // Ensure saving changes

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<Degree, DegreeDto>(obj);
            return respond;
        }




        [HttpDelete("api/app/degree/removedata/{id}")]
        public async Task<RespondDto> RemoveDataAsync(int id)
        {
            var obj = await Repository.FindAsync(id);
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
