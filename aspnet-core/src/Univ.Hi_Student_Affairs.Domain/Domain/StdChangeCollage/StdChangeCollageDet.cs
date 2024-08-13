using System;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs.Domain.StdChangeCollage
{
    public class StdChangeCollageDet : Entity<Guid>
    {
        [ForeignKey("StdChangeCollageId")]
        public Guid? StdChangeCollageId { get; private set; }


    }
}
