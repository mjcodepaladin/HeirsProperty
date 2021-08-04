using HeirsPropertyDataLayer.Models;
using HeirsPropertyBusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeirsProperty
{
    public partial class UpdateEvent : Form
    {
        public UpdateEvent()
        {
            InitializeComponent();
        }

        Event underLyingEvent { get; set; }


        public Event LoadEventByID(int ineventid)
        {
            Event retEvent = HPSystemEngine.LoadEvent(ineventid);

            return retEvent;
        }


        public void LoadEventToDisplay(Event inEvent)
        {

            underLyingEvent = inEvent;


        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Event myEvent = this.GetEventFromDisplay();
            string retmessage = this.SubmitMyEvent(myEvent);
            MessageBox.Show(retmessage);
        }

        private string SubmitMyEvent(Event myEvent)
        {
            throw new NotImplementedException();
        }

        private Event GetEventFromDisplay()
        {
            throw new NotImplementedException();
        }
    }
}
