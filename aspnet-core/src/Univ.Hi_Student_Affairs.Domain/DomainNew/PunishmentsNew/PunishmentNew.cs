using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Univ.Hi_Student_Affairs.DomainNew.PunishmentsNew
{
    public class PunishmentNew
    : FullAuditedAggregateRoot<int>
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

        public PunishmentNew()
        {

        }
        public PunishmentNew(string name, PunishEffect punishEffect, bool univDismissal, bool zeroMark,
           int deprivationId, PunishmentType punishmentType)
        {
            Name = name;
            PunishEffect = punishEffect;
            UnivDismissal = univDismissal;
            ZeroMark = zeroMark;
            DeprivationId = deprivationId;
            PunishmentType = punishmentType;
        }
        public static PunishmentNew create(string name, PunishEffect punishEffect, bool univDismissal, bool zeroMark,
           int deprivationId, PunishmentType punishmentType)
        {
            return new PunishmentNew(name, punishEffect, univDismissal,
                zeroMark, deprivationId, punishmentType);
        }
        public void Update(string name, PunishEffect punishEffect, bool univDismissal, bool zeroMark,
          int deprivationId, PunishmentType punishmentType)
        {
            Name = name;
            PunishEffect = punishEffect;
            UnivDismissal = univDismissal;
            ZeroMark = zeroMark;
            DeprivationId = deprivationId;
            PunishmentType = punishmentType;
        }
    }

}
