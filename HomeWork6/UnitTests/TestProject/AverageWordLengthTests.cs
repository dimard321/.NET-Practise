using Shouldly;
using StringExamples;
using Xunit;

namespace TestProject
{
    /// <summary>
    /// Юнит тесты для класса AverageWordLength
    /// </summary>
    public class AverageWordLengthTests
    {
        [Theory]
        [InlineData("omg i love Dima", 3)]
        [InlineData("123 4567", 3.5)]
        [InlineData("", 0)]

        public void AverageWordLength_ShouldReternAverageWordLength(string inputString, double exceptResult)
        {
            //Arrange
            var averageWordLength = new AverageWordLength();

            //Act
            var result = averageWordLength.GetAverageWordLength(inputString);

            //Assert
            result.ShouldBeEquivalentTo(exceptResult);
        }
    }
}
