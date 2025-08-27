// See https://aka.ms/new-console-template for more information
using ClassRoomNet60;

// Et objekt af Classroom oprettes.
Classroom Hold3D = new Classroom()
{
    ClassName = "3D",
    SemesterStart = new DateTime(2025, 08, 25)

};

// To objekter af Student oprettes :-)
Hold3D.StudentList.Add(new Student("Kia", 4, 4));
Hold3D.StudentList.Add(new Student("Mikka", 4, 26));
Hold3D.StudentList.Add(new Student("Lars", 12, 24));

// Console.WriteLines til at kunne udskrive klassenavn, semesterstart og en liste af Students.
Console.WriteLine($"Class Name: {Hold3D.ClassName}");
Console.WriteLine($"Semester Start: {Hold3D.SemesterStart.ToShortDateString()}");
Console.WriteLine("Students:");

// En foreach-løkke som henter Student-objekter på Hold3D StudentListen. Man får udskrevet navn, fødselsdag og hvilken
// årstid fødselsdagen er i.
foreach (var s in Hold3D.StudentList)
{
    Console.WriteLine($" - {s.Name}, Birthday: {s.Birthday}/{s.BirthMonth}, Season: {s.Season()}");
}

Hold3D.CountBirthdaysInEachSeason();
Console.ReadLine();