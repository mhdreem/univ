
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using System.Linq;
using Univ.Hi_Student_Affairs.Dtos.Respond;
using Microsoft.AspNetCore.Mvc;
using Univ.Hi_Student_Affairs.Dtos.TypeLic;
using Univ.Hi_Student_Affairs.Dtos;
using Univ.Hi_Student_Affairs.Base;

namespace Univ.Hi_Student_Affairs
{

    public class TypeLicService :GenericAppService<TypeLic, TypeLicDto, int, TypeLicPagedAndSortedResultRequestDto, CreateTypeLicDto, UpdateTypeLicDto>, ITypeLicService
    {
        private readonly TypeLicManager _Manager;
        public TypeLicService(IRepository<TypeLic, int> repository,
            TypeLicManager Manager)
        : base(repository)
        { this._Manager = Manager; }

            
        

        [HttpPost("api/app/type-lic/FilterData")]
        public async  Task<RespondDto>
                FilterDataAsync(TypeLicPagedAndSortedResultRequestDto input)
        {
            //Set a default sorting, if not provided
            if (input.Sorting.IsNullOrWhiteSpace())
            {
                input.Sorting = nameof(TypeLic.NameAr);
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
            var bookDtos = ObjectMapper.Map<List<TypeLic>, List<TypeLicDto>>(books);


            //Get the total count with another query (required for the paging)
            var totalCount = await Repository.GetCountAsync();

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = new PagedResultDto<TypeLicDto>(
                totalCount,
                bookDtos
            );
            return respond;

        }

        [HttpPost("api/app/type-lic/check")]
        public async Task<RespondDto>
   CheckAsync(CheckTypeLicDto input)
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
            var TypeLicDtos = ObjectMapper.Map<List<TypeLic>, List<TypeLicDto>>(books);

            if (TypeLicDtos != null && TypeLicDtos.Count() > 0)
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
            TypeLicDtos = ObjectMapper.Map<List<TypeLic>, List<TypeLicDto>>(books);

            if (TypeLicDtos != null && TypeLicDtos.Count() > 0)
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


        [HttpPost("api/app/type-lic/check-type-lic-branch")]
        public async Task<RespondDto>
        CheckTypeLicBranchAsync(CheckTypeLicBranchDto input)
        {
            RespondDto respond = new RespondDto();
            //Get the IQueryable<Book> from the repository
            List<string> errors = new List<string>();


            if (input.TypeLicId != null )
            {
                var TypeLic = await Repository.FindAsync( x=>x.Id == input.TypeLicId);
                if (TypeLic!= null )
                {
                    var arr= TypeLic.TypeLicBranchs.Where(
                            x => x.NameAr != null && x.NameAr.ToString().Contains(input.NameAr));

                    if (arr != null && arr.Count() > 0)
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





                }
            }

            



            respond.IsSuccess = true;
            respond.Result = true;
            return respond;
        }



        [HttpPost("api/app/type-lic/PostData")]
        public  async Task<RespondDto> PostDataAsync(CreateTypeLicDto input)
        {
            var admission = await _Manager.CreateAsync(

                input.NameAr,
                input.NameEn,
                input.Ord
            );

           var newAdmission = await Repository.InsertAsync(admission);

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<TypeLic, TypeLicDto>(newAdmission);

            return respond;
        }



        [HttpPut("api/app/type-lic/modifydata/{Id}")]
        public async Task<RespondDto> ModifyDataAsync(int Id, UpdateTypeLicDto input)
        {
            var admission = ObjectMapper.Map<UpdateTypeLicDto, TypeLic>(input);


            admission= await _Manager.UpdateAsync(Id, admission);

            await Repository.UpdateAsync(admission);

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<TypeLic, TypeLicDto>(admission); 
            return respond;
        }



        
        [HttpDelete("api/app/type-lic/RemoveData/{Id?}")]
        public async Task<RespondDto> RemoveDataAsync(int Id)
        {
            var obj = await Repository.FindAsync(Id);
            if (obj != null)
            {
                await Repository.DeleteAsync(obj);
            }
            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = true ;
            return respond;

        }




        //univeSection

        [HttpPost("api/app/type-lic/add-type-lic-Branch/{typelicid}")]
        public async Task<RespondDto> AddTypeLicBranchAsync(int typelicid, CreateTypeLicBranchDto input)
        {
            var TypeLicBranch = ObjectMapper.Map<CreateTypeLicBranchDto, TypeLicBranch>(input);
            var @TypeLic= await Repository.GetAsync(typelicid, true);
            _Manager.AddTypeLicBranch(@TypeLic, TypeLicBranch);
            await Repository.UpdateAsync(@TypeLic);
            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<TypeLic, TypeLicDto>(@TypeLic);
            return respond;

        }


        [HttpPost("api/app/type-lic/modify-type-lic-Branch/{Id}/{typelicid}")]
        public async Task<RespondDto> UpdateTypeLicBranchAsync(int Id, int typelicid, UpdateTypeLicBranchDto input)
        {
            var @TypeLic = await Repository.GetAsync(typelicid, true);

            var TypeLicBranch = ObjectMapper.Map<UpdateTypeLicBranchDto, TypeLicBranch>(input);
        
            _Manager.UpdateTypeLicBranch(@TypeLic,Id, TypeLicBranch);
            await Repository.UpdateAsync(@TypeLic);
            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<TypeLic, TypeLicDto>(@TypeLic);
            return respond;
        }



        [HttpPost("api/app/type-lic/remove-type-lic-Branch/{Id}/{typelicid}")]
        public async Task<RespondDto> RemoveTypeLicBranchAsync(int Id, int typelicid)
        {
            var @Typelic = await Repository.GetAsync(typelicid, true);


            _Manager.RemoveTypeLicBranch(@Typelic, Id);

            await Repository.UpdateAsync(@Typelic);

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<TypeLic, TypeLicDto>(@Typelic);

            return respond;
        }

    }
}
