using System.Windows;
using System.Windows.Input;
using MyBudgetManager.View;
using BudgetManager.Infrastructure.Commands;
using BudgetManager.ViewModels.Base;

namespace BudgetManager.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Open WPF Windows Commands
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

        //#region CreateExpenseCommand
        //public ICommand CreateExpense { get; }
        //ExpenseWindow expenseWindow = new ExpenseWindow();
        //private void OnCreateExpenseCommandExecuted(object p)
        //{
        //    createIncome.
        //}
        //private bool ValidateForm()
        //{
        //    bool output = true;
        //    decimal amountOfMoney = 0;
        //    bool validAmountToIncrement = decimal.TryParse(expenseWindow.AmountOfMoney.Text, out amountOfMoney);

        //    if (!validAmountToIncrement)//we need only negative value and only numbers
        //    {
        //        output = false;
        //    }
        //    return output;
        //}
        //private bool OnOpenCreateExpenseCommandExecute(object p) => true;
        //#endregion
        #region ExpenseCommand
        public ICommand CreateExpense { get; }
        CreateIncome createExpense;
        private void OnCreateExpenseCommandExecuted(object p)
        {
            createExpense.Execute(p);
        }
        private bool OnOpenCreateExpenseCommandExecute(object p) => true;
        #endregion

        #region IncomeCommand
        public ICommand CreateIncome { get; }
        CreateIncome createIncome;
        private void OnCreateIncomeCommandExecuted(object p)
        {
            createIncome.Execute(p);
        }
        private bool OnOpenCreateIncomeCommandExecute(object p) => true;
        #endregion
        //#region CreateIncomeCommand
        //public ICommand CreateIncome { get; }
        //IncomeWindow incomeWindow = new IncomeWindow();
        //private void OnCreateIncomeCommandExecuted(object p)
        //{
        //    if (ValidateForm())
        //    {
        //        OperationModel model = new OperationModel(incomeWindow.AmountOfMoney.Text, incomeWindow.cbIncomeCategory.Text, incomeWindow.Note.Text);
        //        GlobalConfig.Connection.CreateChange(model);

        //        incomeWindow.AmountOfMoney.Text = "0";
        //        incomeWindow.cbIncomeCategory.Text = "";
        //        incomeWindow.Note.Text = "";
        //    }
        //    else
        //    {
        //        MessageBox.Show("This form has invalid information, please check it and try again !");
        //    }
        //}
        //private bool OnOpenCreateIncomeCommandExecute(object p) => true;


        //#endregion

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
            CreateExpense = new LambdaCommand(OnCreateExpenseCommandExecuted, OnOpenCreateExpenseCommandExecute);
            CreateIncome = new LambdaCommand(OnCreateIncomeCommandExecuted, OnOpenCreateIncomeCommandExecute);

            #endregion
        }
    }
}
