using System;
using Xunit;
using UnitTest.Calculator;

namespace XUnitTest
{
    public class UnitTest1
    {
        Calculator cal = new Calculator();
        [Fact]
        public void AddFactTest()
        {
            Assert.Equal(10, cal.Add(5, 5));
        }
        [Theory]
        [InlineData(10,10,20)]
        [InlineData(5,5,10)]
        public void AddTheoryTest(int a, int b, int c)
        {
            Assert.Equal(c, cal.Add(a, b));
        }
       
    }
    

}
