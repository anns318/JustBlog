using FA.JustBlog.Core.Models;
using Microsoft.AspNetCore.Identity;

namespace FA.JustBlog.Core.DataSeed
{
    public class SeedRole
    {
        public static async Task CreateRole(IServiceProvider serviceProvider)
        {
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var UserManager = serviceProvider.GetRequiredService<UserManager<User>>();
            string[] roleNames = { "Admin", "BlogOwner", "Contributor", "User" };


            foreach (var roleName in roleNames)
            {
                var roleExist = await RoleManager.RoleExistsAsync(roleName);
                if (!roleExist)
                {
                    //create the roles and seed them to the database: Question 1
                    await RoleManager.CreateAsync(new IdentityRole(roleName));
                }
            }

            //Here you could create a super user who will maintain the web app
            List<User> listUser = new List<User> { new User
            {

                //UserName = Configuration["AppSettings:UserName"],
                //Email = Configuration["AppSettings:UserEmail"]
                  UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                EmailConfirmed = true
            },
            new User
            {
                UserName = "blogowner@gmail.com",
                Email = "blogowner@gmail.com",
                EmailConfirmed = true
            },
            new User
            {
                UserName = "contributor@gmail.com",
                Email = "contributor@gmail.com",
                EmailConfirmed = true
            },
            new User
            {
                UserName = "user@gmail.com",
                Email = "user@gmail.com",
                EmailConfirmed = true
            }
        };

            //Ensure you have these values in your appsettings.json file
            string userPWD = "123123";
            int i = 0;
            foreach(var item in listUser)
            {
                var _user = await UserManager.FindByEmailAsync(item.Email);
                if (_user == null)
                {
                    var createAdmin = await UserManager.CreateAsync(item, userPWD);
                    if (createAdmin.Succeeded)
                    {
                        //here we tie the new user to the role
                        await UserManager.AddToRoleAsync(item, roleNames[i]);
                    }
                }
                i++;
            }

            

            
        }


    }
}
