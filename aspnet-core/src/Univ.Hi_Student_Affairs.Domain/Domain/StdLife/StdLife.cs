using System;
using System.ComponentModel.DataAnnotations.Schema;
using Univ.Hi_Student_Affairs.enums;
using Volo.Abp.Domain.Entities.Auditing;

namespace Univ.Hi_Student_Affairs.Domain.StdLife
{
    public class StdLife : FullAuditedAggregateRoot<Guid>
    {

        public virtual Operation? Operation { get; private set; }



        public Guid? RefrenceID { get; private set; }



        [ForeignKey("StudentId")]
        public Guid? StudentId { get; private set; }
        public virtual Student.Student? Student { get; private set; }


        public DateTime? Date { get; private set; }

        public TimeOnly? Time { get; private set; }


        public int Ord { get; private set; }


    }
}
