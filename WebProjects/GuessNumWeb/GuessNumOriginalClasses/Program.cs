using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            /*string userinput = "";

            Console.WriteLine("Enter a Test Number to test the long function");

            userinput = Console.ReadLine();

            bool inNumber = GameFrameWork.isNumericS(userinput);

            Console.WriteLine("Your answer is" + inNumber);


            Console.Write("Enter a test number to test the short function:");

            bool inNumeric = GameFrameWork.IsNumericTry(userinput);

            userinput = Console.ReadLine();

            Console.WriteLine("Your answere is" + inNumeric);

            Console.ReadLine();*/



            //PlayerGuessNumber.FullGameLoop(100, 1);

            //ComputerGuessNumber.GameLoop(100, 1);

            //GameFrameWork.GameOption(100, 1);

            ComputerGuessNumber.CompVCompLoop(100, 1);

            Console.ReadLine();


        }

    }
}
