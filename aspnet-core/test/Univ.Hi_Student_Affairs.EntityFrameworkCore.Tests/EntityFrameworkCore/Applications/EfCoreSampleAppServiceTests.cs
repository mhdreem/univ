using Univ.Hi_Student_Affairs.Samples;
using Xunit;

namespace Univ.Hi_Student_Affairs.EntityFrameworkCore.Applications;

[Collection(Hi_Student_AffairsTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<Hi_Student_AffairsEntityFrameworkCoreTestModule>
{

}
