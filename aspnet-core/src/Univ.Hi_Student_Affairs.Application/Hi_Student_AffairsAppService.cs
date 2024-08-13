using Univ.Hi_Student_Affairs.Localization;
using Volo.Abp.Application.Services;

namespace Univ.Hi_Student_Affairs;

/* Inherit your application services from this class.
 */
public abstract class Hi_Student_AffairsAppService : ApplicationService
{
    protected Hi_Student_AffairsAppService()
    {
        LocalizationResource = typeof(Hi_Student_AffairsResource);
    }
}
