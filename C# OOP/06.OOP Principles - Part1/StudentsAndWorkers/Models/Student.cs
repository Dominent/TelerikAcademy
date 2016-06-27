namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Student : Human
    {
        public Student(string firstName, string lastName, IEnumerable<GradeType> grades) : base(firstName, lastName)
        {
            Grades = grades;
        }
        public IEnumerable<GradeType> Grades { get; set; }

        public override string ToString()
        {
            var strBuilder = new StringBuilder();

            strBuilder.AppendLine($"First-Name: {this.FirstName}");
            strBuilder.AppendLine($"Last-Name: {this.LastName}");

            strBuilder.AppendLine(new string('=', 5) + "Grades" + new string('=', 5));

            foreach(var grade in this.Grades)
                strBuilder.AppendLine(Enum.GetName(typeof(GradeType), grade));

            strBuilder.AppendLine();

            return strBuilder.ToString();
        }
    }
}
