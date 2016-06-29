using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternPractice.Test
{
    [TestClass]
    public class UnitTestAbstractFactory
    {
        [TestMethod]
        public void TestMethod_Abstravtory()
        {
            IAbstractFactory factoryA = new ConcreteFactoryA();
            IAbstractFactory factoryB = new ConcreteFactoryB();

            var clientA = new Client(factoryA);
            var clientB = new Client(factoryB);
        }
    }
}
