using Volo.Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs
{
    public class Status : BasicAggregateRoot<int>
    {
        //حالة الطالب
        public string? NameAr { get; set; }
        public string? NameEn { get; set; }
        //الترتيب
        public int? Ord { get; set; }

    }
}
