using System;
using WiredBrainCoffee.Storage;

namespace WiredBrainCoffee.Simulators
{
    public class CoffeeMachine
    {
        private CoffeeMachineStateSaver _coffeeMachineStateSaver;

        public CoffeeMachine()
        {
            _coffeeMachineStateSaver = new CoffeeMachineStateSaver();
            CoffeeMachineState state = _coffeeMachineStateSaver.Load();
            CounterCappuccino = state.CounterCappuccino;
        }
        public int CounterCappuccino { get; set; }

        public void MakeCappuccino()
        {
            CounterCappuccino++;
            Console.WriteLine($"Make cappuccino number {CounterCappuccino}");
            _coffeeMachineStateSaver.Save(new CoffeeMachineState { CounterCappuccino = CounterCappuccino });
        }

        public void ShowStoredState()
        {
            _coffeeMachineStateSaver.ShowStoredJson(); 
        }
    }
}