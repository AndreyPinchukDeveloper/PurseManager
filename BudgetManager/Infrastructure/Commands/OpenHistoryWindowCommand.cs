using BudgetManager.Infrastructure.Commands.Base;
using BudgetManager.View.Windows;
using System.Windows;

namespace BudgetManager.Infrastructure.Commands
{
    internal class OpenHistoryWindowCommand:Command
    {
        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
            HostoryOfOperationsWindow window = new HostoryOfOperationsWindow();
            window.Owner = Application.Current.MainWindow;
            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            window.ShowDialog();
        }
    }
}
