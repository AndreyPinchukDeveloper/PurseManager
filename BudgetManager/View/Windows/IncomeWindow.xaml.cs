using BudgetManager.Data;
using BudgetManagerLibrary;
using BudgetManagerLibrary.Model;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace MyBudgetManager.View
{
    /// <summary>
    /// Interaction logic for IncomeWindow.xaml
    /// </summary>
    public partial class IncomeWindow : Window
    {

        public IncomeWindow()
        {
            InitializeComponent();
            ComboBoxIncome();
        }

        public List<IncomeList> Income { get; set; }
        private void ComboBoxIncome()
        {
            PurseDatabaseEntities data = new PurseDatabaseEntities();
            var item = data.IncomeList.ToList();
            Income = item;
            DataContext = Income;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateForm())
            {
                OperationModel model = new OperationModel(
                    AmountOfMoney.Text,
                    cbIncomeCategory.Text,
                    Note.Text);

                GlobalConfig.Connection.CreateChange(model);

                AmountOfMoney.Text = "0";
                cbIncomeCategory.Text = "";
                Note.Text = "";
                MainWindow mainWindow = new MainWindow();
                mainWindow.UpdateUserMoneyData();
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
