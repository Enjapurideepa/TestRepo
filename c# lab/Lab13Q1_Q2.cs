using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace Lab13
{
    [Serializable]
    public class Contact
    {
        public int ContactNo { get; set; }
        public string ContactName { get; set; }
        public string CellNo { get; set; }
    }
    class Lab13Q1_Q2
    {
        public static void Serialization()
        {
            List<Contact> listcontacts = new List<Contact>();
            //Contact contact = new Contact();
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
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream stream = new FileStream("D:\\Temp.txt", FileMode.Create, FileAccess.Write))
                {
                    formatter.Serialize(stream, listcontacts);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static List<Contact> Deserialize()
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream stream = new FileStream("D:\\Temp.txt", FileMode.Open, FileAccess.Read))
                {
                    List<Contact> listContacts = formatter.Deserialize(stream) as List<Contact>;
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
            List<Contact> listcontacts = Deserialize();
            foreach (Contact c in listcontacts)
                Console.WriteLine($"{c.ContactNo} {c.ContactName} {c.CellNo}");
            Console.WriteLine("Done..");
            Console.ReadKey();
        }
    }
}
