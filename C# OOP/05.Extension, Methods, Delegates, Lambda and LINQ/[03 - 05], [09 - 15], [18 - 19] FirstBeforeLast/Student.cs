//-----------------------------------------------------------------------
// <copyright file="Student.cs" company="Telerik Academy">
// Telerik Academy by Progress
// </copyright>
// <author>Petromil "Dominent" Pavlov </author>
//-----------------------------------------------------------------------

namespace FirstBeforeLast
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Collection of all possible marks a student can acquire.
    /// </summary>
    public enum Marks
    {
        /// <summary>
        /// Grade Poor means that the student failed.
        /// </summary>
        Poor,

        /// <summary>
        /// Grade Average means that the student passed.
        /// </summary>
        Average,

        /// <summary>
        /// Grade Good means that the student passed with excellence.
        /// </summary>
        Good,

        /// <summary>
        /// Grade Excellent means that the student achieved top results.
        /// </summary>
        Excellent
    }

    /// <summary>
    /// Student base class.
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Gets or sets the first name of the student.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name of the student.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the age of the student.
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Gets or sets the phone of the student.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the email of the student.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the group of the student.
        /// </summary>
        public int Group { get; set; }

        /// <summary>
        /// Gets or sets the city of the student.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the faculty number of the student.
        /// </summary>
        public string FacultyNumber { get; set; }

        /// <summary>
        /// Gets or sets a collection of the marks of the student.
        /// </summary>
        public List<Marks> Marks { get; set; }

        /// <summary>
        /// Filters students by comparing names lexicographically.
        /// </summary>
        /// <param name="students">Array of Student objects</param>
        /// <returns>Collection of students that match the condition.</returns>
        public static IEnumerable<Student> Filter(Student[] students)
        {
            var output =
                from student in students
                where student.FirstName.CompareTo(student.LastName) == -1
                select student;

            return output;
        }

        /// <summary>
        /// Display representation of the student.
        /// </summary>
        /// <returns>A string containing first and last name of the student</returns>
        public override string ToString()
        {
            return $"[ First name: {FirstName}, Last name: {LastName} ]";
        }
    }
}