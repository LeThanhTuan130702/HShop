using Acme.BookStore.Localization;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Admin;

/* Inherit your application services from this class.
 */
public abstract class BookStoreAdminAppService : ApplicationService
{
    protected BookStoreAdminAppService()
    {
        LocalizationResource = typeof(BookStoreResource);
    }
}
