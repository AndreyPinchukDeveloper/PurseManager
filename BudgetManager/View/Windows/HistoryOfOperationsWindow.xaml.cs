﻿using BudgetManager.Data;
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
    /// Interaction logic for HostoryOfOperationsWindow.xaml
    /// </summary>
    public partial class HostoryOfOperationsWindow : Window
    {
        public HostoryOfOperationsWindow()
        {
            InitializeComponent();
            DGrid.ItemsSource = BudgetManagerDataEntities.GetContext().HistoryOfOperations.ToList();
        }
    }
}
