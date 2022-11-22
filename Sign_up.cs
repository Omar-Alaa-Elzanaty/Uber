using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBER
{
    public abstract class Sign_up:Person
    {
        private Login log=new Login();
        public  Sign_up()
        {
            Console.Write("Enter username : ");
            log.Username_s_g=Console.ReadLine();
            Console.Write("Enter Password : ");
            log.Password_s_g = Console.ReadLine();
            Console.Write("Enter Gander : Male | Female ? ");
            base.Gander_s_g = Console.ReadLine();
            Console.Write("Enter National ID : ");
            base.National_ID_s_g = Console.ReadLine();
            Console.Write("Enter Birthdate : D / M / Y ->  ");
            string[] s = new string[3];
            s = Console.ReadLine().Split();
            int d = int.Parse(s[0]);
            int m = int.Parse(s[1]);
            int y = int.Parse(s[2]);
            base.set_birthdate(d, m,y);
            base.User = log.Username_s_g;
            base.Password = log.Password_s_g;
        }
        public abstract void sign();
    }
}
