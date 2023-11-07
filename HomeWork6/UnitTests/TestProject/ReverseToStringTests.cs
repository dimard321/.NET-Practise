using Shouldly;
using StringExamples;
using Xunit;

namespace TestProject
{
    /// <summary>
    /// Юнит тесты для класса ReverseToString
    /// </summary>
    public class ReverseToStringTests
    {
        [Theory]
        [InlineData("omg i love Dima", "Dima love i omg")]
        [InlineData("The greatest victory is that which requires no battle", "battle no requires which that is victory greatest The")]
        [InlineData("", "")]
        [InlineData("1 2 3 ", "3 2 1")]
        public void ReverseToString_ShouldReternReverseString(string inputString, string exceptResult)
        {
            //Arrange
            var rewerseToString = new ReverseToString();

            //Act
            var result = rewerseToString.ReverseWords(inputString);

            //Assert
            result.ShouldBeEquivalentTo(exceptResult);
        }
    }
}
