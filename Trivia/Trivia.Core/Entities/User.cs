using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia.Core.Entities
{
    public class User : Entity
    {
        public string EmailAddress { get; set; }
        public virtual ICollection<Role> Roles { get; set; }

    }
}
