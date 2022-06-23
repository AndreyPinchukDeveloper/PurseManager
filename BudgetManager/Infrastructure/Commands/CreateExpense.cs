using BudgetManager.Infrastructure.Commands.Base;

namespace BudgetManager.Infrastructure.Commands
{
    internal class CreateExpense:Command
    {
        //ExpenseWindow expenseWindow = new ExpenseWindow();
        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
            /*if (ValidateForm())
            {
                OperationModel model = new OperationModel(expenseWindow.AmountOfMoney.Text, expenseWindow.cbExpenseCategory.Text, expenseWindow.Note.Text);
                GlobalConfig.Connection.CreateChange(model);

                expenseWindow.AmountOfMoney.Text = "0";
                expenseWindow.cbExpenseCategory.Text = "";
                expenseWindow.Note.Text = "";
            }
            else
            {
                MessageBox.Show("This form has invalid information, please check it and try again !");
            }*/
        }

        /*private bool ValidateForm()
        {
            bool output = true;
            decimal amountOfMoney = 0;
            bool validAmountToIncrement = decimal.TryParse(expenseWindow.AmountOfMoney.Text, out amountOfMoney);

            if (!validAmountToIncrement)//we need only negative value and only numbers
            {
                output = false;
            }
            return output;
        }*/
    }
}
