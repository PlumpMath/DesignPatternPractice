using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternPractice.Test
{
    [TestClass]
    public class UnitTestSingleton
    {
        [TestMethod]
        public void TestNoThreadSingelton_GetInstance()
        {
            Assert.IsNotNull(NoThreadSingleton.Instance);
        }

        [TestMethod]
        public void TestSimpleSingleton_GetInstance()
        {
            Assert.IsNotNull(SimpleSingleton.Instance);
        }

        [TestMethod]
        public void TestSimpleSingleton_GetInstance2()
        {
            Assert.IsNotNull(SimpleSingleton.Instance2);
        }

        [TestMethod]
        public void TestWithoutLockSingleton_GetInstance()
        {
            Assert.IsNotNull(WithoutLockSingleton.Instance);
        }

        [TestMethod]
        public void TestFullLazySingleton_GetInstance()
        {
            Assert.IsNotNull(FullLazySingleton.Instance);
        }

        [TestMethod]
        public void TestDotNet4LazySingleton_GetInstance()
        {
            Assert.IsNotNull(DotNet4LazySingleton.Instance);
        }
    }
}
