using Microsoft.VisualStudio.TestPlatform.Common.Interfaces;
using System;
using Xunit;
using Xunit.Sdk;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1, 2, 3, 6)]
        [InlineData(5, 5, 5, 15)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,5,0)]
        [InlineData(-5, 20, 15)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var tester = new UnitTestMethods();


            //Act
            var actual = tester.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2,2,4)]
        [InlineData(5, 4, 20)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);


        }

        [Theory]
        [InlineData(20, 5, 4)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var tester = new UnitTestMethods();

            //Act
            var actual = tester.Divide(num1, num2);


            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
#pragma warning disable xUnit1001 // Fact methods cannot have parameters
        public void YourMethodName(object tester)
#pragma warning restore xUnit1001 // Fact methods cannot have parameters
        {
            //Arrange
            var expected = 'h';

            //Act
            var actual = tester.YourMethodName();

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void YourMethodName2(System.Collections.Generic.IEnumerable<object> actual)
        {
            //Arrange
            var expected = 'h';

            //Act


            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
