using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trivia.Core.Entities;

namespace Trivia.TestData.TestObjects
{
    public class TestApplicationRole : TestObject<ApplicationRole>
    {
        private static List<TestApplicationRole> _TestObjects = new List<TestApplicationRole>();
        public static IEnumerable<ApplicationRole> Entities { get { return _TestObjects.Select(to => to.Entity); } }
        public static IEnumerable<TestApplicationRole> Values { get { return _TestObjects.AsEnumerable(); } }

        public static readonly TestApplicationRole SUPER_ADMIN;
        public static readonly TestApplicationRole AUTHORIZATION_ADMIN;
        public static readonly TestApplicationRole ROLE_MANAGER;
        public static readonly TestApplicationRole USER_MANAGER;

        static TestApplicationRole()
        {
            SUPER_ADMIN = new TestApplicationRole("Super Admin", "Role with every permission.");
            AUTHORIZATION_ADMIN = new TestApplicationRole("Authorization Admin", "Role with permission to administer permissions, roles and users.");
            ROLE_MANAGER = new TestApplicationRole("Role Manager", "Role with permission to manage roles.");
            USER_MANAGER = new TestApplicationRole("User Manager", "Role with permission to manage users.");
        }

        public TestApplicationRole(string name, string description)
        {
            _TestObjects.Add(this);
            Entity = new ApplicationRole
            {
                Name = name,
                Description = description,
            };
        }
    }
}
