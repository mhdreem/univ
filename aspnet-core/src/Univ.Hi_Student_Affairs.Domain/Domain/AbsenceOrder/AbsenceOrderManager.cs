using JetBrains.Annotations;
using System.Threading.Tasks;
using Volo.Abp.Domain.Services;
using Volo.Abp;
using Volo.Abp.Domain.Repositories;
using Univ.Hi_Student_Affairs.Domain.Admission;
using System;

namespace Univ.Hi_Student_Affairs
{
    public class AbsenceOrderManager : DomainService
    {
        private readonly IRepository<AbsenceOrder, int> _Repository;
        public AbsenceOrderManager(IRepository<AbsenceOrder, int> Repository)
        {
            _Repository = Repository;
        }

        public async Task<AbsenceOrder> CreateAsync(
            [NotNull] string name,
            [NotNull] AbsenceType? AbsenceType = null,
            [CanBeNull] int? ord = null
            )
        {
            try {
                Check.NotNullOrWhiteSpace(name, nameof(name));

                var ExistingName = await _Repository.FindAsync(x => x.Name == name);
                if (ExistingName != null)
                {
                    throw new AbsenceOrderNameAlreadyExistsException(name);
                }

                var AbsenceOrder = new AbsenceOrder();
                AbsenceOrder.Name = name;
                AbsenceOrder.Ord = ord;
                AbsenceOrder.AbsenceType = AbsenceType;
                return AbsenceOrder;

            }
            catch (Exception ex)
            { }
            return null;
           


        }

        public async Task<AbsenceOrder> UpdateAsync(
            [NotNull] int id ,
            [NotNull] AbsenceOrder updateAbsenceOrder
            )
        {
            Check.NotNull(updateAbsenceOrder, nameof(updateAbsenceOrder));
            Check.NotNullOrWhiteSpace(updateAbsenceOrder.Name, nameof(updateAbsenceOrder.Name));


            var OldAbsenceOrder = await _Repository.FindAsync(x => x.Id==  id);
            if (OldAbsenceOrder == null )
            {
                throw new AbsenceOrderNotExistsException();
            }                

            var Existing_Admission_Name = await _Repository.FindAsync(x => x.Name== updateAbsenceOrder.Name && x.Id!= id);            
            if (Existing_Admission_Name != null )
            {
                throw new AbsenceOrderNameAlreadyExistsException(OldAbsenceOrder.Name);
            }


            OldAbsenceOrder.Name =  updateAbsenceOrder.Name;
            OldAbsenceOrder.Ord = updateAbsenceOrder.Ord;
            OldAbsenceOrder.AbsenceType = updateAbsenceOrder.AbsenceType;

            return OldAbsenceOrder;
        }
    }
}
