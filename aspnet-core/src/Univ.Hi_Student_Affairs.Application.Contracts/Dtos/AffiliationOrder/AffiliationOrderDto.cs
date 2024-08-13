using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos.AffiliationOrder
{
    public class AffiliationOrderDto : EntityDto<int>
    {
        public string? Name { get; set; }

        public virtual AffiliationType? AffiliationType { get; set; }

        public int? Ord { get; set; }

    }

    public class CreateAffiliationOrderDto
    {
        public string Name { get; set; }

        public virtual AffiliationType? AffiliationType { get; set; }

        public int? Ord { get; set; }

    }

    public class UpdateAffiliationOrderDto : CreateAffiliationOrderDto
    {
        public int Id { get; set; }

    }



    public class CheckAffiliationOrderDto : EntityDto<int?>
    {
        public string? Name { get; set; }

        public virtual AffiliationType? AffiliationType { get; set; }

        public int? Ord { get; set; }
    }

    public class AffiliationOrderPagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {
        public virtual int? Id { get; set; }
        public virtual string? Name { get; set; }

        public virtual AbsenceType? AbsenceType { get; set; }

        public virtual int? Ord { get; set; }

    }

}
