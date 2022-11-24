using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UBER
{
    public class Customer:Person
    {
        private string Mail, Payment_method;
        
        public Customer()
        {
            this.Mail = "NO Mail";
            this.Payment_method = "Cash";
        }
        public Customer(string username,string pass)
        {
            //get tuple of username and pass from customer and put all data in main attribute
        }
        public Customer(int x)
        {
            this.Mail = "NO Mail";
            this.Payment_method = "Cash";
            signup = new Cust_Sign();
        }
        public string Payment_method_s_g { get => Payment_method; set => Payment_method = value; }

        public string Select_Service() {
            Console.WriteLine("choose your Travel : \n");
            string travel_type;
            travel_type = Console.ReadLine();
            // sql database for activity record
            return travel_type;
        }
        public int Add_Review()
        {
            int review = 0;
            while (true)
            {
                Console.WriteLine("Choose your rate from -5 stars to 5 stars");
                review = int.Parse(Console.ReadLine());
                if (review >= -5 && review <= 5) break;
            }
            return review;
        }
        public float Detect_price()
        {
            Console.WriteLine("Enter the expected price");
            float Expected_price = float.Parse(Console.ReadLine());
            return Expected_price;
        }
        public string Destination()
        {
            Distination_s_g = Console.ReadLine();
            return Distination_s_g;
        }
        ~Customer(){
            //update data or create one in database
        }
        // i think that should make order class or function insert your Destination
    }
}