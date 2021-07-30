using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeirsPropertyDataLayer.Models;

namespace HeirsProperty
{
    public partial class EventCreation : Form
    {
        public EventCreation()
        {
            InitializeComponent();
        }

     
        Event workingEvent { get; set; }
        

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            workingEvent = this.getEventFromForm();
            string  message = this.validateEvent(workingEvent);
            if(HPropFrontEngine.ParseOK(message))
            { 
                this.submitEvent(workingEvent);
                MessageBox.Show("Event Created");
            }
            else
            {
                MessageBox.Show($"This Event could not be created yet please correct as per: {message}");


            }
           
        }

        private string validateEvent(Event workingEvent)
        {

            string message = HPropFrontEngine.MessageOK;



            if(workingEvent.EventName=="")
            {
                message = "Event Name cannot be Empty";
            }
            if(workingEvent.EventPrice<0 )
            {
                message += ":Event Price cannot be less than zero:";

            }
           /* if(workingEvent.EventDate == null)
            {
                message += ":Event Iss empty:";

            }*/
           if(workingEvent.EventCapacity<0)
            {
                message += ":Event Capacity cannot be less than zero (Zero capacity is interpreted as unlimited):";
            }
            return message;
           

        }

        private void submitEvent(Event workingEvent)
        {
            string  validmessage = HPropFrontEngine.LogicValidateAddEvent(workingEvent);
        }

        private Event getEventFromForm()
        {
            Event retEvent = new Event();
            string evName = this.txtEventName.Text.Trim();
            this.CheckEventName(evName);
            string evPriceStr = txtEventPrice.Text.Trim();
            Decimal evPriceD = this.CheckConvertPrice(evPriceStr);
            string evEventCapacityStr = this.txtEventCapacity.Text;
            int evEventCapacityint = this.CheckConvertInt(evEventCapacityStr);

            return retEvent;


        }

        private int CheckConvertInt(string evEventCapacityStr)
        {
            int anum = -1;
            if(!int.TryParse(evEventCapacityStr,out anum))
            {
                MessageBox.Show($"{evEventCapacityStr} was not understood as a number");
            }
            return anum;
        }

        private void CheckEventName(string evName)
        {
            if(evName.Length > 150)
            {
                MessageBox.Show("This Name is too Long");
            }
        }

        private decimal CheckConvertPrice(string evPriceStr)
        {
            Decimal cvtPrice =-1.00M;
            if(Decimal.TryParse(evPriceStr, out cvtPrice))
            {
                return cvtPrice;
            }
            else
            {
                MessageBox.Show($"{evPriceStr}:That was not understood as an Event Price");
                return -1.00M;
            }
        }
    }
}
