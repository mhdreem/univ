using Univ.Hi_Student_Affairs.Base;
using Univ.Hi_Student_Affairs.Dtos.Continent;
using Volo.Abp.Domain.Repositories;

namespace Univ.Hi_Student_Affairs.Service
{
    //[Route("api/app/country")]
    public class CountryService : GenericAppService<Country, CountryDto, int, CountryPagedAndSortedResultRequestDto, CreateCountryDto, UpdateCountryDto>, ICountryService
    {
       
        public CountryService(IRepository<Country, int> repository
            )
        : base(repository)
        {  }



        /*
         public async Task<RespondDto> AllAsync()
        {
            var items = await Repository.GetListAsync();
            RespondDto RespondDto = new RespondDto();
            RespondDto.IsSuccess = true;
            RespondDto.Result = items;
            return RespondDto;
        }

        public async Task<RespondDto> FilterAsync(Dtos.CustomePagedAndSortedResultRequestDto.CustomePagedAndSortedResultRequestDto input)
        {
            var query = await Repository.GetQueryableAsync();


            // Apply filtering
            if (input.Filters != null && input.Filters.Any())
            {
                foreach (var filter in input.Filters)
                {
                    // Dynamic filtering
                    var propertyInfo = typeof(Country).GetProperty(filter.Key);
                    if (propertyInfo != null)
                    {
                        var parameter = Expression.Parameter(typeof(Country), "x");
                        var member = Expression.Property(parameter, propertyInfo);
                        var constant = Expression.Constant(filter.Value);
                        var equality = Expression.Equal(member, constant);
                        var lambda = Expression.Lambda<Func<Country, bool>>(equality, parameter);
                        query = query.Where(lambda);
                    }
                }
            }


            // Sorting
            if (!string.IsNullOrWhiteSpace(input.Sorting))
            {
                query = query.OrderBy<Country>(input.Sorting);
            }

            var queryable = await Repository.GetQueryableAsync();

            //Get the books
            var items = await AsyncExecuter.ToListAsync(
                query
                    .Skip(input.SkipCount)
                    .Take(input.MaxResultCount)
            );

            //Convert to DTOs
            var bookDtos = ObjectMapper.Map<List<Country>, List<CountryDto>>(items);


            //Get the total count with another query (required for the paging)
            var totalCount = await Repository.GetCountAsync();
            RespondDto respondDto = new RespondDto();
            respondDto.Result = new PagedResultDto<CountryDto>(
                totalCount, bookDtos);

            return respondDto;
        }


         [HttpGet("search")]
         public async Task<RespondDto> SearchAsync(Expression<Func<Country, bool>> predicate)
         {
             var items = await Repository.GetListAsync(predicate);
             RespondDto RespondDto = new RespondDto();
             RespondDto.IsSuccess = true;
             RespondDto.Result = items;
             return RespondDto;

         }

        [HttpGet("advancesearch")]
        public async Task<RespondDto> AdvancedSearchAsync(string searchTerm,
                                                              Func<Country, bool> predicate)
        {
            var items = await Repository.GetListAsync(); // Load all items here
            RespondDto RespondDto = new RespondDto();
            RespondDto.IsSuccess = true;
            RespondDto.Result = items.Where(predicate).ToList();
            return RespondDto;
        }






         [HttpPost("filter")]

        

         /*
           public async Task<PagedResultDto<CountryDto>> GetListAsync(CountryPagedAndSortedResultRequestDto input)
           {
               var query = await Repository.GetQueryableAsync();


               // Apply filtering
               if (input.Filters != null && input.Filters.Any())
               {
                   foreach (var filter in input.Filters)
                   {
                       // Dynamic filtering
                       var propertyInfo = typeof(Country).GetProperty(filter.Key);
                       if (propertyInfo != null)
                       {
                           var parameter = Expression.Parameter(typeof(Country), "x");
                           var member = Expression.Property(parameter, propertyInfo);
                           var constant = Expression.Constant(filter.Value);
                           var equality = Expression.Equal(member, constant);
                           var lambda = Expression.Lambda<Func<Country, bool>>(equality, parameter);
                           query = query.Where(lambda);
                       }
                   }
               }


               // Sorting
               if (!string.IsNullOrWhiteSpace(input.Sorting))
               {
                   query = query.OrderBy<Country>(input.Sorting);
               }

               var queryable = await Repository.GetQueryableAsync();

               //Get the books
               var items = await AsyncExecuter.ToListAsync(
                   query
                       .Skip(input.SkipCount)
                       .Take(input.MaxResultCount)
               );

               //Convert to DTOs
               var bookDtos = ObjectMapper.Map<List<Country>, List<CountryDto>>(items);


               //Get the total count with another query (required for the paging)
               var totalCount = await Repository.GetCountAsync();

              return new PagedResultDto<CountryDto>(
                   totalCount, bookDtos);


           }
         */
    }

}
