using System;
using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos.StdPhoto
{
    public class StdPhotoDto : FullAuditedEntityDto<Guid>
    {

        public Guid? StudentId { get; set; }

        public byte[]? Data { get; set; }
    }

}
