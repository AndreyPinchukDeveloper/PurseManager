using BudgetManagerLibrary;
using System.Data.SqlClient;
using System.Windows;

namespace MyBudgetManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GlobalConfig.InitializeConnections(DatabaseType.Sql);
            UpdateUserMoneyData();
        }

        public void UpdateUserMoneyData()
        {
            using (SqlConnection connection = new SqlConnection(GlobalConfig.ConnectionString("PurseDatabase")))
            {
                string commander = "SELECT SUM([ValueToChange]) FROM [HistoryOfOperations]";
                SqlCommand command = new SqlCommand(commander, connection);
                connection.Open();
                object sum = command.ExecuteScalar();
                UserMoney.Text = sum.ToString();
            }
        }
        

    }
}
