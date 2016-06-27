namespace SchoolClasses.Models.Teacher
{
    using System.Collections.Generic;
    using SchoolClasses.Contracts;

    public class Teacher : ITeacher
    {
        private readonly string name;

        public Teacher(string name)
        {
            this.name = name;
        }

        public string Name { get { return this.name; } }

        public IEnumerable<IDiscipline> Disciplines { get; set; }
    }
}
