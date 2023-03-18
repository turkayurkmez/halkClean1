namespace TDD.FizzBuzzGame
{
    public class FizzBuzzBoardGame
    {
        public string GetWordForNumber(int number)
        {
            if (number == 3)
            {
                return "Fizz";
            }
            else if (number == 5)
            {
                return "Buzz";
            }

            return string.Empty;

        }
    }
}
