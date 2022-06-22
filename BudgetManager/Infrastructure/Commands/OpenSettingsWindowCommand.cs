using BudgetManager.Infrastructure.Commands.Base;
using BudgetManager.View.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BudgetManager.Infrastructure.Commands
{
    internal class OpenSettingsWindowCommand:Command
    {
        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
            SettingsWindow window = new SettingsWindow();
            window.Owner = Application.Current.MainWindow;
            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            window.ShowDialog();
        }
    }
}
