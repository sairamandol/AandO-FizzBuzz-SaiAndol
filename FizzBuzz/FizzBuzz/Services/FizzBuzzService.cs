using System;
using System.Collections.Generic;
using System.Linq;
using FizzBuzz.Models;

namespace FizzBuzz.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public List<FizzBuzzViewModel> Generate(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Number must be a positive number");
            }

            return Enumerable.Range(1, number)
                 .Select(n => new FizzBuzzViewModel() {Number = n, Display = n.ToString()})
                 .ToList();
        }
    }
}