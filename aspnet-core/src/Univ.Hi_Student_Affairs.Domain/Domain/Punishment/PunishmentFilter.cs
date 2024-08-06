
using System.ComponentModel.DataAnnotations.Schema;

namespace Univ.Hi_Student_Affairs
{
    public class PunishmentFilter
    {
        public string? Name { get; set; }

        public bool? PunishEffect { get; set; }

        public bool? UnivDismissal { get; set; }

        public bool? ZeroMark { get; set; }


     
        public int? DeprivationId { get; set; }
    



     
        public PunishmentType? PunishmentType { get; set; }
      

    }
}
