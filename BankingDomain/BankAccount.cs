using System;

namespace BankingDomain
{
    public class BankAccount
    {

        private decimal CurrentBalance = 7000; // JFHCI

        public decimal GetBalance()
        {
            return CurrentBalance; 
        }

        public void Withdraw(decimal amountToWithdraw)
        {
            if (amountToWithdraw > CurrentBalance)
            {
                throw new OverdraftException();
            }
            else
            {
                CurrentBalance -= amountToWithdraw;
            }
        }

        public void Deposit(decimal amountToDeposit)
        {
            CurrentBalance += amountToDeposit;
        }
    }
}