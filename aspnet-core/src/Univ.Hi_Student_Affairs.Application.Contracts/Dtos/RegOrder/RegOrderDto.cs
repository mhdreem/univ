using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos.RegOrder
{
    public class RegOrderDto : EntityDto<int>
    {
        // اسم الأمر 
        public virtual string? Name { get; set; }

        public virtual RegType? RegType { get; set; }


        //الترتيب
        public virtual int? Ord { get; set; }
    }

    public class CreateRegOrderDto 
    {
        // اسم الأمر 
        public virtual string? Name { get; set; }

        public virtual RegType? RegType { get; set; }


        //الترتيب
        public virtual int? Ord { get; set; }
    }

    public class UpdateRegOrderDto : CreateRegOrderDto
    {
        public int Id{ get; set; }
    }



    public class CheckRegOrderDto : EntityDto<int?>
    {

        // اسم الأمر 
        public virtual string? Name { get; set; }

        public virtual RegType? RegType { get; set; }


        //الترتيب
        public virtual int? Ord { get; set; }


    }

    public class RegOrderPagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {
        public int Id { get; set; }
        public virtual string? Name { get; set; }

        public virtual RegType? RegType { get; set; }


        //الترتيب
        public virtual int? Ord { get; set; }

    }
}
