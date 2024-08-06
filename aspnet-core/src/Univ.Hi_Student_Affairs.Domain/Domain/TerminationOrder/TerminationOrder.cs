using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs
{
    public class TerminationOrder : BasicAggregateRoot<int>
    {
        // اسم الأمر 
        public virtual string? Name { get; set; }

        public virtual TerminationType? TerminationType { get; set; }


        //الترتيب
        public virtual int? Ord { get; set; }

    }
}

