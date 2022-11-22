using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBER
{
    class Cust_Sign:Sign_up
    {
        private string Credit_card;
        public Cust_Sign():base()
        {
        }
        public override void sign()
        {
            Console.Write("Enter your Credit_number : ");
            Credit_card = Console.ReadLine();
            //upload data of user if not found or out this account already use
            //base.First_name_s_g = "x";
        }
    }
}
