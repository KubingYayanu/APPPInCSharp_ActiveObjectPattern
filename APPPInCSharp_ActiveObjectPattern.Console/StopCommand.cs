namespace APPPInCSharp_ActiveObjectPattern.Console
{
    public class StopCommand : Command
    {
        public void Execute()
        {
            DelayedTyper.stop = true;
        }
    }
}