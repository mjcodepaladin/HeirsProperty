using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GuessNumLibrary;
using GuessNumWeb.BusinessLogic.Models;

namespace GuessNumWeb
{
    public partial class PlayerGuessNumInput : System.Web.UI.Page
    {
        protected GameState gameState { get; set; }

        public int UpperNum { get; set; } = 0;
        public int LowerNum { get; set; } = 0;


        protected void Page_Load(object sender, EventArgs e)
        {



        }

        protected void btnUserGuess_Click(object sender, EventArgs e)
        {
            int userNumGuess = 0;

            string userInput = txtBoxUserNum.Text.Trim();


        }
    }
}