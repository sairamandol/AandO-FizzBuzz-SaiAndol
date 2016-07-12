namespace FizzBuzz.Services.Rules
{
    public class DivisibleBy3Rule : IDivisibilityRule
    {
        public bool Apply(int number)
        {
            return number % 3 == 0;
        }
    }
}