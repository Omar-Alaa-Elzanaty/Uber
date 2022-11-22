using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBER
{
     public abstract class  Payment_Methods
     {
        public abstract void Process_Record();
        public virtual double payment(double wallet,double coast)
        {
            if (wallet < coast)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("can't complete the operation");
                Console.ForegroundColor = ConsoleColor.White;
                return wallet;
            }
            return wallet - coast;
        }
        public abstract void Recipt();
    }
}
