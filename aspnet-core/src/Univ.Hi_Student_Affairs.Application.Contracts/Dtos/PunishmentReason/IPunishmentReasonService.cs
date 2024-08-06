using System;
using System.Collections.Generic;
using System.Text;
using Univ.Hi_Student_Affairs.Dtos;
using Volo.Abp.Application.Services;
namespace Univ.Hi_Student_Affairs.Dtos.PunishmentReason
{
    public interface IPunishmentReasonService : ICrudAppService<PunishmentReasonDto, int, PunishmentReasonPagedAndSortedResultRequestDto, CreatePunishmentReasonDto, UpdatePunishmentReasonDto>
    {

    }
}

