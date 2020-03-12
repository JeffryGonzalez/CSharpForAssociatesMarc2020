using System;

namespace BankingDomain
{
    public class BankAccount : IProvideBalances
    {
        private ICalculateBonuses BonusCalculator;
        private INotifyTheFeds FedNotifier;

        public BankAccount(ICalculateBonuses bonusCalculator, INotifyTheFeds fedNotifier)
        {
            BonusCalculator = bonusCalculator;
            FedNotifier = fedNotifier;
        }

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
               FedNotifier.NotifyOfWithdrawal(this, amountToWithdraw);
            }
        }

        public void Deposit(decimal amountToDeposit)
        {
            // WTCYWYH
            decimal bonus = BonusCalculator.GetBonusFor(this, amountToDeposit);
            CurrentBalance += amountToDeposit + bonus;
        }
    }
}