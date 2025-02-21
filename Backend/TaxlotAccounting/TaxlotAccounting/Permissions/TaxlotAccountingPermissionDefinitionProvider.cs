using TaxlotAccounting.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace TaxlotAccounting.Permissions;

public class TaxlotAccountingPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(TaxlotAccountingPermissions.GroupName);

        var booksPermission = myGroup.AddPermission(TaxlotAccountingPermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(TaxlotAccountingPermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(TaxlotAccountingPermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(TaxlotAccountingPermissions.Books.Delete, L("Permission:Books.Delete"));

        //Define your own permissions here. Example:
        //myGroup.AddPermission(TaxlotAccountingPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<TaxlotAccountingResource>(name);
    }
}
