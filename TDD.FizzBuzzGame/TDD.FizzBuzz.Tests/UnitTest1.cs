using TDD.FizzBuzzGame;

namespace TDD.FizzBuzz.Tests
{
    public class GameTest
    {
        //[Fact]
        //public void IsExists()
        //{
        //    var gameBoard = new TDD.FizzBuzzGame.FizzBuzzBoardGame();
        //    int number = 3;
        //    string response = gameBoard.GetWordForNumber(number);
        //}

        private FizzBuzzBoardGame gameBoard = new FizzBuzzBoardGame();

        /*
         * Ben bir oyuncu olarak
         * -- Given: Oyun oynarken
         * -- When: 3 sayısına denk gelirsem
         * -- Then: Fizz demeliyim
         * 
         */

        [Fact]
        public void When_Send_Three_Return_Fizz()
        {
            gameBoard = new FizzBuzzBoardGame();
            int number = 3;
            string actual = gameBoard.GetWordForNumber(number);
            Assert.Equal("Fizz", actual);
        }

        [Fact]
        public void When_Send_Five_ReturnBuzz()
        {
            gameBoard = new FizzBuzzBoardGame();
            int number = 5;
            string actual = gameBoard.GetWordForNumber(number);
            Assert.Equal("Buzz", actual);
        }


    }
}