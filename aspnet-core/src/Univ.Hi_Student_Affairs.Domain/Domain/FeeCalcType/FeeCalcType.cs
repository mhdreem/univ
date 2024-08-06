using System;
using System.Collections.ObjectModel;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs
{
    public class FeeCalcType : BasicAggregateRoot<int>
    {
        public virtual string Name { get; set; }
        public int? Ord { get; set; }

        public virtual Collection<Admission>? Admissions { get; protected set; } //Sub collection


        public FeeCalcType()
        {
            Name = "";
            Admissions = new Collection<Admission>();
        }


        public FeeCalcType(int id ,string Name, int? Ord)
        {
            this.Id= id;
            this.Name = Name;
            this.Ord = Ord;
            Admissions = new Collection<Admission>();
        }

       
    }
}
