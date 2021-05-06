using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab12
{
    class Lab12Q1
    {
        class MyException : ApplicationException
        {
            public override string Message => base.Message;
            public MyException(string msg) : base(msg)
            {

            }
        }
        public static void ReadAndDisplay(string file_path)
        {
            try
            {
                if (File.Exists(file_path))
                {
                    FileStream filestream = new FileStream(file_path, FileMode.Open, FileAccess.Read);
                    StreamReader reader = new StreamReader(filestream);
                    string str = reader.ReadLine();
                    while (str != null)
                    {
                        Console.WriteLine(str);
                        str = reader.ReadLine();
                    }
                    reader.Close();
                    filestream.Close();
                }
                else
                    throw new MyException("File Not Found..!");
            }
            catch (MyException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        public static void Main()
        {
            Console.WriteLine("Enter Which File You Want To Open :-");
            string file_path = Console.ReadLine();
            ReadAndDisplay(file_path);
            Console.ReadKey();
        }
    }
}
