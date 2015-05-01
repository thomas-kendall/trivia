using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trivia.Core.Entities;

namespace Trivia.TestData.TransferObjects
{
    public class UserTO : TransferObject<User>
    {
        private string EmailAddress { get; set; }
        private IEnumerable<RoleTO> RoleTOs { get; set; }

        public UserTO(object key, string emailAddress, IEnumerable<RoleTO> roleTOs)
        {
            this.Key = key;
            this.EmailAddress = emailAddress;
            this.RoleTOs = roleTOs;
        }

        public override User Materialize(ITestDataManager testDataManager)
        {
            var entity = (User)testDataManager.FindTestObjectByKey(Key);
            if (entity == null)
            {
                entity = new User();
                entity.EmailAddress = EmailAddress;
                entity.Roles = new List<Role>(RoleTOs.Select(r => r.Materialize(testDataManager)));
                testDataManager.AddTestObject(Key, entity);
            }
            return entity;
        }
    }
}
