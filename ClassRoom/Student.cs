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

        public override string ToString()
        {
            return $"name{name},birthMonth{birthMonth},birthday{birthday}";
        }

        public string Season()
        {
            if (birthMonth == 12 || birthMonth == 1 || birthMonth == 2)
            {
                return "winter";
            }


            if (birthMonth==3|| birthMonth == 4 || birthMonth == 5)
            {
                return "spring";
            }

            if (birthMonth==6|| birthMonth == 7 || birthMonth == 8)
            {
                return "summer";
            }

            if (birthMonth==9|| birthMonth == 10 || birthMonth == 11)
            {
                return "autumn";
            }
            else
            {
                return "wrong month";
            }
        }
    }
}
