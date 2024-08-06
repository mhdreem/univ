using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs
{
    public class Punishment : BasicAggregateRoot<int>
    {
        public string? Name { get; set; }
        
        public PunishEffect? PunishEffect { get; set; }

        public bool? UnivDismissal { get; set; }

        public bool? ZeroMark { get; set; }


        //نوع الحرمان
        [ForeignKey("Deprivation")]
        public int? DeprivationId { get; set; }
        public virtual Deprivation? Deprivation { get; set; }




      
        public PunishmentType? PunishmentType { get; set; }
     





    }
}
