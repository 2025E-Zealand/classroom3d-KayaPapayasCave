using ClassRoomNet60;
namespace ClassroomTests

{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void seasonTestStudentsWinter()
        {
            // Arrange
            var Hold4D = new Classroom();
            Hold4D.StudentList.Add(new Student("Henrik", 5, 8));

            // Act
            string Season = Hold4D.StudentList[0].Season();

            // Assert
            Assert.AreEqual("Winter", Season);
        }

        [TestMethod]
        public void seasonTestStudentsSpring()
        {
            // Arrange
            var Hold4D = new Classroom();
            Hold4D.StudentList.Add(new Student("Henrik", 5, 8));

            // Act
            string Season = Hold4D.StudentList[0].Season();

            // Assert
            Assert.AreEqual("Spring", Season);
        }
    }
}
