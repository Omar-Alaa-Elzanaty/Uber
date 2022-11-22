using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBER
{
    class Drive_Sign:Sign_up
    {
        private string License;
        public Drive_Sign():base()
        { 
        }
        public override void sign()
        {
            Console.Write("Enter your car License");
            License = Console.ReadLine();
            //upload data of user if not found or out this account already use
        }
    }
}
