using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univ.Hi_Student_Affairs.Dtos;
using Univ.Hi_Student_Affairs.Dtos.Univ;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Univ.Hi_Student_Affairs.Base;

namespace Univ.Hi_Student_Affairs.Service
{
    public class DepartmentService :GenericAppService<Department, DepartmentDto, int, PagedResultRequestDto, CreateDepartmentDto, UpdateDepartmentDto>
    {
        public DepartmentService(IRepository<Department, int> repository, IMapper mapper)
            : base(repository)
        {
            // You can use the injected repository and mapper here
        }


    }
}
