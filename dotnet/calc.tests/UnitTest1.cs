using System;
using Xunit;
using calc.Controllers;

namespace calc.tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestAdd()
        {
            var calc = new CalcController();
            Assert.Equal(5, calc.Add(2, 3));
        }

        [Fact]
        public void TestSubtract()
        {
            var calc = new CalcController();
            Assert.Equal(1, calc.Subtract(3, 2));
        }

        [Fact]
        public void TestMultiply()
        {
            var calc = new CalcController();
            Assert.Equal(6, calc.Multiply(2, 3));
        }

        [Fact]
        public void TestDivide()
        {
            var calc = new CalcController();
            Assert.Equal(2, calc.Divide(6, 3));
        }
    }
}
