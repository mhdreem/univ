using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain.Country.Exception
{
    internal class CountryNameEnAlreadyExistsException : BusinessException
    {
        public CountryNameEnAlreadyExistsException(string NameEn)
            : base(Hi_Student_AffairsDomainErrorCodes.ContinentNameEnAlreadyExists)
        {
            WithData("NameEn", NameEn);
        }
    }

}