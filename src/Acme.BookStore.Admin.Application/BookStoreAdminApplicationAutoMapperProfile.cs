using AutoMapper;
using Acme.BookStore.Books;
using Acme.BookStore.Admin.Books;

namespace Acme.BookStore.Admin;

public class BookStoreAdminApplicationAutoMapperProfile : Profile
{
    public BookStoreAdminApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
