namespace BankAccounts.Models.Accounts
{
    using Contracts;
    using System;
    using Absract;
    using Infrastructure.Common;
    class Deposit : Account, IWithdraw
    {
        public Deposit(ICustomer setCustomer, decimal setBalance, int setInterestRate) : base(setCustomer, setBalance, setInterestRate) { }

        public void WithrawMoney(decimal input)
        {
            if (input > this.Balance)
            {
                throw new Exception("Cannot withdraw more than your current ammount!");
            }
            this.Balance -= input;
        }

        //Deposit accounts have no interest if their balance is positive and less than 1000
        public override decimal CalcInterestAmount(int months)
        {
            if (this.Balance > 0 && this.Balance < Constants.DepositMinBalanceInterestPenalty)
            {
                throw new Exception("Deposit accounts have no interest if their balance is positive and less than 1000");
            }
            return base.CalcInterestAmount(months);
        }
    }
}


