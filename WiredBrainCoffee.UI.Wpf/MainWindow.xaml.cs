using System.Windows;
using WiredBrainCoffee.Simulators;

namespace WiredBrainCoffee.UI.Wpf
{
    public partial class MainWindow : Window
    {
        private readonly CoffeeMachine _coffeeMachine;

        public MainWindow()
        {
            InitializeComponent();
            _coffeeMachine = new CoffeeMachine();
            CappuccinoCounterTextBox.Text = _coffeeMachine.CounterCappuccino.ToString();
        }

        private void MakeCappuccinoButton_OnClick(object sender, RoutedEventArgs e)
        {
            _coffeeMachine.MakeCappuccino();
            CappuccinoCounterTextBox.Text = _coffeeMachine.CounterCappuccino.ToString();
        }
    }
}