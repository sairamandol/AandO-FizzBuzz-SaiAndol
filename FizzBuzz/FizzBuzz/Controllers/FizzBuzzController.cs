using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FizzBuzz.Models;
using FizzBuzz.Services;
using FizzBuzz.Validations;

namespace FizzBuzz.Controllers
{
    public class FizzBuzzController : Controller
    {
        private readonly IFizzBuzzService _fizzBuzzService;
        private readonly IValidate _shouldBeGreatorThan50;
        private readonly ShouldBeBetween50And1000 _shouldBeBetween50And1000;

        public FizzBuzzController(IFizzBuzzService fizzBuzzService, IValidate shouldBeGreatorThan50, ShouldBeBetween50And1000 shouldBeBetween50And1000)
        {
            _fizzBuzzService = fizzBuzzService;
            _shouldBeGreatorThan50 = shouldBeGreatorThan50;
            _shouldBeBetween50And1000 = shouldBeBetween50And1000;
        }

        public ActionResult Index(int number = 0)
        {
            if (number == 0)
            {
                return View(new List<FizzBuzzViewModel>());
            }
            if (!(_shouldBeGreatorThan50.Validate(number) && _shouldBeBetween50And1000.Validate(number)))
            {
                ModelState.AddModelError("number", "Number must be between 50 and 1000");
                return View(new List<FizzBuzzViewModel>());
            }
            var fizzBuzzViewModels = _fizzBuzzService.Generate(number);

            return View(fizzBuzzViewModels);
        }
    }
}