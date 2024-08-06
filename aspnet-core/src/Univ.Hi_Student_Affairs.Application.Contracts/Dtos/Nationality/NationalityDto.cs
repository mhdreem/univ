using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs.Dtos.Nationality
{

    public class NationalityDto : EntityDto<int>
    {

        //اسم الجنسية

        public string NameAr { get; set; }


        //اسم الجنسية باللغة الانكليزية

        public string NameEn { get; set; }




        //الترتيب
        public int? Ord { get; set; }


        //رمز الجنسية بوزارة التعليم
        public int? MinistryEncode { get; set; }


        public virtual string? Barcode { get; set; }


    }

    public class CreateNationalityDto 
    {

        //اسم الجنسية

        public string NameAr { get; set; }


        //اسم الجنسية باللغة الانكليزية

        public string NameEn { get; set; }




        //الترتيب
        public int? Ord { get; set; }


        //رمز الجنسية بوزارة التعليم
        public int? MinistryEncode { get; set; }


        public virtual string? Barcode { get; set; }


    }

    public class UpdateNationalityDto : CreateNationalityDto
    {
        public int Id{ get; set; }
    }

    public class CheckNationalityDto
    {
        public int? id { get; set; }
        //اسم الجنسية

        public string nameAr { get; set; }


        //اسم الجنسية باللغة الانكليزية

        public string nameEn { get; set; }




        //الترتيب
        public int? ord { get; set; }


        //رمز الجنسية بوزارة التعليم
        public int? ministryEncode { get; set; }


        public virtual string? barcode { get; set; }



    }


    public class NationalityPagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {
        public virtual int? Id { get; set; }
        //اسم الجنسية

        public string? NameAr { get; set; }


        //اسم الجنسية باللغة الانكليزية

        public string? NameEn { get; set; }




        //الترتيب
        public int? Ord { get; set; }


        //رمز الجنسية بوزارة التعليم
        public int? MinistryEncode { get; set; }


        public virtual string? Barcode { get; set; }
    }


}
