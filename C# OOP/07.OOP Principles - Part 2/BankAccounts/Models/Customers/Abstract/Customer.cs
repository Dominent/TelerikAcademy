using BankAccounts.Contracts;

namespace BankAccounts.Customers.Abstract
{
    public abstract class Customer : ICustomer
    {
        private readonly string name;

        protected int age;

        protected Customer(string setName, int setAge)
        {
            this.name = setName;
            this.age = setAge;
        }

        public string Name { get { return this.name; } }

        public int Age { get { return this.age; } }
    }
}
