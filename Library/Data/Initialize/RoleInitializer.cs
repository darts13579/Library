using System.Threading.Tasks;
using Library.Data.Entity;
using Microsoft.AspNetCore.Identity;

namespace Library.Data.Initialize
{
    public class RoleInitializer
    {
        public static async Task InitializeAsync(UserManager<LibraryUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            const string adminEmail = "admin@mail.com";
            const string password = "test123";
            if (await roleManager.FindByNameAsync("admin") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("admin"));
            }

            if (await roleManager.FindByNameAsync("employee") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("employee"));
            }

            if (await userManager.FindByNameAsync(adminEmail) == null)
            {
                var admin = new LibraryUser {Email = adminEmail, UserName = adminEmail};
                var result = await userManager.CreateAsync(admin, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin, "admin");
                }
            }
        }
    }
}