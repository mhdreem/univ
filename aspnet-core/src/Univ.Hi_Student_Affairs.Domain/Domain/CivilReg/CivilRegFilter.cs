using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univ.Hi_Student_Affairs
{
    public class CivilRegFilter
    {
        public string? NameAr { get; set; }
        public string? NameEn { get; set; }


     
        public int? CountryId { get; set; }
       



        
        public int? CityId { get; set; }
       



    }
}
