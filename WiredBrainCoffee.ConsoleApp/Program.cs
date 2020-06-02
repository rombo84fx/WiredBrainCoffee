using System;
using WiredBrainCoffee.Simulators;

namespace WiredBrainCoffee.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var coffeeMachine = new CoffeeMachine();
            coffeeMachine.MakeCappuccino();
            coffeeMachine.MakeCappuccino();

            Console.WriteLine($"Counter cappuccino: {coffeeMachine.CounterCappuccino}");
            coffeeMachine.ShowStoredState();
        }
    }
}