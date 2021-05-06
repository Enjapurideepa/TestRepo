
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Lab12Task2
{
    class Program
    {
        static string sourcedata;
        public static void Read(string file_path)
        {

            if (File.Exists(file_path))
            {
                sourcedata = File.ReadAllText(file_path);

            }
        }
        public static void Write(string file_path)
        {

            File.AppendAllText(file_path, sourcedata + Environment.NewLine);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter source path along with file name");
            string source_path = Console.ReadLine();

            Console.WriteLine("Enter source path along with file name");
            string destination_path = Console.ReadLine();
            Read(source_path);
            Write(destination_path);





        }
    }
}

