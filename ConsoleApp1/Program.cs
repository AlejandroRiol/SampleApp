using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {                       //0         //1         //2
            string[] cases = { "progress", "closed", "completed", "another", "onemore", "lastOne"};
            Console.WriteLine(cases[0] + " " + cases[1] + " " + cases[2]);

            Random rand = new Random();
            int index = rand.Next(cases.Length); //0 1 2

            if (cases[index] == "closed")
            {
                cases[index] = "progress";
            }

            Console.WriteLine(cases[0] + " " + cases[1] + " " + cases[2]);
        }
    }
}
