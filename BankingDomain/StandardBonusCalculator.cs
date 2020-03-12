namespace BankingDomain
{
    public class StandardBonusCalculator : ICalculateBonuses
    {
        public decimal GetBonusFor(IProvideBalances balanceHavingThing, decimal amountToDeposit)
        {
            return balanceHavingThing.GetBalance() >= 10000 ? amountToDeposit * 0.1M : 0;
        }
    }
}