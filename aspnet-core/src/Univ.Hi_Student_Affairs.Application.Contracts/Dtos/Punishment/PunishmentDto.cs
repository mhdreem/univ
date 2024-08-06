using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos.Punishment
{
    public class PunishmentDto : EntityDto<int>
    {
        public string Name { get; set; } = "";

        public PunishEffect? PunishEffect { get; set; }

        public bool? UnivDismissal { get; set; }

        public bool? ZeroMark { get; set; }


       
        public int? DeprivationId { get; set; }
       



        public PunishmentType? PunishmentType { get; set; }





    }

    public class CreatePunishmentDto 
    {
        public string Name { get; set; } = "";

        public PunishEffect? PunishEffect { get; set; }

        public bool? UnivDismissal { get; set; }

        public bool? ZeroMark { get; set; }



        public int? DeprivationId { get; set; }




        public PunishmentType? PunishmentType { get; set; }





    }

    public class UpdatePunishmentDto : CreatePunishmentDto
    {

        public int Id { get; set; }





    }

    public class CheckPunishmentDto : EntityDto<int?>
    {
        public string? Name { get; set; }

        public PunishEffect? PunishEffect { get; set; }

        public bool? UnivDismissal { get; set; }

        public bool? ZeroMark { get; set; }



        public int? DeprivationId { get; set; }




        public PunishmentType? PunishmentType { get; set; }




    }


    public class PunishmentPagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {
        public int? Id { get; set; }
        public string? Name { get; set; }

        public PunishEffect? PunishEffect { get; set; }

        public bool? UnivDismissal { get; set; }

        public bool? ZeroMark { get; set; }



        public int? DeprivationId { get; set; }




        public PunishmentType? PunishmentType { get; set; }


    }

}
