﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univ.Hi_Student_Affairs
{
    public class StatusFilter
    {
        //حالة الطالب
        public string? NameAr { get; set; }
        public string? NameEn { get; set; }
        //الترتيب
        public int? Ord { get; set; }




    }
}