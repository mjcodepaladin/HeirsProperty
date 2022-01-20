using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    public static class GameFrameWork
    {
        static int PLAYER_SCORE = 0;
        static int COMPUTER_SCORE = 0;
        static int NUMBER_OF_GAMES = 0;
        static int AUTOGAME_COUNT = 0;// if you want the computer to guess and provide a number (play itself)

        public static void GameMainMenu()
        {
            GameFrameWork.WriteBorder();
            GameFrameWork.WriteMainMenu();
            GameFrameWork.WriteBorder();
        }

        private static void WriteMainMenu()
        {



            //not in current use case

            //this tells the user to press P to play Guess a Number where the Computer Chooses and Player Guesses| Press C to Play a version Where Player chooses and Computer Guesses and A to have the computer play against itself

            Console.WriteLine("press P to play Guess a Number where the Computer chooses and player guesses"); //Press C to Play a version Where Player chooses and Computer Guesses and A to have the computer play against itself");

            Console.WriteLine("Press C to play a version where you choose a number and the computer guesses.");

            Console.WriteLine("Press A if you would like the computer to both choose a number and guess a number.");

            Console.WriteLine("Press V if you would like the computer to play itself.");

            //throw new NotImplementedException();

        }

        public static string getMenuChoice()
        {
            // get the nymber of the menuchoice the user chose and return it

            Console.WriteLine("Enter your selection:");

            string userChoice = Console.ReadKey().ToString();

            return userChoice;


        }

        private static void WriteBorder()
        {
            //N/A

            Console.WriteLine("**********************************************");
 
        }

        public static void GameLoop()
        {
            //not in current use case

            //this is the main gameloop

            //depends on selection of if player or computer guesses, the loop ends on a victory or loss, the player can also choose an e for exit 


            string userInput = "";

            int gameLoop = 0;

            bool exitGame = false;

            while (userInput.ToUpper() != "E")
            {

                if (userInput == "E")
                {
                    exitGame = true;

                    //string endGame = ComputerGuessNumber.GameLoop(userInput);

                    GameFrameWork.GiveExitMessage();

                }

                else
                {
                    exitGame = false;
                }

            }

            //return gameLoop++;

            exitGame = false;

            //return gameLoop++;

          /*      string userInput = GuessNumber.PlayerGuessNumber();

            else
            {

                gameCheck = true;

                GameFrameWork.GiveExitMessage();

            }

            return gameLoop i++;*/



        GameFrameWork.GiveExitMessage();


        }

        public static void GiveExitMessage()
        {
            //N/A

            Console.WriteLine("Thank you for playing our game!");


        }

        public static int GetRandomNumber(int upper,int lower)
        {
            //work course function- ran frequently

            //Activity: The computer makes a SUBSEQUENT GUESS guess based upon feedback either by random or by guessing algorithm. PreC:yes PostC:no; the left over amount of guesses is not communicated

            // generates a random number between lower and upper inclusive
            int retnum = 0;
            Random r = new Random();
            int rInt = r.Next(lower, upper);
            return rInt;


        }

         public static bool isNumericS(string inNumber)
         {
            bool isnum = false;
            bool okdigit = true;
            int mynum;
            string sdigit;
            List<char> dlist = inNumber.ToList();

           foreach (char mydigit in dlist)
           {
            if (mydigit == '0')
            {
                isnum = true;
            }
            else if (mydigit == '1')
            {
                isnum = true;
            }
            else if (mydigit == '2')
            {
                isnum = true;
            }
            else if (mydigit == '2')
            {
                isnum = true;
            }
            else if (mydigit == '3')
            {
                isnum = true;
            }
            else if (mydigit == '4')
            {
                isnum = true;
            }
            else if (mydigit == '5')
            {
                isnum = true;
            }
            else if (mydigit == '6')
            {
                isnum = true;
            }
            else if (mydigit == '7')
            {
                isnum = true;
            }
            else if (mydigit == '8')
            {
                isnum = true;
            }
            else if (mydigit == '9')
            {
                isnum = true;
            }
            else
            {
                // NOT A DIGIT FALSE!!
                return false;
            }


           }
            return true;



         }


           public static bool IsNumericTry(string inNumeric)
           {
              int myint = 0;
              bool retbool = Int32.TryParse(inNumeric, out myint);

              return retbool;
           }
        

        public static void GameOption(int upperLimit, int lowerLimit)
        {


            //another option is the computer plays itself;;; user will be able to enter the amount of times they want the computer to play itself runs "v"
            //computer vs. computer

            string userChoice = "";

            bool gameOver = false;


            Console.WriteLine("Welcome to Guess a Number");
            Console.WriteLine("");


            while (gameOver == false)// exit game
            {
                //WriteBorder, GameLoop, and WriteMenu are never used!


                Console.WriteLine("If at any time you want to exit the game press 'E'");
                //Wrap in GameLoop = exit game option
                Console.WriteLine("");

                Console.WriteLine("User Menu:");
                Console.WriteLine("");

                Console.WriteLine("Press 'P' if you would like to guess a number the computer is thinking of or 'C' if you would like the computer to guess a number you are thinking of.");

                userChoice = Console.ReadLine();



                if (userChoice.ToUpper() == "P")
                {
                    PlayerGuessNumber.FullGameLoop(upperLimit, lowerLimit);
                 

                }
                else if (userChoice.ToUpper() == "C")
                {
                    ComputerGuessNumber.CompGuessLoop(upperLimit, lowerLimit);

                }
                else if (userChoice.ToUpper() == "V")
                {
                    //This feature coming soon!
                }
                else if (userChoice.ToUpper() == "E")
                {
                    gameOver = true;

                    GameFrameWork.GiveExitMessage();

                    Console.WriteLine("Press 'Enter' to exit");

                    //GameLoop();

                }
                else
                {
                    Console.WriteLine("You have not entered a valid response!");
                    Console.WriteLine("");

                    Console.WriteLine("Press 'P' if you would like to guess a number the computer is thinking of or 'C' if you would like the computer to guess a number you are thinking of.");

                }

            }

            



        }
        

    }
}
