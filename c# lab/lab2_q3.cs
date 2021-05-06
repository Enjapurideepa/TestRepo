using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3_Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Cities = new string[10];
            int i = 0;
            while (true)
            {
                Console.Write("Enter which city you want to add : ");
                Cities[i] = Console.ReadLine();
                i++;
                Console.WriteLine();
                Console.Write("do you want to continue : ");
                string c = Console.ReadLine();
                if (c == "Y" || c == "y")
                    continue;
                else
                    break;
            }
            Console.WriteLine("Printing cities : ---");
            foreach (string city in Cities)
            {
                Console.WriteLine(city);
            }
            Console.ReadLine();
        }
    }
}
