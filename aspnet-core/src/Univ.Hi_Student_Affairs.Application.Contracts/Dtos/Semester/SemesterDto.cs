using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos.Semester
{

    public class SemesterDto : EntityDto<int>
    {

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


    public class CreateSemesterDto
    {

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


    public class UpdateSemesterDto : CreateSemesterDto
    {
        public int Id { get; set; }


    }


    public class CheckSemesterDto : EntityDto<int>
    {
        //الفصل الدراسي
        public virtual string? NameAr { get; set; }


        //الفصل باللغة الانكليزية
        public virtual string? NameEn { get; set; }



        //فصل الشهادة
        public virtual string? GradeNameAr { get; set; }
        public virtual string? GradeNameEn { get; set; }



        //الترتيب
        public virtual int? Ord { get; set; }




    }


    public class SemesterPagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {
        public virtual int? Id { get; set; }
        //الفصل الدراسي
        public virtual string? NameAr { get; set; }


        //الفصل باللغة الانكليزية
        public virtual string? NameEn { get; set; }



        //فصل الشهادة
        public virtual string? GradeNameAr { get; set; }
        public virtual string? GradeNameEn { get; set; }



        //الترتيب
        public virtual int? Ord { get; set; }

    }

}
