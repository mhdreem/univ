using System;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs.Domain
{
    public class StdNonSyrianUnivDet : Entity<Guid>
    {
        [ForeignKey("StdNonSyrianUnivId")]
        public Guid? StdNonSyrianUnivId { get; private set; }

    }
}
