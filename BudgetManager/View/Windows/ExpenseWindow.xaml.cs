using BudgetManager.Data;
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

namespace MyBudgetManager.View
{
    /// <summary>
    /// Interaction logic for ExpenseWindow.xaml
    /// </summary>
    public partial class ExpenseWindow : Window
    {
        public ExpenseWindow()
        {
            InitializeComponent();
            ComboBoxExpense();
        }
        public List<ExpenseList> Expense { get; set; }
        private void ComboBoxExpense()
        {
            PurseDatabaseEntities data = new PurseDatabaseEntities();
            var item = data.ExpenseList.ToList();
            Expense = item;
            DataContext = Expense;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateForm())
            {
                OperationModel model = new OperationModel(
                    AmountOfMoney.Text,
                    cbExpenseCategory.Text,
                    Note.Text);

                GlobalConfig.Connection.CreateChange(model);

                AmountOfMoney.Text = "0";
                cbExpenseCategory.Text = "";
                Note.Text = "";
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
            bool validAmountToIncrement = decimal.TryParse(AmountOfMoney.Text, out amountOfMoney);

            if (!validAmountToIncrement)//we need only negative value and only numbers
            {
                output = false;
            }
            return output;
        }
    }
}
