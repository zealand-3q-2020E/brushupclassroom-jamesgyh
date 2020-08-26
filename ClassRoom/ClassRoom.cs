using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class ClassRoom
    {
        public string ClassName { get; set; }
        public List<Student> studentList { get; set; }
        public DateTime SemesterStartDateTime { get; set; }

        public ClassRoom()
        {
            studentList=new List<Student>();
            SemesterStartDateTime = new DateTime();
        }
    }
}

