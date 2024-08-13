using System;
using System.Collections.ObjectModel;
using Univ.Hi_Student_Affairs.Dtos.AffiliationOrder;
using Univ.Hi_Student_Affairs.Dtos.Semester;
using Volo.Abp.Application.Dtos;


namespace Univ.Hi_Student_Affairs.Dtos.StdAffiliation
{
    public class StdAffiliationDto : FullAuditedEntityDto<Guid>
    {


        public AffiliationState? AffiliationState { get; set; }



        public Guid? StudentId { get; set; }
        public StudentDto? Student { get; set; }




        public Guid? AffiliationOrderId { get; set; }
        public AffiliationOrderDto? AffiliationOrder { get; set; }



        public int? Year { get; set; }


        //الفصل الحالي
        public int? SemesterId { get; set; }

        public virtual SemesterDto? Semester { get; set; }


        public string? Note { get; set; }


        public Collection<StdAffiliationStageDto>? StdAffiliationStages { get; set; }

    }
}
