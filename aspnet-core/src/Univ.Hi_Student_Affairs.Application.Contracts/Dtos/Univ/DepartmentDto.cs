using System.Collections.ObjectModel;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs.Dtos.Univ
{

    public class DepartmentDto : EntityDto<int>
    {

        public int? UnivId { get; set; }
        public int? UnivSectionId { get; set; }
        public int? CollageId { get; set; }
       


        //اسم القسم

        public virtual string? NameAr { get; set; }
        public virtual string? NameEn { get; set; }




        //الترتيب
        public virtual int? Ord { get; set; }

        //اسم القسم باللغة الانكليزية



        //اسم القسم بالاجازة الممنوحة للطالب

        public virtual string? DegreeNameAr { get; set; }
        public virtual string? DegreeNameEn { get; set; }


        //رمز القسم بوزراة التعليم
        public virtual int? MinistryEncode { get; set; }


        //رمز القسم بوزراة التعليم
        public virtual string? Barcode { get; set; }

        public virtual Collection<BranchDto>? Branchs { get; set; }


      
    }


    public class CreateDepartmentDto 
    {

        public int? UnivId { get; set; }
        public int? UnivSectionId { get; set; }
        public int? CollageId { get; set; }



        //اسم القسم

        public virtual string? NameAr { get; set; }
        public virtual string? NameEn { get; set; }




        //الترتيب
        public virtual int? Ord { get; set; }

        //اسم القسم باللغة الانكليزية



        //اسم القسم بالاجازة الممنوحة للطالب

        public virtual string? DegreeNameAr { get; set; }
        public virtual string? DegreeNameEn { get; set; }


        //رمز القسم بوزراة التعليم
        public virtual int? MinistryEncode { get; set; }


        //رمز القسم بوزراة التعليم
        public virtual string? Barcode { get; set; }

        public virtual Collection<BranchDto>? Branchs { get; set; }



    }


    public class UpdateDepartmentDto : CreateDepartmentDto
    {
        public int Id { get; set; } 
    }

    public class CheckDepartmentDto : EntityDto<int?>
    {
        public int? UnivId { get; set; }
        public int? UnivSectionId { get; set; }
        public int? CollageId { get; set; }



        //اسم القسم

        public virtual string? NameAr { get; set; }
        public virtual string? NameEn { get; set; }




        //الترتيب
        public virtual int? Ord { get; set; }

        //اسم القسم باللغة الانكليزية



        //اسم القسم بالاجازة الممنوحة للطالب

        public virtual string? DegreeNameAr { get; set; }
        public virtual string? DegreeNameEn { get; set; }


        //رمز القسم بوزراة التعليم
        public virtual int? MinistryEncode { get; set; }


        //رمز القسم بوزراة التعليم
        public virtual string? Barcode { get; set; }

     


    }

    public class DepartmentPagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {

        public int? UnivId { get; set; }
        public int? UnivSectionId { get; set; }
        public int? CollageId { get; set; }
        public int? DepartmentId { get; set; }



        public virtual int? Id { get; set; }
        //اسم القسم

        public virtual string? NameAr { get; set; }
        public virtual string? NameEn { get; set; }




        //الترتيب
        public virtual int? Ord { get; set; }

        //اسم القسم باللغة الانكليزية



        //اسم القسم بالاجازة الممنوحة للطالب

        public virtual string? DegreeNameAr { get; set; }
        public virtual string? DegreeNameEn { get; set; }


        //رمز القسم بوزراة التعليم
        public virtual int? MinistryEncode { get; set; }


        //رمز القسم بوزراة التعليم
        public virtual int? Barcode { get; set; }


    }


}
