﻿
using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain
{
    public class RegOrderNotExistsException : BusinessException
    {
        public RegOrderNotExistsException()
            : base(Hi_Student_AffairsDomainErrorCodes.RegOrderNotExists)
        {

        }
    }
}