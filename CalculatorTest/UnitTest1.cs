using System;
using Xunit;
using Calculator;

namespace CalculatorTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestAddition()
        {
            double num1 = 20;
            double num2 = 5;
            double expectedResult = 25;
            double result = CalculatorProgram.Addition(num1, num2);
            Assert.Equal(expectedResult, result);
        }
         [Fact]
        public void AddArrayTest()
        {
            double num1 = 5;
            double num2 = 7;
            double expectedResult = 12;
            double[] nums = new[] { num1, num2 };
            double result = CalculatorProgram.Addition(nums);
            Console.Write(result);

            Assert.Equal(expectedResult, result);
        }
        [Fact]

        public void TestSubtraction()
        {
            double num1 = 20;
            double num2 = 5;
            double expectedResult = 15;
            double result = CalculatorProgram.Subtraction(num1, num2);
            Assert.Equal(expectedResult, result);
        }
        public void SubArrayTest()
        {
            double num1 = 2;
            double num2 = 1;
            double expectedResult = 1;
            double[] nums = new[] { num1, num2 };
            double result = CalculatorProgram.Subtraction(nums);
            Write(result);

            Assert.Equal(expectedResult, result);
        }
         
        [Fact]
        public void TestMultiplication()
        {
            double num1 = 20;
            double num2 = 5;
            double expectedResult = 100;
            double result = CalculatorProgram.Multiplication(num1, num2);
            Assert.Equal(expectedResult, result);
        }
        
        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(9, 2, 4.5)]
        [InlineData(5, 3, 1.67)]
        public void TestDivisionTheory(double num1, double num2, double expectedResult)
        {
         
            double result = CalculatorProgram.Division(num1, num2);
            Assert.Equal(expectedResult, result,2);
        }
        [Fact]
        public void TestDivideByZeroException()
        {
            double num1 = 2;
            double num2 = 0;
            var expectedResult = Assert.Throws<DivideByZeroException> (() => CalculatorProgram.Division(num1, num2));
            
            Assert.Equal("Can not be divided by zero", expectedResult.Message);
        }



    }


}
