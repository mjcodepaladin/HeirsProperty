using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeirsPropertyBusinessLogic
{
    public static class TestEngine
    {

        public static string AddTestEvent(int indexe = 0)
        {
            HeirsPropertyDataLayer.Models.Event myEvent = new HeirsPropertyDataLayer.Models.Event();
            myEvent.EventName = $"Test Fund Dinner {indexe}";
            myEvent.EventCapacity = 120;
            myEvent.EventPrice =  175.00M;
            myEvent.EventDateDeterminationBool = false;
            myEvent.EventDate = DateTime.Now;

            var returnevent = HeirsPropertyDataLayer.Models.Event.InsertEvent(myEvent);

            string retMessage = $"Tried to insert anEvent Called:{returnevent.EventName}, Its new ID is: {returnevent.EventID} ";

            return retMessage;

        }
    }
}
