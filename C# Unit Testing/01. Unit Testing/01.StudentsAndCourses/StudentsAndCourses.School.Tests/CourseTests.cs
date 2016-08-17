namespace StudentsAndCourses.School.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using MSTestExtensions;
    using System;

    [TestClass]
    public class CourseTests : BaseTest
    {
        [TestMethod]
        public void AddStudent_WhenPassedNull_ShouldThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => (new Course()).AddStudent(null));
        }

        [TestMethod]
        public void RemoveStudent_WhenPassedNull_ShouldThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => (new Course()).RemoveStudent(null));
        }

        [TestMethod]
        public void RemoveStudent_WhenPassedStudentDosentExist_ShouldThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => (new Course()).RemoveStudent(new Student(15000, "TestStudent")));
        }
    }
}
