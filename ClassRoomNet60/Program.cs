// See https://aka.ms/new-console-template for more information
using ClassRoomNet60;

Classroom Hold3D = new Classroom()
{
    ClassName = "3D",
    SemesterStart = new DateTime(2025, 08, 25)

};

Hold3D.StudentList.Add(new Student("Kia", 4, 4));
Hold3D.StudentList.Add(new Student("Mikka", 4, 26));

Console.WriteLine($"Class Name: {Hold3D.ClassName}");
Console.WriteLine($"Semester Start: {Hold3D.SemesterStart.ToShortDateString()}");
Console.WriteLine("Students:");

foreach (var s in Hold3D.StudentList)
{
    Console.WriteLine($" - {s.Name}, Birthday: {s.Birthday}/{s.BirthMonth}, Season: {s.Season()}");
}