using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class PlayerGuessNumber
    {
        //Activity: user enters a guess PreC:no PostC:no

        //GuessNumber.ComputerGuessNumber();

        public static void FullGameLoop(int upperLimit, int lowerLimit)
        {

            int winningNumber = 0;

            winningNumber = GameFrameWork.GetRandomNumber(upperLimit, lowerLimit);

            Console.WriteLine("I am guessing a number between " + upperLimit + " and " + lowerLimit);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            bool rightAnswer = false;

            int userNum = 0;

            int guessCount = 0;


            while (!rightAnswer)
            {
                //read the number in
                //check to see if this is a number
                //compare user's number to winning number
                //if they have the right answer set it to true
                //if wrong answer set to false and return feedback too high or low
                //remember to set it to false unless true(correct)
                //set counter

                Console.WriteLine("Please enter your guess:");

                string userGuessString = Console.ReadLine();//convert

                bool isNumeric = GameFrameWork.IsNumericTry(userGuessString);

                

                while (!isNumeric)
                {
                    Console.WriteLine("That was not a number!");

                    Console.WriteLine("Please enter a number!");

                    userGuessString = Console.ReadLine();

                    isNumeric = GameFrameWork.IsNumericTry(userGuessString);

                }
                userNum = Int32.Parse(userGuessString);

                guessCount++;


                if (userNum == winningNumber)
                {
                    rightAnswer = true;

                    Console.WriteLine("Your answer is correct!");

                    Console.WriteLine("You win!");
                }

                else if(userNum > winningNumber)
                {
                    rightAnswer = false;

                    Console.WriteLine("Your answer was too high!");
                }

                else if(userNum < winningNumber)
                {
                    rightAnswer = false;

                    Console.WriteLine("Your answer was too low!");
                }


            }

            Console.WriteLine("It took you " + guessCount + " guesses! ");
            Console.WriteLine("");

            Console.WriteLine("New game!");

        }


    }
}
