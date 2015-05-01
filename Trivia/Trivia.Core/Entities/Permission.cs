using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia.Core.Entities
{
    public class Permission : Entity
    {
        public string ApplicationAuthority { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
