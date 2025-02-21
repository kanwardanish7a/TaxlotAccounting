using MongoDB.Driver;
using Volo.Abp.Data;
using Volo.Abp.MongoDB;
using TaxlotAccounting.Entities.Books;
using TaxlotAccounting.Entities.Taxlot;

namespace TaxlotAccounting.Data;

[ConnectionStringName("Default")]
public class TaxlotAccountingDbContext : AbpMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */
    
    public IMongoCollection<Book> Books => Collection<Book>();
    public IMongoCollection<TaxLot> TaxLots => Collection<TaxLot>(); // Add TaxLots collection

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        //builder.Entity<YourEntity>(b =>
        //{
        //    //...
        //});
    }
}

