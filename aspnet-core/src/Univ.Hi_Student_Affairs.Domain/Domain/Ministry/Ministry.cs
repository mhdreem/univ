using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs
{
    public  class Ministry : BasicAggregateRoot<int>
    {
        public string? NameAr { get; set; }
        public string? NameEn { get; set; }





    }
}
