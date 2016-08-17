namespace StudentsAndCourses.School
{
    using System;
    using System.Collections.Generic;

    internal class Course
    {
        IList<Student> students;

        internal Course()
        {
            students = new List<Student>();
        }

        internal void AddStudent(Student student)
        {
            if (student == null)
                throw new ArgumentNullException();
            students.Add(student);
        }

        internal void RemoveStudent(Student student)
        {
            if (student == null)
                throw new ArgumentNullException();
            if (!students.Contains(student))
                throw new ArgumentException();
            students.Remove(student);
        }

        internal IList<Student> Students { get { return new List<Student>(students); } }
    }
}
