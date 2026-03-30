using Volo.Abp.Modularity;

namespace Acme.BookStore.Admin;

public abstract class BookStoreApplicationTestBase<TStartupModule> : BookStoreTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
