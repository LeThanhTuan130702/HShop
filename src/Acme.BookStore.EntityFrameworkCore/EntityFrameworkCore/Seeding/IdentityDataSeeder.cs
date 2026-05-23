using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Volo.Abp;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Guids;
using Volo.Abp.Identity;
using Volo.Abp.MultiTenancy;
using Volo.Abp.Uow;

namespace Acme.BookStore.EntityFrameworkCore.Seeding;

public class IdentityDataSeeder : ITransientDependency, IIdentityDataSeeder
{
    protected IGuidGenerator GuidGenerator { get; }

    protected IIdentityUserRepository UserRepository { get; }

    protected IIdentityRoleRepository RoleRepository { get; }

    protected ILookupNormalizer Normalizer { get; }

    protected IdentityRoleManager RoleManager { get; }

    protected IdentityUserManager UserManager { get; }

    protected ICurrentTenant CurrentTenant { get; }

    protected IOptions<IdentityOptions> IdentityOptions { get; }

    public IdentityDataSeeder(
        IIdentityUserRepository userRepository,
        IIdentityRoleRepository roleRepository,
        IGuidGenerator guidGenerator,
        ILookupNormalizer normalizer,
        IdentityRoleManager roleManager,
        IdentityUserManager userManager,
        ICurrentTenant currentTenant,
        IOptions<IdentityOptions> identityOptions
    )
    {
        UserRepository = userRepository;
        RoleRepository = roleRepository;
        GuidGenerator = guidGenerator;
        Normalizer = normalizer;
        RoleManager = roleManager;
        UserManager = userManager;
        CurrentTenant = currentTenant;
        IdentityOptions = identityOptions;
    }



    [UnitOfWork]
    public virtual async Task<IdentityDataSeedResult> SeedAsync(string adminEmail, string adminPassword, Guid? tenantId = null, string? adminUserName = null)
    {
        Check.NotNullOrWhiteSpace(adminEmail, nameof(adminEmail));
        Check.NotNullOrWhiteSpace(adminPassword, nameof(adminPassword));

        using (CurrentTenant.Change(tenantId))
        {
            await IdentityOptions.SetAsync();

            var result = new IdentityDataSeedResult();

            // --- Seed "admin" role ---
            const string adminRoleName = "admin";
            var adminRole = await RoleRepository.FindByNormalizedNameAsync(Normalizer.NormalizeName(adminRoleName));
            if (adminRole == null)
            {
                adminRole = new IdentityRole(GuidGenerator.Create(), adminRoleName, tenantId)
                {
                    IsStatic = true,
                    IsPublic = true
                };

                (await RoleManager.CreateAsync(adminRole)).CheckErrors();
                result.CreatedAdminRole = true;
            }

            // // --- Seed "user" role ---
            // const string userRoleName = "user";
            // var userRole = await RoleRepository.FindByNormalizedNameAsync(Normalizer.NormalizeName(userRoleName));
            // if (userRole == null)
            // {
            //     userRole = new IdentityRole(GuidGenerator.Create(), userRoleName, tenantId)
            //     {
            //         IsStatic = true,
            //         IsPublic = true,
            //         IsDefault = true
            //     };

            //     (await RoleManager.CreateAsync(userRole)).CheckErrors();
            // }

            // --- Seed admin user ---
            var adminUserName1 = adminUserName ?? adminEmail;
            var adminUser = await UserRepository.FindByNormalizedUserNameAsync(Normalizer.NormalizeName(adminUserName1));

            if (adminUser != null)
            {
                return result;
            }

            adminUser = new IdentityUser(GuidGenerator.Create(), adminUserName1, adminEmail, tenantId)
            {
                Name = adminUserName1
            };

            (await UserManager.CreateAsync(adminUser, adminPassword, validatePassword: false)).CheckErrors();
            result.CreatedAdminUser = true;

            (await UserManager.AddToRoleAsync(adminUser, adminRoleName)).CheckErrors();

            return result;
        }
    }
}
