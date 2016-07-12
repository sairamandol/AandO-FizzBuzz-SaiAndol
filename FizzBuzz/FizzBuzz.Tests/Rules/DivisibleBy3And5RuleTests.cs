using FizzBuzz.Services.Rules;
using NUnit.Framework;

namespace FizzBuzz.Tests.Rules
{
    [TestFixture]
    public class DivisibleBy3And5RuleTests
    {
        //Happy Path
        [Test]
        public void Apply_GivenNumberIsDivisibleByBoth3And5_ReturnsTrue()
        {
            //arrange
            const int number = 15;
            var divisibleBy3And5Rule = new DivisibleBy3And5Rule();

            //act
            var result = divisibleBy3And5Rule.Apply(number);

            //assert
            Assert.IsTrue(result);
        }

        //UnHappy Path
        [Test]
        public void Apply_GivenNumberIsDivisibleBy3_ButNotBy5_ReturnsFalse()
        {
            //arrange
            const int number = 9;
            var divisibleBy3And5Rule = new DivisibleBy3And5Rule();

            //act
            var result = divisibleBy3And5Rule.Apply(number);

            //assert
            Assert.IsFalse(result);
        }

        //UnHappy Path
        [Test]
        public void Apply_GivenNumberIsDivisibleBy5_ButNotBy3_ReturnsFalse()
        {
            //arrange
            const int number = 20;
            var divisibleBy3And5Rule = new DivisibleBy3And5Rule();

            //act
            var result = divisibleBy3And5Rule.Apply(number);

            //assert
            Assert.IsFalse(result);
        }

        //UnHappy Path
        [Test]
        public void Apply_GivenNumberIsNotDivisibleEitherBy5NorBy3_ReturnsFalse()
        {
            //arrange
            const int number = 22;
            var divisibleBy3And5Rule = new DivisibleBy3And5Rule();

            //act
            var result = divisibleBy3And5Rule.Apply(number);

            //assert
            Assert.IsFalse(result);
        }

    }
}