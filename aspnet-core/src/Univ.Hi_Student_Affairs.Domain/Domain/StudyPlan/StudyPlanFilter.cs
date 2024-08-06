using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univ.Hi_Student_Affairs.Domain.StudyPlan
{
    public class StudyPlanFilter
    {
        //وصف الخطة الدراسية        
        public string? Name { get; set; }


        //وصف الخطة الدراسية        
        public string? Description { get; set; }


        //تاريخ بداية الخطة
        public DateTime? FireDate { get; set; }


        //الترتيب
        public int? Ord { get; set; }

    }
}
