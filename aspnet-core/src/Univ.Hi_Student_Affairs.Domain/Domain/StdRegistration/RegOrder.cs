using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs.Domain.StdRegistration
{
    public class RegOrder : Entity<int>
    {
        // اسم الأمر 
        public virtual string? Name { get; private set; }

        public virtual RegType? RegType { get; private set; }


        //الترتيب
        public virtual int? Ord { get; private set; }

    }
}
