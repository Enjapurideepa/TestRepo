using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab9
{
    class MyException : ApplicationException
    {
        public MyException(string message) : base(message)
        {

        }
        public override string Message => base.Message;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dicttionary = new Dictionary<string, string>();
            string ans = "y";
            do
            {
                Console.WriteLine("1.ADD");
                Console.WriteLine("2.Display");
                Console.WriteLine("3.Search");
                Console.WriteLine("4.Delete");
                Console.WriteLine("5.Update");
                Console.WriteLine("6.Exit");
                Console.WriteLine();
                Console.Write("Enter Your Choice : ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        try
                        {
                            Console.Write("Enter User ID : ");
                            string id = Console.ReadLine();
                            Console.Write("Enter User Name : ");
                            string name = Console.ReadLine();
                            dicttionary.Add(id, name);
                            Console.WriteLine($"{id} is added into Dictionary......!");
                            break;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            break;
                        }
                    case 2:
                        try
                        {
                            if (dicttionary.Count == 0)
                                throw new MyException("Dictionary IS Empty \nAdd Some Data And Plz Try Again.......!");
                            else
                            {
                                foreach (KeyValuePair<string, string> dict in dicttionary)
                                    Console.WriteLine($"Key : {dict.Key}  Value : {dict.Value}");
                                break;
                            }
                        }
                        catch (MyException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 3:
                        Console.Write("Enter Which Element To Search : ");
                        string search = Console.ReadLine();
                        int flag = 0;
                        try
                        {
                            foreach (KeyValuePair<string, string> dict in dicttionary)
                            {
                                if (dict.Key.Equals(search))
                                {
                                    Console.WriteLine($"The Value Of Searched Key is : {dict.Value}");
                                    flag += 1;
                                    break;
                                }
                            }
                            if (flag == 0)
                                throw new MyException("Key Not Exist In Dictionary");
                        }
                        catch (MyException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 4:
                        Console.Write("Which Key You Want To Delete : ");
                        string deletekey = Console.ReadLine();
                        int flag1 = 0;
                        try
                        {
                            foreach (KeyValuePair<string, string> dict in dicttionary)
                            {
                                if (dict.Key.Equals(deletekey))
                                {
                                    dicttionary.Remove(dict.Key);
                                    Console.WriteLine($"{dict.Key} is Deleted...!");
                                    flag1 += 1;
                                    break;
                                }
                            }
                            if (flag1 == 0)
                                throw new MyException("Key Not Exist In Dictionary");
                        }
                        catch (MyException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 5:
                        Console.Write("Which Key You Want To Update : ");
                        string updatekey = Console.ReadLine();
                        Console.Write("Enter New Value : ");
                        string newValue = Console.ReadLine();
                        int flag2 = 0;
                        foreach (KeyValuePair<string, string> dict in dicttionary)
                        {
                            if (dict.Key.Equals(updatekey))
                            {
                                dicttionary[dict.Key] = newValue;
                                Console.WriteLine($"{dict.Key} is Updated...!");
                                Console.WriteLine("\n****************** Displaying Updated Dictionary *******************\n");
                                foreach (KeyValuePair<string, string> dict1 in dicttionary)
                                    Console.WriteLine($"Key : {dict1.Key}  Value : {dict1.Value}");
                                flag2 += 1;
                                break;
                            }
                        }
                        if (flag2 == 0)
                        {
                            Console.Write("The Key you Were Looking Is Not Exist In the Dictionary\nDo You Want Me TO add That Key In Dictionary : ");
                            string ans2 = Console.ReadLine();
                            if (ans2 == "y" || ans == "Y")
                            {
                                dicttionary.Add(updatekey, newValue);
                                Console.WriteLine("Added Successfully...!");
                                break;
                            }
                        }
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Do You Wish To Continue : ");
                ans = Console.ReadLine();
            } while (ans == "y" || ans == "Y");
        }
    }
}
