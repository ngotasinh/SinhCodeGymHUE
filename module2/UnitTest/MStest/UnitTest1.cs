using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTest.Calculator;

namespace MStest
{
    [TestClass]
    public class UnitTest1
    {
        private Calculator cal = new Calculator();
        [TestMethod]
        public void AddTest()
        {
            Assert.IsTrue(cal.Add(1, 1) == 2);
            Assert.AreEqual(20, cal.Add(10, 10));
        }
        [TestMethod]
        public void SubtractTest()
        {
            Assert.AreEqual(10, cal.Subtract(20, 10));
        }
    }
}
