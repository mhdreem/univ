using JetBrains.Annotations;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using Volo.Abp;
using Univ.Hi_Student_Affairs.Domain;
using System.ComponentModel.DataAnnotations.Schema;

namespace Univ.Hi_Student_Affairs
{
    public class PunishmentManager : DomainService
    {

        private readonly IRepository<Punishment, int> _Repository;


        public PunishmentManager(IRepository<Punishment, int> Repository)
        {
            _Repository = Repository;

        }

        

        public async Task<Punishment> CreateAsync(
        [NotNull] string? Name,
        [CanBeNull] PunishEffect? PunishEffect,
        [CanBeNull] bool? UnivDismissal,
        [CanBeNull] bool? ZeroMark,
        [CanBeNull] int? DeprivationId,
        PunishmentType? PunishmentType
            )
        {
            Check.NotNullOrWhiteSpace(Name, nameof(Name));
            


            var ExistingName = await _Repository.FindAsync(x => x.Name == Name);
            if (ExistingName != null)
            {
                throw new PunishmentNameAlreadyExistsException(Name);
            }

            var Punishment  = new Punishment();
            Punishment.Name = Name;
            Punishment.PunishEffect = PunishEffect;
            Punishment.UnivDismissal = UnivDismissal;
            Punishment.ZeroMark = ZeroMark;
            Punishment.DeprivationId = DeprivationId;
            Punishment.PunishmentType = PunishmentType;
            



            return Punishment;

        }

        public async Task<Punishment> UpdateAsync(
            [NotNull] int id,
            [NotNull] Punishment input
            )
        {
            Check.NotNull(input, nameof(input));
            Check.NotNullOrWhiteSpace(input.Name, nameof(input.Name));



            var Old = await _Repository.FindAsync(x => x.Id == id);
            if (Old== null)
            {
                throw new PunishmentNotExistsException();
            }

            var ExistingName = await _Repository.FindAsync(x => x.Name == input.Name && x.Id != id);
            if (ExistingName != null)
            {
                throw new PunishmentNameAlreadyExistsException(input.Name);
            }





            Old.Name = input.Name;
            Old.PunishEffect = input.PunishEffect;
            Old.UnivDismissal = input.UnivDismissal;
            Old.ZeroMark = input.ZeroMark;
            Old.DeprivationId = input.DeprivationId;
            Old.PunishmentType = input.PunishmentType;


            return Old;
        }
    }
}