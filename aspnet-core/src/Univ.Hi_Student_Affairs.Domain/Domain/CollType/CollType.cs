using System;
using System.Collections.ObjectModel;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs
{
    public class CollType : BasicAggregateRoot<int>
    {
        public CollType()
        {
            Name = "";
            Collages = new Collection<Collage> { new Collage() };

        }

        public CollType(string name, int? ord, int? ministry_Encode, string? barcode)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Ord = ord;
            MinistryEncode = ministry_Encode;
            Barcode = barcode;
            Collages = new Collection<Collage> { new Collage() };

        }

        //نوع الكلية
        public virtual string Name { get; set; }


        //الترتيب
        public virtual int? Ord { get; set; }


        //رمز الكلية بوزراة التعليم
        public virtual int? MinistryEncode { get; set; }

        public virtual string? Barcode { get; set; }


        public virtual Collection<Collage>? Collages { get; protected set; } //Sub collection

    }
}
