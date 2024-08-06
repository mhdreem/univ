
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;
using System.Linq;
using Univ.Hi_Student_Affairs.Dtos.Admission;
using Univ.Hi_Student_Affairs.Dtos.Respond;
using Univ.Hi_Student_Affairs.Base;
using Microsoft.AspNetCore.Mvc;

using Univ.Hi_Student_Affairs.Dtos;

namespace Univ.Hi_Student_Affairs
{

    public class AdmissionService:GenericAppService<Admission, AdmissionDto,int, AdmissionPagedAndSortedResultRequestDto,  CreateAdmissionDto, UpdateAdmissionDto>, IAdmissionService
    {
        private readonly AdmissionManager _admissionManager;
        public AdmissionService(IRepository<Admission, int> repository,
            AdmissionManager _admissionManager)
        : base(repository)
        { this._admissionManager = _admissionManager; }

            public async override Task<PagedResultDto<AdmissionDto>>
                 GetListAsync(AdmissionPagedAndSortedResultRequestDto input)
            {
                //Set a default sorting, if not provided
                if (input.Sorting.IsNullOrWhiteSpace())
                {
                    input.Sorting = nameof(Admission.NameAr);
                }

            //Get the IQueryable<Book> from the repository


            var queryable = await Repository.GetQueryableAsync();
            
                //Get the books
                var books = await AsyncExecuter.ToListAsync(
                    queryable
                        .WhereIf(input.Id != null, x => x.Id.ToString().Contains(input.Id.ToString()))
                        .WhereIf(input.NameAr != null && !input.NameAr.IsNullOrEmpty(), x => x.NameAr!= null && x.NameAr.ToString().Contains(input.NameAr))
                        .WhereIf(input.NameEn != null && !input.NameEn.IsNullOrEmpty(), x => x.NameEn != null && x.NameEn.ToString().Contains(input.NameEn))
                        //.OrderBy(input.Sorting)
                        .Skip(input.SkipCount)
                        .Take(input.MaxResultCount)
                );

                //Convert to DTOs
                var bookDtos = ObjectMapper.Map<List<Admission>, List<AdmissionDto>>(books);


                //Get the total count with another query (required for the paging)
                var totalCount = await Repository.GetCountAsync();

                return new PagedResultDto<AdmissionDto>(
                    totalCount,
                    bookDtos
                );
            }

        [HttpPost("api/app/admission/check")]
        public async Task<RespondDto>
               CheckAsync(CheckAdmissionDto input)
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
            var AdmissionKindDtos = ObjectMapper.Map<List<Admission>, List<AdmissionDto>>(books);

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

            //Get the books
            books = await AsyncExecuter.ToListAsync(
                queryable
                    .WhereIf(input.id != null && input.id != 0, x => x.Id.ToString().Contains(input.id.ToString()))
                    .WhereIf(input.nameEn != null && !input.nameEn.IsNullOrEmpty(), x => x.NameEn != null && x.NameEn.ToString().Contains(input.nameEn))
            );

            //Convert to DTOs
            AdmissionKindDtos = ObjectMapper.Map<List<Admission>, List<AdmissionDto>>(books);

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

        [HttpPost("api/app/admission/FilterData")]
        public async  Task<RespondDto>
                FilterDataAsync(AdmissionPagedAndSortedResultRequestDto input)
        {
            //Set a default sorting, if not provided
            if (input.Sorting.IsNullOrWhiteSpace())
            {
                input.Sorting = nameof(Admission.NameAr);
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
            var bookDtos = ObjectMapper.Map<List<Admission>, List<AdmissionDto>>(books);


            //Get the total count with another query (required for the paging)
            var totalCount = await Repository.GetCountAsync();

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = new PagedResultDto<AdmissionDto>(
                totalCount,
                bookDtos
            );
            return respond;

        }




        [HttpPost("api/app/admission/PostData")]
        public  async Task<RespondDto> PostDataAsync(CreateAdmissionDto input)
        {
            var admission = await _admissionManager.CreateAsync(

                input.NameAr,
                input.NameEn,
                input.MinistryEncode,
                input.Barcode,
                input.Ord
            );

           var newAdmission = await Repository.InsertAsync(admission);

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<Admission, AdmissionDto>(newAdmission);

            return respond;
        }



        [HttpPut("api/app/admission/ModifyData/{id}")]
        public async Task<RespondDto> ModifyDataAsync(int id, UpdateAdmissionDto input)
        {
            var admission = ObjectMapper.Map<UpdateAdmissionDto, Admission>(input);


            admission= await _admissionManager.UpdateAdmissionAsync(id, admission);

            await Repository.UpdateAsync(admission);

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<Admission, AdmissionDto>(admission); 
            return respond;
        }



        //[HttpDelete("api/app/[controller]/RemoveData/{id?}")]
        [HttpDelete("api/app/admission/RemoveData/{id?}")]
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
