using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Univ.Hi_Student_Affairs.Domain.Continent;
using Volo.Abp.Domain.Services;
using Volo.Abp;

namespace Univ.Hi_Student_Affairs
{
    public class ContinentManager : DomainService
    {

        private readonly IContinentRepository _Repository;
        public ContinentManager(IContinentRepository Repository)
        {
            _Repository = Repository;
        }



        public async Task<Continent> CreateAsync(
            [NotNull] string nameAr,
            [NotNull] string nameEn,
            [CanBeNull] int? ministryEncode,
            [CanBeNull] string? barcode,            
            [CanBeNull] int? ord = null,
            [CanBeNull] ICollection<Country>? countries = null 
            )
        {
            Check.NotNullOrWhiteSpace(nameAr, nameof(nameAr), ContinentConsts.MaxNameArLength, 2);

            Check.NotNullOrWhiteSpace(nameEn, nameof(nameEn), ContinentConsts.MaxNameArLength, 2);



            var Existing_NameAr = await _Repository.FindAsync(x => x.NameAr == nameAr);
            if (Existing_NameAr != null)
            {
                throw new ContinentNameArAlreadyExistsException(nameAr);
            }


            var Existing_NameEn = await _Repository.FindAsync(x => x.NameEn == nameEn);
            if (Existing_NameEn != null)
            {
                throw new ContinentNameEnAlreadyExistsException(nameEn);
            }


            var @continent =  new Continent(
                0,
                nameAr,
                nameEn,
                ministryEncode,
                barcode,
                ord,
                null

            );

                    


            if (countries != null )
            foreach(var @country in countries)
            {
                    var newCountry = new Country(0,0, @country.NameAr, @country.NameEn, @country.MinistryEncode, @country.Barcode, @country.Ord,null);

                    if (newCountry != null && @country.Cities != null && @country.Cities.Count() > 0)
                        foreach (var @city in @country.Cities)
                        {
                            newCountry.AddCity(@city.NameAr, @city.NameEn, @city.Ord, @city.PhoneCode, @city.Barcode, @city.MinistryEncode);
                        }

                    
                    @continent.Countries.Add(newCountry);
            }

            return @continent;
        }


       
        public async Task<Continent> UpdateAsync(
            [NotNull] int id,
            [NotNull] Continent input
            )
        {
            Check.NotNullOrWhiteSpace(input.NameAr, nameof(input.NameAr));
            Check.NotNullOrWhiteSpace(input.NameEn, nameof(input.NameEn));


            var Old = await _Repository.FindAsync(x => x.Id == id);
            if (Old == null)
            {
                throw new ContinentNotExistsException();
            }

            var Existing_NameAr = await _Repository.FindAsync(x => x.NameAr == input.NameAr && x.Id != id);
            if (Existing_NameAr != null)
            {
                throw new ContinentNameArAlreadyExistsException(input.NameAr);
            }


            var Existing_NameEn = await _Repository.FindAsync(x => x.NameEn == input.NameEn && x.Id != id);
            if (Existing_NameEn != null)
            {
                throw new ContinentNameEnAlreadyExistsException(input.NameEn);
            }



            Old.NameAr = input.NameAr;
            Old.NameEn = input.NameEn;
            Old.Ord = input.Ord;
            Old.Barcode = input.Barcode;
            Old.MinistryEncode = input.MinistryEncode;
            return Old;
        }
   


        public void RemoveCountry(Continent @continent,
            [NotNull]  int CountryId)
        {
             @continent.RemoveCountry(CountryId);        
        }


        public void AddCountry(Continent @continent,

             string? nameAr, string? nameEn, int? ministryEncode, string? barcode, int? ord,
             ICollection<City> cities)
        {
            @continent.AddCountry(nameAr, nameEn, ministryEncode, barcode, ord, cities);
        }


        public void UpdateCountry(
            Continent @continent,
            int  countryId,
                 string? nameAr, string? nameEn, int? ministryEncode, string? barcode, int? ord,
                 ICollection<City> cities)
        {
            @continent.UpdateCountry(countryId,nameAr, nameEn, ministryEncode, barcode, ord, cities);
        }



        public void AddCity(Continent @continent,
            int countryId,
            string nameAr, string nameEn, int? ord, string? phoneCode, string? barcode, int? ministryEncode
            )
        {
            @continent.AddCity(countryId, nameAr, nameEn, ord, phoneCode, barcode, ministryEncode);


        }

        public void  RemoveCity(Continent @continent,
           int cityId,
           int countryId
           
           )
        {
            @continent.RemoveCity(cityId, countryId);
        }

        public void UpdateCity(
            Continent @continent,
            int cityId,
            int countryId,           
            string nameAr, string nameEn, int? ord, string? phoneCode, string? barcode, int? ministryEncode
          )
        {
            @continent.UpdateCity( cityId, countryId, nameAr, nameEn, ord, phoneCode, barcode, ministryEncode);            
        }






    }
}