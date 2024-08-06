﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain.Nationality.Exception
{
    public class NationalityNameArAlreadyExistsException : BusinessException
    {
        public NationalityNameArAlreadyExistsException(string NameAr)
            : base(Hi_Student_AffairsDomainErrorCodes.NationalityNameArAlreadyExists)
        {
            WithData("NameAr", NameAr);
        }
    }

}
