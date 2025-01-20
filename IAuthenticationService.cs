using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPC_
{
    public interface IAuthenticationService
    {
        bool AuthenticateUser(string name , string password);

        bool AuthorizeUser(string name , string role);
    }
}
