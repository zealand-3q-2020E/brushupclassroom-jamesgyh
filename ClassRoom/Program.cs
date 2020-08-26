using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Student
    {
        public string name;
        public int birthMonth;
        public int birthday;

        public Student(string Name,int BirthMonth,int Birthday)
        {
            name = Name;
            birthMonth = BirthMonth;
            birthday = Birthday;
        }
       
    }
}
