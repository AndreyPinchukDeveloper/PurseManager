using MyBudgetManager.View;
using BudgetManager.Infrastructure.Commands.Base;
using System.Windows;

namespace BudgetManager.Infrastructure.Commands
{
    internal class OpenExpenseWindowCommand:Command
    {
        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
            ExpenseWindow window = new ExpenseWindow();
            window.Owner = Application.Current.MainWindow;
            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            window.ShowDialog();
        }
    }
}
