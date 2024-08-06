﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain.Language.Exception
{
    public class LanguageNotExistsException : BusinessException
    {
        public LanguageNotExistsException()
            : base(Hi_Student_AffairsDomainErrorCodes.LanguageNotExists)
        {

        }
    }
}