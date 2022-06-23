using MyBudgetManager.View;
using BudgetManager.Infrastructure.Commands.Base;
using System.Windows;

namespace BudgetManager.Infrastructure.Commands
{
    internal class OpenIncomeWindowCommand:Command
    {
        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
            IncomeWindow window = new IncomeWindow();
            window.Owner = Application.Current.MainWindow;
            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            window.ShowDialog();
        }
    }
}
