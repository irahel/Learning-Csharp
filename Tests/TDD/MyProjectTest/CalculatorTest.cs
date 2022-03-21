using System.Collections.Generic;
using System.Collections;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTest
    {   

        //Assert.True
        //Assert.False
        //Assert.Equal        
        [Fact]
        public void TestAdd()
        {        
            Assert.Equal(20, Calculator.Add(10, 10));
            Assert.Equal(30, Calculator.Add(15, 15));
            Assert.Equal(40, Calculator.Add(30, 10));
        }

        [Theory]
        [InlineData(10,10,20)]
        [InlineData(15,15,30)]
        [InlineData(20,20,40)]
        public void TestAddTheory(int n1, int n2, int expected)
        {
            Assert.Equal(expected, Calculator.Add(n1, n2));
        }
        [Fact(Skip = "Not Implemented Yet")]
        public void TestSubtract()
        {
            Assert.Equal(0, Calculator.Subtract(10,10));
        }        

        [Fact(DisplayName = "Testing Division")]
        public void TestDivide()
        {
            Assert.Equal(1, Calculator.Divide(10,10));
        }
        [Fact]
        public void TestMultiply()
        {
            Assert.Equal(100, Calculator.Multiply(10,10));
        }
    }
}
