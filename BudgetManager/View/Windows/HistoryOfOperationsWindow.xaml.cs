using BudgetManager.Data;
using System.Linq;
using System.Windows;

namespace BudgetManager.View.Windows
{
    /// <summary>
    /// Interaction logic for HostoryOfOperationsWindow.xaml
    /// </summary>
    public partial class HostoryOfOperationsWindow : Window
    {
        public HostoryOfOperationsWindow()
        {
            InitializeComponent();
            DGrid.ItemsSource = PurseDatabaseEntities.GetInstance().HistoryOfOperations.ToList();
        }
    }
}
