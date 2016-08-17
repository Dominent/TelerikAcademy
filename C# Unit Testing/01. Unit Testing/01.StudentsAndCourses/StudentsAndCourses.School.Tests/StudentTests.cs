namespace StudentsAndCourses.School.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using MSTestExtensions;
    using System;

    [TestClass]
    public class StudentTests : BaseTest
    {
        [TestMethod]
        public void Name_WhenPassedInvalidName_ShouldThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Student(15000, ""));
        }

        [TestMethod]
        public void Name_WhenPassedNullName_ShouldThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new Student(15000, null));
        }

        [TestMethod]
        public void Id_WhenPassedId_ShouldThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Student(10000, "Name_SetInvalidId_ShouldThrowArgumentException"));
        }
    }
}
