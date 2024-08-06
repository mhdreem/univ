using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos.SeqResult
{
    public class SeqResultDto : EntityDto<int>
    {
        public string? NameAr { get; set; }


        public string? NameEn { get; set; }


        //الترتيب
        public int? Ord { get; set; }


    }

    public class CreateSeqResultDto 
    {
        public string? NameAr { get; set; }


        public string? NameEn { get; set; }


        //الترتيب
        public int? Ord { get; set; }


    }


    public class UpdateSeqResultDto:CreateSeqResultDto
    {
        public int? Id  { get; set; }
    }



    public class CheckSeqResultDto : EntityDto<int?>
    {

        public string? NameAr { get; set; }


        public string? NameEn { get; set; }


        //الترتيب
        public int? Ord { get; set; }



    }
    public class SeqResultPagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {
        public int? Id { get; set; }
        public string? NameAr { get; set; }


        public string? NameEn { get; set; }


        //الترتيب
        public int? Ord { get; set; }



    }
}
