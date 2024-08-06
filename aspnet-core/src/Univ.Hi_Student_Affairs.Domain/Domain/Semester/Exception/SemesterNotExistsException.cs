﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain.AverageCalc.Exception
{
    public class SemesterNotExistsException : BusinessException
    {
        public SemesterNotExistsException()
            : base(Hi_Student_AffairsDomainErrorCodes.SemesterNotExists)
        {

        }
    }
}