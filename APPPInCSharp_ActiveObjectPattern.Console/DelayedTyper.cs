namespace APPPInCSharp_ActiveObjectPattern.Console
{
    public class DelayedTyper : Command
    {
        private long itsDelay;
        private char itsChar;
        public static bool stop = false;
        public static ActiveObjectEngine engine = new ActiveObjectEngine();

        public DelayedTyper(long delay, char c)
        {
            itsDelay = delay;
            itsChar = c;
        }

        public void Execute()
        {
            System.Console.Write(itsChar);
            if (!stop)
            {
                DelayAndRepeat();
            }
        }

        private void DelayAndRepeat()
        {
            engine.AddCommand(new SleepCommand(itsDelay, engine, this));
        }
    }
}