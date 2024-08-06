
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Univ.Hi_Student_Affairs.Dtos.CustomePagedAndSortedResultRequestDto;
using Univ.Hi_Student_Affairs.Dtos.Respond;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.ObjectMapping;

namespace Univ.Hi_Student_Affairs.Base
{

    public class GenericAppService<TEntity, TEntityDto, TKey, TGetListInput, TCreateInput, TUpdateInput>
        :CrudAppService<TEntity, TEntityDto, TKey, TGetListInput, TCreateInput, TUpdateInput>
       where TEntity : class, IEntity<TKey>
    {
        protected GenericAppService(IRepository<TEntity, TKey> repository)
              : base(repository)
        {

        }

        
        public async Task<RespondDto> AllAsync()
        {
            var items = await Repository.GetListAsync();
            RespondDto RespondDto = new RespondDto();
            RespondDto.IsSuccess = true;
            RespondDto.Result= items;
            return RespondDto;
        }


        
        [HttpPost]
        public async Task<RespondDto> FilterAsync(CustomePagedAndSortedResultRequestDto input)
        {
           
                var query = await Repository.GetQueryableAsync();

                // Apply filtering
                if (input.Filters != null && input.Filters.Any())
                {
                    foreach (var filter in input.Filters)
                    {
                        // Dynamic filtering
                        var propertyInfo = typeof(TEntity).GetProperty(filter.Key);
                        if (propertyInfo != null)
                        {
                            var parameter = Expression.Parameter(typeof(TEntity), "x");
                            var member = Expression.Property(parameter, propertyInfo);
                            var constant = Expression.Constant(filter.Value);
                            var equality = Expression.Equal(member, constant);
                            var lambda = Expression.Lambda<Func<TEntity, bool>>(equality, parameter);
                            query = query.Where(lambda);
                        }
                    }
                }

                // Sorting
                if (!string.IsNullOrWhiteSpace(input.Sorting))
                {
                    query = query.OrderBy<TEntity>(input.Sorting);
                }

                var queryable = await Repository.GetQueryableAsync();

                //Get the books
                var items = await AsyncExecuter.ToListAsync(
                    query
                        .Skip(input.SkipCount)
                        .Take(input.MaxResultCount)
                );

                //Convert to DTOs
                var bookDtos = ObjectMapper.Map<List<TEntity>, List<TEntityDto>>(items);


                //Get the total count with another query (required for the paging)
                var totalCount = await Repository.GetCountAsync();
                RespondDto respondDto = new RespondDto();
            respondDto.IsSuccess =true;
                respondDto.Result = new PagedResultDto<TEntityDto>(
                    totalCount, bookDtos);

                return respondDto;
           
        
        }

    }

}


