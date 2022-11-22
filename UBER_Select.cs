using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBER
{
    class UBER_Select: Driver__record_operation,UBER_Services
    {
        static private int[] Driver_ID=new int[10001];

        public UBER_Select()
        {
            Console.WriteLine("Welcome in Uber Select");
        }
        public void serviceinfo()
        {
            //descripition for uber select
        }
        public double Total_Prices(double trip_price)
        {
            return trip_price + (trip_price * .3);
        }
        public int Number_of_Riders()
        {
            return 4;
        }
        public void number_of_stoppoint()
        {
            Console.WriteLine("max number of stop point : {0}", 4);
        }
        public void Add_Driver_ID(int ID)
        {
            base.Add_Driver_ID(Driver_ID, ID);
        }
        public void Remove_Driver_ID(int ID)
        {
            base.Remove_Driver_ID(Driver_ID, ID);
        }
        public void Addorder(int ID, string destination)
        {
            //sql database
        }
        public void Removeorder(int ID, string destination)
        {
            //sql database
        }

        public static implicit operator int(UBER_Select v)
        {
            throw new NotImplementedException();
        }
    }
}
