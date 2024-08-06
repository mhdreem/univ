using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;

namespace Univ.Hi_Student_Affairs.Dtos.CollType
{
    public interface ICollTypeService : ICrudAppService<CollTypeDto, int, CollTypePagedAndSortedResultRequestDto, CreateCollTypeDto, UpdateCollTypeDto>
    {

    }
}