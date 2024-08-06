using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Univ.Hi_Student_Affairs;

[Dependency(ReplaceServices = true)]
public class Hi_Student_AffairsBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Hi_Student_Affairs";
}
