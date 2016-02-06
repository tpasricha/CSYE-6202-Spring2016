namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string RunFizzBuzz(int number)
        {
            string result = number.ToString();

            if (number == 0)
                return "0";
            else if (number == 1)
                return "1";
            else if (number % 5 == 0 && number % 3 == 0)
                return "FizzBuzz";
            else if (number % 3 == 0)
                return "Fizz";
            else if (number % 5 == 0)
                return "Buzz";
            else
                return result;
        }
    }
}
