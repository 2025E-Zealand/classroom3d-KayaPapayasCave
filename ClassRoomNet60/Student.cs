using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class Student
    {
        // Properties
        public string Name { get; private set; }
        public int BirthMonth { get; private set; }
        public int Birthday { get; private set; }

        // Constructor
        public Student(string name, int birthMonth, int birthday)
        {
            Name = name;
            BirthMonth = birthMonth;
                // Der er kun 12 måneder. Hvis man angiver noget under 1 eller over 12, så får man en fejlbesked :)
                if (birthMonth < 1 || birthMonth > 12)
                {
                    throw new ArgumentException("Birth month must be between 1 and 12");
                }
            Birthday = birthday;
        }

        // Metoder
        public string Season()
        {
            if (BirthMonth == 12 || BirthMonth == 1 || BirthMonth == 2)
            {
                return "Winter";
            }
            else if (BirthMonth == 3 || BirthMonth == 4 || BirthMonth == 5)
            {
                return "Spring";
            }
            else if (BirthMonth == 6 || BirthMonth == 7 || BirthMonth == 8)
            {
                return "Summer";
            }
            else
            {
                return "Fall";
            }
        }
    }
}
