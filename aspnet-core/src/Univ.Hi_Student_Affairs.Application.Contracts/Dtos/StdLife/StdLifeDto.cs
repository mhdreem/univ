using System;
using Univ.Hi_Student_Affairs.Dtos.Operation;
using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos.StdLife
{
    public class StdLifeDto :FullAuditedEntityDto<Guid>
    {

        public int? OperationId { get; set; }
        public virtual OperationDto? Operation { get; set; }



        public Guid? RefrenceID { get; set; }




        public Guid? StudentId { get; set; }
        public virtual StudentDto? Student { get; set; }


        public DateTime? Date { get; set; }

        public TimeSpan? Time { get; set; }


        public int Ord { get; set; }


    }
}
