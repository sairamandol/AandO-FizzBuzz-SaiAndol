using System.Collections.Generic;
using System.Web.Mvc;
using FizzBuzz.Controllers;
using FizzBuzz.Models;
using FizzBuzz.Services;
using FizzBuzz.Validations;
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
            IValidate shouldBeGreatorThan50 = MockRepository.GenerateMock<IValidate>();
            var fizzBuzzController = new FizzBuzzController(fizzBuzzService, shouldBeGreatorThan50);
            //act
            var viewResult = fizzBuzzController.Index() as ViewResult;
            //assert
            Assert.IsInstanceOf<List<FizzBuzzViewModel>>(viewResult.Model);

        }

        [Test]
        public void Index_CallsTheValidator_ToValidateInput()
        {
            //arrange
            var fizzBuzzService = MockRepository.GenerateMock<IFizzBuzzService>();
            IValidate shouldBeGreatorThan50 = MockRepository.GenerateMock<IValidate>();
            var fizzBuzzController = new FizzBuzzController(fizzBuzzService, shouldBeGreatorThan50);
            //act
            var viewResult = fizzBuzzController.Index(49) as ViewResult;
            //assert
            Assert.IsInstanceOf<List<FizzBuzzViewModel>>(viewResult.Model);
            fizzBuzzService.AssertWasNotCalled(f => f.Generate(Arg<int>.Is.Anything));
            shouldBeGreatorThan50.AssertWasCalled(v => v.Validate(Arg<int>.Is.Anything));
        }

        [Test]
        public void Index_CallsTheFileService_ForValuesGreatorThan50()
        {
            //arrange
            var fizzBuzzService = MockRepository.GenerateMock<IFizzBuzzService>();
            IValidate shouldBeGreatorThan50 = MockRepository.GenerateMock<IValidate>();
            shouldBeGreatorThan50.Stub(v => v.Validate(Arg<int>.Is.Anything)).Return(true);
            var fizzBuzzController = new FizzBuzzController(fizzBuzzService, shouldBeGreatorThan50);
            //act
            var viewResult = fizzBuzzController.Index(51) as ViewResult;
            //assert
            fizzBuzzService.AssertWasCalled(f => f.Generate(Arg<int>.Is.Anything));
        }
    }
}