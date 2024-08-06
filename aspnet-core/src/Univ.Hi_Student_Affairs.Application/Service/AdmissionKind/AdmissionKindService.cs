
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;
using System.Linq;
using Univ.Hi_Student_Affairs.Dtos.Respond;
using Microsoft.AspNetCore.Mvc;
using Univ.Hi_Student_Affairs.Dtos.AdmissionKind;
using Univ.Hi_Student_Affairs.Base;

namespace Univ.Hi_Student_Affairs
{

    public class AdmissionKindService :GenericAppService<AdmissionKind, AdmissionKindDto, int, AdmissionKindPagedAndSortedResultRequestDto, CreateAdmissionKindDto,UpdateAdmissionKindDto>, IAdmissionKindService
    {
        private readonly AdmissionKindManager _Manager;

        public AdmissionKindService(
            IRepository<AdmissionKind, int> repository,
            AdmissionKindManager Manager)
        : base(repository)
        { this._Manager = Manager; }

            
        

        [HttpPost("api/app/admission-kind/FilterData")]
        public async  Task<RespondDto>
                FilterDataAsync(AdmissionKindPagedAndSortedResultRequestDto input)
        {
            //Set a default sorting, if not provided
            if (input.Sorting.IsNullOrWhiteSpace())
            {
                input.Sorting = nameof(AdmissionKind.NameAr);
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
            var bookDtos = ObjectMapper.Map<List<AdmissionKind>, List<AdmissionKindDto>>(books);


            //Get the total count with another query (required for the paging)
            var totalCount = await Repository.GetCountAsync();

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = new PagedResultDto<AdmissionKindDto>(
                totalCount,
                bookDtos
            );
            return respond;

        }


        [HttpPost("api/app/admission-kind/check")]
        public async Task<RespondDto>
                CheckAsync(CheckAdmissionKindDto input)
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
            var AdmissionKindDtos = ObjectMapper.Map<List<AdmissionKind>, List<AdmissionKindDto>>(books);

            if (AdmissionKindDtos!= null && AdmissionKindDtos.Count()>0)
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
            AdmissionKindDtos = ObjectMapper.Map<List<AdmissionKind>, List<AdmissionKindDto>>(books);

            if (AdmissionKindDtos != null && AdmissionKindDtos.Count() > 0)
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



        [HttpPost("api/app/admission-kind/PostData")]
        public  async Task<RespondDto> PostDataAsync(CreateAdmissionKindDto input)
        {
            var admission = await _Manager.CreateAsync(

                input.NameAr,
                input.NameEn,
                input.Ord
            );

           var newAdmission = await Repository.InsertAsync(admission);

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<AdmissionKind, AdmissionKindDto>(newAdmission);

            return respond;
        }



        [HttpPut("api/app/admission-kind/ModifyData/{id}")]
        public async Task<RespondDto> ModifyDataAsync(int id, UpdateAdmissionKindDto input)
        {
            var admission = ObjectMapper.Map<UpdateAdmissionKindDto, AdmissionKind>(input);


            admission= await _Manager.UpdateAdmissionAsync(id, admission);

            await Repository.UpdateAsync(admission);

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<AdmissionKind, AdmissionKindDto>(admission); 
            return respond;
        }



      
        [HttpDelete("api/app/admission-kind/RemoveData/{id}")]
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
