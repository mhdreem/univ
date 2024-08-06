using System;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs
{

    public class Semester : BasicAggregateRoot<int>
    {
        public Semester()
        {
            NameAr = "";
        }

        public Semester(int id,string name_Ar, string? name_En, string? grade_Name_Ar, string? grade_Name_En, int? ord)
        {
            this.Id = id;
            NameAr = name_Ar ?? throw new ArgumentNullException(nameof(name_Ar));
            NameEn = name_En;
            GradeNameAr = grade_Name_Ar;
            GradeNameEn = grade_Name_En;
            Ord = ord;
        }

        //الفصل الدراسي
        public virtual string NameAr { get; set; }


        //الفصل باللغة الانكليزية
        public virtual string? NameEn { get; set; }



        //فصل الشهادة
        public virtual string? GradeNameAr { get; set; }
        public virtual string? GradeNameEn { get; set; }



        //الترتيب
        public virtual int? Ord { get; set; }




    }
}
