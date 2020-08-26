using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class Student
    {
        public string name { get; set; }
        public int birthMonth { get; set; }
        public int birthday { get; set; }

        public Student(string Name, int BirthMonth, int Birthday)
        {
            name = Name;
            birthMonth = BirthMonth;
            birthday = Birthday;
        }

        
    }
}
