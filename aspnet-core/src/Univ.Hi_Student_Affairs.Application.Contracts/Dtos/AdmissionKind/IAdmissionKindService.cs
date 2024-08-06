using System;
using System.Collections.Generic;
using System.Text;
using Univ.Hi_Student_Affairs.Dtos.Admission;
using Volo.Abp.Application.Services;

namespace Univ.Hi_Student_Affairs.Dtos.AdmissionKind
{
    public interface IAdmissionKindService : ICrudAppService<AdmissionKindDto, int, AdmissionKindPagedAndSortedResultRequestDto, CreateAdmissionKindDto, UpdateAdmissionKindDto>
    {

    }
}
