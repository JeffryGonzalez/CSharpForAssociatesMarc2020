using BankingDomain;
using System.Windows.Forms;

namespace BankKiosk
{
    internal class WindowsFedNotifier : INotifyTheFeds
    {
        public void NotifyOfWithdrawal(BankAccount bankAccount, decimal amountToWithdraw)
        {
            MessageBox.Show($"The fed has been notified of your activity");
        }
    }
}