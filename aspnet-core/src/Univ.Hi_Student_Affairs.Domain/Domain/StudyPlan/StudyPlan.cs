using System;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs
{
    public  class StudyPlan : BasicAggregateRoot<int>
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
        [ForeignKey("CollageId")]
        public virtual  int? CollageId { get; set; }
        public virtual Collage? Collage { get; set; }



        //طريقة حساب المعدل وهو مفتاح ثانوي لجدول Average_Calc        
        public virtual AverageCalc AverageCalc { get; set; }


        public StudyPlan()
        {
            this.Name = "";
            this.Collage = new Collage();
            this.AverageCalc = new AverageCalc();
        }

        public StudyPlan(int Id, string name, string? description, DateTime? fireDate, int? ord, Collage collage, AverageCalc averageCalc)
        {
            this.Id = Id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Description = description;
            FireDate = fireDate;
            Ord = ord;
            Collage = collage ?? throw new ArgumentNullException(nameof(collage));
            AverageCalc = averageCalc ?? throw new ArgumentNullException(nameof(averageCalc));
        }


        public StudyPlan(int Id, string name, string? description, DateTime? fireDate, int? ord)
        {
            this.Id = Id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Description = description;
            FireDate = fireDate;
            Ord = ord;
            this.Collage = new Collage();
            this.AverageCalc = new AverageCalc();

        }

    }
}
