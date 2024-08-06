using JetBrains.Annotations;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using Volo.Abp;
using System.ComponentModel.DataAnnotations.Schema;
using Univ.Hi_Student_Affairs.Domain;

namespace Univ.Hi_Student_Affairs
{
    public class PunishmentReasonManager : DomainService
    {

        private readonly IRepository<PunishmentReason, int> _Repository;


        public PunishmentReasonManager(IRepository<PunishmentReason, int> Repository)
        {
            _Repository = Repository;

        }



        public async Task<PunishmentReason> CreateAsync(
            [NotNull] string? Name
            )
        {
            Check.NotNullOrWhiteSpace(Name, nameof(Name));
            

            var ExistingName = await _Repository.FindAsync(x => x.Name == Name);
            if (ExistingName != null)
            {
                throw new PunishmentReasonNameAlreadyExistsException(Name);
            }





            var PunishmentReason  = new PunishmentReason();
            PunishmentReason.Name = Name;
         

            return PunishmentReason;

        }

        public async Task<PunishmentReason> UpdateAsync(
            [NotNull] int id,
            [NotNull] PunishmentReason input
            )
        {
            Check.NotNull(input, nameof(input));
            Check.NotNullOrWhiteSpace(input.Name, nameof(input.Name));



            var Old = await _Repository.FindAsync(x => x.Id == id);
            if (Old== null)
            {
                throw new PunishmentReasonNotExistsException();
            }

            var Existing_Name = await _Repository.FindAsync(x => x.Name == input.Name && x.Id != id);
            if (Existing_Name != null)
            {
                throw new PunishmentReasonNameAlreadyExistsException(input.Name);
            }



            Old.Name = input.Name;
        

            return Old;
        }
    }
}