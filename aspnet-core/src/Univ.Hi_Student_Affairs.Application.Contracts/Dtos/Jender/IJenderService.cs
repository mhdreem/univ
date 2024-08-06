using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;

namespace Univ.Hi_Student_Affairs.Dtos.Jender
{
    public interface IJenderService : ICrudAppService<JenderDto, int, JenderPagedAndSortedResultRequestDto, CreateJenderDto,UpdateJenderDto>
    {

    }
}

