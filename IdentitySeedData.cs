using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models
{
    public class IdentitySeedData
    {
        private const string adminUser = "Vladimir";
        private const string adminPassword = "Secret123$";
        
        public static async void EnsurePopulated(IApplicationBuilder app) 
        {
            AppIdentityDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider
                .GetRequiredService<AppIdentityDbContext>();
            if (context.Database.GetPendingMigrations().Any()) 
            {
                context.Database.Migrate();
            }
        
            UserManager<IdentityUser> userManager = app.ApplicationServices
                .CreateScope().ServiceProvider
                .GetRequiredService<UserManager<IdentityUser>>();


            IdentityUser user = await userManager.FindByNameAsync(adminUser);
            if (user == null) 
            {
                user = new IdentityUser("Vladimir");
                user.Email = "v.stijakovic@gmail.com";
                user.PhoneNumber = "555-3334";
                await userManager.CreateAsync(user, adminPassword);
            }
        }
    }
}