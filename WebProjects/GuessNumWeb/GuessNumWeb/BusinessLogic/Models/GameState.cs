using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuessNumWeb.BusinessLogic.Models
{
    public class GameState
    {
        //The state of the game after each guess; what does the computer need to know

        public int GameRounds { get; set; }//The amount of round a user wants to play
        public int LowerParameter { get; set; }
        public int UpperParameter { get; set; }
        public int GoalNum { get; set; }
        public int CurrentNum { get; set; }
        public string LResponse { get; set; }//Low
        public string HResponse { get; set; }//High
        public string CResponse { get; set; }//Correct
        public string userChoice { get; set; }//choices: p (playerGuesses),c (compGuesses),v (compVComp)


    }
}