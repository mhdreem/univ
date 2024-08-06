using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univ.Hi_Student_Affairs.Domain. StudyPlan;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using Volo.Abp;
using Univ.Hi_Student_Affairs.Domain.StudyPlan.Exception;
using Univ.Hi_Student_Affairs.Domain.AverageCalc.Exception;

namespace Univ.Hi_Student_Affairs
{
    public class StudyPlanManager : DomainService
    {

        private readonly IRepository< StudyPlan, int> _Repository;


        public StudyPlanManager(IRepository< StudyPlan, int> Repository)
        {
            _Repository = Repository;

        }



        public async Task< StudyPlan> CreateAsync(
            [NotNull] string name,
            [CanBeNull] string? description = null,
            [CanBeNull] DateTime? fireDate=null,
            [CanBeNull] int? ord=null
            )
        {
            Check.NotNullOrWhiteSpace(name, nameof(name));



            var Existing_Name = await _Repository.FindAsync(x => x.Name == name);
            if (Existing_Name != null)
            {
                throw new StudyPlanNameAlreadyExistsException(name);
            }


            


            return new  StudyPlan(
                0,
                name,
                description,
                fireDate,
                ord

            );
        }

        public async Task< StudyPlan> UpdateAsync(
            [NotNull] int id,
            [NotNull]  StudyPlan input
            )
        {
            Check.NotNullOrWhiteSpace(input.Name, nameof(input.Name));


            var Old = await _Repository.FindAsync(x => x.Id == id);
            if (Old == null)
            {
                throw new StudyPlanNotExistsException();
            }

            var Existing_Name = await _Repository.FindAsync(x => x.Name == input.Name && x.Id != id);
            if (Existing_Name != null)
            {
                throw new StudyPlanNameAlreadyExistsException(input.Name);
            }




            Old.Name = input.Name;
            Old.Description= input.Description;
            Old.FireDate= input.FireDate;
            Old.Ord = input.Ord;


            return Old;
        }
    }
}