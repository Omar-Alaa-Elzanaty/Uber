using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBER
{
    public class Login
    {
        private string Username, Password;
        private bool checker(String type)
        {
            if (type=="Driver") // Driver
            {
                // check database of Driver
                //this.Username;
                return true;
            }
            else // customer
            {
                // check database of customer
                //this.Username;
                return true;
            }
        }
        public Login() { }
        public Login(string user,string pass)
        {
            this.Username = user;
            this.Password = pass;
        }
        public bool check(string ty)
        {
            return checker(ty);
        }
        public string Username_s_g { get => Username; set => Username = value; }
        public string Password_s_g { get => Password; set => Password = value; }
    }
}
