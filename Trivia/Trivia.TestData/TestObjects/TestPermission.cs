using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trivia.Core;
using Trivia.Core.Entities;
using Trivia.TestData.TransferObjects;

namespace Trivia.TestData.TestObjects
{
    public class TestPermission : TestObject<PermissionTO, Permission>
    {
        public static readonly TestPermission VIEW_PERMISSION = new TestPermission(ApplicationAuthorities.ViewPermission, "The authority to view application permissions.", true);
        public static readonly TestPermission EDIT_PERMISSION = new TestPermission(ApplicationAuthorities.EditPermission, "The authority to edit application permissions.", true);
        public static readonly TestPermission VIEW_ROLE = new TestPermission(ApplicationAuthorities.ViewRole, "The authority to view application roles.", true);
        public static readonly TestPermission EDIT_ROLE = new TestPermission(ApplicationAuthorities.EditRole, "The authority to edit application roles.", true);
        public static readonly TestPermission DELETE_ROLE = new TestPermission(ApplicationAuthorities.DeleteRole, "The authority to delete application roles.", true);
        public static readonly TestPermission VIEW_USER = new TestPermission(ApplicationAuthorities.ViewUser, "The authority to view application users.", true);
        public static readonly TestPermission EDIT_USER = new TestPermission(ApplicationAuthorities.EditUser, "The authority to edit application users.", true);
        public static readonly TestPermission DELETE_USER = new TestPermission(ApplicationAuthorities.DeleteUser, "The authority to delete application users.", true);
        public TestPermission(string applicationAuthority, string description, bool isActive)
        {               
            TransferObject = new PermissionTO(this, applicationAuthority, description, isActive);
        }
    }
}
