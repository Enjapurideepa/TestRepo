using System;

namespace lab1_q4
{
    class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
            SetDetails(s);
            GetDetails(s);
            Console.ReadLine();
        }
        static void SetDetails(student s1)
        {
            Console.Write("Enter Roll Number of student : ");
            s1.Rollnumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name of student : ");
            s1.Studentname = Console.ReadLine();
            Console.Write("Enter Age of student : ");
            s1.Age = Convert.ToByte(Console.ReadLine());
        }
        static void GetDetails(student s1)
        {
            Console.WriteLine("********************************StudentDetails*****************************");
            Console.WriteLine("roll number :- " + s1.Rollnumber);
            Console.WriteLine("name :- " + s1.Studentname);
            Console.WriteLine("Age :- " + s1.Age);
        }
        }
    }
