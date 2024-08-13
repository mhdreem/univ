using System;
using Volo.Abp.Application.Dtos;


namespace Univ.Hi_Student_Affairs.Dtos.StdNonSyrianUniv
{
    public class StdNonSyrianUnivDto : FullAuditedEntityDto<Guid>
    {


        public Guid? StudentId { get; set; }
        public StudentDto? Student { get; set; }
    }
}
