using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain.Country.Exception
{
    public class CityNameArAlreadyExistsException : BusinessException
    {
        public CityNameArAlreadyExistsException(string NameAr)
            : base(Hi_Student_AffairsDomainErrorCodes.CityNameArAlreadyExists)
        {
            WithData("NameAr", NameAr);
        }
    }

}
