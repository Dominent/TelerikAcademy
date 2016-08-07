namespace BankAccounts.Models.Accounts
{
    using Absract;
    using Contracts;
    using Customers;
    using Infrastructure.Common;
    using System;

    public class Mortgage : Account
    {
        public Mortgage(ICustomer setCustomer, decimal setBalance, int setInterestRate) : base(setCustomer, setBalance, setInterestRate) { }

        public override decimal CalcInterestAmount(int months)
        {
            var penalty = 0;
            //Mortgage accounts have 0 interest for the first 6 months for individuals
            if (this.Customer is Individual)
            {
                if (months - Constants.MortrageIndividualAccInterestPenalty <= 0)
                {
                    throw new Exception("Mortgage accounts have 0 interest for the first 6 months for individuals");
                }
                penalty = Constants.MortrageIndividualAccInterestPenalty;
            }

            //Mortgage accounts have ½ interest for the first 12 months for companies
            if (this.Customer is Company)
            {
                if (months - Constants.MortrageCompanyAccInterestPenalty <= 0)
                {
                    throw new Exception("Mortgage accounts have ½ interest for the first 12 months for companies");
                }
                penalty = Constants.MortrageCompanyAccInterestPenalty / 2;

            }

            return base.CalcInterestAmount(months - penalty);
        }
    }
}
