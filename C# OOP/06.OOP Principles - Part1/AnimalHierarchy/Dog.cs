namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Dog : Animal
    {
        public Dog(string name, SexType sex, int age) : base(name, sex, age) { }

        public override void Talk()
        {
            Console.WriteLine("Baou");
        }
    }
}
