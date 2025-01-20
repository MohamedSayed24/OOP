using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPC_
{
    public class BasicAuthenticationService : IAuthenticationService
    {
        string[] userNames = {"mohamed","aya","hesham" };
        string[] passwords = { "mohamed123", "aya222", "hesham456" };
        string[]  roles = { "admin", "user", "dba" };
        public bool AuthenticateUser(string name, string password)
        {
           for(int i=0;i<userNames.Length;i++ )
            {
                if (userNames[i]==name && passwords[i]==password)
                    return true;

            }
            return false;
        }

        public bool AuthorizeUser(string name,string role)
        {
            for (int i = 0; i < userNames.Length; i++)
            {
                if (userNames[i]==name && roles[i]==role)
                    return true;
            }
            return false;
        }

 
    }
}
