using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FizzBuzz.Models;
using FizzBuzz.Services;

namespace FizzBuzz.Controllers
{
    public class FizzBuzzController : Controller
    {
        private readonly IFizzBuzzService _fizzBuzzService;

        public FizzBuzzController(IFizzBuzzService fizzBuzzService)
        {
            _fizzBuzzService = fizzBuzzService;
        }

        public ActionResult Index(int number = 0)
        {
            var fizzBuzzViewModels = _fizzBuzzService.Generate(number);

            return View(fizzBuzzViewModels);
        }
    }
}