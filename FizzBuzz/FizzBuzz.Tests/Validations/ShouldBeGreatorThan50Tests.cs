
using FizzBuzz.Validations;
using NUnit.Framework;

namespace FizzBuzz.Tests.Validations
{
    [TestFixture]
    public class ShouldBeGreatorThan50Tests
    {
        [Test]
        public void Validate_GivenAnNumberGreatorThan50_ReturnsTrue()
        {
            var shouldBeGreatorThan50 = new ShouldBeGreatorThan50();

            Assert.IsTrue(shouldBeGreatorThan50.Validate(51));
        }

        [Test]
        public void Validate_GivenAnNumberEquals50_ReturnsFalse()
        {
            var shouldBeGreatorThan50 = new ShouldBeGreatorThan50();

            Assert.IsFalse(shouldBeGreatorThan50.Validate(50));
        }
        [Test]
        public void Validate_GivenAnNumberlessThan50_ReturnsFalse()
        {
            var shouldBeGreatorThan50 = new ShouldBeGreatorThan50();

            Assert.IsFalse(shouldBeGreatorThan50.Validate(49));
        }
    }
}