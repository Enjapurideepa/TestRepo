using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6q1
{
    class InvalidCreditLimit : ApplicationException
    {
        public InvalidCreditLimit(string msg) : base(msg)
        {

        }
        public override string Message => base.Message;
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("********** Welcome ***************");
            Console.WriteLine();
            Console.Write("Enter Customer ID : ");
            int customid = int.Parse(Console.ReadLine());
            Console.Write("Enter Customer Name : ");
            string customname = Console.ReadLine();
            Console.Write("Enter Customer Address : ");
            string customaddress = Console.ReadLine();
            Console.Write("Enter Customer City : ");
            string customcity = Console.ReadLine();
            Console.Write("Enter Customer Phone No : ");
            string customphone = Console.ReadLine();
            Console.Write("Enter CreditLimit : ");
            double creditlimit = double.Parse(Console.ReadLine());
            Customer customer = new Customer(customid, customname, customaddress, customcity, customphone, creditlimit);
            ShowDetails(customer);
            Console.ReadKey();
        }
        public static void ShowDetails(Customer customer)
        {
            try
            {
                if (customer.CreditLimit > 5000)
                {
                    throw new InvalidCreditLimit("Credit Limit Exceeded\nPlease Check Once..!");
                }
                else
                {
                    Console.WriteLine("****************** Customer Details ********************");
                    Console.WriteLine();
                    Console.WriteLine("Customer ID   : {0}", customer.CustomerID);
                    Console.WriteLine("Customer Name : {0}", customer.CustomerName);
                    Console.WriteLine("CutomerAddress: {0}", customer.Address);
                    Console.WriteLine("Customer City : {0}", customer.City);
                    Console.WriteLine("Customer Phone: {0}", customer.Phone);
                    Console.WriteLine("Credit LIMIT  : {0}", customer.CreditLimit);
                }
            }
            catch (InvalidCreditLimit IN)
            {
                Console.WriteLine(IN.Message);
            }
        }
    }
}

