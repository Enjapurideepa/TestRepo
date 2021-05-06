using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    public class ArithmeticOperation1
    {

        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Sub(double a, double b)
        {
            return a - b;
        }
        public double Mul(double a, double b)
        {
            return a * b;
        }
        public double Divide(double a, double b)
        {
            return a / b;
        }
        public double Max(double a, double b)
        {
            return Math.Max(a, b);
        }
    }

    class Lab10Q2
    {
        public delegate double ArithmeticDelegate(double a, double b);
        public static double PerformArithmeticOperation(ArithmeticDelegate arithmeticDelegate, double a, double b)
        {
            return arithmeticDelegate(a, b);
        }
        static void Main(string[] args)
        {
            ArithmeticOperation1 arithmeticOperation1 = new ArithmeticOperation1();
            string ans = "y";
            do
            {
                Console.Write("Enter First Number :");
                double num1 = double.Parse(Console.ReadLine());
                Console.Write("Enter Second Number :");
                double num2 = double.Parse(Console.ReadLine());
                Console.WriteLine("1.Addition");
                Console.WriteLine("2.Subtraction");
                Console.WriteLine("3.Multiplication");
                Console.WriteLine("4.Division");
                Console.WriteLine("5.Maximum Of Two");
                Console.WriteLine("6.Exit");
                Console.Write("Which Operation You Want To Perform  : ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ArithmeticDelegate arithmetic = arithmeticOperation1.Add;
                        Console.WriteLine("The Addition Of Two Numbers is :{0} ", PerformArithmeticOperation(arithmetic, num1, num2));
                        break;
                    case 2:
                        ArithmeticDelegate arithmetic1 = arithmeticOperation1.Sub;
                        Console.WriteLine("The Subtraction Of Two Numbers is : {0} ", PerformArithmeticOperation(arithmetic1, num1, num2));
                        break;
                    case 3:
                        ArithmeticDelegate arithmetic2 = arithmeticOperation1.Mul;
                        Console.WriteLine("The Multiplication Of Two Numbers is : {0}", PerformArithmeticOperation(arithmetic2, num1, num2));
                        break;
                    case 4:
                        ArithmeticDelegate arithmetic3 = arithmeticOperation1.Divide;
                        Console.WriteLine("The Division Of Two Numbers is : {0}", PerformArithmeticOperation(arithmetic3, num1, num2));
                        break;
                    case 5:
                        ArithmeticDelegate arithmetic4 = arithmeticOperation1.Max;
                        Console.WriteLine("The Maximum Of Two Numbers is : {0}", PerformArithmeticOperation(arithmetic4, num1, num2));
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                }
                Console.Write("Want to continue : ");
                ans = Console.ReadLine();
            } while (ans == "y" || ans == "Y");
        }
    }
}
