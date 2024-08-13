using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos.CollType
{

    public class CollTypeDto : EntityDto<int>
    {

        //نوع الكلية
        public virtual string Name { get; set; }


        //الترتيب
        public virtual int? Ord { get; set; }


        //رمز الكلية بوزراة التعليم
        public virtual int? MinistryEncode { get; set; }

        public virtual string? Barcode { get; set; }



    }


    public class CreateCollTypeDto
    {

        //نوع الكلية
        public virtual string Name { get; set; }


        //الترتيب
        public virtual int? Ord { get; set; }


        //رمز الكلية بوزراة التعليم
        public virtual int? MinistryEncode { get; set; }

        public virtual string? Barcode { get; set; }



    }


    public class UpdateCollTypeDto : CreateCollTypeDto
    {
        public int Id { get; set; }

    }


    public class CheckCollTypeDto
    {
        public int? Id { get; set; }
        //نوع الكلية
        public virtual string? Name { get; set; }

        //الترتيب
        public virtual int? Ord { get; set; }

        //رمز الكلية بوزراة التعليم
        public virtual int? MinistryEncode { get; set; }

        public virtual string? Barcode { get; set; }


    }

    public class CollTypePagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {
        public virtual int? Id { get; set; }
        //نوع الكلية
        public virtual string? Name { get; set; }


        //الترتيب
        public virtual int? Ord { get; set; }


        //رمز الكلية بوزراة التعليم
        public virtual int? MinistryEncode { get; set; }

        public virtual string? Barcode { get; set; }



    }


}
