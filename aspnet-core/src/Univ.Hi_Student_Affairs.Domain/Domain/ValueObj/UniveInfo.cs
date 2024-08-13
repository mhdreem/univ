
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Univ.Hi_Student_Affairs.Domain.Student;
using Univ.Hi_Student_Affairs.Domain.Student.Admission;
using Univ.Hi_Student_Affairs.Domain.Univ;
using Volo.Abp.Domain.Values;

namespace Univ.Hi_Student_Affairs.Domain.ValueObj
{

    public class UniveInfo : ValueObject
    {
        public UniveInfo(int year, int admissionId, int univId, int univSectionId, int collageId, int? departmentId, int? branchId, int? classId, int? semesterId)
        {
            Year = year;
            AdmissionId = admissionId;
            UnivId = univId;
            UnivSectionId = univSectionId;
            CollageId = collageId;
            DepartmentId = departmentId;
            BranchId = branchId;
            ClassId = classId;
            SemesterId = semesterId;

        }

        public static UniveInfo Create(int year, int admissionId, int univId, int univSectionId, int collageId, int? departmentId, int? branchId, int? classId, int? semesterId)
        {
            return new UniveInfo(year, admissionId, univId, univSectionId, collageId, departmentId, branchId, classId, semesterId);
        }

        public UniveInfo Update(int year, int admissionId, int univId, int univSectionId, int collageId, int? departmentId, int? branchId, int? classId, int? semesterId)
        {
            Year = year;
            AdmissionId = admissionId;
            UnivId = univId;
            UnivSectionId = univSectionId;
            CollageId = collageId;
            DepartmentId = departmentId;
            BranchId = branchId;
            ClassId = classId;
            SemesterId = semesterId;
            return this;
        }


        //العام الحالي
        public int Year { get; private set; }


        //نوع القبول
        [ForeignKey("AdmissionId")]
        public int AdmissionId { get; private set; }
        public virtual Admission Admission { get; private set; }



        //الكلية
        [ForeignKey("UnivId")]
        public int UnivId { get; private set; }
        public virtual Univ.Univ Univ { get; private set; }


        //الكلية
        [ForeignKey("UnivSectionId")]
        public int UnivSectionId { get; private set; }
        public virtual UnivSection UnivSection { get; private set; }



        //الكلية
        [ForeignKey("CollageId")]
        public int CollageId { get; private set; }
        public virtual Collage Collage { get; private set; }


        //الاختصاص
        [ForeignKey("DepartmentId")]
        public int? DepartmentId { get; private set; }

        public virtual Department? Department { get; private set; }




        //الاختصاص
        [ForeignKey("BranchId")]
        public int? BranchId { get; private set; }
        public virtual Branch? Branch { get; private set; }


        //السنة الدراسية الحالية
        [ForeignKey("ClassId")]
        public int? ClassId { get; private set; }

        public virtual Class? Class { get; private set; }






        //الفصل الحالي
        [ForeignKey("SemesterId")]
        public int? SemesterId { get; private set; }
        public virtual Semester? Semester { get; private set; }



        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Year;
            yield return AdmissionId;
            yield return Admission;
            yield return UnivId;
            yield return Univ;
            yield return UnivSectionId;
            yield return UnivSection;
            yield return CollageId;
            yield return Collage;
            yield return DepartmentId;
            yield return Department;
            yield return BranchId;
            yield return Branch;

        }

    }
}
