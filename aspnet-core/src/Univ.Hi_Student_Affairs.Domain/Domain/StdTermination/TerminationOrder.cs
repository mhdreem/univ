using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs.Domain.StdTermination
{
    public class TerminationOrder : Entity<int>
    {
        // اسم الأمر 
        public virtual string? Name { get; private set; }

        public virtual TerminationType? TerminationType { get; private set; }


        //الترتيب
        public virtual int? Ord { get; private set; }

    }
}

