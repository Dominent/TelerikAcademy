namespace AnimalHierarchy
{
    using System;

    public abstract class Animal : IAnimal, ISound
    {
        private readonly string name;

        private readonly SexType sex;

        private readonly int age;

        protected Animal(string name, SexType sex, int age)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }

        public string Name { get { return this.name; } }

        public SexType Sex { get { return this.sex; } }

        public int Age { get { return this.age; } }

        public virtual void Talk()
        {
            Console.WriteLine("I talk");
        }
    }
}
