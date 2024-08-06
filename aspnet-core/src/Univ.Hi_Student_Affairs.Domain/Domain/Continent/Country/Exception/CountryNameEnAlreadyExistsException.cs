using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain.Continent
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