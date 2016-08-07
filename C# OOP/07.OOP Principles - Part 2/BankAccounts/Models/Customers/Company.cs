using BankAccounts.Customers.Abstract;

namespace BankAccounts.Customers
{
    public class Company : Customer
    {
        public Company(string setName, int setAge) : base(setName, setAge) { }
    }
}
