using Volo.Abp.Application.Dtos;

namespace TaxlotAccounting.Services.Dtos.Taxlot
{
    public class TaxLotDto : AuditedEntityDto<Guid>
    {
        public string Ticker { get; set; }
        public DateTime AcquisitionDate { get; set; }
        public decimal Quantity { get; set; }
        public decimal CostBasis { get; set; }
        public decimal FairMarketValue { get; set; }
    }
}
