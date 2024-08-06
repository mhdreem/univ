using AutoMapper.Internal.Mappers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Univ.Hi_Student_Affairs.Dtos;
using Univ.Hi_Student_Affairs.Dtos.CustomePagedAndSortedResultRequestDto;
using Univ.Hi_Student_Affairs.Dtos.Respond;
using Univ.Hi_Student_Affairs.Dtos.Student;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.ObjectMapping;
using Univ.Hi_Student_Affairs.Base;

namespace Univ.Hi_Student_Affairs.Service
{
    public class StudentService :GenericAppService<Student, StudentDto, Guid, CustomePagedAndSortedResultRequestDto, CreateStudentDto, UpdateStudentDto>, IStudentService
    {
        private readonly StudentManager _Manager;
        public StudentService(IRepository<Student, Guid> repository,
            StudentManager Manager)
        : base(repository)
        { this._Manager = Manager; }



    




        [HttpPost("api/app/student/check")]
        public async Task<RespondDto>
        CheckAsync(CheckStudentDto input)
        {
            RespondDto respond = new RespondDto();
            List<string> errors = new List<string>();
            var queryable = await Repository.GetQueryableAsync();


            //Get the arr
            var arr = await AsyncExecuter.ToListAsync(
                queryable
                          );

            //Convert to DTOs
            var Dtos = ObjectMapper.Map<List<Student>, List<StudentDto>>(arr);

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





        [HttpPost("api/app/student/postdata")]
        public async Task<RespondDto> PostDataAsync(CreateStudentDto input)
        {

           

            try
            {
                var inputObj = ObjectMapper.Map<CreateStudentDto, Student>(input);

                var obj = await _Manager.CreateAsync(inputObj);

                var newObj = await Repository.InsertAsync(obj);

                RespondDto respond = new RespondDto();
                respond.IsSuccess = true;
                respond.Result = ObjectMapper.Map<Student, StudentDto>(newObj);

                return respond;
            }
            catch(Exception ex) { }
            return null;
        }



        [HttpPut("api/app/student/modifydata/{id}")]
        public async Task<RespondDto> ModifyDataAsync(Guid id, UpdateStudentDto input)
        {
            var obj = ObjectMapper.Map<UpdateStudentDto, Student>(input);


            obj = await _Manager.UpdateAsync(id, obj);

            await Repository.UpdateAsync(obj);

            RespondDto respond = new RespondDto();
            respond.IsSuccess = true;
            respond.Result = ObjectMapper.Map<Student, StudentDto>(obj);
            return respond;
        }




        [HttpDelete("api/app/student/removedata/{id}")]
        public async Task<RespondDto> RemoveDataAsync(Guid id)
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
