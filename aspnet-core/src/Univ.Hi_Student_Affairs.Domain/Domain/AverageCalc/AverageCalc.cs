using System.Collections.ObjectModel;
using System.Xml.Linq;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs
{
    public  class AverageCalc : BasicAggregateRoot<int>
    {
        //نوع التقريب
        public string Name { get; set; }

        //شرح عن نوع التقريب        
        public string? Desc { get; set; }

        public int? Ord { get; set; }

        public virtual Collection<StudyPlan>? StudyPlans { get; protected set; } //Sub collection


        public AverageCalc() {
            Name = "";
            this.StudyPlans = new Collection<StudyPlan>();
        }

        public AverageCalc(int id,string name,string? desc,int? ord )
        {
            this.Id = id;
            this.Name = name;   
            this.Desc = desc;   
            this.Ord = ord;
            this.StudyPlans = new Collection<StudyPlan>();
        }


    }
}
