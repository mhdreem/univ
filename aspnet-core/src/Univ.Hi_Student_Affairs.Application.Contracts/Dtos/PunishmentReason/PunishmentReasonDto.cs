using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos.PunishmentReason
{
    public class PunishmentReasonDto : EntityDto<int>
    {
        public string? Name { get; set; }
    }

    public class CreatePunishmentReasonDto 
    {
        public string? Name { get; set; }
    }


    public class UpdatePunishmentReasonDto : CreatePunishmentReasonDto
    {
        public int Id{ get; set; }
    }


    public class CheckPunishmentReasonDto : EntityDto<int>
    {
        public string? Name { get; set; }
    }

    public class PunishmentReasonPagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {
        public int? Id { get; set; }
        public string? Name { get; set; }

    }
}
