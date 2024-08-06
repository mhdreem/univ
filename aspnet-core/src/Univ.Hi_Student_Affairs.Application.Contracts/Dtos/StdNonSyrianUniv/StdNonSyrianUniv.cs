using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;


namespace Univ.Hi_Student_Affairs.Dtos.StdNonSyrianUniv
{
    public class StdNonSyrianUnivDto : FullAuditedEntityDto<Guid>
    {

     
        public Guid? StudentId { get; set; }
        public StudentDto? Student { get; set; }
    }
}
