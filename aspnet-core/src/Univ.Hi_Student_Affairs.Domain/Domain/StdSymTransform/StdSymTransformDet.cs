using System;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs.Domain.StdSymTransform
{
    public class StdSymTransformDet : Entity<Guid>
    {

        [ForeignKey("StdSymTransformId")]
        public Guid? StdSymTransformId { get; private set; }



    }
}
