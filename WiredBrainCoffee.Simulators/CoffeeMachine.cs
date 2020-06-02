namespace WiredBrainCoffee.Simulators
{
    public class CoffeeMachine
    {
        public int CounterCappuccino { get; set; }

        public void MakeCappuccino()
        {
            CounterCappuccino++;
        }
    }
}