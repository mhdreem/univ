
namespace Univ.Hi_Student_Affairs
{
    public class TerminationOrderFilter
    {
        // اسم الأمر 
        public virtual string? Name { get; set; }

        public virtual TerminationType? TerminationType { get; set; }


        //الترتيب
        public virtual int? Ord { get; set; }



    }
}
