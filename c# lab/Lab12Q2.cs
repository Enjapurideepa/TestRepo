using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab12_2
{
    class Lab12Q2
    {
        class MyException : ApplicationException
        {
            public override string Message => base.Message;
            public MyException(string msg) : base(msg)
            {

            }
        }
        public static void SourceToDestination(string source_path, string destination)
        {
            try
            {
                if (File.Exists(source_path) && File.Exists(destination))
                {
                    string source_content = File.ReadAllText(source_path);
                    if (source_content != null)
                        File.AppendAllText(destination, source_content + Environment.NewLine);

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
            Console.WriteLine("Enter From Which File You Want To Copy :-");
            string source_path = Console.ReadLine();
            Console.WriteLine("Enter From Destination Location:-");
            string destination_path = Console.ReadLine();
            SourceToDestination(source_path, destination_path);
            Console.ReadKey();
        }
    }
}
