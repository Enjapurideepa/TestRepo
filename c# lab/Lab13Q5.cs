using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Lab13
{
    [DataContract]
    class Suppliers
    {
        [DataMember]
        public int supplierId { get; set; }
        [DataMember]
        public string supplierName { get; set; }
        [DataMember]
        public string city { get; set; }
        [DataMember]
        public string phoneNo { get; set; }
        [DataMember]
        public string email { get; set; }
    }
    class Lab13Q5
    {
        public static void Serialize()
        {
            try
            {
                int count = 0;
                Object[] arrayOfSuppliers = new object[2];
                for (int index = 0; index < arrayOfSuppliers.Length; index++)
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
                    arrayOfSuppliers[count] = new Suppliers() { supplierId = id, supplierName = name, city = city, email = email, phoneNo = number };
                    count += 1;
                }
                DataContractJsonSerializer jsonSer = new DataContractJsonSerializer(typeof(Suppliers));
                string path = @"D:\\list1.json";

                using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    jsonSer.WriteObject(stream, arrayOfSuppliers);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void Main()
        {
            Serialize();
            Console.ReadKey();
        }
    }
}
