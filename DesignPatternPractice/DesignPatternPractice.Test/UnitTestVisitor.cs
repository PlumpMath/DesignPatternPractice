using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternPractice.Test
{
    [TestClass]
    public class UnitTestVisitor
    {
        [TestMethod]
        public void Test_Visitor()
        {
            VisitorObjectStructure o = new VisitorObjectStructure();
            o.Attach(new ConcreteElementA());
            o.Attach(new ConcreteElementB());

            var v1 = new ConcreteVisitor1();
            var v2 = new ConcreteVisitor2();

            o.Accept(v1);
            o.Accept(v2);
        }
    }
}
