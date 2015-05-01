using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia.Core
{
    public class ApplicationAuthorities
    {
        public static readonly string ViewPermission = "authorization.permission.view";
        public static readonly string EditPermission = "authorization.permission.edit";
        public static readonly string ViewRole = "authorization.role.view";
        public static readonly string EditRole = "authorization.role.edit";
        public static readonly string DeleteRole = "authorization.role.delete";
        public static readonly string ViewUser = "authorization.user.view";
        public static readonly string EditUser = "authorization.user.edit";
        public static readonly string DeleteUser = "authorization.user.delete";
    }
}
