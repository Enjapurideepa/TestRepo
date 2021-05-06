using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Lab13
{
    public class Supplier
    {
        public int supplierId { get; set; }
        public string supplierName { get; set; }
        public string city { get; set; }
        public string phoneNo { get; set; }
        public string email { get; set; }
    }
    class Lab13Q4
    {
        public static void Serialization()
        {
            try
            {
                Console.WriteLine("Enter Supplier Id : ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Supplier Name : ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Supplier City : ");
                string city = Console.ReadLine();
                Console.WriteLine("Enter Supplier Phone Number : ");
                string number = Console.ReadLine();
                Console.WriteLine("Enter Supplier Email : ");
                string email = Console.ReadLine();
                Supplier supplier = new Supplier() { supplierId = id, supplierName = name, city = city, phoneNo = number, email = email };
                XmlSerializer serializer = new XmlSerializer(typeof(Supplier));
                using (FileStream stream = new FileStream("D://supplier.xml", FileMode.Create, FileAccess.Write))
                {
                    serializer.Serialize(stream, supplier);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static Supplier Deserialize()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Supplier));
                using (FileStream stream = new FileStream("D://supplier.xml", FileMode.Open, FileAccess.Read))
                {
                    Supplier supplier = serializer.Deserialize(stream) as Supplier;
                    return supplier;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        static void Main()
        {
            Serialization();
            Supplier supplier = Deserialize();
            Console.WriteLine("***************** Details ********************");
            Console.WriteLine("ID     : " + supplier.supplierId);
            Console.WriteLine("Name   : " + supplier.supplierName);
            Console.WriteLine("Phone  : " + supplier.phoneNo);
            Console.WriteLine("City   : " + supplier.city);
            Console.WriteLine("Email  : " + supplier.email);
            Console.ReadKey();
        }
    }
}
