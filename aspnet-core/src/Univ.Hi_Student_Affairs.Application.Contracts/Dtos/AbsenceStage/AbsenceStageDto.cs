using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos.AbsenceStage
{
    public class AbsenceStageDto : EntityDto<int>
    {
        public string? Name { get; set; }

        public StageState? StageState { get; set; }

        public int? Ord { get; set; }
    }

    public class CreateAbsenceStageDto
    {
        public string? Name { get; set; }

        public StageState? StageState { get; set; }

        public int? Ord { get; set; }
    }


    public class UpdateAbsenceStageDto : CreateAbsenceStageDto
    {
        public int Id { get; set; }
    }

    public class CheckAbsenceStageDto : EntityDto<int?>
    {
        public string? Name { get; set; }

        public StageState? StageState { get; set; }

        public int? Ord { get; set; }

    }

    public class AbsenceStagePagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public StageState? StageState { get; set; }

        public int? Ord { get; set; }

    }

}
