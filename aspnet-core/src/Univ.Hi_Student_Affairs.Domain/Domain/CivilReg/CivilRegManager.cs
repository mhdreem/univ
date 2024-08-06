using JetBrains.Annotations;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using Volo.Abp;
using System.ComponentModel.DataAnnotations.Schema;
using Univ.Hi_Student_Affairs.Domain.CivilReg.Exception;

namespace Univ.Hi_Student_Affairs
{
    public class CivilRegManager : DomainService
    {

        private readonly IRepository<CivilReg, int> _Repository;


        public CivilRegManager(IRepository<CivilReg, int> Repository)
        {
            _Repository = Repository;

        }



        public async Task<CivilReg> CreateAsync(
            [NotNull] string? NameAr,
            [CanBeNull] string? NameEn = null,
            [CanBeNull] int? CountryId = null,           
            [CanBeNull] int? CityId = null
            )
        {
            Check.NotNullOrWhiteSpace(NameAr, nameof(NameAr));
            

            var Existing_Admission_NameAr = await _Repository.FindAsync(x => x.NameAr == NameAr);
            if (Existing_Admission_NameAr != null)
            {
                throw new CivilRegNameArAlreadyExistsException(NameAr);
            }





            var CivilReg  = new CivilReg();
            CivilReg.NameAr = NameAr;
            CivilReg.NameEn = NameEn;
            CivilReg.CityId = CityId;
            CivilReg.CountryId = CountryId;

            return CivilReg;

        }

        public async Task<CivilReg> UpdateAsync(
            [NotNull] int id,
            [NotNull] CivilReg input
            )
        {
            Check.NotNull(input, nameof(input));
            Check.NotNullOrWhiteSpace(input.NameAr, nameof(input.NameAr));



            var Old = await _Repository.FindAsync(x => x.Id == id);
            if (Old== null)
            {
                throw new CivilRegNotExistsException();
            }

            var Existing_NameAr = await _Repository.FindAsync(x => x.NameAr == input.NameAr && x.Id != id);
            if (Existing_NameAr != null)
            {
                throw new CivilRegNameArAlreadyExistsException(input.NameAr);
            }



            Old.NameAr = input.NameAr;
            Old.NameEn = input.NameEn;
            Old.CityId = input.CityId;
            Old.CountryId = input.CountryId;


            return Old;
        }
    }
}