using System.Collections.ObjectModel;
using Univ.Hi_Student_Affairs.Dtos.StudyPlan;
using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos.AverageCalc
{
    public class AverageCalcDto : EntityDto<int>
    {

        //نوع التقريب
        public string? Name { get; set; }

        //شرح عن نوع التقريب        
        public string? Desc { get; set; }

        public int? Ord { get; set; }

        public virtual Collection<StudyPlanDto> StudyPlans { get; protected set; } //Sub collection





    }


    public class CreateAverageCalcDto
    {

        //نوع التقريب
        public string? Name { get; set; }

        //شرح عن نوع التقريب        
        public string? Desc { get; set; }

        public int? Ord { get; set; }

        public virtual Collection<StudyPlanDto> StudyPlans { get; protected set; } //Sub collection





    }


    public class UpdateAverageCalcDto : CreateAverageCalcDto
    {
        public int? Id { get; set; }
    }


    public class AverageCalcPagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {
        public virtual int? Id { get; set; }
        //نوع التقريب
        public string? Name { get; set; }

        //شرح عن نوع التقريب        
        public string? Desc { get; set; }

        public int? Ord { get; set; }


    }


    public class CheckAverageCalcDto : EntityDto<int?>
    {

        //نوع التقريب
        public string? Name { get; set; }

        //شرح عن نوع التقريب        
        public string? Desc { get; set; }

        public int? Ord { get; set; }


    }


}
