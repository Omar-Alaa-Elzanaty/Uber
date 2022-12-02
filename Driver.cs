using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UBER
{
    public class Driver : Person
    {
        private string Car_Licence;
        private float Reviews,Reviews_count;
        private bool current_state;
        private int Driver_ID;


        public Driver()
        {
            Reviews_count = 0;
        }
        public Driver(string username, string pass)
        {
            //get tuple of username and pass from Driver and put all data in main attribute
        }
        public Driver(char x)
        {
            Reviews_count = 0;
            signup = new Drive_Sign();
        }
        static public Driver git_driver(int id)
        {
            //git data of driver from databse
            return new Driver();
        }
        public bool Current_state_s_g { get => current_state; set => current_state = value; }
        public string Car_Licence_s_g { get => Car_Licence; set => Car_Licence = value; }
        public int Driver_ID_s_g { get => Driver_ID; set => Driver_ID = value; }

        public float Get_Reviews()
        {
            if (Reviews == 0)
            {
                Console.WriteLine("no Review Yet");
            }
            return Reviews;
        }
        public void Update_Review(int Review) {
            Reviews_count++;
            this.Reviews = (this.Reviews + Review) / Reviews_count;
        }
        /// <summary>
        /// let you know all orders get by this driver 
        /// </summary>
        public void Show_my_orders(int Drive_id,int User_ID,string Destination)
        {
            if (!Current_state_s_g)
            {
                Console.WriteLine("this Driver isn't avilable for now");
            }
            if(Drive_id==this.Driver_ID)
            Console.WriteLine("User_ID : {0} , Destination : {1}", User_ID, Destination);
            
        }
        public int catch_order()
        {
            Console.WriteLine("Enter User ID : ");
            int x = int.Parse(Console.ReadLine());
            return x;
        }
        public string Typeofservice()
        {
            string serve = Console.ReadLine();
            return serve;
        }
    }
}