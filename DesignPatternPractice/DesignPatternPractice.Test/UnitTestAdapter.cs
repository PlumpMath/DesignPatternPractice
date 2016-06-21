using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternPractice.Test
{
    [TestClass]
    public class UnitTestAdapter
    {
        [TestMethod]
        public void Test_Adapter()
        {
            ITarget adapter = new MyAdapter();
            adapter.Request();
        }
    }
}
