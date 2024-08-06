using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Application.Dtos;


namespace Univ.Hi_Student_Affairs.Dtos.Univ
{
    public class CollageDto : EntityDto<int>
    {

       
        public int? UnivSectionId { get; set; }
       


        //اسم الكلية 
        public virtual string? NameAr { get; set; }

        //اسم الكلية 
        public virtual string? NameEn { get; set; }


        //اسم العميد
        public virtual string? DeanAr { get; set; }
        public virtual string? DeanEn { get; set; }




        //عدد السنوات الدراسية 
        public virtual int? NumYear { get; set; }







        //الترتيب
        public virtual int? Ord { get; set; }




        //اسم الاجازة الممنوحة للطالب
        public virtual string? DegreeNameAr { get; set; }


        //اسم الاجازة الممنوحة للطالب باللغة الانكليزية
        public virtual string? DegreeNameEn { get; set; }



        //رمز الكلية بوزراة التعليم
        public virtual int? MinistryEncode { get; set; }


        //رمز الكلية بوزراة التعليم
        public virtual string? Barcode { get; set; }

        public virtual int? CollTypeId { get; set; }


        public virtual Collection<DepartmentDto>? Departments { get; set; } //sub collection










    }


    public class CreateCollageDto 
    {


        public int? UnivSectionId { get; set; }



        //اسم الكلية 
        public virtual string? NameAr { get; set; }

        //اسم الكلية 
        public virtual string? NameEn { get; set; }


        //اسم العميد
        public virtual string? DeanAr { get; set; }
        public virtual string? DeanEn { get; set; }




        //عدد السنوات الدراسية 
        public virtual int? NumYear { get; set; }







        //الترتيب
        public virtual int? Ord { get; set; }




        //اسم الاجازة الممنوحة للطالب
        public virtual string? DegreeNameAr { get; set; }


        //اسم الاجازة الممنوحة للطالب باللغة الانكليزية
        public virtual string? DegreeNameEn { get; set; }



        //رمز الكلية بوزراة التعليم
        public virtual int? MinistryEncode { get; set; }


        //رمز الكلية بوزراة التعليم
        public virtual string? Barcode { get; set; }

        public virtual int? CollTypeId { get; set; }


        public virtual Collection<DepartmentDto>? Departments { get; set; } //sub collection










    }


    public class UpdateCollageDto : CreateCollageDto
    {
        public int Id { get; set; }
    }


    public class CheckCollageDto : EntityDto<int?>
    {
       
        public int? UnivSectionId { get; set; }



        //اسم الكلية 
        public virtual string? NameAr { get; set; }

        //اسم الكلية 
        public virtual string? NameEn { get; set; }


        //اسم العميد
        public virtual string? DeanAr { get; set; }
        public virtual string? DeanEn { get; set; }




        //عدد السنوات الدراسية 
        public virtual int? NumYear { get; set; }







        //الترتيب
        public virtual int? Ord { get; set; }




        //اسم الاجازة الممنوحة للطالب
        public virtual string? DegreeNameAr { get; set; }


        //اسم الاجازة الممنوحة للطالب باللغة الانكليزية
        public virtual string? DegreeNameEn { get; set; }



        //رمز الكلية بوزراة التعليم
        public virtual int? MinistryEncode { get; set; }


        //رمز الكلية بوزراة التعليم
        public virtual string? Barcode { get; set; }

        public virtual int? CollTypeId { get; set; }


        public virtual Collection<DepartmentDto>? Departments { get; set; } //sub collection



    }

    public class CollagePagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {

        public int? UnivId { get; set; }
        public int? UnivSectionId { get; set; }
        public int? CollageId { get; set; }
        public int? DepartmentId { get; set; }



        public virtual int? Id { get; set; }
        //اسم الكلية 
        public virtual string? NameAr { get; set; }

        //اسم الكلية 
        public virtual string? NameEn { get; set; }


        //اسم العميد
        public virtual string? DeanAr { get; set; }
        public virtual string? DeanEn { get; set; }




        //عدد السنوات الدراسية 
        public virtual int? NumYear { get; set; }







        //الترتيب
        public virtual int? Ord { get; set; }




        //اسم الاجازة الممنوحة للطالب
        public virtual string? DegreeNameAr { get; set; }


        //اسم الاجازة الممنوحة للطالب باللغة الانكليزية
        public virtual string? DegreeNameEn { get; set; }



        //رمز الكلية بوزراة التعليم
        public virtual int? MinistryEncode { get; set; }


        //رمز الكلية بوزراة التعليم
        public virtual string? Barcode { get; set; }


    }
}
