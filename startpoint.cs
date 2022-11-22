﻿using System;
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
            Person person;
            if (type == "1")//customer
            {
                if (operation == "1")//signUp
                {
                    person = new Customer(0);
                    person.Sign_up_operation();
                    Console.WriteLine("Thanks for using Uber App");
                }
                else // login
                {
                    Console.Write("Enter Username : ");
                    user = Console.ReadLine();
                    Console.Write("Enter Password : ");
                    pass = Console.ReadLine();
                    Login logdata = new Login(user, pass);
                    while (!logdata.check("Customer"))
                    {
                        Console.WriteLine("There is something Wrong Username or Password");
                    }
                    person = new Customer(user, pass);
                    Console.WriteLine("         Welcome back on Uber App");

                    Console.WriteLine("to Make Order -> press 1");
                    string choice = Console.ReadLine();
                    if (choice == "1") make_order((Customer)person);//order
                }
            }
            else //driver
            {
                if (operation == "1")//signUp
                {
                    person = new Driver(0);
                    person.Sign_up_operation();
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
                    person = new Driver(user, pass);

                }
            }
        }
        public static void make_order(Customer cust)
        {
            double price = 0;
            UBER_Services serve;
            Console.WriteLine("Enter The price of trip:  ");
            price = double.Parse(Console.ReadLine());
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
