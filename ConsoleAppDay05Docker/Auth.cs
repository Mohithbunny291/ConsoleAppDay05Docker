using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay05Docker
{
    public class Auth
    {
        public string Login(string username, string password)
        {
            string loginMsg;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                loginMsg = "Name and Password can't be empty";
            else
            {
                if (((username == "Sam") && (password == "Sam123")) || ((username == "Admin") && (password == "Admin123")))
                {
                    loginMsg = "login success";
                }
                else
                {
                    loginMsg = "login fail";
                }
            }
            return loginMsg;
        }
    }
}
