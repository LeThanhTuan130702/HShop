using Acme.BookStore.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.BookStore.Admin.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BookStoreController : AbpControllerBase
{
    protected BookStoreController()
    {
        LocalizationResource = typeof(BookStoreResource);
    }
}
