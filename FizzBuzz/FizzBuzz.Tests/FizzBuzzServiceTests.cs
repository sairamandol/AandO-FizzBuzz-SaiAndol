using System.Linq;
using FizzBuzz.Services;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzServiceTests
    {
        [Test]
        public void Generate_GivenAPositiveNumber_WouldGenerateA_ListOfFizzBuzzViewModels_Between1AndGivenNumber()
        {
            //arrange
            var fizzBuzzService = new FizzBuzzService();
            //act
            var fizzBuzzViewModels = fizzBuzzService.Generate(2);
            //assert
            Assert.That(fizzBuzzViewModels.Count == 2);
            Assert.That(fizzBuzzViewModels.First().Number == 1);
            Assert.That(fizzBuzzViewModels.First().Display == "1");
            Assert.That(fizzBuzzViewModels.Last().Number == 2);
            Assert.That(fizzBuzzViewModels.Last().Display == "2");
        }
    }
}