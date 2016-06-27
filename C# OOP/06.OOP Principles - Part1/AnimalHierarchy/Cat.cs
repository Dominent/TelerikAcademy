namespace AnimalHierarchy
{
    using System;

    abstract class Cat : Animal
    {
        protected Cat(string name, int age, SexType sex) : base(name, sex, age) { }

        public override void Talk()
        {
            Console.WriteLine("Meooow");
        }
    }
}
