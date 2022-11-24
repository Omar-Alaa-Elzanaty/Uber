using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace UBER
{
    class startpoint
    {
        static void Main(string[] args)
        {
            Console.WriteLine("         Welcome in Uber");
            Console.WriteLine("Sign up / Login   AS : Customer Click 1");
            Console.WriteLine("Sign up / Login   AS : Drvier   Click 2");
            string type = Console.ReadLine();
            Console.WriteLine("For Sign up -> 1  :  Login  -> 2");
            string operation = Console.ReadLine();
            string user, pass;
            if (type == "1")//customer
            {
                Customer cust;
                if (operation == "1")//signUp
                {
                    cust = new Customer(0);
                    cust.Sign_up_operation();
                    Console.WriteLine("Thanks for using Uber App");
                }
                else // login
                {
                    Console.Write("Enter Username : ");
                    user = Console.ReadLine();
                    Console.Write("Enter Password : ");
                    pass = Console.ReadLine();
                    Login logdata = new Login(user, pass);
                    while(!logdata.check("Customer"))
                    {
                        Console.WriteLine("There is something Wrong Username or Password");
                        Console.WriteLine("Enter Username then Password");
                        logdata.Username_s_g = Console.ReadLine();
                        logdata.Password_s_g = Console.ReadLine();
                    }
                    cust = new Customer(user, pass);
                    Console.WriteLine("         Welcome back on Uber App");

                    Console.WriteLine("to Make Order -> press 1");
                    Console.WriteLine("to show balancing wallet -> press 2");
                    Console.WriteLine("to show last payment method -> press 3");
                    string choice = Console.ReadLine();
                    if (choice == "1") make_order(cust);//order
                    if (choice == "2") Console.WriteLine($"Your Balance wallet : {cust.Wallet_s_g}");
                    if (choice == "3") cust.Payment_method_s_g=" ";
                }
            }
            else //driver
            {
                Driver driver;
                if (operation == "1")//signUp
                {
                    driver = new Driver(0);
                    driver.Sign_up_operation();
                }
                else// login
                {
                    Console.Write("Enter Username : ");
                    user = Console.ReadLine();
                    Console.Write("Enter Password : ");
                    pass = Console.ReadLine();
                    Login logdata = new Login(user, pass);
                    while (!logdata.check("Drvier"))
                    {
                        Console.WriteLine("There is something Wrong Username or Password");
                    }
                    driver = new Driver(user, pass);

                }
            }
        }
        public static void make_order(Customer cust)
        {
            double price = 0;
            UBER_Services serve;
            price = cust.Detect_price();
            Console.WriteLine("Enter your destination:  ");
            string destination = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nEnter number of  your Serves");
            Console.WriteLine("1- Uber_Select");
            Console.WriteLine("2- Uber_Comfort");
            Console.WriteLine("3- Uber_X");
            Console.WriteLine("4- Uber_Scoter");
            Console.ForegroundColor = ConsoleColor.White;
            int serves_choice = int.Parse(Console.ReadLine());
            if (serves_choice == 1) serve = new UBER_Select(); 
            else if (serves_choice == 2) serve = new UBER_Comfort(); 
            else if (serves_choice == 3) serve = new UBER_X();
            else if (serves_choice == 4) serve = new UBER_Scoter();
            else serve = new UBER_Select();
            string choice;
            while (true)
            {
                Console.WriteLine("\nchoose your Serves options by Entering it's name");
                Console.WriteLine("________________________________________________\n");
                Console.WriteLine("Serviceinfo");
                Console.WriteLine("Number_of_Riders");
                Console.WriteLine("Number_of_stoppoint");
                Console.WriteLine("Total_Prices");
                Console.WriteLine("Next");
                choice = Console.ReadLine().ToLower();
                if (choice == "next") break;
                else if (choice == "serviceinfo") {serve.serviceinfo();}
                else if (choice == "number_of_riders") { Console.WriteLine(serve.Number_of_Riders());}
                else if (choice == "number_of_stoppoint") { serve.number_of_stoppoint();}
                else if (choice == "total_prices") { Console.WriteLine("Cost of Trip "+serve.Total_Prices(price));}
                else Console.WriteLine("choose one of avaliable options");
            }
            changecolor(ConsoleColor.Red);
            Console.WriteLine("choose Payment Method");
            changecolor(ConsoleColor.White);
            Console.WriteLine("Cash");
            Console.WriteLine("Online Wallet");
            choice = Console.ReadLine().ToLower();
            changecolor(ConsoleColor.Green);
            Payment_Methods pay;
            if (choice == "online wallet")
            {
                pay = new Online_Wallet();
                double money = cust.Wallet_s_g;
                money = pay.payment(money, serve.Total_Prices(money));
                if (money >= 0) cust.Wallet_s_g -= money;
            }
            else
            {
                pay = new Cash();
                pay.Process_Record();
                changecolor(ConsoleColor.DarkGreen);
                Console.WriteLine("Completed process...");
                changecolor(ConsoleColor.White);
            }
            pay.Recipt();//need implementation
        }
        static void changecolor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }
    }
   
}
