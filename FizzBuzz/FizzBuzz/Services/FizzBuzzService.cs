using System;
using System.Collections.Generic;
using System.Linq;
using FizzBuzz.Models;
using FizzBuzz.Services.Rules;

namespace FizzBuzz.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        private readonly DivisibleBy3Rule _divisibleBy3;
        private readonly DivisibleBy5Rule _divisibleBy5;
        private readonly DivisibleBy3And5Rule _divisibleBy3And5;

        public FizzBuzzService(DivisibleBy3Rule divisibleBy3, DivisibleBy5Rule divisibleBy5,
            DivisibleBy3And5Rule divisibleBy3And5)
        {
            _divisibleBy3 = divisibleBy3;
            _divisibleBy5 = divisibleBy5;
            _divisibleBy3And5 = divisibleBy3And5;
        }

        public List<FizzBuzzViewModel> Generate(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Number must be a positive number");
            }

            return Enumerable.Range(1, number)
                .Select(CreateFizzBuzzViewModel)
                .ToList();
        }

        private FizzBuzzViewModel CreateFizzBuzzViewModel(int number)
        {
            var isDivisibleBy3 = _divisibleBy3.Apply(number);
            var isDivisibleBy5 = _divisibleBy5.Apply(number);
            var isDivisibleBy3And5 = _divisibleBy3And5.Apply(number);

            if (isDivisibleBy3)
            {
                return isDivisibleBy3And5
                    ? new FizzBuzzViewModel() {Number = number, Display = "fizz buzz"}
                    : new FizzBuzzViewModel() {Number = number, Display = "fizz"};
            }
            if (isDivisibleBy5)
            {
                return isDivisibleBy3And5
                    ? new FizzBuzzViewModel() {Number = number, Display = "fizz buzz"}
                    : new FizzBuzzViewModel() {Number = number, Display = "buzz"};
            }
            return new FizzBuzzViewModel {Number = number, Display = number.ToString()};
        }
    }
}