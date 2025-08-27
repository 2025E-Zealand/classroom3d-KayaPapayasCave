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

        // Metoder
        // En metode som tæller hvor mange fødselsdage der er i hver årstid i klassen. Det er LINQ i C# :)
        public void CountBirthdaysInEachSeason()
        {
            // Denne statement tæller hvor mange Students i StudentList, der har fødselsdag i hver årstid. Dette gemmes i CountBirthdays.
            var CountBirthdays = StudentList
                .GroupBy(s => s.Season())
                .Select(g => new { Season = g.Key, Count = g.Count() });

            // En foreach-løkke hvor alle elementer i CountBirthdays gennemgås, og derefter printes det ud.
            foreach (var c in CountBirthdays)
            {
                Console.WriteLine($"{c.Season}: {c.Count}");
            }
        }

    }
}
