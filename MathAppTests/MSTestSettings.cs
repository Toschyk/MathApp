using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathApp;

namespace MathAppTests
{
    [TestClass]
    public class CalculatorTests
    {
        private Calculator calculator;

        [TestInitialize]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        public void Add_TwoNumbers_ReturnsCorrectSum()
        {
            var result = calculator.Add(2, 3);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Divide_ByZero_ThrowsException()
        {
            calculator.Divide(10, 0);
        }
    }
}
