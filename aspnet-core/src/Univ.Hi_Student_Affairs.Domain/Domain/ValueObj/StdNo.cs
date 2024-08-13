using System.Collections.Generic;
using Volo.Abp.Domain.Values;

namespace Univ.Hi_Student_Affairs.Domain.ValueObj
{

    public class StdNo : ValueObject
    {
        public StdNo(ulong stdMinistryId, ulong stdCollageId, ulong? examCollageId)
        {
            StdMinistryId = stdMinistryId;
            StdCollageId = stdCollageId;
            ExamCollageId = examCollageId;
        }

        public static StdNo Create(ulong stdMinistryId, ulong stdCollageId, ulong? examCollageId)
        {
            return new StdNo(stdMinistryId, stdCollageId, examCollageId);
        }

        public StdNo Update(ulong stdMinistryId, ulong stdCollageId, ulong? examCollageId)
        {
            StdMinistryId = stdMinistryId;
            StdCollageId = stdCollageId;
            ExamCollageId = examCollageId;
            return this;

        }


        //الرقم الوزاري
        public ulong StdMinistryId { get; set; }

        //الرقم الطالب ضمن الكلية
        public ulong StdCollageId { get; set; }


        //الرقم الامتحاني
        public ulong? ExamCollageId { get; set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return StdMinistryId;
            yield return StdCollageId;
            yield return ExamCollageId;

        }


    }
}
