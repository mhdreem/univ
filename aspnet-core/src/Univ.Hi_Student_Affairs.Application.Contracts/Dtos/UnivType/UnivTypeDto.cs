using Microsoft.VisualBasic;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Univ.Hi_Student_Affairs.Dtos.Univ;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs.Dtos.UnivType
{

    public class UnivTypeDto : EntityDto<int>
    {

        //اسم نوع الجامعة

        public virtual string NameAr { get; set; }
        public virtual string? NameEn { get; set; }


        //الترتيب
        public virtual int? Ord { get; set; }

     
    }


    public class CreateUnivTypeDto 
    {

        //اسم نوع الجامعة

        public virtual string NameAr { get; set; }
        public virtual string? NameEn { get; set; }


        //الترتيب
        public virtual int? Ord { get; set; }

      
    }


    public class UpdateUnivTypeDto : CreateUnivTypeDto
    {

public int Id { get; set; }
    }



    public class CheckUnivTypeDto : EntityDto<int?>
    {
        public int? Id { get; set; }

        //اسم نوع الجامعة

        public virtual string? NameAr { get; set; }
        public virtual string? NameEn { get; set; }


        //الترتيب
        public virtual int? Ord { get; set; }

    }


    public class UnivTypePagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {
        public virtual int? Id { get; set; }
        //اسم نوع الجامعة

        public virtual string? NameAr { get; set; }
        public virtual string? NameEn { get; set; }


        //الترتيب
        public virtual int? Ord { get; set; }


    }
}
