using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice
{
    public class Waiter
    {
        private IList<Command> orders = new List<Command>();

        //Set Order
        public void SetOrder(Command command)
        {
            if (command.ToString() == "CommandMode.BakeChickenWingCommand")
            {
                Console.WriteLine("Hello waiter, chicken wing is null, take another orders.");
            }
            else 
            {
                orders.Add(command);
                Console.WriteLine("Add more Order: " + command.ToString() + " Time: " + DateTime.Now.ToString());
            }
        }

        public void CancelOrder(Command command) 
        {
            orders.Remove(command);
            Console.WriteLine("Cancel Order: " + command.ToString() + " Time: " + DateTime.Now.ToString());
        }

        public void Notify() 
        {
            foreach (Command cmd in orders) 
            {
                cmd.ExcuteCommand();
            }
        }
    }
}
