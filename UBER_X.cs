using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBER
{
    class UBER_X:Driver__record_operation,UBER_Services
    {
        public void serviceinfo()
        {
            //this function provide descripition for uberx service
        }
        public double Total_Prices(double trip_coast)
        {
            return trip_coast + (trip_coast * .45);
        }
        public int Number_of_Riders()
        {
            return 3;
        }
        public void number_of_stoppoint()
        {
            Console.WriteLine("max number of stop point : {0}", 1);
        }
        public void Addorder(int ID, string destination)
        {
            //sql database
        }
        public void Removeorder(int ID, string destination)
        {
            //sql database
        }
    }
}
