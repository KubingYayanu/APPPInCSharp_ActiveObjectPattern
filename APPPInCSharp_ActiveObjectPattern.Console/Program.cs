namespace APPPInCSharp_ActiveObjectPattern.Console
{
    class Program
    {
        public static void Main(string[] args)
        {
            DelayedTyper.engine.AddCommand(new DelayedTyper(100, '1'));
            DelayedTyper.engine.AddCommand(new DelayedTyper(300, '3'));
            DelayedTyper.engine.AddCommand(new DelayedTyper(500, '5'));
            DelayedTyper.engine.AddCommand(new DelayedTyper(700, '7'));

            Command stopCommand = new StopCommand();

            DelayedTyper.engine.AddCommand(new SleepCommand(10000, DelayedTyper.engine, stopCommand));
            DelayedTyper.engine.Run();
        }
    }
}