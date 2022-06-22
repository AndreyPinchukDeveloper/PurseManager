using BudgetManager.Infrastructure.Commands.Base;
using BudgetManager.View.Windows;
using MyBudgetManager.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
