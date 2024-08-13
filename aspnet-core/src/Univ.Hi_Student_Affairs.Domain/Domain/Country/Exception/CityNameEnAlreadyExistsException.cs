using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain.Country.Exception
{
    public class CityNameEnAlreadyExistsException : BusinessException
    {
        public CityNameEnAlreadyExistsException(string NameEn)
            : base(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists)
        {
            WithData("NameEn", NameEn);
        }
    }

}
