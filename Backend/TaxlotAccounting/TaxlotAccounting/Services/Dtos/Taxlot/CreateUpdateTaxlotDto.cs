namespace TaxlotAccounting.Services.Dtos.Taxlot
{
    public class CreateUpdateTaxLotDto
    {
        public string Ticker { get; set; }
        public DateTime AcquisitionDate { get; set; }
        public decimal Quantity { get; set; }
        public decimal CostBasis { get; set; }
        public decimal FairMarketValue { get; set; }
    }
}
