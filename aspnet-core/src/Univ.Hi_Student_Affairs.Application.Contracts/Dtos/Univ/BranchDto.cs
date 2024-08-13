using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos.Univ
{
    public class BranchDto : EntityDto<int>
    {

        public int? UnivId { get; set; }
        public int? UnivSectionId { get; set; }
        public int? CollageId { get; set; }
        public int? DepartmentId { get; set; }


        //اسم الاختصاص       
        public virtual string? NameAr { get; set; }
        public virtual string? NameEn { get; set; }




        //الترتيب
        public virtual int? Ord { get; set; }


        //رمز الاختصاص بوزارة التعليم
        public virtual string? Barcode { get; set; }


        //رمز المدينة بوزارة التعليم
        public int? MinistryEncode { get; set; }


    }


    public class CreateBranchDto
    {

        public int? UnivId { get; set; }
        public int? UnivSectionId { get; set; }
        public int? CollageId { get; set; }
        public int? DepartmentId { get; set; }


        //اسم الاختصاص       
        public virtual string? NameAr { get; set; }
        public virtual string? NameEn { get; set; }




        //الترتيب
        public virtual int? Ord { get; set; }


        //رمز الاختصاص بوزارة التعليم
        public virtual string? Barcode { get; set; }


        //رمز المدينة بوزارة التعليم
        public int? MinistryEncode { get; set; }


    }


    public class UpdateBranchDto : CreateBranchDto
    {
        public int Id { get; set; }

    }

    public class CheckBranchDto : EntityDto<int>
    {
        public int? UnivId { get; set; }
        public int? UnivSectionId { get; set; }
        public int? CollageId { get; set; }
        public int? DepartmentId { get; set; }


        //اسم الاختصاص       
        public virtual string? NameAr { get; set; }
        public virtual string? NameEn { get; set; }




        //الترتيب
        public virtual int? Ord { get; set; }


        //رمز الاختصاص بوزارة التعليم
        public virtual string? Barcode { get; set; }


        //رمز المدينة بوزارة التعليم
        public int? MinistryEncode { get; set; }



    }


    public class BranchPagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {

        public int? UnivId { get; set; }
        public int? UnivSectionId { get; set; }
        public int? CollageId { get; set; }
        public int? DepartmentId { get; set; }



        public virtual int? Id { get; set; }
        //اسم الاختصاص       
        public virtual string? NameAr { get; set; }
        public virtual string? NameEn { get; set; }




        //الترتيب
        public virtual int? Ord { get; set; }


        //رمز الاختصاص بوزارة التعليم
        public virtual string? Barcode { get; set; }


        //رمز المدينة بوزارة التعليم
        public int? MinistryEncode { get; set; }


    }

}
