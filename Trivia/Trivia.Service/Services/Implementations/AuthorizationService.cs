using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trivia.Core.Entities;
using Trivia.Core.Repository;

namespace Trivia.Service.Services.Implementations
{
    public class AuthorizationService : IAuthorizationService
    {
        private IApplicationUserRepository applicationUserRepository;

        public AuthorizationService(IApplicationUserRepository userRepository)
        {
            applicationUserRepository = userRepository;
        }

        public bool LoginUser(string email, string password)
        {
            bool result = false;
            ApplicationUser user = applicationUserRepository.FindByEmail(email);
            if(user != null)
            {
                // TODO: check password against the database
            }
            return result;
        }
    }
}
