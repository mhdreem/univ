using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace Univ.Hi_Student_Affairs
{
    public class StdLife : FullAuditedAggregateRoot<Guid>
    {
        [ForeignKey("OperationId")]
        public int? OperationId { get; set; }
        public virtual Operation? Operation { get; set; }



        public Guid? RefrenceID { get; set; }



        [ForeignKey("StudentId")]
        public Guid? StudentId { get; set; }
        public virtual Student? Student { get; set; }


        public DateTime? Date { get; set; }

        public TimeOnly? Time { get; set; }


        public int Ord { get; set; }


    }
}
