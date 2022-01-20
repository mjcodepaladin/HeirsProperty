using GuessNumWeb.BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GuessNumLibrary;

namespace GuessNumWeb.BusinessLogic
{
    public static class GuessNumLogic
    {
        //functions will be analogs to each of our button presses
        //menu and setup page
        //user input page
        //user respone page

        public static GameState SetupPageAction(GameState inUserState)
        {
            //updating our gamestate with the new updates/ ranNum 

            GameState retGameState = new GameState();

            int getRanNum = GuessNumLibrary.GameFrameWork.GetRandomNumber(inUserState.UpperParameter, inUserState.LowerParameter);

            retGameState = inUserState;

            retGameState.GoalNum = getRanNum;

            return retGameState;
        }

    }
}