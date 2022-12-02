using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBER
{
    class UBER_Scoter:Driver__record_operation, UBER_Services
    {
        public void serviceinfo()
        {
            //this function provide descripition for uber_scoter service
        }
        public double Total_Prices(double trip_coast)
        {
            return trip_coast + (trip_coast * .05f);
        }
        public int Number_of_Riders()
        {
            return 1;
        }
        public void number_of_stoppoint()
        {
            Console.WriteLine("max number of stop point : {0}", 1);
        }
        public int Addorder(int ID, string destination)
        {
            return 0;
            //sql database
        }
        public void Removeorder(int ID, string destination)
        {
            //sql database
        }
    }
}
