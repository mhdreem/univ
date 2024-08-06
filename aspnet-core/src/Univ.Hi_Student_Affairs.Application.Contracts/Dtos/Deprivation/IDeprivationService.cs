using System;
using System.Collections.Generic;
using System.Text;
using Univ.Hi_Student_Affairs.Dtos;
using Volo.Abp.Application.Services;
namespace Univ.Hi_Student_Affairs.Dtos.Deprivation
{
    public interface IDeprivationService : ICrudAppService<DeprivationDto, int, DeprivationPagedAndSortedResultRequestDto, CreateDeprivationDto, UpdateDeprivationDto>
    {

    }
}

