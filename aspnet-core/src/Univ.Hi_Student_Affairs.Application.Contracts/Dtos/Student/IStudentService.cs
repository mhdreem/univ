using System;
using Volo.Abp.Application.Services;

namespace Univ.Hi_Student_Affairs.Dtos.Student
{
    public interface IStudentService : ICrudAppService<StudentDto, Guid, CustomePagedAndSortedResultRequestDto.CustomePagedAndSortedResultRequestDto, CreateStudentDto, UpdateStudentDto>
    {

    }
}
