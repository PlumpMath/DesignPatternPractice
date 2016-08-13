using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static DesignPatternPractice.Boss;

namespace DesignPatternPractice.Test
{
    [TestClass]
    public class UnitTestObserver
    {
        [TestMethod]
        public void Test_Observer_BossExample()
        {
            Boss anguryBoss = new Boss();

            StockObserver worker1 = new StockObserver("thkouob", anguryBoss);
            NBAObserver worker2 = new NBAObserver("zf", anguryBoss);

            ////anguryBoss.Attach(worker1);
            ////anguryBoss.Attach(worker2);

            ////anguryBoss.Detach(worker1);
            anguryBoss.Update += new MyEventHandler(worker1.Update);
            anguryBoss.Update += new MyEventHandler(worker2.Update);

            anguryBoss.SubjectState = "Boss is come back!";

            anguryBoss.Notify();
        }

        [TestMethod]
        public void Test_Observer_normal()
        {
            ConcreteSubject s = new ConcreteSubject();
            s.Attach(new ConcreteObserver(s, "x"));
            s.Attach(new ConcreteObserver(s, "y"));
            s.Attach(new ConcreteObserver(s, "z"));

            s.SubjectState = "abc";
            s.Notify();
        }
    }
}
