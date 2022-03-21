using System;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void TestAdd()
        {
            Assert.AreEqual(20, Calculator.Add(10,10));
        }
        public void TestSubtract()
        {
            Assert.AreEqual(0, Calculator.Subtract(10,10));
        }
        public void TestDivide()
        {
            Assert.AreEqual(1, Calculator.Divide(10,10));
        }
        public void TestMultiply()
        {
            Assert.AreEqual(100, Calculator.Multiply(10,10));
        }
    }
}