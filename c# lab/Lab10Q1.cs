using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    public class ArithmeticOperation
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
    class Lab10Q1
    {
        public delegate double ArithmeticDelegate(double a, double b);
        static void Main(string[] args)
        {
            ArithmeticOperation arithmeticOperation = new ArithmeticOperation();
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
                        ArithmeticDelegate arithmetic = new ArithmeticDelegate(arithmeticOperation.Add);
                        Console.WriteLine("The Addition Of Two Numbers is : " + arithmetic(num1, num2));
                        break;
                    case 2:
                        ArithmeticDelegate arithmetic1 = new ArithmeticDelegate(arithmeticOperation.Sub);
                        Console.WriteLine("The Subtraction Of Two Numbers is : " + arithmetic1(num1, num2));
                        break;
                    case 3:
                        ArithmeticDelegate arithmetic2 = new ArithmeticDelegate(arithmeticOperation.Mul);
                        Console.WriteLine("The Multiplication Of Two Numbers is : " + arithmetic2(num1, num2));
                        break;
                    case 4:
                        ArithmeticDelegate arithmetic3 = new ArithmeticDelegate(arithmeticOperation.Divide);
                        Console.WriteLine("The Division Of Two Numbers is : " + arithmetic3(num1, num2));
                        break;
                    case 5:
                        ArithmeticDelegate arithmetic4 = new ArithmeticDelegate(arithmeticOperation.Max);
                        Console.WriteLine("The Maximum Of Two Numbers is : " + arithmetic4(num1, num2));
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
