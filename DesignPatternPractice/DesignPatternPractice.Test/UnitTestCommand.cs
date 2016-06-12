using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatternPractice;

namespace DesignPatternPractice.Test
{
    [TestClass]
    public class UnitTestCommand
    {
        [TestMethod]
        public void Test_BakeExample()
        {
            Barbecuer chef = new Barbecuer();
            Command bakeMuttonCommand1 = new BakeMuttonCommand(chef);
            Command bakeMuttonCommand2 = new BakeMuttonCommand(chef);
            Command bakeChickenWingCommand1 = new BakeChickenWingCommand(chef);
            Waiter girl = new Waiter();

            girl.SetOrder(bakeMuttonCommand1);
            girl.SetOrder(bakeMuttonCommand2);
            girl.SetOrder(bakeChickenWingCommand1);
            girl.Notify();            
        }

        [TestMethod]
        public void Test_BakeExample2()
        {
            Receiver r = new Receiver();
            Command2 c = new ConcreteCommand(r);
            Invoker i = new Invoker();

            i.SetCommand(c);
            i.ExecuteCommand();
        }
    }
}
