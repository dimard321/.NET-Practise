using Shouldly;
using StringExamples;
using Xunit;

namespace TestProject
{
    /// <summary>
    /// Юнит тесты для класса CharacterDoubling
    /// </summary>
    public class CharacterDoublingTests
    {
        [Theory]
        [InlineData("omg i love Dima", "okek", "oomg i loovee Dima")]
        [InlineData("123 456", "256", "1223 45566")]
        [InlineData("", "", "")]

        public void CharacterDoubling_ShouldReternCharacterDoublingString(string inputString, string twoInputString, string exceptResult)
        {
            //Arrange
            var characterDoubling = new CharacterDoubling();

            //Act
            var result = characterDoubling.GetCharacterDoubling(inputString, twoInputString);

            //Assert
            result.ShouldBeEquivalentTo(exceptResult);
        }
    }
}
