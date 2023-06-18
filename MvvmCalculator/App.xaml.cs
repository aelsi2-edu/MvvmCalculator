using System.Windows;

using MvvmCalculator.View;
using MvvmCalculator.ViewModel;
using MvvmCalculator.Model;

namespace MvvmCalculator
{
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MainWindow = new MainWindow
            {
                DataContext = new CalculatorViewModel(new Calculator())
            };
            MainWindow.ShowDialog();
        }
    }
}
