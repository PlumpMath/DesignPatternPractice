using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice
{
    public class Invoker
    {
        private Command2 command;

        public void SetCommand(Command2 command) 
        {
            this.command = command;
        }

        public void ExecuteCommand() 
        {
            this.command.Execute();
        }
    }
}
