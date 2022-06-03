using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTbearerAuthenticationCoreWebAPI.Models
{
   public  interface IJwtAuthenticationManager
    {
        string Authenticate(string email, string username, string password);

    }
}
