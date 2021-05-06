using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab7Task1and2;
namespace Lab7
{
    class Program
    {
        static void Main()
        {
            ContactList contactlist = new ContactList();
            do
            {
                Console.WriteLine("1.Add Contact");
                Console.WriteLine("2.Display Contact");
                Console.WriteLine("3.Edit Contact");
                Console.WriteLine("4.Show All Contacts");
                Console.WriteLine("5.Exit");
                Console.WriteLine("Enter your Choice");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        {
                            Contact c = GetDetails();
                            contactlist.AddContact(c);

                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Enter Cell No");
                            string cellno = Console.ReadLine();
                            Contact contact = contactlist.DisplayContact(cellno);
                            if (contact != null)
                            {
                                Console.WriteLine("Contact Name: " + contact.ContactName);
                                Console.WriteLine("Contact No: " + contact.ContactNo);
                            }
                            else
                                Console.WriteLine("Contact Not Exist");
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Enter ContactNo to verify:");
                            int contactno = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter New Contact Name");
                            string contactname = Console.ReadLine();
                            Console.WriteLine("Enter New Cell No");
                            string cellno = Console.ReadLine();
                            if (contactlist.EditContact(contactno, contactname, cellno))
                            {
                                Console.WriteLine("Contact Updated.");
                            }
                            else
                                Console.WriteLine("Invalid Contact Details");

                        }
                        break;
                    case 4:
                        {
                            List<Contact> contacts = contactlist.DisplayContacts();
                            foreach (Contact c in contacts)
                            {
                                Console.WriteLine("{0} {1} {2} ", c.ContactNo, c.ContactName, c.CellNo);
                            }

                        }
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;


                }

            } while (true);
        }

        private static Contact GetDetails()
        {
            Contact contact = new Contact();
            Console.WriteLine("Enter Contact Details");
            Console.WriteLine("Enter ContactNo");
            contact.ContactNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Contact Name");
            contact.ContactName = Console.ReadLine();
            Console.WriteLine("Enter CellNo");
            contact.CellNo = Console.ReadLine();

            return contact;

        }

    }
}

