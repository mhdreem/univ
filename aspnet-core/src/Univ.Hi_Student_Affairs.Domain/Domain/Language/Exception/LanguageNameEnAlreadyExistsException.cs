using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain.Language.Exception
{
    internal class LanguageNameEnAlreadyExistsException : BusinessException
    {
        public LanguageNameEnAlreadyExistsException(string NameEn)
            : base(Hi_Student_AffairsDomainErrorCodes.LanguageNameEnAlreadyExists)
        {
            WithData("NameEn", NameEn);
        }
    }

}
