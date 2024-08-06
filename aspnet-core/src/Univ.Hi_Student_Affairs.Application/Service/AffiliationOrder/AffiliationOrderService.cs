﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univ.Hi_Student_Affairs.Base;
using Univ.Hi_Student_Affairs.Dtos;
using Univ.Hi_Student_Affairs.Dtos.AffiliationOrder;
using Univ.Hi_Student_Affairs.Dtos.Respond;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Univ.Hi_Student_Affairs.Service
{
    public class AffiliationOrderService :GenericAppService<AffiliationOrder, AffiliationOrderDto, int, AffiliationOrderPagedAndSortedResultRequestDto, CreateAffiliationOrderDto,UpdateAffiliationOrderDto>, IAffiliationOrderService
    {
        private readonly AffiliationOrderManager _Manager;
        public AffiliationOrderService(IRepository<AffiliationOrder, int> repository,
            AffiliationOrderManager Manager)
        : base(repository)
        { this._Manager = Manager; }



        
        [HttpPost("api/app/affiliation-order/filterdata")]
        public async Task<RespondDto>
                FilterDataAsync(AffiliationOrderPagedAndSortedResultRequestDto input)
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
            var arrDtos = ObjectMapper.Map<List<AffiliationOrder>, List<AffiliationOrderDto>>(arr);


            //Get the total count with another query (required for the paging)
            var totalCount = await Repository.GetCountAsync();

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = new PagedResultDto<AffiliationOrderDto>(
                totalCount,
                arrDtos
            );
            return respond;

        }






        [HttpPost("api/app/affiliation-order/check")]
        public async Task<RespondDto>
         CheckAsync(CheckAffiliationOrderDto input)
        {
            RespondDto respond = new RespondDto();
            List<string> errors = new List<string>();
            var queryable = await Repository.GetQueryableAsync();


            //Get the arr
            var arr = await AsyncExecuter.ToListAsync(
                queryable
                    .WhereIf(input.Id != null && input.Id != 0, x => x.Id.ToString().Contains(input.Id.ToString()))
                    .WhereIf(input.Name != null && !input.Name.IsNullOrEmpty(), x => x.Name != null && x.Name.ToString().Contains(input.Name))
            );

            //Convert to DTOs
            var Dtos = ObjectMapper.Map<List<AffiliationOrder>, List<AffiliationOrderDto>>(arr);

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





        [HttpPost("api/app/affiliation-order/postdata")]
        public async Task<RespondDto> PostDataAsync(CreateAffiliationOrderDto input)
        {

            var obj = await _Manager.CreateAsync(
                input.Name,
                input.AffiliationType,
                input.Ord
            );

            var newObj = await Repository.InsertAsync(obj);

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<AffiliationOrder, AffiliationOrderDto>(newObj);

            return respond;
        }



        [HttpPut("api/app/affiliation-order/modifydata/{id}")]
        public async Task<RespondDto> ModifyDataAsync(int id, UpdateAffiliationOrderDto input)
        {
            var obj = ObjectMapper.Map<UpdateAffiliationOrderDto, AffiliationOrder>(input);


            obj = await _Manager.UpdateAsync(id, obj);

            await Repository.UpdateAsync(obj);

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<AffiliationOrder, AffiliationOrderDto>(obj);
            return respond;
        }




        [HttpDelete("api/app/affiliation-order/removedata/{id}")]
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
