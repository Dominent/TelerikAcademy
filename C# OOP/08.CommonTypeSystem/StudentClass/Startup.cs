namespace StudentClass
{
    using System;
    using Infrastructure.Enum;
    using Models;


    public class Startup
    {
        public static void Main()
        {
            //0x030ED878
            var Pesho = new Student("Pesho", "Peshov", 32, 20234678, "Sofia", "0888306256", 3, SpecialityType.NotSet, UnivercityType.NotSet, FacultyType.NotSet, "pesho@abv.bg");
            //0x03110384
            var Pesho2 = new Student("Ivan", "Peshov", 32, 20234678, "Plovdiv", "0888306256", 3, SpecialityType.NotSet, UnivercityType.NotSet, FacultyType.NotSet, "pesho@abv.bg");

            Console.WriteLine(Pesho.Equals(Pesho2));

            Console.WriteLine(Pesho);
            //0x031260CC
            var Pesho3 = Pesho2.Clone();

            Console.WriteLine(Pesho3);

            Console.WriteLine(Pesho.CompareTo(Pesho2));
        }
    }
}
