using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSystem
{
    public  class Authentication
    {
        public string LogIn(string username, string password)
        {
            string lmsg ;
                
                if (string.IsNullOrEmpty(username)|| string.IsNullOrEmpty(password))
            {
                lmsg= "* Required,Pls Enter username and password";
            }
            else
            { 
                if((username == "Jon" && password == "Jon@23")||(username=="Admin" && password=="Admin@123")) 
                
                {
                    lmsg = "Login Success !!!";
                }
                else
                {
                    lmsg = "Login Failure, pls enter valid username or password ";
                }
            }
          return lmsg;
        }
    }
}
