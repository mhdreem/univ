using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univ.Hi_Student_Affairs.Dtos.StdAbsence;
using Volo.Abp.Application.Dtos;


namespace Univ.Hi_Student_Affairs.Dtos.StdAbsenceStage
{
    public class StdAbsenceStageDto : FullAuditedEntityDto<Guid>
    {
       
        public Guid? StdAbsenceId { get; set; }
        public StdAbsenceDto? StdAbsence { get; set; }

    }

    public class CreateStdAbsenceStageDto 
    {

        public Guid? StdAbsenceId { get; set; }
        public StdAbsenceDto? StdAbsence { get; set; }

    }

    public class UpdateStdAbsenceStageDto : CreateStdAbsenceStageDto
    {
        public Guid Id { get; set; }
    }


}
