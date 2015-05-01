using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trivia.Core.Entities;

namespace Trivia.TestData.TransferObjects
{
    public class RoleTO : TransferObject<Role>
    {
        private string Name { get; set; }
        private string Description { get; set; }
        private bool IsActive { get; set; }
        private IEnumerable<PermissionTO> PermissionTOs { get; set; }

        public RoleTO(object key, string name, string description, bool isActive, IEnumerable<PermissionTO> permissionTOs)
        {
            this.Key = key;
            this.Name = name;
            this.Description = description;
            this.IsActive = isActive;
            this.PermissionTOs = permissionTOs;
        }

        public override Role Materialize(ITestDataManager testDataManager)
        {
            var entity = (Role)testDataManager.FindTestObjectByKey(Key);
            if (entity == null)
            {
                entity = new Role();
                entity.Name= Name;
                entity.Description = Description;
                entity.IsActive = IsActive;
                if (PermissionTOs != null)
                {
                    foreach(var permissionTO in PermissionTOs)
                    {
                        entity.Permissions.Add(permissionTO.Materialize(testDataManager));
                    }
                }
                testDataManager.AddTestObject(Key, entity);
            }
            return entity;

        }
    }
}
