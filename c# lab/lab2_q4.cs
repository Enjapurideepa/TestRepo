using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_4
{
    class Product
    {
        class ProductDemo
        {
            public Object ProductId;
            public Object Product_Name;
            public Object Price;
            public Object Quantity;
            public double Amt;
        }
        static void Main()
        {
            int pid;
            string pname;
            double price;
            int qty;
            ProductDemo p = new ProductDemo();
            Console.Write("Enter the product ID: ");
            pid = int.Parse(Console.ReadLine());
            p.ProductId = pid;
            Console.Write("Enter the product Name: ");
            pname = (string)Console.ReadLine();
            p.Product_Name = pname;
            Console.Write("Enter the price: ");
            price = double.Parse(Console.ReadLine());
            p.Price = price;
            Console.Write("Enter the quantity: ");
            qty = int.Parse(Console.ReadLine());
            p.Quantity = qty;
            p.Amt = price * qty;
            Console.WriteLine();
            Console.WriteLine($"Product ID:{ (int)p.ProductId}\nProduct Name:{ (string)p.Product_Name}\nPrice:{ (double)p.Price}\nQuantity:{ (int)p.Quantity}\nAmount Payabl{ (double)p.Amt} ");
                Console.ReadKey();
        }
    }
}
