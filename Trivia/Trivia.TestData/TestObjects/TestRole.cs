using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trivia.Core.Entities;
using Trivia.TestData.TransferObjects;

namespace Trivia.TestData.TestObjects
{
    public class TestRole : TestObject<RoleTO, Role>
    {
        public static readonly TestRole SUPER_ADMIN = new TestRole("Super Admin", "Role with every permission.", true, TestPermission.values.Select(tp => (TestPermission)tp));
        public static readonly TestRole AUTHORIZATION_ADMIN = new TestRole("Authorization Admin", "Role with permission to administer permissions, roles and users.", true, new TestPermission[] { TestPermission.VIEW_PERMISSION, TestPermission.EDIT_PERMISSION, TestPermission.VIEW_ROLE, TestPermission.EDIT_ROLE, TestPermission.DELETE_ROLE });
        public static readonly TestRole ROLE_MANAGER = new TestRole("Role Manager", "Role with permission to manage roles.", true, new TestPermission[] { TestPermission.VIEW_ROLE, TestPermission.EDIT_ROLE, TestPermission.DELETE_ROLE });
        public static readonly TestRole USER_MANAGER = new TestRole("User Manager", "Role with permission to manage users.", true, new TestPermission[] { TestPermission.VIEW_USER, TestPermission.EDIT_USER, TestPermission.DELETE_USER });
        public TestRole(string name, string description, bool isActive, IEnumerable<TestPermission> testPermissions)
        {
            TransferObject = new RoleTO(this, name, description, isActive, testPermissions.Select(tp => tp.TransferObject));
        }
    }
}
