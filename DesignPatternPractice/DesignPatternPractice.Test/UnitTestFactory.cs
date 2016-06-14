using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternPractice.Test
{
    [TestClass]
    public class UnitTestFactory
    {
        [TestMethod]
        public void Test_Factory()
        {
            Calculator operation = CalculatorFactory.CreatOperation("+");
            var operType = (OperationType)Enum.Parse(typeof(OperationType), operation.Operation, true);
            var result = CalculatorFactory.CalculateAnswer(operType, 1, 2);

            Assert.AreEqual(result, 3);
        }
    }
}
