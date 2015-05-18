using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia.Core.Entities
{
    public class ApplicationRole : IdentityRole
    {
        public string Description { get; set; }
    }
}
