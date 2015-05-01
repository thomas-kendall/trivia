using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trivia.Core.Entities;
using Trivia.TestData.TransferObjects;

namespace Trivia.TestData.TestObjects
{
    public class TestUser : TestObject<UserTO, User>
    {
        public static readonly TestUser CURLY_JEFFERSON = new TestUser("curly.jefferson@example.com", new List<TestRole>() { TestRole.SUPER_ADMIN });
        public static readonly TestUser OLD_GREGG = new TestUser("old.gregg@example.com", new List<TestRole>() { TestRole.AUTHORIZATION_ADMIN });
        public static readonly TestUser MARY_SAMPSONITE = new TestUser("mary.sampsonite@example.com", new List<TestRole>() { TestRole.ROLE_MANAGER, TestRole.USER_MANAGER });
        public TestUser(string emailAddress, IEnumerable<TestRole> testRoles)
        {
            TransferObject = new UserTO(this, emailAddress, testRoles.Select(tr => tr.TransferObject));
        }
    }
}
