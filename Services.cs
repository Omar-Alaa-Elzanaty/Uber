using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace UBER
{
    class Services
    {

        // pair of string take question and answer
        Dictionary<string, string> Faq;

        public Services()
        {
            Console.WriteLine("Services is Additional feature to UBER APP to faciliate your Experience dealing with this App");
        }
        public void Help()
        {
            // this function is tutorial for the program you can print any descirpition to this console project
        }
        public void FAQ()
        {
            foreach(var i in Faq)
            {
                Console.WriteLine("Question : " + i.Key);
                Console.WriteLine("Answer : " + i.Value);
            }
        }
        public void ADD_FQ()
        {
            Console.WriteLine("Write a new Question");
            string que = Console.ReadLine();
            Faq.Add(que, "");
        }
        public void ADD_ANS()
        {
            FAQ();
            Console.WriteLine("Write your question that you want to answer it correctly");
            string que = Console.ReadLine();
            Console.WriteLine("Write your answer ");
            string ans = Console.ReadLine();
            Faq[que] = ans;
        }
    }
}
