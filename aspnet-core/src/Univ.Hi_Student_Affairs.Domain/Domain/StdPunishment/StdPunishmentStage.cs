using System;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;
namespace Univ.Hi_Student_Affairs
{
    public  class StdPunishmentStage : FullAuditedAggregateRoot<Guid>
    {

        [ForeignKey("PunishmentStageId")]
        public virtual int? PunishmentStageId { get; set; }
        public virtual PunishmentStage? PunishmentStage { get; set; }




      
        [ForeignKey("StdPunishmentId")]
        public virtual int? StdPunishmentId { get; set; }
        public virtual StdPunishment? StdPunishment { get; set; }



        //العقوبة من المرحلة
        [ForeignKey("PunishmentId")]
        public int? PunishmentId { get; set; }
        public Punishment? Punishment { get; set; }





        //رقم قرار العقوبة
        public string? No { get; set; }


        //تاريخ قرار العقوبة
        [Column(TypeName = "DATE")]
        public DateTime? Date { get; set; }


        public string? Note { get; set; }
    }
}
