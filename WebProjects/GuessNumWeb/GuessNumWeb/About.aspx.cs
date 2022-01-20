using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GuessNumWeb
{
    public partial class About : Page
    {

        public string Message { get; set; }

        public int RowCount { get; set; } = 10;

        public int counter = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPushMe_Click(object sender, EventArgs e)
        {

        }
    }
}