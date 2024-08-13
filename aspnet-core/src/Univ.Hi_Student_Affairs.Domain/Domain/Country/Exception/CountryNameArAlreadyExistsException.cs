using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain.Country.Exception
{
    public class CountryNameArAlreadyExistsException : BusinessException
    {
        public CountryNameArAlreadyExistsException(string NameAr)
            : base(Hi_Student_AffairsDomainErrorCodes.CountryNameArAlreadyExists)
        {
            WithData("NameAr", NameAr);
        }
    }

}
