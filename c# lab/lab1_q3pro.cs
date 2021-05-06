using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Int32.Parse(args[0]);
            switch(num)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("{0} It's a valid Number", num);
                    break;
                default:
                    Console.WriteLine("You Entered an Incorrect Number");
                    break;
            }
            Console.ReadLine();
        }
    }
}
