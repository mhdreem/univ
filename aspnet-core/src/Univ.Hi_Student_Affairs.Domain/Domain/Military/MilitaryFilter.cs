using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univ.Hi_Student_Affairs
{
    public class MilitaryFilter
    {
        public string? NameAr { get; set; }
        public string? NameEn { get; set; }




        [ForeignKey("CityId")]
        public int? CityId { get; set; }
        public virtual City? City { get; set; }




    }
}
