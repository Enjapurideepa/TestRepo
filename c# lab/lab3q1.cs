
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Lab3
{
    class StudentData
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************Welcome**************");
            Console.Write("Enter Student Id : ");
            int studid = int.Parse(Console.ReadLine());
            Console.Write("Enter Studet Name : ");
            string studname = Console.ReadLine();
            Console.Write("Enter Foundation Marks : ");
            int foundationmarks = int.Parse(Console.ReadLine());
            Console.Write("Enter WebBasics Marks : ");
            int webmarks = int.Parse(Console.ReadLine());
            Console.Write("Enter Dotnet Marks : ");
            int dotnetmarks = int.Parse(Console.ReadLine());
            Participant participent = new Participant(studid, studname, foundationmarks, webmarks, dotnetmarks);
            participent.obtainedMarks();
            participent.percentage();

            Console.WriteLine("********************* Displaying Results**************");
            Console.WriteLine();
            Console.WriteLine("Percentage of Student :- " + participent.GetPercentage());
            Console.ReadKey();
        }
    }
}

