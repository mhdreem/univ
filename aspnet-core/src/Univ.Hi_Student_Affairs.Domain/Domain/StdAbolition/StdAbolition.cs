using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace Univ.Hi_Student_Affairs
{
    public class StdAbolition : FullAuditedAggregateRoot<Guid>
    {
        //رقم قرار لجنة التظلم
        public int? No { get; set; }


        //تاريخه
        [Column(TypeName = "DATE")]
        public DateTime? Date { get; set; }



        public string? Result { get; set; }



        [ForeignKey("PunishmentId")]
        public int? PunishmentId { get; set; }
        public Punishment? Punishment { get; set; }

    }
}
