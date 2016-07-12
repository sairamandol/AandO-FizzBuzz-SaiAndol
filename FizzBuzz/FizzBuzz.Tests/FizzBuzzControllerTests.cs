using System.Collections.Generic;
using System.Web.Mvc;
using FizzBuzz.Controllers;
using FizzBuzz.Models;
using FizzBuzz.Services;
using NUnit.Framework;
using Rhino.Mocks;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzControllerTests
    {
        [Test]
        public void Index_ReturnsViewResultWithModel()
        {
            //arrange
            var fizzBuzzService = MockRepository.GenerateMock<IFizzBuzzService>();
            var fizzBuzzController = new FizzBuzzController(fizzBuzzService);
            //act
            var viewResult = fizzBuzzController.Index() as ViewResult;
            //assert
            Assert.IsInstanceOf<List<FizzBuzzViewModel>>(viewResult.Model);
            fizzBuzzService.AssertWasCalled(f => f.Generate(Arg<int>.Is.Anything));

        }
    }
}