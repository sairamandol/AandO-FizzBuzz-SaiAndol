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

        public FizzBuzzController(IFizzBuzzService fizzBuzzService, IValidate shouldBeGreatorThan50)
        {
            _fizzBuzzService = fizzBuzzService;
            _shouldBeGreatorThan50 = shouldBeGreatorThan50;
        }

        public ActionResult Index(int number = 0)
        {
            if (number == 0)
            {
                return View(new List<FizzBuzzViewModel>());
            }
            if (!_shouldBeGreatorThan50.Validate(number))
            {
                ModelState.AddModelError("number", "Entered number should be greator than 50");
                return View(new List<FizzBuzzViewModel>());
            }
            var fizzBuzzViewModels = _fizzBuzzService.Generate(number);

            return View(fizzBuzzViewModels);
        }
    }
}