using Univ.Hi_Student_Affairs.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Univ.Hi_Student_Affairs.Permissions;

public class Hi_Student_AffairsPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(Hi_Student_AffairsPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(Hi_Student_AffairsPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<Hi_Student_AffairsResource>(name);
    }
}
