namespace AnimalHierarchy
{
    public interface IAnimal
    {
        int Age { get; }

        string Name { get; }

        SexType Sex { get;  }
    }
}
