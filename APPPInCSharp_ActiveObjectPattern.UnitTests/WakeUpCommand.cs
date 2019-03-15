using APPPInCSharp_ActiveObjectPattern.Console;

namespace APPPInCSharp_ActiveObjectPattern.UnitTests
{
    internal class WakeUpCommand : Command
    {
        public bool executed = false;

        public void Execute()
        {
            executed = true;
        }
    }
}