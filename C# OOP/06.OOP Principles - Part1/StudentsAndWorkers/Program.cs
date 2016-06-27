namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        static void Main()
        {
            Random rnd = new Random(DateTime.Now.Millisecond);

            var students = new List<Human>();

            var workers = new List<Human>();

            for (int i = 0; i < Constants.StudentCount || i < Constants.WorkerCount; i++)
            {
                students.Add(new Student(Generator.GenerateFirstName(rnd),
                    Generator.GenerateLastName(rnd),
                    Generator.GenerateGrades(rnd)));

                workers.Add(new Worker(Generator.GenerateFirstName(rnd),
                        Generator.GenerateLastName(rnd),
                        Generator.GenerateSalaryPerWeek(rnd),
                        Generator.GenerateWorkHoursPerWeek(rnd)));
            }

            var studentsOrdered =
                from stud in students
                orderby (stud as Student).Grades ascending
                select stud;

            students.AddRange(workers);
            var output = students;

            foreach (var item in output.OrderBy(x => x.FirstName).ThenBy(x => x.LastName))
                Console.WriteLine(item.ToString());
        }
    }
}
