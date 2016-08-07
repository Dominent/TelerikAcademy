using BankAccounts.Customers.Abstract;

namespace BankAccounts.Customers
{
    public class Individual : Customer
    {
        public Individual(string setName, int setAge) : base(setName, setAge) { }
    }
}
