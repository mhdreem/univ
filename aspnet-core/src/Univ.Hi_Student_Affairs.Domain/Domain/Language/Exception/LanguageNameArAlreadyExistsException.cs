using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain.Language.Exception
{
    public class LanguageNameArAlreadyExistsException : BusinessException
    {
        public LanguageNameArAlreadyExistsException(string Name)
            : base(Hi_Student_AffairsDomainErrorCodes.LanguageNameArAlreadyExists)
        {
            WithData("Name", Name);
        }
    }

}
