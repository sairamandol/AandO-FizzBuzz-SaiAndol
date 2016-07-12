using FizzBuzz.Services.Rules;
using NUnit.Framework;

namespace FizzBuzz.Tests.Rules
{
    [TestFixture]
    public class DivisibleBy3RuleTests
    {
        [Test]
        public void Apply_GivenANumberThatIsDivisibleBy3_ReturnsTrue()
        {
            //arrange
            const int number = 9;
            var divisibleBy3Rule = new DivisibleBy3Rule();

            //act
            var result = divisibleBy3Rule.Apply(number);

            //assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Apply_GivenANumberThatIsNotDivisibleBy3_ReturnsFalse()
        {
            //arrange
            const int number = 8;
            var divisibleBy3Rule = new DivisibleBy3Rule();

            //act
            var result = divisibleBy3Rule.Apply(number);

            //assert
            Assert.IsFalse(result);
        }
    }
}