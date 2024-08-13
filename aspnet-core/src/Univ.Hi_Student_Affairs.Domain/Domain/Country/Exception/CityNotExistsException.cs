using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain.Country.Exception
{
    public class CityNotExistsException : BusinessException
    {
        public CityNotExistsException()
            : base(Hi_Student_AffairsDomainErrorCodes.CityNotExists)
        {

        }
    }
}
