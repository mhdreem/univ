using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univ.Hi_Student_Affairs.Dtos.CollType;
using Volo.Abp.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using Univ.Hi_Student_Affairs.Dtos.Respond;
using Volo.Abp.Application.Dtos;
using Univ.Hi_Student_Affairs.Base;

namespace Univ.Hi_Student_Affairs
{
    public class CollTypeService :GenericAppService<CollType, CollTypeDto, int, CollTypePagedAndSortedResultRequestDto, CreateCollTypeDto,UpdateCollTypeDto>, ICollTypeService
    {
        private readonly CollTypeManager _Manager;
        public CollTypeService(IRepository<CollType, int> repository,
            CollTypeManager Manager)
        : base(repository)
        { this._Manager = Manager; }




        [HttpPost("api/app/coll-type/FilterData")]
        public async Task<RespondDto>
                FilterDataAsync(CollTypePagedAndSortedResultRequestDto input)
        {
            //Set a default sorting, if not provided
            if (input.Sorting.IsNullOrWhiteSpace())
            {
                input.Sorting = nameof(CollType.Name);
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
            var bookDtos = ObjectMapper.Map<List<CollType>, List<CollTypeDto>>(books);


            //Get the total count with another query (required for the paging)
            var totalCount = await Repository.GetCountAsync();

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = new PagedResultDto<CollTypeDto>(
                totalCount,
                bookDtos
            );
            return respond;

        }

        [HttpPost("api/app/coll-type/check")]
        public async Task<RespondDto>
        CheckAsync(CheckCollTypeDto input)
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
            var AdmissionKindDtos = ObjectMapper.Map<List<CollType>, List<CollTypeDto>>(books);

            if (AdmissionKindDtos != null && AdmissionKindDtos.Count() > 0)
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


        [HttpPost("api/app/coll-type/PostData")]
        public async Task<RespondDto> PostDataAsync(CreateCollTypeDto input)
        {
            var admission = await _Manager.CreateAsync(
                input.Name,
                input.MinistryEncode,
                input.Barcode,
                input.Ord
            );

            var newAdmission = await Repository.InsertAsync(admission);

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<CollType, CollTypeDto>(newAdmission);

            return respond;
        }



        [HttpPut("api/app/coll-type/ModifyData/{id}")]
        public async Task<RespondDto> ModifyDataAsync(int id, UpdateCollTypeDto input)
        {
            var admission = ObjectMapper.Map<UpdateCollTypeDto, CollType>(input);


            admission = await _Manager.UpdateAsync(id, admission);

            await Repository.UpdateAsync(admission);

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<CollType, CollTypeDto>(admission);
            return respond;
        }




        [HttpDelete("api/app/coll-type/RemoveData/{id?}")]
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
