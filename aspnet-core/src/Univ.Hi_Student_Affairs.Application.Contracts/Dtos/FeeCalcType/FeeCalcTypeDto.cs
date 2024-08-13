using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos.FeeCalcType
{
    public class FeeCalcTypeDto : EntityDto<int>
    {
        public virtual string Name { get; set; }
        public int? Ord { get; set; }




    }

    public class CreateFeeCalcTypeDto
    {
        public virtual string Name { get; set; }
        public int? Ord { get; set; }





    }

    public class UpdateFeeCalcTypeDto : CreateFeeCalcTypeDto
    {
        public int Id { get; set; }
    }

    public class CheckFeeCalcTypeDto : EntityDto<int?>
    {
        public virtual string Name { get; set; }
        public int? Ord { get; set; }




    }


    public class FeeCalcTypePagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {
        public virtual int? Id { get; set; }
        public virtual string? Name { get; set; }
        public int? Ord { get; set; }

    }
}
