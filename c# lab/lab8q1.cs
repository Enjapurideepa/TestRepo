
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            string ans = "y";
            do
            {
                Console.WriteLine("1.Add Record");
                Console.WriteLine("2.Search Record");
                Console.WriteLine("3.Display All Records");
                Console.WriteLine("4.Display Count Of Records");
                Console.WriteLine("5.Remove Record");
                Console.WriteLine("6.Exit");
                Console.WriteLine();
                Console.Write("Enter Your Choice :- ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter District Code : ");
                        string dcode = Console.ReadLine();
                        Console.Write("Enter District Name : ");
                        string dname = Console.ReadLine();
                        hashtable.Add(dcode, dname);
                        break;
                    case 2:
                        Console.Write("Enter Which District you want to search\nEnter Code  : ");
                        string scode = Console.ReadLine();
                        int flag = 0;
                        foreach (DictionaryEntry d in hashtable)
                        {
                            if (d.Key.Equals(scode))
                            {
                                Console.WriteLine($"District Code : {d.Key} \nDistrict Name : {d.Value}");
                                flag += 1;
                                break;
                            }
                        }
                        if (flag == 0)
                            Console.WriteLine("Invalid District Code...!");
                        break;
                    case 3:
                        if (hashtable.Count != 0)
                        {
                            Console.WriteLine("Code\tDistrictName");
                            foreach (DictionaryEntry d in hashtable)
                            {
                                Console.WriteLine($"{d.Key}\t{d.Value}");
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("No Records are Available..........!");
                            break;
                        }
                    case 4:
                        Console.WriteLine($"Total count Of Records are : {hashtable.Count}");
                        break;
                    case 5:
                        Console.Write("Enter Which District you want to Delete\nEnter Code  : ");
                        string deletecode = Console.ReadLine();
                        int flag1 = 0;
                        foreach (DictionaryEntry d in hashtable)
                        {
                            if (d.Key.Equals(deletecode))
                            {
                                hashtable.Remove(d.Key);
                                Console.WriteLine("Deleted Record Successfully");
                                flag1 += 1;
                                break;
                            }
                        }
                        if (flag1 == 0)
                            Console.WriteLine("Invalid District Code...!");
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                }
                Console.Write("\n Do You Want To Continue  : ");
                ans = Console.ReadLine();
            } while (ans == "y" || ans == "Y");
        }
    }
}

