using Shouldly;
using StringExamples;
using Xunit;

namespace TestProject
{
    /// <summary>
    /// Юнит тесты для класса SumOfBigNumbers
    /// </summary>
    public class SumOfBigNumbersTests
    {
        [Theory]
        [InlineData("12646", "90000", "102646")]
        [InlineData("10", "50", "60")]
        public void SumOfBigNumbers_ShouldReternStringSumOfNumbers(string firstNumber, string twoNumber, string exceptResult)
        {
            //Arrange
            var sumOfNumbers = new SumOfNumbers();

            //Act
            var result = sumOfNumbers.GetSumOfNumbers(firstNumber, twoNumber);

            //Assert
            result.ShouldBeEquivalentTo(exceptResult);
        }

        [Fact]
        public void SumOfBigNumbers_ShouldThrowNullReferenceExceptionIfNumberIsNull()
        {
            //Arrange
            var firstNumber = "10";

            var twoNumber = "";

            var sumOfNumbers = new SumOfNumbers();

            //Act&Assert
            Should.Throw<NullReferenceException>(() => sumOfNumbers.GetSumOfNumbers(firstNumber, twoNumber));
        }

        [Fact]
        public void SumOfBigNumbers_FormatExceptionIfNumberIsNotParseToInt()
        {
            //Arrange
            var firstNumber = "14";

            var twoNumber = "DimaIsMyLove";

            var sumOfNumbers = new SumOfNumbers();

            //Act&Assert
            Should.Throw<FormatException>(() => sumOfNumbers.GetSumOfNumbers(firstNumber, twoNumber));
        }
    }
}