
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLibrary;

namespace Lab7_2
{
    class Lab7q3
    {
        public static void Main(string[] args)
        {
            EmployeeList employeelist = new EmployeeLibrary.EmployeeList();
            string ans = "yes";
            do
            {
                Console.WriteLine("1.Add Employee Records");
                Console.WriteLine("2.Search Employee Records");
                Console.WriteLine("3.Delete Employee Record");
                Console.WriteLine("4.View All Records");
                Console.WriteLine("5.Exit");
                Console.Write("Which Option You Want To Select : ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Employee Number : ");
                        int empnumber = int.Parse(Console.ReadLine());
                        Console.Write("Enter Employee Name : ");
                        string empname = Console.ReadLine();
                        Console.Write("Enter Employee Salary : ");
                        double empsalary = double.Parse(Console.ReadLine());
                        Console.Write("Enter Employee PF : ");
                        double emppf = double.Parse(Console.ReadLine());
                        Employee employee = new Employee(empnumber, empname, empsalary, emppf);
                        employeelist.AddEmployee(employee);
                        break;
                    case 2:
                        Console.Write("Which Employee Record You Want To Search : ");
                        int number = int.Parse(Console.ReadLine());
                        var emp = employeelist.SearchRecords(number);
                        if (emp != null)
                        {
                            Console.WriteLine("****************** Displaying Search Results ***************");
                            Console.WriteLine("Employee Name :- " + emp.EmployeeName);
                            Console.WriteLine("Employee Basic Salary :- " + emp.BasicSalary);
                            Console.WriteLine("Employee PF :- " + emp.PF);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("No Match Found");
                            break;
                        }

                    case 3:
                        Console.Write("Which Employee Record You Want To Search : ");
                        int number2 = int.Parse(Console.ReadLine());
                        if (employeelist.DeleteRecords(number2))
                        {
                            Console.WriteLine("Deleted Record Successfully.......!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Entered ID is Invalid...........!");
                            break;
                        }

                    case 4:
                        List<Employee> employees = employeelist.ViewAll();
                        if (employees != null)
                        {
                            foreach (Employee emp1 in employees)
                            {
                                Console.WriteLine("{0} {1} {2} {3}", emp1.EmployeeNumber, emp1.EmployeeName, emp1.BasicSalary, emp1.PF);
                            }
                            break;
                        }
                        else
                            Console.WriteLine("No Data TO Prit...........!");
                        break;

                    case 5:
                        Environment.Exit(0);
                        break;
                }
                Console.WriteLine();
                Console.Write("Do You Wish To Continue : -");
                ans = Console.ReadLine();
            } while (ans == "y" || ans == "Y");
            Console.WriteLine();
            Console.WriteLine("Thank YOU..");
            Console.ReadKey();
        }
    }
}

