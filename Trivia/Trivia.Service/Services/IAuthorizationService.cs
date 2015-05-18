using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia.Service.Services
{
    public interface IAuthorizationService
    {
        bool LoginUser(string email, string password);
    }
}
