namespace FizzBuzz.Validations
{
    public class ShouldBeBetween50And1000
    { 
        public bool Validate(int number)
        {
            return 50 < number && number < 1000;
        }
    }
}