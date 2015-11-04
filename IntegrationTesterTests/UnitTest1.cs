using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntegrationTester;

namespace IntegrationTesterTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Foo.Do(), "Bar");
        }
    }
}
