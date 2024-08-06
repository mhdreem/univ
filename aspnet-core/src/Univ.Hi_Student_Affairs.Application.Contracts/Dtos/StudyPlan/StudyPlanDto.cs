using System;
using Univ.Hi_Student_Affairs.Dtos.AverageCalc;
using Univ.Hi_Student_Affairs.Dtos.Univ;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs.Dtos.StudyPlan
{
    public  class StudyPlanDto : EntityDto<int>
    {
        //وصف الخطة الدراسية        
        public string Name { get; set; }


        //وصف الخطة الدراسية        
        public string? Description { get; set; }


        //تاريخ بداية الخطة
        public DateTime? FireDate { get; set; }
        

        //الترتيب
        public int? Ord { get; set; }


        //رقم الكلية التابعة لها الخطة        
        public virtual CollageDto Collage { get; set; }


        //طريقة حساب المعدل وهو مفتاح ثانوي لجدول Average_Calc        
        public virtual AverageCalcDto AverageCalc { get; set; }


       



    }


    public class CreateStudyPlanDto 
    {
        //وصف الخطة الدراسية        
        public string Name { get; set; }


        //وصف الخطة الدراسية        
        public string? Description { get; set; }


        //تاريخ بداية الخطة
        public DateTime? FireDate { get; set; }


        //الترتيب
        public int? Ord { get; set; }


        //رقم الكلية التابعة لها الخطة        
        public virtual CollageDto Collage { get; set; }


        //طريقة حساب المعدل وهو مفتاح ثانوي لجدول Average_Calc        
        public virtual AverageCalcDto AverageCalc { get; set; }






    }



    public class UpdateStudyPlanDto : CreateStudyPlanDto
    {
        public int Id { get; set; }


    }

    public class CheckStudyPlanDto :EntityDto<int?>
    {
        //وصف الخطة الدراسية        
        public string Name { get; set; }


        //وصف الخطة الدراسية        
        public string? Description { get; set; }


        //تاريخ بداية الخطة
        public DateTime? FireDate { get; set; }


        //الترتيب
        public int? Ord { get; set; }


        //رقم الكلية التابعة لها الخطة        
        public virtual CollageDto Collage { get; set; }


        //طريقة حساب المعدل وهو مفتاح ثانوي لجدول Average_Calc        
        public virtual AverageCalcDto AverageCalc { get; set; }







    }

    public class StudyPlanPagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {
        public virtual int? Id { get; set; }
        //وصف الخطة الدراسية        
        public string? Name { get; set; }


        //وصف الخطة الدراسية        
        public string? Description { get; set; }


        //تاريخ بداية الخطة
        public DateTime? FireDate { get; set; }


        //الترتيب
        public int? Ord { get; set; }


    }

}
