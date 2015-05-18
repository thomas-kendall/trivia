using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trivia.Core.Entities;

namespace Trivia.TestData.TestObjects
{
    public class TestApplicationUser : TestObject<ApplicationUser>
    {
        private static List<TestApplicationUser> _TestObjects = new List<TestApplicationUser>();
        public static IEnumerable<ApplicationUser> Entities { get { return _TestObjects.Select(to => to.Entity); } }
        public static IEnumerable<TestApplicationUser> Values { get { return _TestObjects.AsEnumerable(); } }

        public static readonly TestApplicationUser CURLY_JEFFERSON;
        public static readonly TestApplicationUser OLD_GREGG;
        public static readonly TestApplicationUser MARY_SAMPSONITE;
        
        static TestApplicationUser()
        {
            CURLY_JEFFERSON = new TestApplicationUser("curly.jefferson@example.com", new List<TestApplicationRole>() { TestApplicationRole.SUPER_ADMIN });
            OLD_GREGG = new TestApplicationUser("old.gregg@example.com", new List<TestApplicationRole>() { TestApplicationRole.AUTHORIZATION_ADMIN });
            MARY_SAMPSONITE = new TestApplicationUser("mary.sampsonite@example.com", new List<TestApplicationRole>() { TestApplicationRole.ROLE_MANAGER, TestApplicationRole.USER_MANAGER });
        }

        public IEnumerable<ApplicationRole> Roles { get; set; }

        public TestApplicationUser(string emailAddress, IEnumerable<TestApplicationRole> testRoles)
        {
            _TestObjects.Add(this);
            Entity = new ApplicationUser
            {
                UserName = emailAddress,
                Email = emailAddress,
            };

            if (testRoles != null)
            {
                Roles = testRoles.Select(tr => tr.Entity);
            }
        }
    }
}
