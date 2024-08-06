using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Volo.Abp;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs
{

    public class UnivSection : BasicAggregateRoot<int>
    {
       
        //اسم فرع الجامعة        
        public virtual string NameAr { get; set; }
        public virtual string NameEn { get; set; }

        //الترتيب
        public virtual int? Ord { get; set; }

        //رمز الفرع بوزارة التعليم
        public virtual int? MinistryEncode { get; set; }


        public virtual string? Barcode { get; set; }


        [ForeignKey("UnivId")]
        public int UnivId { get; set; }        
        public virtual Univ? Univ { get; set; }



        public virtual Collection<Collage>? Collages { get;  set; } //Sub collection

        public UnivSection()
        {
            NameAr = "";
            NameEn = "";
            Collages = new Collection<Collage>();
        }
       
        public UnivSection(string name_ar, string name_en, int? ord, int? ministry_encode, string? Barcode, Collection<Collage> collages
            , int univid)
        {
            NameAr = name_ar;
            NameEn = name_en;
            Ord = ord;
            MinistryEncode = ministry_encode;
            this.Barcode = Barcode;
            this.UnivId = univid;

            if (collages != null && collages.Count > 0)
                Collages = collages;
            else Collages = new Collection<Collage>();
        }


        public UnivSection RemoveCollage(int collageId)
        {
            if (Collages is null ||
                Collages.Count == 0)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryZeroLengthOrNullCitiesList);


            var UnivSection = Collages.SingleOrDefault(x => x.Id == collageId);
            if (UnivSection is null)
            {
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNotExists);
            }
            Collages.Remove(UnivSection);

            return this;
        }


        public UnivSection AddCollage(            
                string NameAr,
                string NameEn,
                string? DeanAr,
                string? DeanEn,
                int? NumYear,
                int? Ord,
                string? DegreeNameAr,
                string? DegreeNameEn,
                int? MinistryEncode,
                string? Barcode
             )
        {
            if (Collages is null ||
                Collages.Count() == 0)
                Collages = new Collection<Collage>();


            if (Collages.Where(x => x.NameAr != null && x.NameAr.Equals(NameAr)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameArAlreadyExists);


            if (Collages.Where(x => x.NameEn != null && x.NameEn.Equals(NameEn)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);


            if (MinistryEncode != null &&
                Collages.Where(x => x.MinistryEncode != null && x.MinistryEncode == MinistryEncode).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityMinistryAlreadyExists);



            Collages.Add(new Collage(NameAr,NameEn,DeanAr,DeanEn,NumYear,Ord,DegreeNameAr,DegreeNameEn,MinistryEncode,Barcode,this.Id));

            return this;
        }



        public UnivSection UpdateCollage(
             int CollageId,
              string NameAr,
                string NameEn,
                string? DeanAr,
                string? DeanEn,
                int? NumYear,
                int? Ord,
                string? DegreeNameAr,
                string? DegreeNameEn,
                int? MinistryEncode,
                string? Barcode
            )
        {
            if (Collages is null ||
                Collages.Count() == 0)
                Collages = new Collection<Collage>();

            var Collage = Collages.Where(x => x.Id == CollageId).FirstOrDefault();
            if (Collage is null)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNotExists);




            if (Collages.Where(x => x.NameAr != null && x.Id != CollageId && x.NameAr.Equals(NameAr)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameArAlreadyExists);


            if (Collages.Where(x => x.NameEn != null && x.Id != CollageId && x.NameEn.Equals(NameEn)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);





            if (MinistryEncode != null &&
                Collages.Where(x => x.MinistryEncode != null && x.Id != CollageId && x.MinistryEncode == MinistryEncode).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityMinistryAlreadyExists);






            Collage.NameAr = NameAr;
            Collage.NameEn = NameEn;
            Collage.Ord = Ord;
            Collage.MinistryEncode = MinistryEncode;
            Collage.DeanEn = DeanEn;
            Collage.DeanAr = DeanAr;
            Collage.Barcode= Barcode;
            Collage.DegreeNameAr= DegreeNameAr;
            Collage.DegreeNameEn= DegreeNameEn;


            return this;
        }



        public Collage GetCollage(int CollageId)
        {
            if (Collages is null ||
                Collages.Count == 0)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryZeroLengthOrNullCitiesList);


            var Collage = Collages.Single(x => x.Id == CollageId);
            if (Collage is null)
            {
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CountryNotExists);
            }
            return Collage;
        }




    }
}
