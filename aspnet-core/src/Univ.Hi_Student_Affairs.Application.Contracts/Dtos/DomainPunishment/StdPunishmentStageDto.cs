using System;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos.DomainPunishment
{
    public class StdPunishmentStageDto : EntityDto<Guid?>
    {


        public virtual int PunishmentStageId { get; set; }
        public virtual PunishmentStageDto? PunishmentStage { get; set; }






        public virtual Guid? StdPunishmentId { get; set; }
        public virtual StdPunishmentDto? StdPunishment { get; set; }



        //العقوبة من المرحلة
        public int PunishmentId { get; set; }
        public PunishmentDto? Punishment { get; set; }





        //رقم قرار العقوبة
        public string? No { get; set; }


        //تاريخ قرار العقوبة
        [Column(TypeName = "DATE")]
        public DateTime? Date { get; set; }


        public string? Note { get; set; }
    }


    public class CreateStdPunishmentStageDto
    {


        public virtual int PunishmentStageId { get; set; }
        public virtual PunishmentStageDto? PunishmentStage { get; set; }






        public virtual Guid? StdPunishmentId { get; set; }
        public virtual StdPunishmentDto? StdPunishment { get; set; }



        //العقوبة من المرحلة

        public int PunishmentId { get; set; }
        public PunishmentDto? Punishment { get; set; }





        //رقم قرار العقوبة
        public string? No { get; set; }


        //تاريخ قرار العقوبة
        [Column(TypeName = "DATE")]
        public DateTime? Date { get; set; }


        public string? Note { get; set; }
    }


    public class UpdateStdPunishmentStageDto : CreateStdPunishmentStageDto
    {
        public Guid Id { get; set; }

    }

}
