using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternPractice.Test
{
    [TestClass]
    public class UnitTestProxy
    {
        [TestMethod]
        public void TestMethod_ProxySendGift()
        {
            ShowGirl mm = new ShowGirl();

            mm.Name = "Wonderful";

            Proxy pursuit = new Proxy(mm);

            pursuit.GiveChocolate();
            pursuit.GiveDolls();
            pursuit.GiveFlowers();
        }
    }
}
