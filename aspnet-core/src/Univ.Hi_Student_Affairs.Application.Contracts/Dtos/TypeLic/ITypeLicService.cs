using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;

namespace Univ.Hi_Student_Affairs.Dtos.TypeLic
{
    public interface ITypeLicService : ICrudAppService<TypeLicDto, int, TypeLicPagedAndSortedResultRequestDto, CreateTypeLicDto, UpdateTypeLicDto>
    {

    }



}
