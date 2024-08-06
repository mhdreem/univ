using Univ.Hi_Student_Affairs.Samples;
using Xunit;

namespace Univ.Hi_Student_Affairs.EntityFrameworkCore.Domains;

[Collection(Hi_Student_AffairsTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<Hi_Student_AffairsEntityFrameworkCoreTestModule>
{

}
