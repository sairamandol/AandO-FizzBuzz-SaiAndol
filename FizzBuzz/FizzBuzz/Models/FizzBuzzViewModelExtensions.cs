namespace FizzBuzz.Models
{
    public static class FizzBuzzViewModelExtensions
    {
        public static string GetDisplayStyle(this FizzBuzzViewModel fizzBuzzViewModel)
        {
            switch (fizzBuzzViewModel.Display.Trim().ToLower())
            {
                case "fizz":
                    return "background-color:blue";
                case "buzz":
                    return "background-color:green";
            }
            return "background-color:grey";
        }
    }
}