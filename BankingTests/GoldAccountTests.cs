using BankingDomain;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BankingTests
{
    public class GoldAccountTests
    {
        // When I make a deposit
        //   - does it give to the bonus calculator the right account and
        //     the right amount.
        //   - Does it take *whatever* the bonus Calculator returns and add it
        //     to the balance.
        // "State Based Testing", "Beckian testing"
        // Moq (RhinoMocks)
        [Fact]
        public void TheBonusCalculatorIsUsedToCalculateBonuses()
        {
            var stubbedBonusCalculator = new Mock<ICalculateBonuses>();

            var account = new BankAccount(stubbedBonusCalculator.Object, null);
            stubbedBonusCalculator.Setup(b => b.GetBonusFor(account, 100)).Returns(69);
            var openingBalance = account.GetBalance();

            account.Deposit(100);

            Assert.Equal(169 + openingBalance, account.GetBalance());
        }
    }
}
