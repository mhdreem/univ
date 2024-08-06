using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain.Continent
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
