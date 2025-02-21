using AutoMapper;
using TaxlotAccounting.Entities.Books;
using TaxlotAccounting.Services.Dtos.Books;

namespace TaxlotAccounting.ObjectMapping;

public class TaxlotAccountingAutoMapperProfile : Profile
{
    public TaxlotAccountingAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        CreateMap<BookDto, CreateUpdateBookDto>();
        /* Create your AutoMapper object mappings here */
    }
}