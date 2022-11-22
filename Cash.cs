using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBER
{
    public class Cash:Payment_Methods
    {
        public override void Process_Record()
        {
            //sql database
            return;
        }
        public  double Payment(double wallet, double cost)
        {
            //sql database
            return base.payment(wallet, cost);
        }
        public override void Recipt()
        {
            //database sql
        }
    }
}
