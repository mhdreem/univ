using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos.Grade
{
    public class GradeDto : EntityDto<int>
    {



        //اسم الدرجة بالعربي        
        public string NameAr { get; set; }



        //اسم الدرجة بالانكليزي        
        public string NameEn { get; set; }


        // الترتيب
        public int? Ord { get; set; }


        //الحد الأدنى
        public int? From { get; set; }


        //الحد الاعلى
        public int? To { get; set; }

    }

    public class CreateGradeDto
    {
        //اسم الدرجة بالعربي        
        public string NameAr { get; set; }



        //اسم الدرجة بالانكليزي        
        public string NameEn { get; set; }


        // الترتيب
        public int? Ord { get; set; }


        //الحد الأدنى
        public int? From { get; set; }


        //الحد الاعلى
        public int? To { get; set; }



    }

    public class UpdateGradeDto : CreateGradeDto
    {
        public int Id { get; set; }



    }

    public class CheckGradeDto : EntityDto<int?>
    {
        //اسم الدرجة بالعربي        
        public string NameAr { get; set; }



        //اسم الدرجة بالانكليزي        
        public string NameEn { get; set; }


        // الترتيب
        public int? Ord { get; set; }


        //الحد الأدنى
        public int? From { get; set; }


        //الحد الاعلى
        public int? To { get; set; }



    }

    public class GradePagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {
        public virtual int? Id { get; set; }

        //اسم الدرجة بالعربي        
        public string? NameAr { get; set; }



        //اسم الدرجة بالانكليزي        
        public string? NameEn { get; set; }


        // الترتيب
        public int? Ord { get; set; }


        //الحد الأدنى
        public int? From { get; set; }


        //الحد الاعلى
        public int? To { get; set; }
    }
}
