using System;
using Volo.Abp.Application.Dtos;


namespace Univ.Hi_Student_Affairs.Dtos.StdInstitute
{
    public class StdInstituteDto : FullAuditedEntityDto<Guid>
    {

        public Guid? StudentId { get; set; }
        public StudentDto? Student { get; set; }
    }
}
