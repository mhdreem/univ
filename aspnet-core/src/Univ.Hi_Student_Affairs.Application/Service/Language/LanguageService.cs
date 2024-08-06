
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using System.Linq;
using Univ.Hi_Student_Affairs.Dtos.Respond;
using Microsoft.AspNetCore.Mvc;
using Univ.Hi_Student_Affairs.Dtos.Language;
using Univ.Hi_Student_Affairs.Dtos;
using Univ.Hi_Student_Affairs.Base;

namespace Univ.Hi_Student_Affairs
{

    public class LanguageService :GenericAppService<Language, LanguageDto, int, LanguagePagedAndSortedResultRequestDto, CreateLanguageDto,UpdateLanguageDto>, ILanguageService
    {
        private readonly LanguageManager _Manager;
        public LanguageService(IRepository<Language, int> repository,
            LanguageManager Manager)
        : base(repository)
        { this._Manager = Manager; }

            
        

        [HttpPost("api/app/Language/FilterData")]
        public async  Task<RespondDto>
                FilterDataAsync(LanguagePagedAndSortedResultRequestDto input)
        {
            //Set a default sorting, if not provided
            if (input.Sorting.IsNullOrWhiteSpace())
            {
                input.Sorting = nameof(Language.NameAr);
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
            var bookDtos = ObjectMapper.Map<List<Language>, List<LanguageDto>>(books);


            //Get the total count with another query (required for the paging)
            var totalCount = await Repository.GetCountAsync();

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = new PagedResultDto<LanguageDto>(
                totalCount,
                bookDtos
            );
            return respond;

        }


        [HttpPost("api/app/language/check")]
        public async Task<RespondDto>
        CheckAsync(CheckLanguageDto input)
        {
            RespondDto respond = new RespondDto();
            //Get the IQueryable<Book> from the repository
            List<string> errors = new List<string>();


            var queryable = await Repository.GetQueryableAsync();


            //Get the books
            var books = await AsyncExecuter.ToListAsync(
                queryable
                    .WhereIf(input.id != null && input.id != 0, x => x.Id.ToString().Contains(input.id.ToString()))
                    .WhereIf(input.nameAr != null && !input.nameAr.IsNullOrEmpty(), x => x.NameAr != null && x.NameAr.ToString().Contains(input.nameAr))
            );

            //Convert to DTOs
            var LanguageDtos = ObjectMapper.Map<List<Language>, List<LanguageDto>>(books);

            if (LanguageDtos != null && LanguageDtos.Count() > 0)
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
                    .WhereIf(input.id != null && input.id != 0, x => x.Id.ToString().Contains(input.id.ToString()))
                    .WhereIf(input.nameEn != null && !input.nameEn.IsNullOrEmpty(), x => x.NameEn != null && x.NameEn.ToString().Contains(input.nameEn))
            );

            //Convert to DTOs
            LanguageDtos = ObjectMapper.Map<List<Language>, List<LanguageDto>>(books);

            if (LanguageDtos != null && LanguageDtos.Count() > 0)
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



        [HttpPost("api/app/Language/PostData")]
        public  async Task<RespondDto> PostDataAsync(CreateLanguageDto input)
        {
            var admission = await _Manager.CreateAsync(

                input.NameAr,
                input.NameEn,
                input.Ord
            );

           var newAdmission = await Repository.InsertAsync(admission);

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<Language, LanguageDto>(newAdmission);

            return respond;
        }



        [HttpPut("api/app/Language/ModifyData/{id}")]
        public async Task<RespondDto> ModifyDataAsync(int id, UpdateLanguageDto input)
        {
            var admission = ObjectMapper.Map<UpdateLanguageDto, Language>(input);


            admission= await _Manager.UpdateAsync(id, admission);

            await Repository.UpdateAsync(admission);

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<Language, LanguageDto>(admission); 
            return respond;
        }



       
        [HttpDelete("api/app/Language/RemoveData/{id?}")]
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
