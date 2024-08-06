using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace Univ.Hi_Student_Affairs
{
    public class StdRegistration : FullAuditedAggregateRoot<Guid>
    {


        public RegistrationState? RegistrationState { get; set; }


        [ForeignKey("StudentId")]
        public Guid? StudentId { get; set; }
        public Student? Student { get; set; }



        [ForeignKey("RegOrderId")]
        public Guid? RegOrderId { get; set; }
        public RegOrder? RegOrder { get; set; }



     
        public string? No { get; set; }
        public DateTime? Date { get; set; }

        public int Year { get; set; }



        //الفصل الحالي
        [ForeignKey("SemesterId")]
        public int? SemesterId { get; set; }
       
        public virtual Semester? Semester { get; set; }



        public string? Agent { get; set; }
        public string? AgentNo { get; set; }
        public string? AgentDate { get; set; }
        public string? AgentSource { get; set; }


        public Collection<StdRegStage>? StdRegStages { get; set; }

}
}
