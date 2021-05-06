using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter First Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Which Opertation You Want To Perform: ");
            string op = Console.ReadLine();
            switch(op)
            {
                case "+":
                    Console.WriteLine(Cal.Add(num1, num2));
                    break;
                case "-":
                    Console.WriteLine(Cal.Sub(num1, num2));
                    break;
                case "*":
                    Console.WriteLine(Cal.Mul(num1, num2));
                    break;
                case "/":
                    Console.WriteLine(Cal.Div(num1, num2));
                    break;
                case "%":
                    Console.WriteLine(Cal.Mod(num1, num2));
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
            Console.ReadLine();
        }
    }
}
