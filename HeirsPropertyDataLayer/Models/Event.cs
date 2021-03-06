using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeirsPropertyDataLayer.Models
{
    public class Event
    {
        public int EventID { get; set; }
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public decimal EventPrice { get; set; }

        public int EventCapacity { get; set; }

        public int EventDateDetermination { get; set; }


        public bool EventDateDeterminationBool
        {
            get
            {
            
               if(this.EventDateDetermination > 0)
                {
                    return true;

                }
               else
                { 
                    return false;
                    //                return (this.EventDateDetermination > 0);//This is an error;no false choice given;

                }
            }
            set
            {
                int setter = 0;
                if (value)
                {
                    this.EventDateDetermination = 1;
                }
                else
                { this.EventDateDetermination = 0; }
            }


    }
        //unclear what this property does


        public static List<Event> SelectAll()
        {
            // returns  ALL events from the EventTable regardless of criteria
            string constring = ConfigurationManager.ConnectionStrings["HeirsProperty.Properties.Settings.HPDatabase"].ConnectionString;
            SqlConnection myConnection = new SqlConnection(constring);
            string sqlstring = "SELECT EventID,EventName,EventPrice,EventDate,EventDateDetermination,EventCapacity FROM EventTable ORDER BY EventID";
            List<Event> events = new List<Event>();
            Event mySingleEvent = new Event();
            List<Event> myretEvents = null;



            try
            {
                //Event myretevent = null;
      
                SqlClientFactory dbFactory = (SqlClientFactory)DbProviderFactories.GetFactory("System.Data.SqlClient");
                using (DbConnection dconnection = dbFactory.CreateConnection())
                {

                    if (dconnection != null)
                    {
                        dconnection.ConnectionString = constring;
                        dconnection.Open();
                        DbCommand myCommand = dconnection.CreateCommand();
                        myCommand.CommandText = sqlstring;
                        using (DbDataReader myReader = myCommand.ExecuteReader())
                        {
                            //            string sqlstring = $"SELECT EventID,EventName,EventPrice,EventDate,EventDateDetermination,EventCapacity FROM EventTable WHERE EventName='{inName}'";

                            while (myReader.Read())
                            {
                                mySingleEvent = new Event();
                               mySingleEvent.EventID = int.Parse(myReader["EventID"].ToString());
                               mySingleEvent.EventName = myReader["EventName"].ToString();
                               mySingleEvent.EventDate = DateTime.Parse(myReader["EventDate"].ToString());
                               mySingleEvent.EventPrice = Decimal.Parse(myReader["EventPrice"].ToString());
                                if (myReader.IsDBNull(5))
                                {
                                   mySingleEvent.EventCapacity = -1;
                                }
                                else
                                {
                                   mySingleEvent.EventCapacity = int.Parse(myReader["EventCapacity"].ToString());
                                }
                               mySingleEvent.EventDateDetermination = int.Parse(myReader["EventDateDetermination"].ToString());


                            }
                            events.Add(mySingleEvent);
                            if (events != null && events.Count > 0)
                            {

                                myretEvents = events;
                            }

                        }
                    }
                }



                return myretEvents;
            }
            catch (Exception ex)
            {

                throw ex;
                //return null;
            }




        }


        public static Event Select(int ineventid)
        {

            Event retEvent = new Event();
            string constring = ConfigurationManager.ConnectionStrings["HeirsProperty.Properties.Settings.HPDatabase"].ConnectionString;
            SqlConnection myConnection = new SqlConnection(constring);
            string sqlstring = $"SELECT EventID,EventName,EventPrice,EventDate,EventDateDetermination,EventCapacity FROM EventTable WHERE EventID='{ineventid}'";
            List<Event> events = new List<Event>();
            Event myTopEvent = new Event();



            try
            {
                Event myretevent = null;


                SqlClientFactory dbFactory = (SqlClientFactory)DbProviderFactories.GetFactory("System.Data.SqlClient");
                using (DbConnection dconnection = dbFactory.CreateConnection())
                {
                    if (dconnection != null)
                    {
                        dconnection.ConnectionString = constring;
                        dconnection.Open();
                        DbCommand myCommand = dconnection.CreateCommand();
                        myCommand.CommandText = sqlstring;
                        using (DbDataReader myReader = myCommand.ExecuteReader())
                        {
                            //            string sqlstring = $"SELECT EventID,EventName,EventPrice,EventDate,EventDateDetermination,EventCapacity FROM EventTable WHERE EventName='{inName}'";

                            while (myReader.Read())
                            {
                                myTopEvent = new Event();
                                myTopEvent.EventID = int.Parse(myReader["EventID"].ToString());
                                myTopEvent.EventName = myReader["EventName"].ToString();
                                myTopEvent.EventDate = DateTime.Parse(myReader["EventDate"].ToString());
                                myTopEvent.EventPrice = Decimal.Parse(myReader["EventPrice"].ToString());
                                if (myReader.IsDBNull(5))
                                {
                                    myTopEvent.EventCapacity = -1;
                                }
                                else
                                {
                                    myTopEvent.EventCapacity = int.Parse(myReader["EventCapacity"].ToString());
                                }
                                myTopEvent.EventDateDetermination = int.Parse(myReader["EventDateDetermination"].ToString());


                                events.Add(myTopEvent);
                                if (events != null && events.Count > 0)
                                {

                                    myretevent = events[0];

                                }
                            }
                        }
                    }
                }



                return myretevent;
            }
            catch (Exception ex)
            {

                throw ex;
                //return null;
            }


      //      return retEvent;

        }

        public static bool UpdateEvent(Event inevent)
        {

            string constring = ConfigurationManager.ConnectionStrings["HeirsProperty.Properties.Settings.HPDatabase"].ConnectionString;
            SqlConnection myConnection = new SqlConnection(constring);
            string sqlstring = $"UPDATE EventTable (SET EventName={inevent.EventName},EventPrice={inevent.EventPrice},EventDate={inevent.EventDate},EventDateDetermination={inevent.EventDateDetermination},EventCapacity={inevent.EventCapacity} FROM EventTable WHERE EventID={inevent.EventID}";
            //List<Event> events = new List<Event>();
            //Event myTopEvent = new Event();



            try
            {
                Event myretevent = null;


                SqlClientFactory dbFactory = (SqlClientFactory)DbProviderFactories.GetFactory("System.Data.SqlClient");
                using (DbConnection dconnection = dbFactory.CreateConnection())
                {
                    if (dconnection != null)
                    {
                        dconnection.ConnectionString = constring;
                        dconnection.Open();
                        DbCommand myCommand = dconnection.CreateCommand();
                        myCommand.CommandText = sqlstring;
                        int myresp = myCommand.ExecuteNonQuery();
                        {
                            if(myresp>0)
                            {
                                return true;
                            }
                            //            string sqlstring = $"SELECT EventID,EventName,EventPrice,EventDate,EventDateDetermination,EventCapacity FROM EventTable WHERE EventName='{inName}'";
                        }
                    }
                }
                return false;

            }
            catch (Exception ex)
            {

                //return false;
                throw ex;
                //return null;
            }
            //Takes in an event object and then updates the row on the table that has the same EventID



        }

        public static Event InsertEvent(Event inevent)
        {

            //This creates an event however due to autonumbering once its created we have to select to find out what its newid is IF we need it
            Event retEvent = inevent;
            //INSERT NEW EVENT SELECT IT BACk

            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;
            var stuff = ConfigurationManager.ConnectionStrings;
            //ConfigurationManager.ConnectionStrings.Clear();
            var otherstuff = ConfigurationManager.AppSettings.AllKeys;

            string constring = ConfigurationManager.ConnectionStrings["HeirsProperty.Properties.Settings.HPDatabase"].ConnectionString;
 //           constring = @"Data Source=COLDIRON\COLDBLADE;Initial Catalog=HeirsPropertyDB;Integrated Security=True";
            SqlConnection myConnection = new SqlConnection(constring);
            string sqlstring = $"INSERT INTO  EventTable  (EventName, EventPrice, EventCapacity, EventDateDetermination, EventDate) VALUES('{inevent.EventName}',{inevent.EventPrice},{inevent.EventCapacity},{inevent.EventDateDetermination},'{inevent.EventDate}')";
            List<Event> events = new List<Event>();
            Event myTopEvent = new Event();



            try
            {
                Event myretevent = null;


                SqlClientFactory dbFactory = (SqlClientFactory)DbProviderFactories.GetFactory("System.Data.SqlClient");
                using (DbConnection dconnection = dbFactory.CreateConnection())//SqlConnection dconnection = new SqlConnection(constring)
                {
                    if (dconnection != null)
                    {
                        dconnection.ConnectionString = constring;
                        dconnection.Open();
                        DbCommand myCommand = dconnection.CreateCommand();
                        myCommand.CommandText = sqlstring;
                        int myresp = myCommand.ExecuteNonQuery();
                        {
                            if (myresp > 0)
                            {
                                retEvent.EventID = GetEventByName(inevent.EventName).EventID;

                                return retEvent;
                            }
                            //            string sqlstring = $"SELECT EventID,EventName,EventPrice,EventDate,EventDateDetermination,EventCapacity FROM EventTable WHERE EventName='{inName}'";
                        }
                    }
                }
                return null;

            }
            catch (Exception ex)
            {

                //return false;
                throw ex;
                //return null;
            }
            //Takes in an event object and then updates the row on the table that has the same EventID






        }

        private static Event GetEventByName(string inName)
        {
            string constring = ConfigurationManager.ConnectionStrings["HeirsProperty.Properties.Settings.HPDatabase"].ConnectionString;
            SqlConnection myConnection = new SqlConnection(constring);
            string sqlstring = $"SELECT EventID,EventName,EventPrice,EventDate,EventDateDetermination,EventCapacity FROM EventTable WHERE EventName='{inName}'";
            List<Event> events = new List<Event>();
            Event myTopEvent = new Event();
            constring = @"Data Source=COLDIRON\COLDBLADE;Initial Catalog=HeirsPropertyDB;Integrated Security=True";


            try
            {
                Event myretevent = null;


                SqlClientFactory dbFactory = (SqlClientFactory)DbProviderFactories.GetFactory("System.Data.SqlClient");
                using(DbConnection dconnection = dbFactory.CreateConnection())
                {
                    if(dconnection!=null)
                    {
                        dconnection.ConnectionString = constring;
                        dconnection.Open();
                        DbCommand myCommand = dconnection.CreateCommand();
                        myCommand.CommandText = sqlstring;
                        using(DbDataReader myReader  = myCommand.ExecuteReader())
                        {
                            //            string sqlstring = $"SELECT EventID,EventName,EventPrice,EventDate,EventDateDetermination,EventCapacity FROM EventTable WHERE EventName='{inName}'";

                            while (myReader.Read())
                            {
                                myTopEvent = new Event();
                                myTopEvent.EventID = int.Parse(myReader["EventID"].ToString());
                                myTopEvent.EventName = myReader["EventName"].ToString();
                                myTopEvent.EventDate = DateTime.Parse(myReader["EventDate"].ToString());
                                myTopEvent.EventPrice = Decimal.Parse(myReader["EventPrice"].ToString());
                                if(myReader.IsDBNull(5))
                                {
                                    myTopEvent.EventCapacity = -1;
                                }
                                else
                                {
                                    myTopEvent.EventCapacity = int.Parse(myReader["EventCapacity"].ToString());
                                }
                                myTopEvent.EventDateDetermination = int.Parse(myReader["EventDateDetermination"].ToString());


                                events.Add(myTopEvent);
                                if(events!= null && events.Count>0)
                                {

                                    myretevent = events[0];
                                    
                                }
                            }
                        }
                    }
                }



                return myretevent;
            }
            catch (Exception ex)
            {

                throw ex;
                //return null;
            }
        }


        public static bool DeleteEvent(int ineventid)
        {

            string constring = ConfigurationManager.ConnectionStrings["HeirsProperty.Properties.Settings.HPDatabase"].ConnectionString;
            SqlConnection myConnection = new SqlConnection(constring);
            string sqlstring = $"DELETE  FROM EventTable WHERE EventID={ineventid}";
            


            try
            {
                Event myretevent = null;


                SqlClientFactory dbFactory = (SqlClientFactory)DbProviderFactories.GetFactory("System.Data.SqlClient");
                using (DbConnection dconnection = dbFactory.CreateConnection())
                {
                    if (dconnection != null)
                    {
                        dconnection.ConnectionString = constring;
                        dconnection.Open();
                        DbCommand myCommand = dconnection.CreateCommand();
                        myCommand.CommandText = sqlstring;
                        int myresp = myCommand.ExecuteNonQuery();
                        {
                            if (myresp > 0)
                            {
                                return true;
                            }
                            //            string sqlstring = $"SELECT EventID,EventName,EventPrice,EventDate,EventDateDetermination,EventCapacity FROM EventTable WHERE EventName='{inName}'";
                        }
                    }
                }
                return false;

            }
            catch (Exception ex)
            {

                //return false;
                throw ex;
                //return null;
            }
            //Takes in an event object and then updates the row on the table that has the same EventID


            return false;
        }
    }
}
