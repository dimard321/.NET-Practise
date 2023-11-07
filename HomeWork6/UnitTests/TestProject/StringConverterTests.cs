using AutoFixture;
using Moq;
using NLog;
using Shouldly;
using StringConverterLibrary;
using Xunit;

namespace TestProject
{
    /// <summary>
    /// Юнит тесты для класса StringConverter
    /// </summary>
    public class StringConverterTests
    {
        private readonly Mock<ILogger> _loggerMock;

        private readonly Fixture _fixture;

        /// <summary>
        /// Конструктор класса, инициализирующий мок для логгера.
        /// </summary>
        public StringConverterTests()
        {
            _loggerMock = new Mock<ILogger>();

            _fixture = new Fixture();
        }

        [Fact]
        public void StringConverter_ShouldConvertStringToInt()
        {
            //Arrange
            var inputString = _fixture.Create<int>().ToString();

            var expectedResult = int.Parse(inputString);

            var stringConverter = new StringConverter(_loggerMock.Object);

            //Act
            var result = stringConverter.ConvertToInt(inputString);

            //Assert
            result.ShouldBeEquivalentTo(expectedResult);
        }

        [Fact]
        public void StringConverter_ThrowOverflowExceptionIfInputStringGreaterThanInt()
        {
            //Arrange
            var inputString = "9999999999999999";

            var stringConverter = new StringConverter(_loggerMock.Object);

            //Act&Assert
            Assert.Throws<OverflowException>(() => stringConverter.ConvertToInt(inputString));
        }

        [Fact]
        public void StringConverter_ShouldValidateInputStringAndReturnTrue()
        {
            //Arrange
            var inputString = _fixture.Create<int>().ToString();

            var stringConverter = new StringConverter(_loggerMock.Object);

            //Act
            var result = stringConverter.Validate(inputString);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void StringConverter_ArgumentExceptionIfNumberIsNotParseToInt()
        {
            //Arrange
            var inputString = "4646hukh";

            var stringConverter = new StringConverter(_loggerMock.Object);

            //Act&Assert
            Assert.Throws<ArgumentException>(() => stringConverter.Validate(inputString));
        }
    }
}

