namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Human
    {
        private string firstName;

        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string FirstName { get { return this.firstName; } }

        public string LastName { get { return this.lastName; } }
    }
}
