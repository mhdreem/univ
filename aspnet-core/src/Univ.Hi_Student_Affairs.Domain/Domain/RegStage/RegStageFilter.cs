using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univ.Hi_Student_Affairs
{
    public class RegStageFilter
    {
        public string? Name { get; set; }

        public StageState? StageState { get; set; }

        public int? Ord { get; set; }

    }
}
