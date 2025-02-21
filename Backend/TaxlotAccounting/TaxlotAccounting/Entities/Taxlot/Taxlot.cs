using Volo.Abp.Domain.Entities.Auditing;

namespace TaxlotAccounting.Entities.Taxlot
{
    public class TaxLot : AuditedAggregateRoot<Guid>
    {
        public string Ticker { get; set; }
        public DateTime AcquisitionDate { get; set; }
        public decimal Quantity { get; set; }
        public decimal CostBasis { get; set; }
        public decimal FairMarketValue { get; set; }
        public string AccountId { get; set; } // Optional, for account association
    }

}
