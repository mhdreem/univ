using JetBrains.Annotations;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using Volo.Abp;
using Univ.Hi_Student_Affairs.Domain.CivilReg.Exception;
using Univ.Hi_Student_Affairs.Domain;
using System.Security.Cryptography;


namespace Univ.Hi_Student_Affairs
{
    public class RegOrderManager : DomainService
    {

        private readonly IRepository<RegOrder, int> _Repository;


        public RegOrderManager(IRepository<RegOrder, int> Repository)
        {
            _Repository = Repository;

        }



        public async Task<RegOrder> CreateAsync(
            [NotNull] string? Name,     
            [CanBeNull] RegType? RegType = null,           
            [CanBeNull] int? Ord = null
            )
        {
            Check.NotNullOrWhiteSpace(Name, nameof(Name));
            

            var Existing_Admission_Name= await _Repository.FindAsync(x => x.Name== Name);
            if (Existing_Admission_Name!= null)
            {
                throw new RegOrderNameAlreadyExistsException(Name);
            }





            var RegOrder  = new RegOrder();
            RegOrder.Name= Name;
            RegOrder.Ord = Ord;
            RegOrder.RegType = RegType;

            return RegOrder;

        }

        public async Task<RegOrder> UpdateAsync(
            [NotNull] int id,
            [NotNull] RegOrder input
            )
        {
            Check.NotNull(input, nameof(input));
            Check.NotNullOrWhiteSpace(input.Name, nameof(input.Name));



            var Old = await _Repository.FindAsync(x => x.Id == id);
            if (Old== null)
            {
                throw new RegOrderNotExistsException();
            }

            var Existing_Name= await _Repository.FindAsync(x => x.Name== input.Name&& x.Id != id);
            if (Existing_Name!= null)
            {
                throw new RegOrderNameAlreadyExistsException(input.Name);
            }



            Old.Name= input.Name;
            Old.Ord = input.Ord;
            Old.RegType= input.RegType;


            return Old;
        }
    }
}