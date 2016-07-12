using FizzBuzz.Models;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzViewModelExtensionsTests
    {
        [Test]
        public void GetDisplayStyle_ReturnsBlueForFizz()
        {
            var fizzBuzzViewModel = new FizzBuzzViewModel() {Number = 3, Display = "fizz"};

            var displayStyle = fizzBuzzViewModel.GetDisplayStyle();

            Assert.That(displayStyle == "background-color:blue");
        }

        [Test]
        public void GetDisplayStyle_ReturnsGreenForBuzz()
        {
            var fizzBuzzViewModel = new FizzBuzzViewModel() {Number = 5, Display = "buzz"};

            var displayStyle = fizzBuzzViewModel.GetDisplayStyle();

            Assert.That(displayStyle == "background-color:green");
        }
    }
}