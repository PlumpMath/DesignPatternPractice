using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice
{
    public class ConcreteCommand : Command2
    {
        public ConcreteCommand(Receiver receiver)
            : base(receiver) 
        { 
        }

        public override void Execute()
        {
            base.receiver.Action();
        }
    }
}
