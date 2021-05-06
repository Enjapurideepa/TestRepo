
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Lab3Q4
    {
        public int supplierId;
        public string supplierName;
        public string city;
        public string phoneNo;
        public string email;

        public void AcceptDetails(int sid, string sname, string c, string pn, string e)
        {
            supplierId = sid;
            supplierName = sname;
            city = c;
            phoneNo = pn;
            email = e;
        }
        public void DisplayDetails()
        {
            Console.WriteLine("***********");
            Console.WriteLine("SUpplier Id:" + supplierId);
            Console.WriteLine("SUpplier Name:" + supplierName);
            Console.WriteLine("city:" + city);
            Console.WriteLine("phone No:" + phoneNo);
            Console.WriteLine("email:" + email);
        }

    }
    class SupplierTest
    {
        public static void Main(string[] args)
        {
            Lab3Q4 l = new Lab3Q4();
            Console.WriteLine("Enter Supplier id:");
            int sid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Supplier Name:");
            string sname = Console.ReadLine();
            Console.WriteLine("Enter Supplier city:");
            string city = Console.ReadLine();
            Console.WriteLine("Enter Supplier Phone No:");
            string phno = Console.ReadLine();
            Console.WriteLine("Enter Supplier email:");
            string e = Console.ReadLine();


            l.AcceptDetails(sid, sname, city, phno, e);
            l.DisplayDetails();
            Console.ReadLine();
        }
    }
}
