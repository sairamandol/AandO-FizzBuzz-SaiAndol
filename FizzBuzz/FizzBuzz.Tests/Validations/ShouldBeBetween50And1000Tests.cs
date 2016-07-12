using FizzBuzz.Validations;
using NUnit.Framework;

namespace FizzBuzz.Tests.Validations
{
    [TestFixture]
    public class ShouldBeBetween50And1000Tests
    {
        [Test]
        public void Validate_GivenAnNumberBetween50And1000_ReturnsTrue()
        {
            var shouldBeBetween50And1000 = new ShouldBeBetween50And1000();

            Assert.IsTrue(shouldBeBetween50And1000.Validate(51));
        }

        [Test]
        public void Validate_GivenAnNumberEquals50_ReturnsFalse()
        {
            var shouldBeBetween50And1000 = new ShouldBeBetween50And1000();

            Assert.IsFalse(shouldBeBetween50And1000.Validate(50));
        }

        [Test]
        public void Validate_GivenAnNumberEquals1000_ReturnsFalse()
        {
            var shouldBeBetween50And1000 = new ShouldBeBetween50And1000();

            Assert.IsFalse(shouldBeBetween50And1000.Validate(1000));
        }

        [Test]
        public void Validate_GivenAnNumberGreatorThan1000_ReturnsFalse()
        {
            var shouldBeBetween50And1000 = new ShouldBeBetween50And1000();

            Assert.IsFalse(shouldBeBetween50And1000.Validate(1001));
        }

        [Test]
        public void Validate_GivenAnNumberlessThan50_ReturnsFalse()
        {
            var shouldBeBetween50And1000 = new ShouldBeBetween50And1000();

            Assert.IsFalse(shouldBeBetween50And1000.Validate(49));
        }
    }
}