using System;
using System.Collections.Generic;
using System.Text;

namespace lab1_q4
{
    class student
    {
        private int rollnumber;
        public int Rollnumber
        {
            get { return rollnumber; }
            set
            {
                rollnumber = value;
            }
        }
        private string studentname;
        public string Studentname
        {
            get { return studentname; }
            set
            {
                studentname = value;
            }
        }
        private byte age;
        public byte Age
        {
            get { return age; }
            set
            {
                age = value;
            }
        }
    }
}
