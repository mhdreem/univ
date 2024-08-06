using System;
using System.Collections.Generic;
using System.Text;
using Univ.Hi_Student_Affairs.Dtos.StdAbolition;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Univ.Hi_Student_Affairs.Dtos.StdAbolition
{
    public interface IStdAbolitionService : ICrudAppService<StdAbolitionDto, int, PagedAndSortedResultRequestDto, CreateStdAbolitionDto, UpdateStdAbolitionDto>
    {

    }


}