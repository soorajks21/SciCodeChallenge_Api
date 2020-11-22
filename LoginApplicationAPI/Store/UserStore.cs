using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginApplicationAPI.Store
{
    public class UserStore
    {
        public UserStore()
        {

        }
        public bool login(string userName, string password)
        {
            if(userName=="Sooraj" && password=="Password")
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
