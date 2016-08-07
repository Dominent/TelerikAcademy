namespace BankAccounts.Models.Accounts
{
    using Absract;
    using Contracts;
    using Customers;
    using Infrastructure.Common;
    using System;

    public class Loan : Account
    {
        public Loan(ICustomer setCustomer, decimal setBalance, int setInterestRate) : base(setCustomer, setBalance, setInterestRate) { }
       
        public override decimal CalcInterestAmount(int months)
        {
            var penalty = 0;
            //Loan accounts have no interest for the first 3 months if are held by individuals
            if (this.Customer is Individual)
            {
                if (months - Constants.LoanIndividualAccInterestPenalty <= 0)
                {
                    throw new Exception("Loan accounts have no interest for the first 3 months if held by a individual");
                }
                penalty = Constants.LoanIndividualAccInterestPenalty;
            }

            //Loan accounts have no interest for the first 2 months if are held by company.
            if (this.Customer is Company)
            {
                if (months - Constants.LoanCompanyAccInterestPenalty <= 0)
                {
                    throw new Exception("Loan accounts have no interest for the first 2 months if held by a company");
                }
                penalty = Constants.LoanCompanyAccInterestPenalty;

            }

            return base.CalcInterestAmount(months - penalty);
        }
    }
}

