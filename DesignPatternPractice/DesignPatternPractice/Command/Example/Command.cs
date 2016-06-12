using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice
{
    public abstract class Command
    {
        protected Barbecuer receiver;
        // check for baker
        public Command(Barbecuer receiver)
        {
            this.receiver = receiver;
        }

        abstract public void ExcuteCommand();
    }

    public abstract class Command2
    {
        protected Receiver receiver;

        public Command2(Receiver receiver)
        {
            this.receiver = receiver;
        }

        abstract public void Execute();
    }
}
