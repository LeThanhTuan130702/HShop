using Acme.BookStore.Admin;
using Volo.Abp.Modularity;

namespace Acme.BookStore.Admin;

[DependsOn(
    typeof(BookStoreAdminApplicationModule),
    typeof(BookStoreDomainTestModule)
)]
public class BookStoreApplicationTestModule : AbpModule
{

}
