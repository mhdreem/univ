using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos.SeqStatus
{
    public class SeqStatusDto : EntityDto<int>
    {

        //حالة الطالب
        [MaxLength(250)]
        public string? NameAr { get; set; }

        //حالة الطالب
        [MaxLength(250)]
        public string? NameEn { get; set; }


        //الترتيب
        public int? Ord { get; set; }
    }

    public class CreateSeqStatusDto
    {

        //حالة الطالب
        [MaxLength(250)]
        public string? NameAr { get; set; }

        //حالة الطالب
        [MaxLength(250)]
        public string? NameEn { get; set; }


        //الترتيب
        public int? Ord { get; set; }
    }


    public class UpdateSeqStatusDto : CreateSeqStatusDto
    {

        public int Id { get; set; }
    }


    public class CheckSeqStatusDto : EntityDto<int>
    {

        public string? NameAr { get; set; }


        public string? NameEn { get; set; }



        public int? Ord { get; set; }




    }

    public class SeqStatusPagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {
        public virtual int? Id { get; set; }

        public string? NameAr { get; set; }


        public string? NameEn { get; set; }


        //الترتيب
        public int? Ord { get; set; }


    }
}
