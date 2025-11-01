using NUnit.Framework;

namespace ConsoleApp1.Tests
{
    public class CalculatorTests
    {
        [Test]
        public void TestAddition()
        {
            var calc = new Calculator.Calculator(5, 3, '+');
            Assert.That(calc.Calculate(), Is.EqualTo(8));
        }

        [Test]
        public void TestSubtraction()
        {
            var calc = new Calculator.Calculator(10, 4, '-');
            Assert.That(calc.Calculate(), Is.EqualTo(6));
        }

        [Test]
        public void TestMultiplication()
        {
            var calc = new Calculator.Calculator(6, 7, '*');
            Assert.That(calc.Calculate(), Is.EqualTo(42));
        }

        [Test]
        public void TestDivision()
        {
            var calc = new Calculator.Calculator(20, 4, '/');
            Assert.That(calc.Calculate(), Is.EqualTo(5));
        }

        [Test]
        public void TestDivisionByZeroThrowsException()
        {
            var calc = new Calculator.Calculator(5, 0, '/');
            Assert.Throws<DivideByZeroException>(() => calc.Calculate());
        }

        [Test]
        public void TestInvalidOperationThrowsException()
        {
            var calc = new Calculator.Calculator(5, 5, '%');
            Assert.Throws<ArgumentException>(() => calc.Calculate());
        }
    }
}