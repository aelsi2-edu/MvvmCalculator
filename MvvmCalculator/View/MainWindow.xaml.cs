using MvvmCalculator.ViewModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MvvmCalculator.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
        {
            base.OnPropertyChanged(e);
            if (e.Property != DataContextProperty)
            {
                return;
            }
            if (e.OldValue is CalculatorViewModel oldViewModel)
            {
                oldViewModel.DividedByZero -= ShowDividedByZeroMessage;
            }
            if (e.NewValue is CalculatorViewModel newViewModel)
            {
                newViewModel.DividedByZero += ShowDividedByZeroMessage;
            }
        }
        private void ShowDividedByZeroMessage()
        {
            MessageBox.Show("Делить на 0 нельзя.");
        }
    }
}
