using MyBudgetManager.View;
using BudgetManager.Infrastructure.Commands.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using BudgetManagerLibrary;
using BudgetManagerLibrary.Model;

namespace BudgetManager.Infrastructure.Commands
{
    internal class CreateIncome:Command
    {
        IncomeWindow incomeWindow = new IncomeWindow();
        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
            if (ValidateForm())
            {
                OperationModel model = new OperationModel(incomeWindow.AmountOfMoney.Text, incomeWindow.cbIncomeCategory.Text, incomeWindow.cbIncomeCategory.Text);
                GlobalConfig.Connection.CreateChange(model);

                incomeWindow.AmountOfMoney.Text = "0";
                incomeWindow.cbIncomeCategory.Text = "";
                incomeWindow.Note.Text = "";
            }
            else
            {
                MessageBox.Show("This form has invalid information, please check it and try again !");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            decimal amountOfMoney = 0;
            bool validAmountToIncrement = decimal.TryParse(incomeWindow.AmountOfMoney.Text, out amountOfMoney);

            if (!validAmountToIncrement)//we need only negative value and only numbers
            {
                output = false;
            }
            return output;
        }
    }
}
