namespace BankAccounts.Contracts
{
    public interface IAccount
    {
        ICustomer Customer { get; }

        decimal Balance { get; }

        int InterestRate { get; }

        void DepositMoney(decimal input);

        decimal CalcInterestAmount(int months);
    }
}
