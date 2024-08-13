using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos.DomainPunishment
{
    public class PunishmentStageDto : EntityDto<int>
    {
        public string? Name { get; set; }

        public StageState? StageState { get; set; }

        public int? Ord { get; set; }
    }

    public class CreatePunishmentStageDto : EntityDto<int>
    {
        public string? Name { get; set; }

        public StageState? StageState { get; set; }

        public int? Ord { get; set; }
    }



    public class UpdatePunishmentStageDto : CreatePunishmentStageDto
    {
        public int Id { get; set; }

    }




    public class CheckPunishmentStageDto : EntityDto<int>
    {
        public string? Name { get; set; }

        public StageState? StageState { get; set; }

        public int? Ord { get; set; }



    }

    public class PunishmentStagePagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {
        public int? Id { get; set; }
        public string? Name { get; set; }

        public StageState? StageState { get; set; }

        public int? Ord { get; set; }

    }
}
