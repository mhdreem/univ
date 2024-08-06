using Univ.Hi_Student_Affairs.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Univ.Hi_Student_Affairs.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class Hi_Student_AffairsController : AbpControllerBase
{
    protected Hi_Student_AffairsController()
    {
        LocalizationResource = typeof(Hi_Student_AffairsResource);
    }
}
