
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Volo.Abp.Application.Dtos;
using Univ.Hi_Student_Affairs.Base;
using Volo.Abp.Domain.Repositories;
using System.Linq;
using Univ.Hi_Student_Affairs.Dtos.Respond;
using Microsoft.AspNetCore.Mvc;
using Univ.Hi_Student_Affairs.Dtos.AverageCalc;

namespace Univ.Hi_Student_Affairs
{

    public class AverageCalcService :GenericAppService<AverageCalc, AverageCalcDto, int, AverageCalcPagedAndSortedResultRequestDto, CreateAverageCalcDto, UpdateAverageCalcDto>, IAverageCalcService
    {

        private readonly AverageCalcManager _Manager;

        public AverageCalcService(IRepository<AverageCalc, int> repository,
            AverageCalcManager Manager)
        : base(repository)
        { this._Manager = Manager; }

            
        

        [HttpPost("api/app/average-Calc/filterdata")]
        public async  Task<RespondDto>
                FilterDataAsync(AverageCalcPagedAndSortedResultRequestDto input)
        {
            //Set a default sorting, if not provided
            if (input.Sorting.IsNullOrWhiteSpace())
            {
                input.Sorting = nameof(AverageCalc.Name);
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
            var bookDtos = ObjectMapper.Map<List<AverageCalc>, List<AverageCalcDto>>(books);


            //Get the total count with another query (required for the paging)
            var totalCount = await Repository.GetCountAsync();

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = new PagedResultDto<AverageCalcDto>(
                totalCount,
                bookDtos
            );
            return respond;

        }

        [HttpPost("api/app/average-calc/check")]
        public async Task<RespondDto>
       CheckAsync(CheckAverageCalcDto input)
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
            var AdmissionKindDtos = ObjectMapper.Map<List<AverageCalc>, List<AverageCalcDto>>(books);

            if (AdmissionKindDtos != null && AdmissionKindDtos.Count() > 0)
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


        [HttpPost("api/app/average-calc/postdata")]
        public  async Task<RespondDto> PostDataAsync(CreateAverageCalcDto input)
        {
            var admission = await _Manager.CreateAsync(
                input.Name,
                input.Desc,
                input.Ord
            );

           var newAdmission = await Repository.InsertAsync(admission);

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<AverageCalc, AverageCalcDto>(newAdmission);

            return respond;
        }



        [HttpPut("api/app/average-calc/ModifyData/{id}")]
        public async Task<RespondDto> ModifyDataAsync(int id, UpdateAverageCalcDto input)
        {
            var admission = ObjectMapper.Map<UpdateAverageCalcDto, AverageCalc>(input);


            admission= await _Manager.UpdateAsync(id, admission);

            await Repository.UpdateAsync(admission);

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<AverageCalc, AverageCalcDto>(admission); 
            return respond;
        }




        [HttpDelete("api/app/average-calc/RemoveData/{id?}")]
        public async Task<RespondDto> RemoveDataAsync(int id)
        {
            var obj = await Repository.FindAsync(id);
            if (obj != null)
            {
                await Repository.DeleteAsync(obj);
            }
            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = true ;
            return respond;

        }


        /*
        public async Task<PagedResultDto<TGetAllOutputDto>> GetAllAsync(PagedAndSortedResultRequestDto input)
        {
            var query = await _repository.GetQueryableAsync();

            // Search functionality if SearchTerm is provided
            if (!string.IsNullOrWhiteSpace(input.SearchTerm))
            {
                query = query.Where(e => EF.Property<string>(e, "Name").Contains(input.SearchTerm)
                                      || EF.Property<string>(e, "Description").Contains(input.SearchTerm));
                // Add more properties using EF.Property based on the entity you have. 
            }

            // Sorting
            var totalCount = await query.CountAsync();
            var items = await query
                .OrderBy(input.Sorting)
                .PageBy(input)
                .ToListAsync();

            // Convert items to output DTO. You may need an IObjectMapper or similar here.
            var outputItems = ObjectMapper.Map<List<TEntity>, List<TGetAllOutputDto>>(items);

            return new PagedResultDto<TGetAllOutputDto>(totalCount, outputItems);
        }

        */
    }
}
