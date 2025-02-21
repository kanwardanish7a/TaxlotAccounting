using AutoMapper;
using TaxlotAccounting.Entities.Taxlot;
using TaxlotAccounting.Services.Dtos.Taxlot;

namespace TaxlotAccounting.Services
{
    public class TaxlotAccountingApplicationAutoMapperProfile : Profile
    {
        public TaxlotAccountingApplicationAutoMapperProfile()
        {
            CreateMap<TaxLot, TaxLotDto>();
            CreateMap<CreateUpdateTaxLotDto, TaxLot>();
        }
    }
}
