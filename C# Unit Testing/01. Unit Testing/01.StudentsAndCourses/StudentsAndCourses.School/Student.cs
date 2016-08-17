using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleToAttribute("StudentsAndCourses.School.Tests")]
namespace StudentsAndCourses.School
{
    internal class Student
    {
        private string name;
        private int id;

        internal Student(int setId, string setName)
        {
            this.Id = setId;
            this.Name = setName;
        }

        internal string Name
        {
            get { return this.name; }
            private set
            {
                if (value == null)
                    throw new ArgumentNullException();
                if (value == "" )
                    throw new ArgumentException();
                this.name = value;
            }
        }

        internal int Id
        {
            get { return this.id; }
            private set
            {
                if (!(value > 10000 && value < 99999))
                    throw new ArgumentException();
                this.id = value;
            }
        }
    }
}
