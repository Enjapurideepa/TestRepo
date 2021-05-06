
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class Lab4Q3

    {
        static Employee[] Employees = new Employee[3];
        static int count = 0;
        static void Main(string[] args)
        {

            string ans = "y";
            do
            {
                Console.WriteLine("1.Enter Permanent Employee Data");
                Console.WriteLine("2.Enter Contract Employee Data");
                Console.Write("Enter Your Choice:");
                int choice = Convert.ToInt32(Console.ReadLine());
                Employee s = null;
                switch (choice)
                {
                    case 1:
                        s = new Employee();
                        break;
                    case 2:
                        s = new Employee();
                        break;
                }
                GetEmployeeDetails(s);

                Console.Write("do you wanna continue(y/n):");
                ans = Console.ReadLine();
            } while (ans == "y");
            DisplayEmployee();
            Console.WriteLine("Press any key to exit:");
            Console.ReadLine();

        }
        static void GetEmployeeDetails(Employee s)
        {
            if (count < 3)
            {

                Console.Write("Enter Employee ID:");
                int sid = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Employee Name:");
                string name = Console.ReadLine();
                Console.Write("Enter Address:");
                string address = Console.ReadLine();
                Console.Write("Enter City:");
                string city = Console.ReadLine();
                Console.Write("Enter Department:");
                string department = Console.ReadLine();
                Console.Write("Enter Salary:");
                double salary = Convert.ToDouble(Console.ReadLine());
                s.EmployeeId = sid;
                s.EmployeeName = name;
                s.City = city;
                s.Address = address;
                s.Department = department;
                s.Salary = salary;

                if (s is PermanentEmployee)
                {
                    PermanentEmployee pe = (PermanentEmployee)s;
                    Console.Write("Enter Provident Fund:");
                    double pf = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter No of Leaves:");
                    int noofleaves = Convert.ToInt32(Console.ReadLine());
                    pe.providentFund = pf;
                    pe.noOfLeaves = noofleaves;

                }
                else if (s is ContractEmployee)
                {
                    ContractEmployee ce = (ContractEmployee)s;

                    Console.Write("Enter Perks:");
                    double perks = Convert.ToInt32(Console.ReadLine());

                    ce.Perks = perks;

                }
                else
                    Employees[count] = s;
                count++;

            }
            else
                Console.WriteLine("No More Space");
        }
        static void DisplayEmployee()
        {
            Console.WriteLine("Employee Name \t Salary");
            foreach (Employee s in Employees)
            {
                Console.Write(s.EmployeeName + "\t\t\t");
                Console.Write(s.GetSalary());
                Console.WriteLine();
            }
        }
    }
}

