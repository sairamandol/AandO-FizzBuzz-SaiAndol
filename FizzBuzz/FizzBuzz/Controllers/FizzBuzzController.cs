using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FizzBuzz.Models;

namespace FizzBuzz.Controllers
{
    public class FizzBuzzController : Controller
    {
        // GET: FizzBuzz
        public ActionResult Index(int number = 0)
        {
            return View(new List<FizzBuzzViewModel>());
        }
    }
}