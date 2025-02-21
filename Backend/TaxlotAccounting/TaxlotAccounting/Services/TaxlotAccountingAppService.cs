using Volo.Abp.Application.Services;
using TaxlotAccounting.Localization;

namespace TaxlotAccounting.Services;

/* Inherit your application services from this class. */
public abstract class TaxlotAccountingAppService : ApplicationService
{
    protected TaxlotAccountingAppService()
    {
        LocalizationResource = typeof(TaxlotAccountingResource);
    }
}