using TaxlotAccounting.Services.Dtos.Taxlot;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace TaxlotAccounting.Services.Taxlot
{

    public interface ITaxLotAppService :
    ICrudAppService<
        TaxLotDto, // DTO used for displaying tax lots
        Guid, // Primary key of the TaxLot entity
        PagedAndSortedResultRequestDto, // Used for paging and sorting
        CreateUpdateTaxLotDto> // DTO used for creating/updating tax lots
    {
        Task<TaxLotDto> GetAsync(Guid id);
        Task<PagedResultDto<TaxLotDto>> GetListAsync(PagedAndSortedResultRequestDto input);
        Task<TaxLotDto> CreateAsync(CreateUpdateTaxLotDto input);
        Task<TaxLotDto> UpdateAsync(Guid id, CreateUpdateTaxLotDto input);
        Task DeleteAsync(Guid id);
    }
}
