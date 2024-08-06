
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Univ.Hi_Student_Affairs.IApplicationService;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using System.Linq;
using Univ.Hi_Student_Affairs.Dtos.Respond;
using Microsoft.AspNetCore.Mvc;
using Univ.Hi_Student_Affairs.Dtos;
using Volo.Abp;
using Univ.Hi_Student_Affairs.Dtos.AbsenceOrder;
using Univ.Hi_Student_Affairs.Base;


namespace Univ.Hi_Student_Affairs
{

    public class AbsenceOrderService :GenericAppService<AbsenceOrder, AbsenceOrderDto, int, AbsenceOrderPagedAndSortedResultRequestDto, CreateAbsenceOrderDto,UpdateAbsenceOrderDto>, IAbsenceOrderService
    {
        private readonly AbsenceOrderManager _Manager;

        public AbsenceOrderService(
            IRepository<AbsenceOrder, int> repository,
            AbsenceOrderManager Manager)
        : base(repository)
        { this._Manager = Manager; }

            
        

        [HttpPost("api/app/absence-order/FilterData")]
        public async  Task<RespondDto>
                FilterDataAsync(AbsenceOrderPagedAndSortedResultRequestDto input)
        {
            //Set a default sorting, if not provided
            if (input.Sorting.IsNullOrWhiteSpace())
            {
                input.Sorting = nameof(AbsenceOrder.Name);
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
            var bookDtos = ObjectMapper.Map<List<AbsenceOrder>, List<AbsenceOrderDto>>(books);


            //Get the total count with another query (required for the paging)
            var totalCount = await Repository.GetCountAsync();

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = new PagedResultDto<AbsenceOrderDto>(
                totalCount,
                bookDtos
            );
            return respond;

        }


        [HttpPost("api/app/absence-order/check")]
        public async Task<RespondDto>
                CheckAsync(CheckAbsenceOrderDto input)
        {
            RespondDto respond = new RespondDto();
            
            List<string> errors = new List<string>(); 


            var queryable = await Repository.GetQueryableAsync();


            //Get the books
            var books = await AsyncExecuter.ToListAsync(
                queryable
                    .WhereIf(input.Id != null && input.Id != 0, x => x.Id.ToString().Contains(input.Id.ToString()))
                    .WhereIf(input.Name != null && !input.Name.IsNullOrEmpty(), x => x.Name != null && x.Name.ToString().Contains(input.Name))                    
            );

            //Convert to DTOs
            var AbsenceOrderDtos = ObjectMapper.Map<List<AbsenceOrder>, List<AbsenceOrderDto>>(books);

            if (AbsenceOrderDtos!= null && AbsenceOrderDtos.Count()>0)
            {
                respond.IsSuccess = false;
                respond.Error = "name_is_not_uniqe";
                errors.Add("name_is_not_uniqe");
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



        [HttpPost("api/app/absence-order/PostData")]
        public  async Task<RespondDto> PostDataAsync(CreateAbsenceOrderDto input)
        {
            var absenceOrder = await _Manager.CreateAsync(
                input.Name,
                input.AbsenceType,
                input.Ord
            );

           var newabsenceOrder = await Repository.InsertAsync(absenceOrder);

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<AbsenceOrder, AbsenceOrderDto>(newabsenceOrder);

            return respond;
        }



        [HttpPut("api/app/absence-order/ModifyData/{id}")]
        public async Task<RespondDto> ModifyDataAsync(int id, UpdateAbsenceOrderDto input)
        {
            var absenceOrder = ObjectMapper.Map<UpdateAbsenceOrderDto, AbsenceOrder>(input);


            absenceOrder= await _Manager.UpdateAsync(id, absenceOrder);

            await Repository.UpdateAsync(absenceOrder);

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<AbsenceOrder, AbsenceOrderDto>(absenceOrder); 
            return respond;
        }



        [HttpDelete("api/app/absence-order/RemoveData/{id}")]
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



    }
}
