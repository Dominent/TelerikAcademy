namespace BankAccounts.Models.Accounts.Absract
{
    using Contracts;
    using System;

    public abstract class Account : IAccount
    {
        private readonly ICustomer customer;

        protected decimal balance;

        private readonly int interestRate;

        public Account(ICustomer setCustomer, decimal setBalance, int setInterestRate)
        {
            this.customer = setCustomer;
            this.Balance = setBalance;
            this.interestRate = setInterestRate;
        }

        public ICustomer Customer { get { return this.customer; } }

        public decimal Balance
        {
            get { return this.balance; }
            protected set
            {
                if (this.balance - value < 0)
                {
                    throw new Exception("Cannot have negative balance!");
                }
                this.balance = value;
            }
        }

        public int InterestRate
        {
            get { return this.interestRate; }
            protected set { this.InterestRate = value; }
        }

        public void DepositMoney(decimal input)
        {
            if (input < 0)
            {
                throw new Exception("Cannot deposit negative ammount!");
            }
            this.Balance += input;
        }

        public virtual decimal CalcInterestAmount(int months)
        {
            if (months <= 0)
            {
                throw new Exception("Months cannot be less than 0");
            }
            return this.InterestRate * months;
        }
    }
}
