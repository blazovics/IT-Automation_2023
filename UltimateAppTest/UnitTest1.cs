using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UltimateApp.Test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void AddTest()
        {
            int? retVal = Calculator.calculate(2, 3, Operation.Add);
            Assert.AreEqual(5, retVal);
        }

        [TestMethod]
        public void ModuloTest()
        {
            int? retVal = Calculator.calculate(10, 3, Operation.Modulo);
            Assert.AreEqual(1, retVal);
        }
    }
}
