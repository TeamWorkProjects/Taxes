using System;
using Xunit;

namespace taxes.test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            int a = 2;
            int b = 4;
            //Act
            int result = a + b;
            //Assert
            Assert.Equal(result, 6);
        }
    }
}
