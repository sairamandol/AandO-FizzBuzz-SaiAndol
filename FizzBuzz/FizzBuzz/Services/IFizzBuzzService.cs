using System.Collections.Generic;
using FizzBuzz.Models;

namespace FizzBuzz.Services
{
    public interface IFizzBuzzService
    {
        List<FizzBuzzViewModel> Generate(int number);
    }
}