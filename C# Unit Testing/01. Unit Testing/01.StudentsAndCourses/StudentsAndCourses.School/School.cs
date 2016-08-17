namespace StudentsAndCourses.School
{
    using System.Collections.Generic;

    internal class School
    {
        private IList<Student> students;
        private IList<Course> courses;

        internal School()
        {
            this.students = new List<Student>();
            this.courses = new List<Course>();
        }

        internal IList<Student> Students { get { return new List<Student>(students); } }

        internal IList<Course> Courses { get { return new List<Course>(courses); } }
    }
}
