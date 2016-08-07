using System.Text;

namespace PersonClass
{
    public class Person : IPerson
    {
        private readonly string name;

        private int? age;

        public Person(string setName)
        {
            this.name = setName;
        }

        public string Name { get { return this.name; } }

        public int? Age { get { return this.age != null ? this.age : -1; } set { this.age = value; } }

        public override string ToString()
        {
            var strBuilder = new StringBuilder();
            strBuilder.AppendLine($"Name: {this.Name}");
            strBuilder.AppendLine($"Age: {(this.Age != -1 ? this.Age.ToString() : "[ null ]")}");
            return strBuilder.ToString();
        }
    }
}
