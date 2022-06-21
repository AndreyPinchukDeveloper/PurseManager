using System.Windows;
using System.Windows.Input;
using MyBudgetManager.View;
using PurseManager.Infrastructure.Commands;
using PurseManager.ViewModels.Base;

namespace PurseManager.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Open_WPF_Windows
        public ICommand OpenIncomeWindow { get; }
        private void OnIncomeWindowCommandExecuted(object p)
        {
            IncomeWindow window = new IncomeWindow();
            window.Owner = Application.Current.MainWindow;
            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            window.ShowDialog();
        }

        private bool OnOpenIncomeWindowCommandExecute(object p) => true;

        public ICommand OpenExpenseWindow { get; }
        private void OnExpenseWindowCommandExecuted(object p)
        {
            ExpenseWindow window = new ExpenseWindow();
            window.Owner = Application.Current.MainWindow;
            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            window.ShowDialog();
        }

        private bool OnExpenseWindowCommandExecute(object p) => true;

        #endregion

        #region CloseAplicationCommand
        public ICommand CloseApplicationCommand { get; }

        private void OnCloseApplicationCommandExecuted(object p)
        {
            Application.Current.Shutdown();
        }

        private bool CanOnCloseApplicationCommandExecute(object p) => true;//because always available
        #endregion

        #region MainWindow Title
        /// <summary>
        /// Title for main window
        /// </summary>
        private string _title = "Purse";

        public string Title
        {
            get => _title;
            set => Set(ref _title, value);
        }
        #endregion

        #region MyBudgetDefaultValue
        /// <summary>
        /// Amount of your budget
        /// </summary>
        private string _MyBudget = "0";
        public string MyBudget
        {
            get => _MyBudget;
            set => Set(ref _MyBudget, value);
        }
        #endregion

        public MainWindowViewModel()
        {
            #region Commands
            OpenIncomeWindow = new LambdaCommand(OnIncomeWindowCommandExecuted, OnOpenIncomeWindowCommandExecute);
            OpenExpenseWindow = new LambdaCommand(OnExpenseWindowCommandExecuted, OnExpenseWindowCommandExecute);
            #endregion
        }
    }
}
