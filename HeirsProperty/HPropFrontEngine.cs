using HeirsPropertyDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeirsProperty
{
    public static class HPropFrontEngine
    {
        static EventDashboard theEventDashboard;
        static EventCreation theEventCreateForm;
        internal static string MessageOK ="<OK>";

        static void CreateNewEventDashboard()
        {
            theEventDashboard = new EventDashboard();
        }
        public static void NavigateOpenEventDashboard()
        {
            if(theEventDashboard==null)
            {
                HPropFrontEngine.CreateNewEventDashboard();
            }
            theEventDashboard.Show();

        }

        internal static void NavigateDonorInviteDash()
        {
            throw new NotImplementedException();
        }

        internal static bool ParseOK(string message)
        {
            bool retok = false;
            retok = (message == MessageOK) || (message.ToLower() == "null") || (message == "0");
            return retok;

        }

        static void CreateNewEventCreation()
        {
            theEventCreateForm = new EventCreation();
        }

        internal static void NavigateDonorDash()
        {
            throw new NotImplementedException();
        }

        internal static void NavigateStatisticsDash()
        {
            throw new NotImplementedException();
        }

        public static void NavigateEventCreation()
        {
            if (theEventCreateForm == null)
            {
                HPropFrontEngine.CreateNewEventCreation();
            }
            theEventCreateForm.Show();

        }

        internal static string LogicValidateAddEvent(Event workingEvent)
        {
            throw new NotImplementedException();
        }
    }
}
