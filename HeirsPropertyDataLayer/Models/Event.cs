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

        public int EventDateDetermination { get; set; }//grabs the int from the database and works with the bool below


        public bool EventDateDeterminationBool//easy to connect from radio button
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
                    this.EventDateDetermination = 1;//true
                }
                else
                { this.EventDateDetermination = 0; }//false
            }


        }
        //unclear what this property does


        public static List<Event> SelectAll()
        {
            // returns  ALL events from the EventTable regardless of criteria
            string constring = ConfigurationManager.ConnectionStrings[0].ConnectionString;
            SqlConnection myConnection = new SqlConnection(constring);
            string sqlstring = "SELECT EventID,EventName,EventPrice,EventDate,EventDateDetermination,EventCapacity FROM EventTable ORDER BY EventID";
            List<Event> events = new List<Event>();
            Event myTopEvent = new Event();
            List<Event> myretEvents = null;

            

            try
            {
                //Event myretevent = null;
      
                SqlClientFactory dbFactory = (SqlClientFactory)DbProviderFactories.GetFactory("Microsoft.Data.SqlClient");//Turning regular database to a MicrosofSQLClient database (MS SQL Database); Casts SqlClientFactory and takes in "Microsoft.Data.SqlClient"
                using (DbConnection dconnection = dbFactory.CreateConnection())//createConection is a property from SQLClientFactory
                {
                    if (dconnection != null)
                    {
                        dconnection.ConnectionString = constring;//ConnectionString is a property
                        dconnection.Open();
                        DbCommand myCommand = dconnection.CreateCommand();
                        myCommand.CommandText = sqlstring;//The select command; sqlstring sets your query
                        using (DbDataReader myReader = myCommand.ExecuteReader())//make a new reader by executing a command
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

                                    myretEvents = events;
                                }
                            }
                        }
                    }
                }



                return myretEvents;//if nothing is added returns to null

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
            string constring = ConfigurationManager.ConnectionStrings[0].ConnectionString;
            SqlConnection myConnection = new SqlConnection(constring);
            string sqlstring = $"SELECT EventID,EventName,EventPrice,EventDate,EventDateDetermination,EventCapacity FROM EventTable WHERE EventID='{ineventid}'";
            List<Event> events = new List<Event>();
            Event myTopEvent = new Event();



            try
            {
                Event myretevent = null;


                SqlClientFactory dbFactory = (SqlClientFactory)DbProviderFactories.GetFactory("Microsoft.Data.SqlClient");
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

            string constring = ConfigurationManager.ConnectionStrings[0].ConnectionString;
            SqlConnection myConnection = new SqlConnection(constring);
            string sqlstring = $"UPDATE EventTable (SET EventName={inevent.EventName},EventPrice={inevent.EventPrice},EventDate={inevent.EventDate},EventDateDetermination={inevent.EventDateDetermination},EventCapacity={inevent.EventCapacity} FROM EventTable WHERE EventID={inevent.EventID}";
            //List<Event> events = new List<Event>();
            //Event myTopEvent = new Event();



            try
            {
                Event myretevent = null;


                SqlClientFactory dbFactory = (SqlClientFactory)DbProviderFactories.GetFactory("Microsoft.Data.SqlClient");
                using (DbConnection dconnection = dbFactory.CreateConnection())
                {
                    if (dconnection != null)
                    {
                        dconnection.ConnectionString = constring;
                        dconnection.Open();
                        DbCommand myCommand = dconnection.CreateCommand();
                        myCommand.CommandText = sqlstring;
                        int myresp = myCommand.ExecuteNonQuery();///myresp what is the databases response to my command/we know we are not getting back a bunch of rows; contains the number of rows affected which should be 1 row
                        {
                            if(myresp>0)//should return 1
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

        public static Event InsertEvent(Event inevent)//this has everything but the id
        {

            //This creates an event however due to autonumbering once its created we have to select to find out what its newid is IF we need it
            //inserts event bc it doesn't have an id; the id needs to be returned so the user can use it later

            Event retEvent = inevent;//this can't be changed as a parameter
            //INSERT NEW EVENT SELECT IT BACk



            retEvent.EventID = GetEventByName(inevent.EventName).EventID;

            string constring = ConfigurationManager.ConnectionStrings["HeirsPropertyDBConnectionString"].ConnectionString;
            SqlConnection myConnection = new SqlConnection(constring);
            string sqlstring = $"INSERT INTO  EventTable  (EventName, EventPrice, EventCapacity, EventDateDetermination, EventDate) VALUES({inevent.EventName},{inevent.EventPrice},{inevent.EventCapacity},{inevent.EventDateDetermination},{inevent.EventDate})";
            List<Event> events = new List<Event>();
            Event myTopEvent = new Event();
            //He needs to query the event to get back 


            try
            {
                Event myretevent = null;


                //SqlClientFactory dbFactory = (SqlClientFactory)DbProviderFactories.GetFactory("Microsoft.Data.SqlClient");
                using (SqlConnection dconnection = new SqlConnection(constring))
                {
                    if (dconnection != null)
                    {
                        //dconnection.ConnectionString = constring;
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
            string constring = ConfigurationManager.ConnectionStrings[0].ConnectionString;
            SqlConnection myConnection = new SqlConnection(constring);
            string sqlstring = $"SELECT EventID,EventName,EventPrice,EventDate,EventDateDetermination,EventCapacity FROM EventTable WHERE EventName='{inName}'";
            List<Event> events = new List<Event>();
            Event myTopEvent = new Event();
           
           
            
            try
            {
                Event myretevent = null;


                SqlClientFactory dbFactory = (SqlClientFactory)DbProviderFactories.GetFactory("Microsoft.Data.SqlClient");
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

            string constring = ConfigurationManager.ConnectionStrings[0].ConnectionString;
            SqlConnection myConnection = new SqlConnection(constring);
            string sqlstring = $"DELETE  FROM EventTable WHERE EventID={ineventid}";
            


            try
            {
                Event myretevent = null;


                SqlClientFactory dbFactory = (SqlClientFactory)DbProviderFactories.GetFactory("Microsoft.Data.SqlClient");
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
