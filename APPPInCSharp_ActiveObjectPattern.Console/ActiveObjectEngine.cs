using System.Collections.Generic;

namespace APPPInCSharp_ActiveObjectPattern.Console
{
    public class ActiveObjectEngine
    {
        private List<Command> itsCommands = new List<Command>();

        public void AddCommand(Command c)
        {
            itsCommands.Add(c);
        }

        public void Run()
        {
            while (itsCommands.Count > 0)
            {
                Command c = itsCommands[0];
                itsCommands.RemoveAt(0);
                c.Execute();
            }
        }
    }
}