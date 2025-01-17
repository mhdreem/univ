﻿using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;

namespace Univ.Hi_Student_Affairs.Dtos.UnivType
{
    public interface IUnivTypeService : ICrudAppService<UnivTypeDto, int, UnivTypePagedAndSortedResultRequestDto, CreateUnivTypeDto, UpdateUnivTypeDto>
    {

    }
}