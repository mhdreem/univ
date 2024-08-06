﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain.Admission
{
    internal class AdmissionNotExistsException : BusinessException
    {
        public AdmissionNotExistsException(string name)
            : base(Hi_Student_AffairsDomainErrorCodes.AdmissionNotExists)
        {
            
        }
    }

}