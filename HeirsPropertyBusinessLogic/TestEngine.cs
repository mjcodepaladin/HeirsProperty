using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeirsPropertyDataLayer.Models;

namespace HeirsPropertyBusinessLogic
{
    public static class TestEngine
    {

        public static string AddTestEvent(int indexe = 0)
        {
            Event myEvent = new Event();
            myEvent.EventName = $"Test Fund Dinner::TestAdd:: {indexe}";
            myEvent.EventCapacity = 120 + indexe;
            myEvent.EventPrice = 175.00M + (indexe * 50);
            myEvent.EventDateDeterminationBool = false;
            myEvent.EventDate = DateTime.Now.AddDays((double)indexe);

            var returnevent = Event.InsertEvent(myEvent);

            string retMessage = $"Tried to insert anEvent Called:{returnevent.EventName}, Its new ID is: {returnevent.EventID} ";

            return retMessage;

        }

        public static string UpdateTestEvent(int ineventid)
        {
            HeirsPropertyDataLayer.Models.Event myEvent = new HeirsPropertyDataLayer.Models.Event();
            myEvent.EventName = $"Test Fund Dinner::Updated {999}";
            myEvent.EventCapacity = 120;
            myEvent.EventPrice = 175.00M;
            myEvent.EventDateDeterminationBool = false;
            myEvent.EventDate = DateTime.Now;

            var returnevent = HeirsPropertyDataLayer.Models.Event.UpdateEvent(myEvent);

            string retMessage = $"Tried to Update Event with id: {ineventid} anEvent Called:{myEvent.EventName}, Its new ID is: {myEvent.EventID} the UPDATE STATUS WAS :: {returnevent.ToString()} ";

            return retMessage;

        }

        public static string TestLibraryKeyList()
        {
            StringBuilder builder = new StringBuilder();

            ConnectionStringSettingsCollection myappsettings = ConfigurationManager.ConnectionStrings;



            foreach (ConnectionStringSettings acofig in myappsettings)
            {
                builder.AppendLine(acofig.Name);
            }

            return builder.ToString();
        }

        public static string TestAppConfigs()
        {
            StringBuilder builder = new StringBuilder();
            
            ConnectionStringSettingsCollection myappsettings = ConfigurationManager.ConnectionStrings;
  
           
            
            foreach(ConnectionStringSettings acofig in myappsettings)
            {
                builder.AppendLine(acofig.ConnectionString);
            }

            return builder.ToString();
        }

        public static string TestLibraryConfigs()
        {

            string[] retstring = HeirsPropertyDataLayer.DataServices.GetTestConfigurationSet();
            StringBuilder builder = new StringBuilder();

            foreach (string h in retstring)
            {
                builder.Append(h);
            };
            return builder.ToString();
        }

        public static string DeleteTestEvent(int v)
        {
            string retstring = "<Event Delete Fail>"; 
            if(Event.DeleteEvent(v))
            {
                retstring = "Event Successfully Deleted";

            }

            return retstring;
        }

        public static string GetSingleEvent(int v)
        {
            Event myevent = Event.Select(v);
            string retstring = TestEngine.SingleEventToString(myevent);
            return retstring;
        }

        public static string GetEventsAsString()
        {
            var myevents = TestEngine.GetEvents();
            string retstring = TestEngine.TestEventsToString(myevents);
            return retstring;
        }

        public static string Add3Events(string v)
        {
            return v + TestEngine.AddNEvents(3);
        }

        private static string AddNEvents(int v)
        {
            StringBuilder retbuild = new StringBuilder();
          for(int n= 0; n <v;n++)
            {
                retbuild.AppendLine(TestEngine.AddTestEvent(v));
            }
            return retbuild.ToString();

        }

        public static List<Event> GetEvents()
        {
            var myReturnEvents = Event.SelectAll();



            return myReturnEvents;

        }




        public static string TestEventsToString(List<Event> inevents)
        {
            string retstring = "";

            StringBuilder builder = new StringBuilder();

            foreach (Event anevent in inevents)
            {
                builder.AppendLine(TestEngine.SingleEventToString(anevent));
            }

            retstring = builder.ToString();

            return retstring;


        }

        private static string SingleEventToString(Event anevent)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("*********");
            builder.AppendLine($"EventName:{anevent.EventName}");
            builder.AppendLine($"EventID:{anevent.EventID}");
            builder.AppendLine($"EventPrice:${anevent.EventPrice}");
            builder.AppendLine($"EventCapacity:{anevent.EventCapacity}");
            builder.AppendLine($"EventDate:{anevent.EventDate.ToString()}");
            builder.AppendLine($"EventDeterminationINT:{anevent.EventDateDetermination}");
            builder.AppendLine($"EventDeterminationBOOL:{anevent.EventDateDeterminationBool.ToString()}");
            builder.AppendLine("*********");


            return builder.ToString();


        }
    }
}
