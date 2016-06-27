namespace SchoolClasses.Models.Student
{
    using System;
    using SchoolClasses.Contracts;

    public class Student : IStudent
    {
        private readonly string id;
        private readonly string name;

        public Student()
        {
            id = Guid.NewGuid().ToString();
        }

        public string Id { get { return this.id; } }

        public string Name { get { return this.name; } }
    }
}
