using AutoMapper.Internal.Mappers;
using TaxlotAccounting.Entities.Taxlot;
using TaxlotAccounting.Services.Dtos.Taxlot;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace TaxlotAccounting.Services.Taxlot
{
    public class TaxLotAppService : ApplicationService, ITaxLotAppService
    {
        private readonly IRepository<TaxLot, Guid> _repository;

        public TaxLotAppService(IRepository<TaxLot, Guid> repository)
        {
            _repository = repository;
        }

        public async Task<TaxLotDto> GetAsync(Guid id)
        {
            var taxLot = await _repository.GetAsync(id);
            return ObjectMapper.Map<TaxLot, TaxLotDto>(taxLot);
        }

        public async Task<PagedResultDto<TaxLotDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            var queryable = await _repository.GetQueryableAsync();
            var query = queryable
                .Skip(input.SkipCount)
                .Take(input.MaxResultCount);
            var taxLots = await AsyncExecuter.ToListAsync(query);
            var totalCount = await AsyncExecuter.CountAsync(queryable);

            return new PagedResultDto<TaxLotDto>(totalCount, ObjectMapper.Map<List<TaxLot>, List<TaxLotDto>>(taxLots));
        }

        public async Task<TaxLotDto> CreateAsync(CreateUpdateTaxLotDto input)
        {
            var taxLot = ObjectMapper.Map<CreateUpdateTaxLotDto, TaxLot>(input);
            await _repository.InsertAsync(taxLot);
            return ObjectMapper.Map<TaxLot, TaxLotDto>(taxLot);
        }

        public async Task<TaxLotDto> UpdateAsync(Guid id, CreateUpdateTaxLotDto input)
        {
            var taxLot = await _repository.GetAsync(id);
            ObjectMapper.Map(input, taxLot);
            await _repository.UpdateAsync(taxLot);
            return ObjectMapper.Map<TaxLot, TaxLotDto>(taxLot);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
