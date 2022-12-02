using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBER
{
    interface UBER_Services
    {
        void serviceinfo();
        double Total_Prices(double trip_coast);
        int Number_of_Riders();
        void number_of_stoppoint();
        int Addorder(int id, string Destination);
        void Removeorder(int id, string Destination);
    }
}
