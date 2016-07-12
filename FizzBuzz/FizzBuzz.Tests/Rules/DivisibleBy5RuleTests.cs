using FizzBuzz.Services.Rules;
using NUnit.Framework;

namespace FizzBuzz.Tests.Rules
{
    [TestFixture]
    public class DivisibleBy5RuleTests
    {
        [Test]
        public void Apply_GivenANumberThatIsDivisibleBy5_ReturnsTrue()
        {
            //arrange
            const int number = 15;
            var divisibleBy5Rule = new DivisibleBy5Rule();

            //act
            var result = divisibleBy5Rule.Apply(number);

            //assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Apply_GivenANumberThatIsNotDivisibleBy5_ReturnsFalse()
        {
            //arrange
            const int number = 8;
            var divisibleBy5Rule = new DivisibleBy5Rule();

            //act
            var result = divisibleBy5Rule.Apply(number);

            //assert
            Assert.IsFalse(result);
        }

    }
}