using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos.TerminationOrder
{
    public class TerminationOrderDto : EntityDto<int>
    {
        // اسم الأمر 
        public virtual string? Name { get; set; }

        public virtual TerminationType? TerminationType { get; set; }


        //الترتيب
        public virtual int? Ord { get; set; }
    }

    public class CreateTerminationOrderDto
    {
        // اسم الأمر 
        public virtual string? Name { get; set; }

        public virtual TerminationType? TerminationType { get; set; }


        //الترتيب
        public virtual int? Ord { get; set; }
    }


    public class UpdateTerminationOrderDto
    {
        public int Id { get; set; }
    }



    public class CheckTerminationOrderDto : EntityDto<int?>
    {
        // اسم الأمر 
        public virtual string? Name { get; set; }

        public virtual TerminationType? TerminationType { get; set; }


        //الترتيب
        public virtual int? Ord { get; set; }





    }

    public class TerminationOrderPagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {
        public int? Id { get; set; }
        // اسم الأمر 
        public virtual string? Name { get; set; }

        public virtual TerminationType? TerminationType { get; set; }


        //الترتيب
        public virtual int? Ord { get; set; }

    }

}
