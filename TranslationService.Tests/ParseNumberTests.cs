using FluentAssertions;
using NUnit.Framework;

namespace TranslationService.Tests
{
    public class ParseNumberTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(1, "ONE")]
        [TestCase(11, "ELEVEN")]
        [TestCase(10, "TEN")]
        [TestCase(30, "THIRTY")]
        [TestCase(104, "ONE HUNDRED AND FOUR")]
        [TestCase(130, "ONE HUNDRED AND THIRTY")]
        [TestCase(999, "NINE HUNDRED AND NINTY NINE")]
        public void VerifyInputReturnsStringRepresenation(int number, string expectation)
        {
            //Arrange
            var parseNumber = new ParseNumber();

            //Act

            var response = parseNumber.GetText(number);

            //Assert
            response.Should().Be(expectation);
        }
    }
}