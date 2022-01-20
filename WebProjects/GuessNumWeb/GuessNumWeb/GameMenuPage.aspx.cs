using GuessNumWeb.BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GuessNumWeb
{
    public partial class GameMenuPage : System.Web.UI.Page
    {
        protected GameState gameState { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSelect_Click(object sender, EventArgs e)
        {
            string userChoice = this.ddlMenuChoices.SelectedValue;

            gameState.userChoice = userChoice;

            if((GameState) Session["GameState"] == null)
            {
         
                Session.Add("GameState", this.gameState);//adds a variable to the session called gameState; Allows for all users to have a version of this object per session

            }
            else 
            {

                Session["GameState"] = this.gameState;//updating an existing game state in game session

            }
        }
    }
}