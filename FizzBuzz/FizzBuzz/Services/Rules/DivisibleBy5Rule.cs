namespace FizzBuzz.Services.Rules
{
    public class DivisibleBy5Rule : IDivisibilityRule
    {
        public bool Apply(int number)
        {
            return number % 5 == 0;
        }
    }
}