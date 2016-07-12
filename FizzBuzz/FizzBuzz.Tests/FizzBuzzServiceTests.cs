using System;
using System.Linq;
using FizzBuzz.Services;
using FizzBuzz.Services.Rules;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzServiceTests
    {
        private FizzBuzzService _fizzBuzzService;

        [SetUp]
        public void Setup()
        {
            _fizzBuzzService = new FizzBuzzService(new DivisibleBy3Rule(), new DivisibleBy5Rule(), new DivisibleBy3And5Rule());
        }

        [Test]
        public void Generate_GivenAPositiveNumber_WouldGenerateA_ListOfFizzBuzzViewModels_Between1AndGivenNumber()
        {
            //arrange
            //act
            var fizzBuzzViewModels = _fizzBuzzService.Generate(2);
            //assert
            Assert.That(fizzBuzzViewModels.Count == 2);
            Assert.That(fizzBuzzViewModels.First().Number == 1);
            Assert.That(fizzBuzzViewModels.First().Display == "1");
            Assert.That(fizzBuzzViewModels.Last().Number == 2);
            Assert.That(fizzBuzzViewModels.Last().Display == "2");
        }

        [Test]
        public void Generate_GivenAnNegativeNumber_ThrowsArgumentException()
        {
            //arrange
            Assert.Throws<ArgumentException>(() => _fizzBuzzService.Generate(-1));
        }

        [Test]
        public void Generate_GivenAnNumberDivisibleByOnly3_CreatesAViewModelContainingDisplayFizz()
        {
            var fizzBuzzViewModels = _fizzBuzzService.Generate(3);

            Assert.That(fizzBuzzViewModels.Last().Display == "fizz");
        }

        [Test]
        public void Generate_GivenAnNumberDivisibleByOnly5_CreatesAViewModelContainingDisplayBuzz()
        {
            var fizzBuzzViewModels = _fizzBuzzService.Generate(5);

            Assert.That(fizzBuzzViewModels.Last().Display == "buzz");
        }

        [Test]
        public void Generate_GivenAnNumberDivisibleBy3And5_CreatesAViewModelContainingDisplayBuzz()
        {
            var fizzBuzzViewModels = _fizzBuzzService.Generate(15);

      
            Assert.That(fizzBuzzViewModels.Find(m => m.Number==6).Display == "fizz");
            Assert.That(fizzBuzzViewModels.Find(m => m.Number==7).Display == "7");
            Assert.That(fizzBuzzViewModels.Find(m => m.Number==10).Display == "buzz");
            Assert.That(fizzBuzzViewModels.Last().Display == "fizz buzz");
        }
    }
}