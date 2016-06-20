//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Telerik Academy">
// Telerik Academy by Progress
// </copyright>
// <author>Petromil "Dominent" Pavlov </author>
//-----------------------------------------------------------------------

namespace FirstBeforeLast
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Public class holding the main starting point of our program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main starting point of our program
        /// </summary>
        public static void Main()
        {
            var students = new Student[]
            {
                new Student()
                {
                    FirstName = "Pesho",
                    LastName = "Peshov",
                    Age = 17,
                    Email = "peshopeshov@gmail.com",
                    Phone = "0888306256",
                    City = "Sofia",
                    FacultyNumber = "22121335",
                    Marks = new List<Marks>()
                    {
                        Marks.Excellent,
                        Marks.Average
                    },
                    Group = 2
                },
                new Student()
                {
                    FirstName = "Ivan",
                    LastName = "Ivanov",
                    Age = 22,
                    Email = "ivanivanov@gmail.com",
                    Phone = "0888306256",
                    City = "Plovdiv",
                    FacultyNumber = "22121316",
                    Marks = new List<Marks>()
                    {
                        Marks.Poor,
                        Marks.Good
                    },
                    Group = 2
                },
                new Student()
                {
                    FirstName = "Svetlin",
                    LastName = "Nakov",
                    Age = int.MaxValue,
                    Email = "snakov@abv.bg",
                    Phone = "0888306256",
                    City = "Veliko Turnovo",
                    FacultyNumber = "22121309",
                    Marks = new List<Marks>()
                    {
                        Marks.Excellent,
                        Marks.Excellent,
                        Marks.Excellent
                    },
                    Group = 1
                },
                new Student()
                {
                    FirstName = "Ivan",
                    LastName = "Pavlov",
                    Age = 23,
                    Email = "ivanpavlov@gmail.com",
                    Phone = "0888306256",
                    City = "Sofia",
                    FacultyNumber = "22121306",
                    Marks = new List<Marks>()
                    {
                        Marks.Poor,
                        Marks.Poor
                    },
                    Group = 3
                }
            };

            var output = Student.Filter(students);

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------------------------------------------------------");

            var studByAge =
                  from student in students
                  where (student.Age > 18 && student.Age < 24)
                  select new
                  {
                      FirstName = student.FirstName,
                      LastName = student.LastName
                  };

            foreach (var item in studByAge)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------------------------------------------------------");

            var studByName = students.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName);

            foreach (var item in studByName)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------------------------------------------------------");

            studByName =
                from stud in students
                orderby stud.FirstName descending, stud.LastName descending
                select stud;

            foreach (var item in studByName)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------------------------------------------------------");

            var studList = students.ToList();

            var studByGroup =
                from stud in studList
                where stud.Group == 2
                orderby stud.FirstName
                select stud;

            foreach (var item in studByGroup)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------------------------------------------------------");

            foreach (var item in studList.FilterByGroup())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------------------------------------------------------");

            var studByEmail =
                from stud in studList
                where stud.Email.Contains("@abv.bg")
                select stud;

            foreach (var item in studByEmail)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------------------------------------------------------");

            var studByCity =
                from stud in studList
                where stud.City == "Sofia"
                select stud;

            foreach (var item in studByCity)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------------------------------------------------------");

            var studByGrade =
                from stud in studList
                where stud.Marks.Contains(Marks.Excellent)
                select new
                {
                    FullName = stud.FirstName + " " + stud.LastName,
                    Marks = stud.Marks
                };

            foreach (var item in studByGrade)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------------------------------------------------------");

            foreach (var item in studList.FilterByGrade())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------------------------------------------------------");

            var studByFN =
                from stud in studList
                where stud.FacultyNumber.Substring((stud.FacultyNumber.Length - 1) - 1) == "06"
                select stud.Marks;

            foreach (var item in studByFN)
            {
                foreach (var mark in item)
                {
                    Console.WriteLine(mark);
                }
            }

            Console.WriteLine("------------------------------------------------------------");

            var allStudByGroup =
                from stud in studList
                orderby stud.Group
                select stud;

            foreach (var item in allStudByGroup)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------------------------------------------------------");

            foreach(var item in studList.GroupByGroup())
            {
                Console.WriteLine(item);
            }
        }
    }
}
