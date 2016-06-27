namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;

    public static class Generator
    {
        public static string GenerateFirstName(Random rnd)
        {
            var firstNames = new string[] { "Gosho", "Ivan", "Joro", "Niki", "Tosho" };

            return firstNames[rnd.Next(0, firstNames.Length)];
        }

        public static string GenerateLastName(Random rnd)
        {
            var lastNames = new string[] { "Ivanov", "Dragoev", "Pavlov", "Nikolaev", "Naydenov" };

            return lastNames[rnd.Next(0, lastNames.Length)];
        }

        public static IEnumerable<GradeType> GenerateGrades(Random rnd)
        {
            var items = Enum.GetValues(typeof(GradeType));

            var output = new List<GradeType>();

            var gradesCount = rnd.Next(0, Constants.MaxGradesPerStudentCount);

            for (int i = 0; i < gradesCount; i++)
            {
                var grade = items.GetValue(rnd.Next(0, Constants.MaxGradesCount));

                output.Add(((GradeType)grade));
            }
            return output;
        }

        public static double GenerateWorkHoursPerWeek(Random rnd)=> rnd.Next(0, Constants.MaxWorkHoursPerWeek);

        public static decimal GenerateSalaryPerWeek(Random rnd) => rnd.Next(0, Constants.MaxMoneyPerWeekWork);
    }
}
