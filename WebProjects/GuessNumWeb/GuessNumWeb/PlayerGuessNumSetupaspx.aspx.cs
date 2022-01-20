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

    public partial class PlayerGuessNumSetupaspx : System.Web.UI.Page
    {

        protected GameState gameState { get; set;}
        public int LowerNum { get; set; }
        public int UpperNum { get; set; }
        public string ErrorMessage { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSetup_Click(object sender, EventArgs e)
        {
            string imputLow = this.txtLowerNum.Text.Trim();

            string imputHigh = this.txtUpperNum.Text.Trim();

            this.LowerNum = int.Parse(imputLow);

            this.UpperNum = int.Parse(imputHigh);

            int low = 0;

            //Session.Add

            
            try
            {
                this.UpperNum = int.Parse(imputHigh);

                this.gameState.UpperParameter = UpperNum;


            }
            catch (FormatException fx)
            {
                this.ErrorMessage = "Please enter your number in a standard math format without commas";
                throw fx;

            }
            catch (NullReferenceException nx)
            {
                this.ErrorMessage = "Please enter something";
                throw nx;
            }
            catch (Exception)
            {
                this.ErrorMessage = "Please re-enter your number something wasn't right";
                throw;
            }



            try
            {
                this.LowerNum = int.Parse(imputLow);

                this.gameState.LowerParameter = LowerNum;


            }
            catch (FormatException fx)
            {
                this.ErrorMessage = "Please enter your number in a standard math format without commas";
                throw fx;

            }
            catch (NullReferenceException nx)
            {
                this.ErrorMessage = "Please enter something";
                throw nx;
            }
            catch (Exception)
            {
                this.ErrorMessage = "Please re-enter your number something wasn't right";
                throw;
            }

            //We need to store the users input to the session

            Session.Add("GameState", this.gameState);//adds a variable to the session called gameState; Allows for all users to have a version of this object per session

            this.gameState = (GameState)Session["GameState"];//grabs the game state from session 
            
            //PlayerGuessNumber.FullGameLoop(UpperNum, LowerNum);




        }
    }
}