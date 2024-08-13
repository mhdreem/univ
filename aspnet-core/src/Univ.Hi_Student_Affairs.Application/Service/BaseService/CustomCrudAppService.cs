using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Univ.Hi_Student_Affairs.Dtos.CustomePagedAndSortedResultRequestDto;
using Univ.Hi_Student_Affairs.Dtos.Respond;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;

namespace Univ.Hi_Student_Affairs.Service.BaseService
{
    public class CustomCrudAppService<TEntity, TEntityDto, TKey, TCreateInput, TUpdateInput>
    : CrudAppService<TEntity, TEntityDto, TKey, PagedAndSortedResultRequestDto, TCreateInput, TUpdateInput>
    where TEntity : class, IEntity<TKey>
    {
        public CustomCrudAppService(IRepository<TEntity, TKey> repository)
            : base(repository)
        {
        }

        public virtual async Task<RespondDto> CreateCustomAsync(TCreateInput input)
        {
            try
            {
                var result = await CreateAsync(input);
                return new RespondDto
                {
                    IsSuccess = true,
                    Result = result
                };
            }
            catch (Exception ex)
            {
                return new RespondDto
                {
                    IsSuccess = false,
                    Error = ex.Message
                };
            }
        }

        public virtual async Task<RespondDto> UpdateCustomAsync(TKey id, TUpdateInput input)
        {
            try
            {
                var result = await UpdateAsync(id, input);
                return new RespondDto
                {
                    IsSuccess = true,
                    Result = result
                };
            }
            catch (Exception ex)
            {
                return new RespondDto
                {
                    IsSuccess = false,
                    Error = ex.Message
                };
            }
        }

        public virtual async Task<RespondDto> DeleteCustomAsync(TKey id)
        {
            try
            {
                await DeleteAsync(id);
                return new RespondDto
                {
                    IsSuccess = true
                };
            }
            catch (Exception ex)
            {
                return new RespondDto
                {
                    IsSuccess = false,
                    Error = ex.Message
                };
            }
        }

        public virtual async Task<RespondDto> GetCustomAsync(TKey id)
        {
            try
            {
                var result = await GetAsync(id);
                return new RespondDto
                {
                    IsSuccess = true,
                    Result = result
                };
            }
            catch (Exception ex)
            {
                return new RespondDto
                {
                    IsSuccess = false,
                    Error = ex.Message
                };
            }
        }

        public virtual async Task<RespondDto> GetAllCustomAsync(PagedAndSortedResultRequestDto input)
        {
            try
            {
                var result = await base.GetListAsync(input);
                return new RespondDto
                {
                    IsSuccess = true,
                    Result = result.Items,
                    Total_Result_Count = result.TotalCount
                };
            }
            catch (Exception ex)
            {
                return new RespondDto
                {
                    IsSuccess = false,
                    Error = ex.Message
                };
            }
        }

        public virtual async Task<RespondDto> FilterAsync(CustomePagedAndSortedResultRequestDto input)
        {
            try
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

                // Sorting using Dynamic LINQ
                if (!string.IsNullOrWhiteSpace(input.Sorting))
                {
                    query = query.OrderBy(input.Sorting); // Works with System.Linq.Dynamic.Core
                }

                // Pagination
                var totalCount = await AsyncExecuter.CountAsync(query);
                var items = await AsyncExecuter.ToListAsync(
                    query.Skip(input.SkipCount).Take(input.MaxResultCount)
                );

                // Convert to DTOs
                var itemDtos = ObjectMapper.Map<List<TEntity>, List<TEntityDto>>(items);

                // Create PagedResultDto
                var pagedResult = new PagedResultDto<TEntityDto>(totalCount, itemDtos);

                // Return wrapped in RespondDto
                return new RespondDto
                {
                    IsSuccess = true,
                    Result = pagedResult,
                    Total_Result_Count = totalCount
                };
            }
            catch (Exception ex)
            {
                // Handle exceptions and return a failure response
                return new RespondDto
                {
                    IsSuccess = false,
                    Error = ex.Message
                };
            }
        }


    }

}
