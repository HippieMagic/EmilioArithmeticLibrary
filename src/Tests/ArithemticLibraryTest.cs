using NUnit.Framework;

namespace ArithmeticLibrary.Tests
{
    [TestFixture]
    public class ArithmeticOperationsTests
    {
        private ArithmeticOperations calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new ArithmeticOperations();
        }

        [Test]
        public void Add_ValidInputs_ReturnsCorrectResult()
        {
            float result = calculator.Add(5.0f, 3.0f);
            Assert.AreEqual(8.0f, result);
        }

        [Test]
        public void Subtract_ValidInputs_ReturnsCorrectResult()
        {
            float result = calculator.Subtract(5.0f, 3.0f);
            Assert.AreEqual(2.0f, result);
        }

        [Test]
        public void Divide_ValidInputs_ReturnsCorrectResult()
        {
            float result = calculator.Divide(6.0f, 2.0f);
            Assert.AreEqual(3.0f, result);
        }

        [Test]
        public void Divide_ByZero_ReturnsNegative9999()
        {
            float result = calculator.Divide(5.0f, 0.0f);
            Assert.AreEqual(-9999, result);
        }

        [Test]
        public void Multiply_ValidInputs_ReturnsCorrectResult()
        {
            float result = calculator.Multiply(4.0f, 3.0f);
            Assert.AreEqual(12.0f, result);
        }

        [Test]
        public void IsValidOperator_InvalidOperator_ReturnsFalse()
        {
            Assert.IsFalse(calculator.IsValidOperator("invalid"));
        }

        [Test]
        public void IsValidNumber_ValidNumber_ReturnsTrue()
        {
            Assert.IsTrue(calculator.IsValidNumber("42"));
        }

        [Test]
        public void IsValidNumber_InvalidNumber_ReturnsFalse()
        {
            Assert.IsFalse(calculator.IsValidNumber("not_a_number"));
        }
    }
}
