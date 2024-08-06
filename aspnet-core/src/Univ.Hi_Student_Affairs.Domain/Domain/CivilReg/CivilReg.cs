using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs
{
    public class CivilReg :BasicAggregateRoot<int>
    {
        public string? NameAr { get; set; }
        public string? NameEn { get; set; }


        [ForeignKey("CountryId")]
        public int? CountryId { get; set; }
        public virtual Country? Country { get; set; }



        [ForeignKey("CityId")]
        public int? CityId { get; set; }
        public virtual City? City { get; set; }

    }
}
