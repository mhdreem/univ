using System;
using System.Collections.ObjectModel;
using Univ.Hi_Student_Affairs.Domain.ValueObj;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs.Domain.Student
{
    public class AcceptedStudent : BasicAggregateRoot<Guid>
    {
        public StudentProfile studnetProfile { get; private set; }
        public UniveInfo UniveInfo { get; private set; }
        public virtual Collection<StdCertificate.StdCertificate>? StdCertificates { get; private set; }
        public virtual Collection<StdAdmission.StdAdmission>? StdAdmissions { get; private set; }

    }
}
