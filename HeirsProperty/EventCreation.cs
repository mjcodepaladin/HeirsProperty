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
            Decimal evPriceD = this.CheckConvert(evPriceStr);
            string evEventCapacityStr = this.txtEventCapacity.Text;
            int evEventCapacityint = this.CheckConvertInt(evEventCapacityStr);

            return retEvent;


        }

        private int CheckConvertInt(string evEventCapacityStr)
        {
            throw new NotImplementedException();
        }

        private void CheckEventName(string evName)
        {
            throw new NotImplementedException();
        }

        private decimal CheckConvert(string evPriceStr)
        {
            throw new NotImplementedException();
        }
    }
}
