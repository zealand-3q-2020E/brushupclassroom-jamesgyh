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
            var ClassRoom = new ClassRoom();
            ClassRoom.ClassName = "3Q";
            ClassRoom.SemesterStartDateTime = new DateTime(26/8/2019);
            ClassRoom.studentList.Add(new Student("james",4,27));
            ClassRoom.studentList.Add(new Student("leon",5,19));
        }
    }

    
}
