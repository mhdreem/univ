using System;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs
{

    public class Class : BasicAggregateRoot<int>
    {
        public Class()
        {
            NameAr = "";
            NameEn = "";
        }

        public Class(int id,string name_Ar, string name_En, int? ord)
        {
            this.Id = id;
            NameAr = name_Ar ?? throw new ArgumentNullException(nameof(name_Ar));
            NameEn = name_En ?? throw new ArgumentNullException(nameof(name_En));
            Ord = ord;
        }

        //السنة الدراسية

        public string NameAr { get; set; }
        public string NameEn { get; set; }

        //الترتيب
        public int? Ord { get; set; }


    }
}
