using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{



    public class ComputerGuessNumber
    {
        public static int upperlimit { get; set; }// Activity: Within The computer makes an INITIAL guess either by random or by guessing algorithm.
        public int guesslimit { get; set; }
        public static int lowerlimit { get; set; }
        public int currentguess { get; set; }
        public int guesscount { get; set; }


        public static int MakeComputerGuess(string feedback, int oldguess, int lowerg, int upperg)
        {

            //Activity: The computer makes an INITIAL guess either by random or by guessing algorithm. PreC:yes PostC:yes


            int cGuess = -1; //lowerg + upperg / 2;

            int CGuessOne = (lowerg + upperg) / 2;

            bool newGuess = false;


            //int newGuess = 0;

            // make loop to store old guesses and update using those parameters 
            if (feedback.ToUpper() == "H")
            {

                //****swaps oldguess1, oldguess2, oldguess3 before you make your new guess find average if old two guesses repeat


                //Console.WriteLine("Your old guess was too high!"); //oldguess was too high 

                //cGuess = (lowerg + oldguess) / 2;// should cGuess = cGuessOne

                ComputerGuessNumber.upperlimit = oldguess - 1;

                //if old number = 1,3,5,7,9 then + 1 / 2
                if (oldguess == 1)
                {
                    cGuess = (lowerg + oldguess) + 1 / 2;
                }
                else if (oldguess == 3)
                {
                    cGuess = (lowerg + oldguess) + 1 / 2;
                }
                else if (oldguess == 5)
                {
                    cGuess = (lowerg + oldguess) + 1 / 2;
                }
                else if (oldguess == 7)
                {
                    cGuess = (lowerg + oldguess) + 1 / 2;
                }
                else if (oldguess == 9)
                {
                    cGuess = (lowerg + oldguess) + 1 / 2;
                }
                else
                {
                    cGuess = (lowerg + oldguess) / 2;
                }


            }
            else if (feedback.ToUpper() == "L")
            {

                //cGuess = (oldguess + upperg) / 2;

                //Console.WriteLine("Your old guess was too low!");//oldguess was too low

                ComputerGuessNumber.lowerlimit = oldguess + 1;

                //if old number = 1,3,5,7,9 then + 1 / 2
                if (oldguess == 1)
                {
                    cGuess = (upperg + oldguess) + 1 / 2;
                }
                else if (oldguess == 3)
                {
                    cGuess = (upperg + oldguess) + 1 / 2;
                }
                else if (oldguess == 5)
                {
                    cGuess = (upperg + oldguess) + 1 / 2;
                }
                else if (oldguess == 7)
                {
                    cGuess = (upperg + oldguess) + 1 / 2;
                }
                else if (oldguess == 9)
                {
                    cGuess = (upperg + oldguess) + 1 / 2;
                }
                else
                {
                    cGuess = (upperg + oldguess) / 2;
                }



                // oldguess + prevOldGuess then / 2


            }
            else if (feedback.ToUpper() == "I")//insert after "I" || feedback == ""
            {
                // THIS IS THE First guess
                //assume initial guess
                //cGuess = GameFrameWork.GetRandomNumber(upperlimit, lowerlimit);

                cGuess = oldguess;//********************************************************************************Have to make note that this the initial is equal to the new computer response: I need to make code that does not allow this to happen

            }
            else if (feedback.ToUpper() == "C")
            {
                ;
                //Console.WriteLine("Correct! You win!");
                //do win cycle
            }
            else
            {
                Console.WriteLine(feedback + " is an INVALID OPTION! TRY AGAIN H for Too HiGH L for Too Low C for Correct");
            }

            return cGuess;//??
        }

        //report guess and get feedback 

        public static int MakeComputerGuessCVC(string feedback, int oldguess, int lowerg, int upperg)
        {

            //Guesser

            //Activity: The computer makes an INITIAL guess either by random or by guessing algorithm. PreC:yes PostC:yes


            int cGuess = -1; //lowerg + upperg / 2;

            int CGuessOne = (lowerg + upperg) / 2;

            bool newGuess = false;

            //int newGuess = 0;


            // make loop to store old guesses and update using those parameters 
            if (feedback.ToUpper() == "H")//////////////////////////////////////////////////////////////////
            {

                //****swaps oldguess1, oldguess2, oldguess3 before you make your new guess find average if old two guesses repeat


                //Console.WriteLine("My old guess was too high!"); //oldguess was too high 

                //cGuess = (lowerg + oldguess) / 2;// should cGuess = cGuessOne

                ComputerGuessNumber.upperlimit = oldguess - 1;

                //if old number = 1,3,5,7,9 then + 1 / 2
                if (oldguess == 1)
                {
                    cGuess = (lowerg + oldguess) + 1 / 2;
                }
                else if (oldguess == 3)
                {
                    cGuess = (lowerg + oldguess) + 1 / 2;
                }
                else if (oldguess == 5)
                {
                    cGuess = (lowerg + oldguess) + 1 / 2;
                }
                else if (oldguess == 7)
                {
                    cGuess = (lowerg + oldguess) + 1 / 2;
                }
                else if (oldguess == 9)
                {
                    cGuess = (lowerg + oldguess) + 1 / 2;
                }
                else
                {
                    cGuess = (lowerg + ComputerGuessNumber.upperlimit) / 2;
                }


            }
            else if (feedback.ToUpper() == "L")
            {

                //cGuess = (oldguess + upperg) / 2;

                //Console.WriteLine("My old guess was too low!");//oldguess was too low

                ComputerGuessNumber.lowerlimit = oldguess + 1;

                //if old number = 1,3,5,7,9 then + 1 / 2
                if (oldguess == 1)
                {
                    cGuess = (upperg + oldguess) + 1 / 2;
                }
                else if (oldguess == 3)
                {
                    cGuess = (upperg + oldguess) + 1 / 2;
                }
                else if (oldguess == 5)
                {
                    cGuess = (upperg + oldguess) + 1 / 2;
                }
                else if (oldguess == 7)
                {
                    cGuess = (upperg + oldguess) + 1 / 2;
                }
                else if (oldguess == 9)
                {
                    cGuess = (upperg + oldguess) + 1 / 2;
                }
                else
                {
                    cGuess = (upperg + ComputerGuessNumber.lowerlimit) / 2;
                }



                // oldguess + prevOldGuess then / 2


            }
            else if (feedback.ToUpper() == "I")//insert after "I" || feedback == ""/////////////////////////////////////////
            {
                // THIS IS THE First guess
                //assume initial guess
                //cGuess = GameFrameWork.GetRandomNumber(upperlimit, lowerlimit);

                cGuess = oldguess;//*****************************Have to make note that this the initial is equal to the new computer response: I need to make code that does not allow this to happen

            }
            else if (feedback.ToUpper() == "C")/////////////////////////////////////////////
            {
                ;
                //Console.WriteLine("Correct! You win!");
                //do win cycle
            }


            return cGuess;//??
        }

        //report guess and get feedback 



        public static string ReportFeedback(int compGuess)
        {

            //******************************************************************************Do I need to correspond comGuess with random number

            Console.WriteLine("The computer guess is: " + compGuess);

            string LMessage = "Too Low";

            string HMessage = "Too High";

            string CMessage = "Correct";

            Console.WriteLine("Please enter 'H' if my guess is too high , 'L' if my guess is too low, or 'C' if my guess is correct:");

            Console.WriteLine("");

            string feedback = Console.ReadLine().ToString();

            bool correctInput = false;

            while (correctInput == false)
            {
                if (feedback.ToUpper() == "L")
                {
                    Console.WriteLine("Your answer was " + LMessage);

                    correctInput = true;

                }

                else if (feedback.ToUpper() == "H")
                {
                    Console.WriteLine("Your answer was " + HMessage);

                    correctInput = true;
                }
                else if (feedback.ToUpper() == "C")
                {
                    Console.WriteLine("Your answer was " + CMessage);

                    correctInput = true;
                }
                else
                {

                    correctInput = false;

                    Console.WriteLine("That was not a valid response");
                    Console.WriteLine("Please enter 'H' if my guess is too high or 'L' if my guess is too low or 'C' if the answer is correct:");

                    feedback = Console.ReadLine().ToString();//***************************************************************************

                }

                //feedback = Console.ReadKey().ToString();

            }

            return feedback;



        }

        public static string ReportFeedbackCVC(int compGuess, int actualNum)
        {

            //Change from string?

            string compFeedback = "";

            //Console.WriteLine("The computer guess is: " + compGuess);

            string LMessage = "Too Low";

            string HMessage = "Too High";

            string CMessage = "Correct";


            //bool correctInput = false;
            Console.WriteLine("Inside report feedback my guess is " + compGuess + "and " + actualNum);

            //actual num compared to compguess then return response
            if (compGuess < actualNum)
                {

                    
                    Console.WriteLine("My answer was " + LMessage);

                compFeedback = "L";

                return compFeedback;

                    //correctInput = true;

                }

                else if (compGuess > actualNum)
                {
                    Console.WriteLine("My answer was " + HMessage);

                compFeedback = "H";

                return compFeedback;

                //correctInput = true;
                }
                else if (compGuess == actualNum)
                {
                    Console.WriteLine("My answer is " + CMessage);

                compFeedback = "C";

                return compFeedback;
                //correctInput = true;
            }
            else
            {
                Console.WriteLine("Test result!");

                compFeedback = "error";

                return compFeedback;
            }
               
            

        }

        public static void CompVCompLoop(int upper, int lower)
        {
            int myNum = 0;

            int loopCount = 0;//was -1

            bool correctNumber = false;

            int updatedGuess = 0;

            string userFeedback = "";

            int runTime = 0;

            int compGuessRan = 0;

            string validateGuess = "";

            int numberOfRuns = 0;



            Console.WriteLine("How many times would you like me to play against myself?");

            userFeedback = Console.ReadLine();//this is the number of times the user wants the computer to play itself


            runTime = Int32.Parse(userFeedback);// converts string to int

            //I need to wrap in exit function     //number of runs final in wrong place?

            while (numberOfRuns < runTime )//|| myNum == compGuessRan

            { 
                

                myNum = GameFrameWork.GetRandomNumber(upper, lower);//The computer's actual number

                Console.WriteLine("The number I have in mind is between 1 and 100");
                Console.WriteLine("");

                Console.WriteLine("Let's see how long it takes me to get the correct number!");


                compGuessRan = GameFrameWork.GetRandomNumber(upper, lower);//computer's guess//was upper, lower


                validateGuess = ComputerGuessNumber.ReportFeedbackCVC(compGuessRan, myNum);//compares the computer's actual number to the computer's random guess and validates the guess based on if it is or isn't right

                

                //updatedGuess = ComputerGuessNumber.MakeComputerGuessCVC(validateGuess, compGuessRan, upper, lower);

                Console.WriteLine("My guess is: " + compGuessRan);//was validate guess


                if (validateGuess.ToUpper() == "C")
                {

                    Console.WriteLine("I got it right on the first try!");
                    Console.WriteLine("");
                    Console.WriteLine("");

                    //compGuessRan = myNum;
                    //correctNumber = true;



                }//add high and low
                
                else 
                {  
                    //////////////////////////////////////////possible problem aresa
                    updatedGuess = compGuessRan;

                    //correctNumber = false;
                    //////////////////////////////////////////} this bracket was here!!!!!!!!!!!!!!!!!!!!!

                    //never gets to this bc it always guesses the right number
                    Console.WriteLine("Test before inner loop" + correctNumber.ToString());

                  while (!correctNumber)////////////////////////possible problem
                  {

                    //validateGuess = ComputerGuessNumber.ReportFeedbackCVC(updatedGuess, myNum);

                    updatedGuess = ComputerGuessNumber.MakeComputerGuessCVC(validateGuess, compGuessRan, lower, upper);
                        Console.WriteLine("test.outer..My guess is: " + updatedGuess);//was validateGuess

                    if (validateGuess.ToUpper() == "C")// = compGuessRan? b/c that's the first guess
                    {

                        Console.WriteLine("I got it right! inner");
                        Console.WriteLine("");
                        Console.WriteLine("");

                        correctNumber = false;/////////////////////////////was true



                    }//add high and low
                    else if (validateGuess.ToUpper() == "H")// = compGuessRan? b/c that's the first guess
                    {

                        Console.WriteLine("My guess was too high!");
                        Console.WriteLine("");
                        Console.WriteLine("");

                        Console.WriteLine("test.inner..My guess is: " + updatedGuess);

                    }

                    else if (validateGuess.ToUpper() == "L")// = compGuessRan? b/c that's the first guess
                    {

                        Console.WriteLine("My guess was too low!");
                        Console.WriteLine("");
                        Console.WriteLine("");

                        Console.WriteLine("test.inner..My guess is: " + updatedGuess);
                    }
                    else///////////////////////////////////////////////////////////////////////////////////////////////////////// 
                    {


                        //validateGuess = ComputerGuessNumber.ReportFeedbackCVC(compGuessRan, myNum);/////////////////////////////?
                        //updatedGuess = compGuessRan;

                        updatedGuess = ComputerGuessNumber.MakeComputerGuessCVC(validateGuess, updatedGuess, lower, upper);//ComputerGuessNumber.lowerlimit, ComputerGuessNumber.upperlimit

                        Console.WriteLine("My new guess is: " + updatedGuess);

                        correctNumber = true;//////////////////////////was false
                    }

                  }

                    
                }//test
                loopCount++;//Constantly been moved correct?

                numberOfRuns++;//Constantly been moved
            }


            Console.WriteLine("");
            Console.WriteLine("It took me " + loopCount + " guesses");
            Console.WriteLine("");

            Console.WriteLine("New Game!");
            Console.WriteLine("");
            Console.ReadLine();

            //the loop is supposed to end here

        }

        public static void CompGuessLoop(int upper, int lower)
        {

            int min = lower;

            int max = upper;

            string userParam = "";

            int loopCount = 0;

            bool correctNumber = false;

            int updatedGuess = 0;

            //bool gameWon = false;



            Console.WriteLine("Think of a number");

            Console.WriteLine();

            Console.WriteLine("Enter your minimum parameter:");

            userParam = Console.ReadLine();

            min = Int32.Parse(userParam);

            Console.WriteLine("Ener your maximum parameter:");

            userParam = Console.ReadLine();

            max = Int32.Parse(userParam);

            //make validation loop user's info parameters
            ComputerGuessNumber.upperlimit = max;
            ComputerGuessNumber.lowerlimit = min;

            int compGuessRan = GameFrameWork.GetRandomNumber(max, min);//get random number based on parameters***** do parameters cancel out the min and max
                                                                       //compGuessRan = my initial guess
                                                                       //show user the guess

            string validateGuess = ComputerGuessNumber.ReportFeedback(compGuessRan);


            if (validateGuess.ToUpper() != "C")
            {
                updatedGuess = ComputerGuessNumber.MakeComputerGuess(validateGuess, compGuessRan, min, max);

            }
            else
            {
                Console.WriteLine("I got it right on the first try!");

                correctNumber = true;
            }


            while (!correctNumber)
            {

                // THE REPORT FEEDBACK NEEDS TO BE TAKING IN BY THE MAKECOMPUTER GUESS


                //validateGuess = ComputerGuessNumber.ReportFeedback(compGuessRan);


                //updatedGuess = ComputerGuessNumber.MakeComputerGuess(validateGuess, compGuessRan, min, max);

                if (validateGuess.ToUpper() == "C")
                {
                    correctNumber = true;



                }
                else
                {
                    validateGuess = ComputerGuessNumber.ReportFeedback(updatedGuess);


                    updatedGuess = ComputerGuessNumber.MakeComputerGuess(validateGuess, updatedGuess, ComputerGuessNumber.lowerlimit, ComputerGuessNumber.upperlimit);


                }

                loopCount++;

            }

         

            Console.WriteLine("It took you " + loopCount + " guesses");
            Console.WriteLine("");

            Console.WriteLine("New Game!");


            //get feedback high or low

            //int divideNum = ComputerGuessNumber.MakeComputerGuess(feedback);  add back/get feedback from user



        }


    }
}
