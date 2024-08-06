﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain.Class
{
    public class ClassNameArAlreadyExistsException : BusinessException
    {
        public ClassNameArAlreadyExistsException(string NameAr)
            : base(Hi_Student_AffairsDomainErrorCodes.ClassNameArAlreadyExists)
        {
            WithData("NameAr", NameAr);
        }
    }

}