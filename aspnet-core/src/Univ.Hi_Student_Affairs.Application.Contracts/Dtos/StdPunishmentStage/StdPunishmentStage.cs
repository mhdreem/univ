using System;
using System.ComponentModel.DataAnnotations.Schema;
using Univ.Hi_Student_Affairs.Dtos.Punishment;
using Univ.Hi_Student_Affairs.Dtos.PunishmentStage;
using Univ.Hi_Student_Affairs.Dtos.StdPunishment;
using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos.StdPunishmentStage
{
    public class StdPunishmentStageDto : FullAuditedEntityDto<Guid>
    {


        public virtual int? PunishmentStageId { get; set; }
        public virtual PunishmentStageDto? PunishmentStage { get; set; }






        public virtual int? StdPunishmentId { get; set; }
        public virtual StdPunishmentDto? StdPunishment { get; set; }



        //العقوبة من المرحلة

        public int? PunishmentId { get; set; }
        public PunishmentDto? Punishment { get; set; }





        //رقم قرار العقوبة
        public string? No { get; set; }


        //تاريخ قرار العقوبة
        [Column(TypeName = "DATE")]
        public DateTime? Date { get; set; }


        public string? Note { get; set; }
    }
}
