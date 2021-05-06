using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;
using System.Collections;

namespace Lab13
{
    class Lab13Q3
    {
        public static void Serialization()
        {
            ArrayList listcontacts = new ArrayList();
            string ans = "y";
            try
            {
                do
                {
                    Console.Write("Enter Contact NO :");
                    int no = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Name : ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Cell No : ");
                    string cell = Console.ReadLine();
                    listcontacts.Add(new Contact() { ContactNo = no, ContactName = name, CellNo = cell });
                    Console.Write("Do You Want To add more : ");
                    ans = Console.ReadLine();
                } while (ans == "Y" || ans == "y");
                SoapFormatter formatter = new SoapFormatter();
                using (FileStream stream = new FileStream("D:\\soap.xml", FileMode.Create, FileAccess.Write))
                {
                    formatter.Serialize(stream, listcontacts);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static ArrayList Deserialize()
        {
            try
            {
                SoapFormatter formatter = new SoapFormatter();
                using (FileStream stream = new FileStream("D:\\soap.xml", FileMode.Open, FileAccess.Read))
                {
                    ArrayList listContacts = formatter.Deserialize(stream) as ArrayList;
                    return listContacts;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        public static void Main(string[] args)
        {
            Serialization();
            ArrayList listcontacts = Deserialize();
            foreach (Contact c in listcontacts)
                Console.WriteLine($"{c.ContactNo} {c.ContactName} {c.CellNo}");
            Console.WriteLine("Done..");
            Console.ReadKey();
        }
    }
}
