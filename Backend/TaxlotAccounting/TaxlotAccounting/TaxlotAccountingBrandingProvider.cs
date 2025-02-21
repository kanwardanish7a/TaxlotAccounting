using Microsoft.Extensions.Localization;
using TaxlotAccounting.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace TaxlotAccounting;

[Dependency(ReplaceServices = true)]
public class TaxlotAccountingBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<TaxlotAccountingResource> _localizer;

    public TaxlotAccountingBrandingProvider(IStringLocalizer<TaxlotAccountingResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}