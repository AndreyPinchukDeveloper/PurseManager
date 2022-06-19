using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using MyBudgetManager.View;
using PurseManager.ViewModels.Base;

namespace PurseManager.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Open_WPF_Windows
        private void OpenExpenseWindow()
        {
            ExpenseWindow expenseMenuWindow = new ExpenseWindow();
            OpenWindow(expenseMenuWindow);
        }

        private void OpenIncomeWindow()
        {
            IncomeWindow incomeWindow = new IncomeWindow();
            OpenWindow(incomeWindow);
        }

        private void OpenWindow(Window window)
        {
            window.Owner = Application.Current.MainWindow;
            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            window.ShowDialog();
        }
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

        #region Commands

        #region Open_WPF_Windows_Commands

        private LambdaCommand openExpenseMenuWindow;
        public LambdaCommand OpenExpenseMenuWindowCommand
        {
            get { return openExpenseMenuWindow ?? new LambdaCommand(obj => { OpenExpenditureWindow(); }); }
        }

        private LambdaCommand openIncomeMenuWindow;
        public LambdaCommand OpenRecieptWindowCommand
        {
            get { return openIncomeMenuWindow ?? new LambdaCommand(obj => { OpenRecieptWindow(); }); }
        }
        #endregion


        #region CloseAplicationCommand
        public ICommand CloseApplicationCommand { get; }

        private void OnCloseApplicationCommandExecuted(object p)
        {
            Application.Current.Shutdown();
        }

        private bool CanOnCloseApplicationCommandExecute(object p) => true;//because always available
        #endregion


        #endregion
    }
}
