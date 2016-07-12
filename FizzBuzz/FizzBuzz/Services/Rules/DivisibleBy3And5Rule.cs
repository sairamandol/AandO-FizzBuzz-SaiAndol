namespace FizzBuzz.Services.Rules
{
    public class DivisibleBy3And5Rule : IDivisibilityRule
    {
        public bool Apply(int number)
        {
            return number % 3 == 0 && number % 5 == 0;
        }
    }
}