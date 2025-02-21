using Microsoft.Extensions.Logging.Abstractions;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Identity;
using Volo.Abp.MultiTenancy;

namespace TaxlotAccounting.Data;

public class TaxlotAccountingDbMigrationService : ITransientDependency
{
    public ILogger<TaxlotAccountingDbMigrationService> Logger { get; set; }

    private readonly IDataSeeder _dataSeeder;
    private readonly TaxlotAccountingDbSchemaMigrator _dbSchemaMigrator;
    private readonly ICurrentTenant _currentTenant;

    public TaxlotAccountingDbMigrationService(
        IDataSeeder dataSeeder,
        TaxlotAccountingDbSchemaMigrator dbSchemaMigrator,
        ICurrentTenant currentTenant)
    {
        _dataSeeder = dataSeeder;
        _dbSchemaMigrator = dbSchemaMigrator;
        _currentTenant = currentTenant;

        Logger = NullLogger<TaxlotAccountingDbMigrationService>.Instance;
    }

    public async Task MigrateAsync()
    {
        Logger.LogInformation("Started database migrations...");

        await MigrateDatabaseSchemaAsync();
        await SeedDataAsync();

        Logger.LogInformation($"Successfully completed host database migrations.");
        Logger.LogInformation("You can safely end this process...");
    }

    private async Task MigrateDatabaseSchemaAsync()
    {
        await _dbSchemaMigrator.MigrateAsync();
    }

    private async Task SeedDataAsync()
    {
        await _dataSeeder.SeedAsync(new DataSeedContext()
            .WithProperty(IdentityDataSeedContributor.AdminEmailPropertyName, IdentityDataSeedContributor.AdminEmailDefaultValue)
            .WithProperty(IdentityDataSeedContributor.AdminPasswordPropertyName, IdentityDataSeedContributor.AdminPasswordDefaultValue)
        );
    }
}
