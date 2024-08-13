using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain.Country.Exception
{
    public class CountryNotExistsException : BusinessException
    {
        public CountryNotExistsException()
            : base(Hi_Student_AffairsDomainErrorCodes.CountryNotExists)
        {

        }
    }
}