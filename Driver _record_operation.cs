using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBER
{
    class Driver__record_operation
    {
        public void Add_Driver_ID(int[] Driver_ID, int ID)
        {
            for (int i = 0; i < Driver_ID.Length; i++)
            {
                if (Driver_ID[i] == 0)
                {
                    Driver_ID[i] = ID;
                    Console.WriteLine("Added successfully");
                    return;
                }
            }
        }
        public void Remove_Driver_ID(int[] Driver_ID, int ID)
        {
            for (int i = 0; i < Driver_ID.Length; i++)
            {
                if (Driver_ID[i] == ID)
                {
                    Driver_ID[i] = 0;
                    Console.WriteLine("Removed successfully");
                    return;
                }
            }
            Console.WriteLine("Error : There is no Driver with this ID");
        }
    }
}
