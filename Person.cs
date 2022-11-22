using System;
namespace UBER
{
    public abstract class Person
    {
        private string First_name, Last_name, National_ID,Phone_number,Current_place,Gander,user,password;
        private int Age;
        private double Wallet;
        private int[] Birthdate = new int[3];
        private int ID;
        public int Age_s_g { get => Age; set => Age = value; }
        public string First_name_s_g { get => First_name; set => First_name = value; }
        public string Last_name_s_g { get => Last_name; set => Last_name = value; }
        public string Gander_s_g { get => Gander; set => Gander = value; }
        public string Current_place_s_g { get => Current_place; set => Current_place = value; }
        public string Phone_number_s_g { get => Phone_number; set => Phone_number = value; }
        public double Wallet_s_g { get => Wallet; set => Wallet = value; }
        public string National_ID_s_g { get => National_ID; set => National_ID = value; }
        public string User { get => user; set => user = value; }
        public string Password { get => password; set => password = value; }
        public int ID_s_g { get => ID; set => ID = value; }

        public Sign_up signup;
        public void set_birthdate(int day ,int month ,int year)
        {
            Birthdate[0] = day;
            Birthdate[1] = month;
            Birthdate[2] = year;
        }
        public string get_birthdate()
        {
            return Convert.ToString(Birthdate[0]) +'\\'+ Convert.ToString(Birthdate[1]) +'\\'+ Convert.ToString(Birthdate[2]);
        }
        public void Add_to_wallet(int newvalue)
        {
            this.Wallet += newvalue;
        }
        public void Remove_from_wallet(int newvalue)
        {
            this.Wallet -= newvalue;
        }
        public void setSignupType(Sign_up sign)// if want to make change instead of default of each constructor
        {                                       // of Driver and customer class
            this.signup = sign;
        }
        public void Sign_up_operation()
        {
            signup.sign();
        }
    }
}