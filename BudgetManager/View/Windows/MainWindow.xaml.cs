using BudgetManager.Data;
using BudgetManagerLibrary;
using BudgetManagerLibrary.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

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
            S();
        }

        public void S()
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
