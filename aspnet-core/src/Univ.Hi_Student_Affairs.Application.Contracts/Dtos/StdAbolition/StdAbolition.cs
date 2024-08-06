using System;
using System.ComponentModel.DataAnnotations.Schema;
using Univ.Hi_Student_Affairs.Dtos.Punishment;
using Volo.Abp.Application.Dtos;


namespace Univ.Hi_Student_Affairs.Dtos.StdAbolition
{
    public class StdAbolitionDto : FullAuditedEntityDto<Guid>
    {
        //رقم قرار لجنة التظلم
        public int? No { get; set; }


        //تاريخه
        [Column(TypeName = "DATE")]
        public DateTime? Date { get; set; }



        public string? Result { get; set; }



      
        public int? PunishmentId { get; set; }
        public PunishmentDto? Punishment { get; set; }

    }


    public class CreateStdAbolitionDto 
    {
        //رقم قرار لجنة التظلم
        public int? No { get; set; }


        //تاريخه
        [Column(TypeName = "DATE")]
        public DateTime? Date { get; set; }



        public string? Result { get; set; }




        public int? PunishmentId { get; set; }
        public PunishmentDto? Punishment { get; set; }

    }


    public class UpdateStdAbolitionDto : CreateStdAbolitionDto
    {

        public Guid Id { get; set; }

    }


}
