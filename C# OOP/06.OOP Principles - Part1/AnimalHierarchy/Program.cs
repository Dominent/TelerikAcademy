namespace AnimalHierarchy
{
    using System;
    using System.Linq;

    using System.Collections.Generic;

    static class Program
    {
        static void Main()
        {
            IEnumerable<IAnimal> collection = new List<IAnimal>()
            {
                new Dog("Nero", SexType.Male, 7),
                new Dog("NaSusedaKucheto", SexType.Female, 6),
                new Frog("Kro", SexType.Female, 1),
                new Kitten("Mariika", 12),
                new Kitten("Mara", 11),
                new Kitten("Svetla", 2),
                new TomCat("Tosho", 22),
                new TomCat("Ivo", 82),
                new TomCat("Stamat", 2)
            };

            collection.AverageAge();
        }

        static void AverageAge(this IEnumerable<IAnimal> collection)
        {
            var input = collection.GroupBy(x => x.GetType());

            foreach (var val in input)
            {
                var sum = 0;
                var count = 0;
                var name = "?";
                foreach (var item in val)
                {
                    count++;
                    sum += item.Age;
                    name = item.ToString().Split('.').Last() + "s";
                }
                Console.WriteLine("{0} are {1:F1} years old.", name, (sum / (double)count));
            }
        }
    }
}
