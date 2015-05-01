using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trivia.Core.Entities;

namespace Trivia.TestData.TransferObjects
{
    public class PermissionTO : TransferObject<Permission>
    {
        private string ApplicationAuthority { get; set; }
        private string Description { get; set; }
        private bool IsActive { get; set; }

        public PermissionTO(object key, string applicationAuthority, string description, bool isActive)
        {
            this.Key = key;
            this.ApplicationAuthority = applicationAuthority;
            this.Description = description;
            this.IsActive = isActive;
        }

        public override Permission Materialize(ITestDataManager testDataManager)
        {
            var entity = (Permission)testDataManager.FindTestObjectByKey(Key);
            if (entity == null)
            {
                entity = new Permission();
                entity.ApplicationAuthority = ApplicationAuthority;
                entity.Description = Description;
                entity.IsActive = IsActive;
                testDataManager.AddTestObject(Key, entity);
            }
            return entity;
        }

    }
}
