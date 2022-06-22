using BudgetManagerLibrary;
using BudgetManagerLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BudgetManager.View.Windows
{
    /// <summary>
    /// Interaction logic for SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateForm())
            {
                IncomeCategoryModel model = new IncomeCategoryModel(
                    NewIncomeCategory.Text);

                GlobalConfig.Connection.CreateChange(model);
                MessageBox.Show("The category " + NewIncomeCategory.Text + " has added !");
                NewIncomeCategory.Text = "";
                
            }
            else
            {
                MessageBox.Show("This form has invalid information, please check it and try again !");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            /*decimal amountOfMoney = 0;
            bool validAmountToIncrement = decimal.TryParse(AmountOfMoney.Text, out amountOfMoney);

            if (!validAmountToIncrement)//we need only negative value and only numbers
            {
                output = false;
            }*/
            return output;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (ValidateForm())
            {
                ExpenseCategoryModel model = new ExpenseCategoryModel(
                    NewExpenseCategory.Text);

                GlobalConfig.Connection.CreateChange(model);
                MessageBox.Show("The category " + NewExpenseCategory.Text + " has added !");
                NewExpenseCategory.Text = "";
                
            }
            else
            {
                MessageBox.Show("This form has invalid information, please check it and try again !");
            }
        }
    }
}
