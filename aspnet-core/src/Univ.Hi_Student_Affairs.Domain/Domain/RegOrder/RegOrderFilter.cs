using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univ.Hi_Student_Affairs
{
    public class RegOrderFilter
    {
        // اسم الأمر 
        public virtual string? Name { get; set; }

        public virtual RegType? RegType { get; set; }


        //الترتيب
        public virtual int? Ord { get; set; }




    }
}
