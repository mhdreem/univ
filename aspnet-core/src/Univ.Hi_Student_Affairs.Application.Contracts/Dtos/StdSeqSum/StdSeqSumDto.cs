using System;
using System.Collections.ObjectModel;
using Univ.Hi_Student_Affairs.Dtos.Class;
using Univ.Hi_Student_Affairs.Dtos.Semester;
using Univ.Hi_Student_Affairs.Dtos.SeqResult;
using Univ.Hi_Student_Affairs.Dtos.SeqStatus;
using Univ.Hi_Student_Affairs.Dtos.StdSeqStudy;
using Univ.Hi_Student_Affairs.Dtos.Univ;
using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos.StdSeqSum
{
    public class StdSeqSumDto : FullAuditedEntityDto<Guid>
    {

        public Guid? StudentId { get; set; }
        public StudentDto? Student { get; set; }



        //العام
        public uint? Year { get; set; }


        //الكلية
        public int? UnivId { get; set; }
        
        public virtual UnivDto? Univ { get; set; }


        //الكلية
        public int? UnivSectionId { get; set; }
        
        public virtual UnivSectionDto? UnivSection { get; set; }


        //الكلية
        public int? CollageId { get; set; }
        
        public virtual CollageDto? Collage { get; set; }


        //الاختصاص
        public int? DepartmentId { get; set; }
        
        public virtual DepartmentDto? Department { get; set; }




        //القسم
        public int? BranchId { get; set; }
        
        public virtual BranchDto? Branch { get; set; }


        //السنة الدراسية الحالية
        public int? ClassId { get; set; }
        
        public virtual ClassDto? Class { get; set; }

        //الفصل الحالي
        public int? SemesterId { get; set; }

        public virtual SemesterDto? Semester { get; set; }


        public int? SeqStatusId { get; set; }
        
        public virtual SeqStatusDto? SeqStatus { get; set; }

        public int? SeqResultId { get; set; }
        
        public virtual SeqResultDto? SeqResult { get; set; }

        //مثبت
        public bool? Fixed { get; set; }


        public Collection<StdSeqStudyDto>? StdSeqStudies { get; set; }



    }
}
