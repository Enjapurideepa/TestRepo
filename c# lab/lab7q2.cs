
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace lab7q2
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductInfo productInfo = new ProductInfo();
            do
            {
                Console.WriteLine("1.Add New Product");
                Console.WriteLine("2.Deleting Currently Searched Product");
                Console.WriteLine("3.Search Product");
                Console.WriteLine("4.Save the New Product");

                Console.WriteLine("5.Exit");
                Console.WriteLine("Enter your Choice");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        {
                            Product p = GetDetails();
                            productInfo.AddProduct(p);

                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Enter Produt Id");
                            int Id = int.Parse(Console.ReadLine());
                            if (productInfo.DeleteProduct(Id))
                            {
                                Console.WriteLine("Product Removed.");
                            }
                            else
                                Console.WriteLine("Invalid Id");
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Enter Product No");
                            string pno = Console.ReadLine();
                            Product product = productInfo.GetProduct(pno);
                            if (product != null)
                            {
                                Console.WriteLine("Price: " + product.ProductName);
                                Console.WriteLine("Price: " + product.Price);
                                Console.WriteLine("Availability: " + product.Stock);
                            }
                            else
                                Console.WriteLine("Product Not Exist");
                        }
                        break;
                    case 4:
                        ArrayList products = productInfo.GetProducts();
                        foreach (Product p in products)
                        {
                            Console.WriteLine("{0} {1} {2} {3}", p.ProductId, p.ProductName, p.Price, p.Stock);
                        }
                        bool a = productInfo.SortedOrder();
                        if (a)
                        {
                            ArrayList products1 = productInfo.GetProducts();
                            foreach (Product p in products1)
                            {
                                Console.WriteLine("{0} {1} {2} {3}", p.ProductId, p.ProductName, p.Price, p.Stock);
                            }
                        }
                        break;

                    case 5:
                        {
                            Environment.Exit(0);
                        }
                        break;


                }
            } while (true);
        }

        private static Product GetDetails()
        {
            Product product = new Product();
            Console.WriteLine("Enter Product Details");
            Console.WriteLine("Enter Id");
            product.ProductId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Product Name");
            product.ProductName = Console.ReadLine();
            Console.WriteLine("Enter Price");
            product.Price = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Stock");
            product.Stock = int.Parse(Console.ReadLine());
            return product;

        }
    }
}
