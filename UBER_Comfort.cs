using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBER
{
    class UBER_Comfort : Driver__record_operation, UBER_Services
    {
        static private int[] Driver_ID = new int[10001];
        public UBER_Comfort()
        {
            Console.WriteLine("Welcome in Uber Comfort");
        }
        public void serviceinfo()
        {
            //description of uber comfort
        }
        public double Total_Prices(double trip_coast)
        {
            return trip_coast + (trip_coast * 0.3);
        }
        public int Number_of_Riders()
        {
            return 3;
        }
        public void number_of_stoppoint()
        {
            Console.WriteLine("max number of stoppoints : {0}", 1);
        }
        public void Add_Driver_ID(int ID)
        {
            base.Add_Driver_ID(Driver_ID, ID);
        }
        public void Remove_Driver_ID(int ID)
        {
            base.Remove_Driver_ID(Driver_ID, ID);
        }
        public int Addorder(int ID,string destination) {
            return 0;
            //sql database
        }
        public void Removeorder(int ID,string destination) {
            //sql database
        }
    }
}
