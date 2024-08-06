using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univ.Hi_Student_Affairs.Domain.IdentifierType
{
    public class IdentifierTypeFilter
    {
        public int? Id { get; set; }
        //الاسم بالعربي
        public string? NameAr { get; set; }
        //الاسم بالانكليزي
        public string? NameEn { get; set; }

        //الترتيب
        public int? Ord { get; set; }
    }
}
