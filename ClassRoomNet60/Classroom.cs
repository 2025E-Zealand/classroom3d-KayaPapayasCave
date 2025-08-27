using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    internal class Classroom
    {
        // Properties
        public string ClassName { get; set; }
        public List<Student> StudentList { get; set; }
        public DateTime SemesterStart { get; set; }

        // Constructor
        public Classroom()
        {
            StudentList = new List<Student>();
        }

    }
}
