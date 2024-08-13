using System;
using System.ComponentModel.DataAnnotations;
using Univ.Hi_Student_Affairs.Dtos.Class;
using Univ.Hi_Student_Affairs.Dtos.Semester;
using Univ.Hi_Student_Affairs.Dtos.SeqResult;
using Univ.Hi_Student_Affairs.Dtos.Status;
using Univ.Hi_Student_Affairs.Dtos.Univ;
using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos.StdSeqStudy
{
    public class StdSeqStudyDto : FullAuditedEntityDto<Guid>
    {

        public Guid? StudentId { get; set; }
        public StudentDto? Student { get; set; }



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




        //الحالة
        public int? StatusId { get; set; }

        public virtual StatusDto? Status { get; set; }



        //منيجة الطالب
        public int? SeqResultId { get; set; }

        public virtual SeqResultDto? SeqResult { get; set; }





        //مشترك بالامتحان ام لا
        public bool? TakeSemesterExam { get; set; }


        //ملاحظات
        [MaxLength(250)]
        public string? Note { get; set; }

        //الفصل محتسب ام لا
        public bool? IsSemesterCounted { get; set; }




        //مثبت
        public bool? SEQ_CANCEL_CHEK { get; set; }



    }
}
