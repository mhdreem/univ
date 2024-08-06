using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain
{
    public class MinistryNameArAlreadyExistsException : BusinessException
    {
        public MinistryNameArAlreadyExistsException(string NameAr)
            : base(Hi_Student_AffairsDomainErrorCodes.MinistryNameArAlreadyExists)
        {
            WithData("NameAr", NameAr);
        }
    }

}
