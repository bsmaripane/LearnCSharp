using NUnit.Framework;
using CalculatorApp;

namespace CalculatorTests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }

        [Test]
        public void Add_TwoNumbers_ReturnsSum()
        {
            double result = calc.Add(3, 2);
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Subtract_TwoNumbers_ReturnsDifference()
        {
            double result = calc.Subtract(10, 4);
            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            double result = calc.Multiply(5, 2);
            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void Divide_TwoNumbers_ReturnsQuotient()
        {
            double result = calc.Divide(10, 2);
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() => calc.Divide(10, 0));
        }
    }
}
