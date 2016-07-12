using System.Collections.Generic;
using System.Web.Mvc;
using FizzBuzz.Controllers;
using FizzBuzz.Models;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzControllerTests
    {
        [Test]
        public void Index_ReturnsViewResultWithModel()
        {
            //arrange
            var fizzBuzzController = new FizzBuzzController();
            //act
            var viewResult = fizzBuzzController.Index() as ViewResult;
            //assert
            Assert.IsInstanceOf<List<FizzBuzzViewModel>>(viewResult.Model);

        }
    }
}