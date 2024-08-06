using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univ.Hi_Student_Affairs
{
    public class DeprivationFilter
    {
        public string? Name { get; set; }

        public int? Number { get; set; }

        public DeprivationType? DeprivationType { get; set; }

    }
}
