using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain.City
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
