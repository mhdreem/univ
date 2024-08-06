
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using System.Linq;
using Univ.Hi_Student_Affairs.Dtos.Respond;
using Microsoft.AspNetCore.Mvc;
using Univ.Hi_Student_Affairs.Dtos.Univ;
using System.Collections.ObjectModel;
using Univ.Hi_Student_Affairs.Dtos.AdmissionKind;
using Univ.Hi_Student_Affairs.Dtos;
using Univ.Hi_Student_Affairs.Base;

namespace Univ.Hi_Student_Affairs
{

    public class UnivService :GenericAppService<Univ, UnivDto, int, UnivPagedAndSortedResultRequestDto, CreateUnivDto,UpdateUnivDto>, IUnivService
    {
        private readonly UnivManager _Manager;
       

        public UnivService(IUnivRepository repository,
            UnivManager Manager)
        : base(repository)
        { this._Manager = Manager;
           
        }

        


        [HttpPost("api/app/univ/filterdata")]
        public async  Task<RespondDto>
                FilterDataAsync(UnivPagedAndSortedResultRequestDto input)
        {
            try {
                //Set a default sorting, if not provided
                if (input.Sorting.IsNullOrWhiteSpace())
                {
                    input.Sorting = nameof(Univ.NameAr);
                }

                //Get the IQueryable<Book> from the repository
                //Get a IQueryable<T> by including sub collections
                //var queryable = Repository.WithDetails();


                //Get a IQueryable<T> by including sub collections
                var queryable = await Repository.WithDetailsAsync();




                // var queryable = await Repository.GetQueryableAsync();


                //Get the books
                var books = await AsyncExecuter
                    .ToListAsync(
                    queryable

                        .WhereIf(input.Id != null, x => x.Id.ToString().Contains(input.Id.ToString()))
                        .WhereIf(input.NameAr != null && !input.NameAr.IsNullOrEmpty(), x => x.NameAr != null && x.NameAr.ToString().Contains(input.NameAr))
                        .WhereIf(input.NameEn != null && !input.NameEn.IsNullOrEmpty(), x => x.NameEn != null && x.NameEn.ToString().Contains(input.NameEn))
                        //.OrderBy(input.Sorting)
                        .Skip(input.SkipCount)
                        .Take(input.MaxResultCount)
                );

                //Convert to DTOs
                var bookDtos = ObjectMapper.Map<List<Univ>, List<UnivDto>>(books);


                //Get the total count with another query (required for the paging)
                var totalCount = await Repository.GetCountAsync();

                RespondDto respond = new RespondDto();
                respond.IsSuccess = true;
                respond.Result = new PagedResultDto<UnivDto>(
                    totalCount,
                    bookDtos
                );
                return respond;
            
            } catch (Exception ex) { }
            return null;


        }




        [HttpPost("api/app/univ/check-univ")]
        public async Task<RespondDto>
        checkUnivAsync(CheckUnivDto input)
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
            var AdmissionKindDtos = ObjectMapper.Map<List<Univ>, List<UnivDto>>(books);

            if (AdmissionKindDtos != null && AdmissionKindDtos.Count() > 0)
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


        [HttpPost("api/app/univ/check-univsection")]
        public async Task<RespondDto>
       CheckUnivSectionAsync(CheckUnivDto input)
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
            var AdmissionKindDtos = ObjectMapper.Map<List<Univ>, List<UnivDto>>(books);

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
                    .WhereIf(input.Id != null && input.Id != 0, x => x.Id.ToString().Contains(input.Id.ToString()))
                    .WhereIf(input.NameEn != null && !input.NameEn.IsNullOrEmpty(), x => x.NameEn != null && x.NameEn.ToString().Contains(input.NameEn))
            );

            //Convert to DTOs
            AdmissionKindDtos = ObjectMapper.Map<List<Univ>, List<UnivDto>>(books);

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



        [HttpPost("api/app/univ/check-collage")]
        public async Task<RespondDto>
       CheckCollageAsync(CheckUnivDto input)
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
            var AdmissionKindDtos = ObjectMapper.Map<List<Univ>, List<UnivDto>>(books);

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
                    .WhereIf(input.Id != null && input.Id != 0, x => x.Id.ToString().Contains(input.Id.ToString()))
                    .WhereIf(input.NameEn != null && !input.NameEn.IsNullOrEmpty(), x => x.NameEn != null && x.NameEn.ToString().Contains(input.NameEn))
            );

            //Convert to DTOs
            AdmissionKindDtos = ObjectMapper.Map<List<Univ>, List<UnivDto>>(books);

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



        [HttpPost("api/app/univ/check-department")]
        public async Task<RespondDto>
       CheckDepartmentAsync(CheckUnivDto input)
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
            var AdmissionKindDtos = ObjectMapper.Map<List<Univ>, List<UnivDto>>(books);

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
                    .WhereIf(input.Id != null && input.Id != 0, x => x.Id.ToString().Contains(input.Id.ToString()))
                    .WhereIf(input.NameEn != null && !input.NameEn.IsNullOrEmpty(), x => x.NameEn != null && x.NameEn.ToString().Contains(input.NameEn))
            );

            //Convert to DTOs
            AdmissionKindDtos = ObjectMapper.Map<List<Univ>, List<UnivDto>>(books);

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


        [HttpPost("api/app/univ/add-univ")]
        public async Task<RespondDto> AddUnivAsync(CreateUnivDto input)
        {

           

            Collection<UnivSection> UnivSections =
                ObjectMapper.Map< Collection < UnivSectionDto >  , Collection<UnivSection>>(input.UnivSections);

            var @univ = await _Manager.CreateAsync(
             input.NameAr,
             input.NameEn,
            input.Ord,
            input.MinistryEncode ,
            input.UnivEncode ,
            UnivSections
            );

            await Repository.InsertAsync(@univ);

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<Univ, UnivDto>(@univ);

            return respond;
        }




        [HttpPut("api/app/univ/modify-univ/{Id}")]
        public async Task<RespondDto> ModifyUnivAsync(int Id, UpdateUnivDto input)
        {
            var @univ = ObjectMapper.Map<UpdateUnivDto, Univ>(input);


            await _Manager.UpdateAsync(Id, @univ);

            await Repository.UpdateAsync(@univ);

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<Univ, UnivDto>(@univ); 
            return respond;
        }



        [HttpDelete("api/app/univ/remove-univ/{Id}")]
        public async Task<RespondDto> RemoveUnivAsync(int Id)
        {
            var obj = await Repository.GetAsync(Id,true);
            await Repository.DeleteAsync(obj);
            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = true ;
            respond.Total_Result_Count = 1;
            return respond;
        }


        //univeSection

        [HttpPost("api/app/univ/add-univesection/{Id}")]
        public async Task<RespondDto> AddUnivSecttionAsync(int Id,CreateUnivSectionDto univsectiondto)
        {
            Collection<Collage> Collages =
              ObjectMapper.Map<Collection<CollageDto>, Collection<Collage>>(univsectiondto.Collages);


            var @univ = await Repository.GetAsync(Id, true);            
             _Manager.AddUnivSection(@univ, univsectiondto.NameAr, univsectiondto.NameEn, univsectiondto.Ord, univsectiondto.MinistryEncode, univsectiondto.Barcode, Collages);
            await Repository.UpdateAsync(@univ);

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<Univ, UnivDto>(@univ);

            return respond;

        }

        [HttpPost("api/app/univ/update-univesection/{Id}/{univid}")]
        public async Task<RespondDto> UpdateUnivSectionAsync(int Id, int univid, UpdateUnivSectionDto dto)
        {
            Collection<Collage> Collages =
              ObjectMapper.Map<Collection<CollageDto>, Collection<Collage>>(dto.Collages);

            var @univ = await Repository.GetAsync(univid, true);



            _Manager.UpdateUnivSection(@univ, Id, dto.NameAr, dto.NameEn, dto.Ord, dto.MinistryEncode, dto.Barcode, Collages);


            await Repository.UpdateAsync(@univ);

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<Univ, UnivDto>(@univ);

            return respond;
        }


        [HttpPost("api/app/univ/remove-univesection/{Id}/{univid}")]
        public async Task<RespondDto> RemoveUnivSectionAsync(int Id, int univid)
        {
            var @univ = await Repository.GetAsync(Id, true);


            _Manager.RemoveUnivSection( @univ, univid);

            await Repository.UpdateAsync(@univ);

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<Univ, UnivDto>(@univ);

            return respond;
        }

        // Collage

        [HttpPost("api/app/univ/add-collage/{univid}/{usivsectionid}")]
        public async Task<RespondDto> AddCollageAsync(int univid,int usivsectionid, CreateCollageDto dto)
        {
            Collection<Department> Departments =
                  ObjectMapper.Map<Collection<DepartmentDto>, Collection<Department>>(dto.Departments);

            var @univ = await Repository.GetAsync(univid, true);        
            _Manager.AddCollage(@univ, usivsectionid, dto.NameAr, dto.NameEn, dto.DeanAr, dto.DeanEn,dto.NumYear, dto.Ord,dto.DegreeNameAr, dto.DegreeNameEn,dto.MinistryEncode,  dto.Barcode, Departments);
            await Repository.UpdateAsync(@univ);
            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<Univ, UnivDto>(@univ);

            return respond;
        }


        [HttpDelete("api/app/univ/remove-collage/{univid}/{univsectionid}/{collageid}")]
        public async Task<RespondDto> RemoveCollageAsync(int univid, int univsectionid, int collageid)
        {

            var @univ = await Repository.FindAsync(univid, true);

            _Manager.RemoveCollage(@univ ,univsectionid, collageid);

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = true;
            return respond;
        }


        [HttpPut("api/app/univ/update-collage/{univid}/{univsectionid}/{collageid}")]
        public async Task<RespondDto> UpdateCollageAsync(int univid,int univsectionid,int collageid, UpdateCollageDto dto)
        {
            RespondDto respond = new RespondDto();
            var @univ = await Repository.GetAsync(univid, true);
            if (@univ == null)
            {
                
                respond.IsSuccess = false;
                respond.Result = false ;
                return respond;
            }

            _Manager.UpdateCollage(@univ , univsectionid,collageid, dto.NameAr, dto.NameEn, dto.DeanAr, dto.DeanEn, dto.NumYear, dto.Ord, dto.DegreeNameAr, dto.DegreeNameEn, dto.MinistryEncode, dto.Barcode);
            await Repository.UpdateAsync(@univ);            
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<Univ, UnivDto>(@univ);
            return respond;           
        }



        //department   

        [HttpPost("api/app/univ/add-department/{univid}/{usivsectionid}/{collageid}")]
        public async Task<RespondDto> AddDepartmentAsync(int univid, int usivsectionid,int collageid, CreateDepartmentDto dto)
        {
            Collection<Branch> Branchs =
                  ObjectMapper.Map<Collection<BranchDto>, Collection<Branch>>(dto.Branchs);

            var @univ = await Repository.GetAsync(univid, true);
            _Manager.AddDepartment(@univ ,usivsectionid, collageid, dto.NameAr, dto.NameEn, dto.Ord, dto.DegreeNameAr, dto.DegreeNameEn, dto.MinistryEncode, dto.Barcode, Branchs);
            await Repository.UpdateAsync(@univ);
            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<Univ, UnivDto>(@univ);

            return respond;
        }







        [HttpDelete("api/app/univ/remove-department/{univid}/{univsectionid}/{collageid}/{departmentid}")]
        public async Task<RespondDto> RemoveDepartmentAsync(int univid, int univsectionid, int collageid,int departmentid)
        {
            var @univ = await Repository.FindAsync(univid, true);
            _Manager.RemoveDeparment(@univ ,univsectionid, collageid,departmentid);
            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = true;
            return respond;
        }





        [HttpPut("api/app/univ/update-department/{univid}/{univsectionid}/{collageid}")]
        public async Task<RespondDto> UpdateDepartmentAsync(int univid, int univsectionid, int collageid, int departmentid, UpdateDepartmentDto dto)
        {
            RespondDto respond = new RespondDto();
            var @univ = await Repository.GetAsync(univid, true);
            if (@univ == null)
            {

                respond.IsSuccess = false;
                respond.Result = false;
                return respond;
            }
            _Manager.UpdateDepartment(@univ , univsectionid, collageid, departmentid,dto.NameAr, dto.NameEn, dto.Ord, dto.DegreeNameAr, dto.DegreeNameEn, dto.MinistryEncode, dto.Barcode);
            await Repository.UpdateAsync(@univ);
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<Univ, UnivDto>(@univ);
            return respond;
        }





        //Branch   

        [HttpPost("api/app/univ/add-branch/{univid}/{usivsectionid}/{collageid}/{departmentid}")]
        public async Task<RespondDto> AddBranchAsync(int univid, int usivsectionid, int collageid,int departmentid, CreateBranchDto dto)
        {
            var @univ = await Repository.GetAsync(univid, true);
            _Manager.AddBranch(@univ, usivsectionid, collageid,departmentid, dto.NameAr, dto.NameEn, dto.Ord,  dto.Barcode, dto.MinistryEncode);
            await Repository.UpdateAsync(@univ);
            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<Univ, UnivDto>(@univ);

            return respond;
        }







        [HttpDelete("api/app/univ/remove-branch/{univid}/{univsectionid}/{collageid}/{departmentid}/{branchid}")]
        public async Task<RespondDto> RemoveBranchAsync(int univid, int univsectionid, int collageid, int departmentid,int branchid)
        {
            var @univ = await Repository.FindAsync(univid, true);
            _Manager.RemoveBranch(@univ ,univsectionid, collageid, departmentid,branchid);
            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = true;
            return respond;
        }





        [HttpPut("api/app/univ/update-branch/{univid}/{univsectionid}/{collageid}/{branchid}")]
        public async Task<RespondDto> UpdateBranchAsync(int univid, int univsectionid, int collageid, int departmentid,int branchid, UpdateBranchDto dto)
        {
            RespondDto respond = new RespondDto();
            var @univ = await Repository.GetAsync(univid, true);
            if (@univ == null)
            {

                respond.IsSuccess = false;
                respond.Result = false;
                return respond;
            }
            _Manager.UpdateBranch(@univ, univsectionid, collageid, departmentid,branchid ,dto.NameAr, dto.NameEn, dto.Ord, dto.Barcode, dto.MinistryEncode);
            await Repository.UpdateAsync(@univ);
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<Univ, UnivDto>(@univ);
            return respond;
        }





    }
}
