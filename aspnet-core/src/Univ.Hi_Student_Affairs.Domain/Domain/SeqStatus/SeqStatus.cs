using System.ComponentModel.DataAnnotations;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs
{

    public class SeqStatus : BasicAggregateRoot<int>
    {

        //حالة الطالب
        [MaxLength(250)]
        public string? NameAr{ get; set; }

        //حالة الطالب
        [MaxLength(250)]
        public string? NameEn { get; set; }


        //الترتيب
        public int? Ord { get; set; }


    }
}
