using JetBrains.Annotations;
using System.Linq;
using System.Threading.Tasks;
using Univ.Hi_Student_Affairs.Domain.Country.Exception;
using Univ.Hi_Student_Affairs.enums;
using Volo.Abp;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;


namespace Univ.Hi_Student_Affairs.Domain.Country
{
    public class CountryManager : DomainService
    {
        private readonly IRepository<Country, int> _repository;

        public CountryManager(IRepository<Country, int> repository)
        {
            _repository = repository;
        }

        private async Task ValidateCountryAsync(string nameAr, string nameEn, string? barcode, int? id = null)
        {
            var existingNameAr = await _repository.FindAsync(x => x.NameAr == nameAr && (!id.HasValue || x.Id != id));
            if (existingNameAr != null)
            {
                throw new CountryNameArAlreadyExistsException(nameAr);
            }

            var existingNameEn = await _repository.FindAsync(x => x.NameEn == nameEn && (!id.HasValue || x.Id != id));
            if (existingNameEn != null)
            {
                throw new CountryNameArAlreadyExistsException(nameEn);
            }

            var existingBarcode = await _repository.FindAsync(x => x.Barcode == barcode && (!id.HasValue || x.Id != id));
            if (existingBarcode != null)
            {
                throw new UserFriendlyException("Barcode already exists");
            }
        }

        private async Task ValidateCityAsync(Country country, string nameAr, string nameEn, string? barcode, int? id = null)
        {
            if (country.Cities == null)
                return;

            var existingNameAr = country.Cities.FirstOrDefault(x => x.NameAr == nameAr && (!id.HasValue || x.Id != id));
            if (existingNameAr != null)
            {
                throw new CountryNameArAlreadyExistsException(nameAr);
            }

            var existingNameEn = country.Cities.FirstOrDefault(x => x.NameEn == nameEn && (!id.HasValue || x.Id != id));
            if (existingNameEn != null)
            {
                throw new CountryNameArAlreadyExistsException(nameEn);
            }

            var existingBarcode = country.Cities.FirstOrDefault(x => x.Barcode == barcode && (!id.HasValue || x.Id != id));
            if (existingBarcode != null)
            {
                throw new UserFriendlyException("Barcode already exists");
            }
        }

        public async Task<Country> CreateAsync(
            [NotNull] Continent continent,
            [NotNull] string nameAr,
            [CanBeNull] string nameEn,
            [CanBeNull] string? barcode,
            [CanBeNull] int? ord = null)
        {
            Check.NotNullOrWhiteSpace(nameAr, nameof(nameAr));
            Check.NotNullOrWhiteSpace(nameEn, nameof(nameEn));

            await ValidateCountryAsync(nameAr, nameEn, barcode, null);

            return new Country(
                nameAr,
                nameEn,
                ord,
                barcode,
                continent,
                null
            );
        }

        public async Task<Country> UpdateAsync(
            [NotNull] int id,
            [NotNull] Continent continent,
            [NotNull] string nameAr,
            [CanBeNull] string nameEn,
            [CanBeNull] string? barcode,
            [CanBeNull] int? ord = null)
        {
            Check.NotNullOrWhiteSpace(nameAr, nameof(nameAr));
            Check.NotNullOrWhiteSpace(nameEn, nameof(nameEn));

            var existingCountry = await _repository.FindAsync(x => x.Id == id);
            if (existingCountry == null)
            {
                throw new CountryNotExistsException();
            }

            await ValidateCountryAsync(nameAr, nameEn, barcode, existingCountry.Id);

            existingCountry.UpdateContinent(continent);
            existingCountry.UpdateNameAr(nameAr);
            existingCountry.UpdateNameEn(nameEn);
            existingCountry.SetOrd(ord);

            return existingCountry;
        }

        public async Task AddCityAsync(Country country,
            string nameAr, string nameEn, int? ord, string? barcode, string? phoneCode)
        {
            await ValidateCityAsync(country, nameAr, nameEn, barcode, null);
            country.AddCity(nameAr, nameEn, ord, barcode, phoneCode);
        }

        public void RemoveCity(Country country, int cityId)
        {
            country.RemoveCity(cityId);
        }

        public async Task UpdateCityAsync(Country country, int cityId,
            string nameAr, string nameEn, int? ord, string? barcode, string? phoneCode)
        {
            await ValidateCityAsync(country, nameAr, nameEn, barcode, cityId);
            country.UpdateCity(cityId, nameAr, nameEn, ord, barcode, phoneCode);
        }
    }

}