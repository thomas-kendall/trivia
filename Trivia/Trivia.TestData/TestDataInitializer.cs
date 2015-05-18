using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trivia.Core.Entities;
using Trivia.DataAccess.EntityFramework;
using Trivia.TestData.TestObjects;

namespace Trivia.TestData
{
    public class TestDataInitializer : DropCreateDatabaseAlways<TriviaDbContext>
    {
        protected override void Seed(TriviaDbContext context)
        {
            IdentityResult result;
            RoleManager<ApplicationRole> roleManager = new RoleManager<ApplicationRole>(new RoleStore<ApplicationRole>(context));
            foreach (var role in TestApplicationRole.Entities)
            {
                if (!roleManager.RoleExists(role.Name))
                {
                    result = roleManager.Create(role);
                    if (!result.Succeeded)
                    {
                        throw new Exception("RoleManager.Create() failed with the following errors: " + string.Concat(result.Errors));
                    }
                }
            }
            context.SaveChanges();

            UserStore<ApplicationUser, ApplicationRole, string, IdentityUserLogin, IdentityUserRole, IdentityUserClaim> userStore = new UserStore<ApplicationUser, ApplicationRole, string, IdentityUserLogin, IdentityUserRole, IdentityUserClaim>(context);
            UserManager<ApplicationUser,string> UserManager = new UserManager<ApplicationUser,string>(userStore);
            foreach (var testUser in TestApplicationUser.Values)
            {
                if (UserManager.FindByEmail(testUser.Entity.Email) == null)
                {
                    result = UserManager.Create(testUser.Entity);
                    if (!result.Succeeded)
                    {
                        throw new Exception("UserManager.Create() failed with the following errors: " + string.Concat(result.Errors));
                    }
                    foreach (var role in testUser.Roles)
                    {
                        result = UserManager.AddToRole(testUser.Entity.Id, role.Name);
                        if (!result.Succeeded)
                        {
                            throw new Exception("UserManager.AddToRole() failed with the following errors: " + string.Concat(result.Errors));
                        }
                    }
                }
            }

            SeedTestObjects(context, TestQuestion.Entities);
            SeedTestObjects(context, TestAnswer.Entities);

            context.SaveChanges();
        }

        private static void SeedTestObjects(TriviaDbContext context, IEnumerable<object> entities)
        {
            foreach (var entity in entities)
            {
                context.Set(entity.GetType()).Add(entity);
            }
        }

    }
}
