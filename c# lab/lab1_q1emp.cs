
        using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Records
    {
        public class Employee
        {
            private int employeeid;
            public int EmployeeId
            {
                get { return employeeid; }
                set
                {
                    employeeid = value;
                }
            }
            private string employeename;
            public string EmployeeName
            {
                get { return employeename; }
                set
                {
                    employeename = value;
                }
            }
            private string address;
            public string Address
            {
                get { return address; }
                set
                {
                    address = value;
                }
            }
            private string city;
            public string City
            {
                get { return city; }
                set
                {
                    city = value;
                }
            }
            private string department;
            public string Department
            {
                get { return department; }
                set
                {
                    department = value;
                }
            }
            private float salary;
            public float Salary
            {
                get { return salary; }
                set
                {
                    salary = value;
                }
            }
        }
    }
