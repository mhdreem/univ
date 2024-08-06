using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs
{

    public class SubExamStatus :BasicAggregateRoot<int>
    {

        //حالة المادة

        public string? NameAr { get; set; }
        public string? NameEn { get; set; }

        //الترتيب
        public int? Ord { get; set; }


    }
}
