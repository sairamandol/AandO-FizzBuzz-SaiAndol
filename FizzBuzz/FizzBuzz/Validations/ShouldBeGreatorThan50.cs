namespace FizzBuzz.Validations
{
    public class ShouldBeGreatorThan50 : IValidate
    {
        public bool Validate(int number)
        {
            return number > 50;
        }
    }
}