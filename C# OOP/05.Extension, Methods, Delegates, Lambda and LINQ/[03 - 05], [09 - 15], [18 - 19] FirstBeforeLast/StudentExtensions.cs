//-----------------------------------------------------------------------
// <copyright file="StudentExtensions.cs" company="Telerik Academy">
// Telerik Academy by Progress
// </copyright>
// <author>Petromil "Dominent" Pavlov </author>
//-----------------------------------------------------------------------

namespace FirstBeforeLast
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Public class holding extension methods for Student.
    /// </summary>
    public static class StudentExtensions
    {
        /// <summary>
        /// Implements an extension method for the class student.
        /// Filters all students by group number, where the group number is equal to 2.
        /// </summary>
        /// <param name="collection">Extension method target.</param>
        /// <returns>All students that match the conditions.</returns>
        public static List<Student> FilterByGroup(this List<Student> collection)
        {
            var studByGroup =
              from stud in collection
              where stud.Group == 2
              orderby stud.FirstName
              select stud;

            return studByGroup.ToList();
        }

        /// <summary>
        /// Implements an extension method for the class student.
        /// Filters all students by grade,where the grade is poor and there are more than two occurrences.
        /// </summary>
        /// <param name="collection">Extension method target.</param>
        /// <returns>All students that match the conditions.</returns>
        public static List<Student> FilterByGrade(this List<Student> collection)
        {
            var studByGrade =
                from stud in collection
                where stud.Marks.FindAll(x => x == Marks.Poor).Count == 2
                select stud;

            return studByGrade.ToList();
        }

        /// <summary>
        /// Implements an extension method for the class student.
        /// Groups all students by group in an ascending order.
        /// </summary>
        /// <param name="collection">Extension method target.</param>
        /// <returns>All students that match the conditions.</returns>
        public static List<Student> GroupByGroup(this List<Student> collection)
        {
            var studByGroup =
              from stud in collection
              orderby stud.Group
              select stud;

            return studByGroup.ToList();
        }
    }
}
