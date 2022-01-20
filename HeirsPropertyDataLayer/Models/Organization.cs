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
    public class Organization
    {
        /*
        public Guid PersonId { get; set; }//No Nulls Allowed
        public int SponsorType { get; set; }//Nulls Allowed
        public string Title { get; set; }//Nulls Allowed
        public string FirstName { get; set; }//Nulls Allowed
        public string MiddleName { get; set; }//Nulls Allowed
        public string LastName { get; set; }//Nulls Allowed
        public string PhoneNumber { get; set; }//Nulls Allowed
        */

        public int OrganizationID { get; set; }// GUID or SQL generated is identity
        public string OrganizationName { get; set; }
        public int OrganizationAddressID { get; set; }//I set this up in SQL as is Identity yes. Should I do tha?

        public static Organization InsertOrganization(Organization inOrganization)
        {


            Organization retOrganization = inOrganization;//this can't be changed as a parameter

            //retOrganization.OrganizationId = inOrganization;//Guid.NewGuid();//Creates a new globally unique identifyer; I do not need to create a Guid ID for Organization bc it comes from the sql server? Actually I will need to create a Guid ID because a user will not be importing data already generated like I did which is why I created a GuidID on the sql side? Should we make this a feature. 

            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;
            var stuff = ConfigurationManager.ConnectionStrings;
            //ConfigurationManager.ConnectionStrings.Clear();
            var otherstuff = ConfigurationManager.AppSettings.AllKeys;


            string constring = ConfigurationManager.ConnectionStrings["HeirsProperty.Properties.Settings.HPDatabase"].ConnectionString;//changed what's inside of the brackets from 0, in all areas in this class
            SqlConnection myConnection = new SqlConnection(constring);
            string sqlstring = $"INSERT INTO  OrganizationTable (OrganizationName, OrganizationAddressID) VALUES('{inOrganization.OrganizationName}',{inOrganization.OrganizationAddressID})";//OrganizationID, //{inOrganization.OrganizationId},?
            //Instead of inOrganization the above for OrganizationID may need to be retOrganization?
            List<Organization> organization = new List<Organization>();//new list of object Organization created
            Organization myOrganization = new Organization();//serves as a placeholder for each donation?


            try
            {
                //Event myretOrganization = null;


                SqlClientFactory dbFactory = (SqlClientFactory)DbProviderFactories.GetFactory("System.Data.SqlClient");
                using (DbConnection dconnection = dbFactory.CreateConnection())
                {
                    if (dconnection != null)//sucessful
                    {
                        dconnection.ConnectionString = constring;
                        dconnection.Open();
                        DbCommand myCommand = dconnection.CreateCommand();
                        myCommand.CommandText = sqlstring;
                        int myresp = myCommand.ExecuteNonQuery();//My response executes a SQL statement
                        {
                            if (myresp > 0)
                            {
                                //xxxindividual id 
                                //use donor id 
                                //retOrganization.OrganizationID = GetEventByName(inevent.EventName).EventID;//Is this line not needed bc we created the donationID as a Guid within the function? (OR) //Should I make a function like GetEventByName to be GetOrganizationByPrice so that organization can be looked up by price?
                                return retOrganization;
                            }
                            //            string sqlstring = $"SELECT EventID,EventName,EventPrice,EventDate,EventDateDetermination,EventCapacity FROM EventTable WHERE EventName='{inName}'";
                        }
                        //create a unique select
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


        }

        private static Organization GetGeneratedID (int inID)
        {
            string constring = ConfigurationManager.ConnectionStrings["HeirsProperty.Properties.Settings.HPDatabase"].ConnectionString;
            SqlConnection myConnection = new SqlConnection(constring);
            string sqlstring = $"SELECT OrganizationID, OrganizationName, OrganizationAddressID FROM OrganizationTable WHERE OrganizationID={inID}";

            //string sqlstring = $"SELECT EventID,EventName,EventPrice,EventDate,EventDateDetermination,EventCapacity FROM EventTable WHERE EventName='{inName}'";
            
            List<Organization> organizations = new List<Organization>();
            Organization myTopOrganization = new Organization();
            constring = @"Data Source = localhost; Initial Catalog = HeirsPropertyDB; Integrated Security = True";

            try
            {
                Organization myretorganization = null;


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

                                myTopOrganization = new Organization();
                                myTopOrganization.OrganizationID = int.Parse(myReader["OrganizationID"].ToString());//takes in string then turns new guid into a value into the thing that comes out
                                myTopOrganization.OrganizationName = myReader["OrganizationName"].ToString();
                                myTopOrganization.OrganizationAddressID = int.Parse(myReader["OrganizationAddressID"].ToString());

                                /*
                                if (myReader.IsDBNull(5))
                                {
                                    myTopEvent.EventCapacity = -1;
                                }
                                else
                                {
                                    myTopEvent.EventCapacity = int.Parse(myReader["EventCapacity"].ToString());
                                }

                                myTopEvent.EventDateDetermination = int.Parse(myReader["EventDateDetermination"].ToString());
                                */

                                organizations.Add(myTopOrganization);
                                if (organizations != null && organizations.Count > 0)
                                {

                                    myretorganization = organizations [0];

                                }
                            }
                        }
                    }
                }



                return myretorganization;
            }
            catch (Exception ex)
            {

                throw ex;
                //return null;
            }
        }


        public static List<Organization> SelectAll()//Haven't started making changes to the below
        {
            //Read
            // returns  ALL organization from the OrganizationTable regardless of criteria
            string constring = ConfigurationManager.ConnectionStrings["HeirsProperty.Properties.Settings.HPDatabase"].ConnectionString;
            SqlConnection myConnection = new SqlConnection(constring);

            //string sqlstring = $"INSERT INTO  OrganizationTable (OrganizationID, SponsorType, Title, FirstName, MiddleName, LastName, PhoneNumber) VALUES('{inOrganization.OrganizationId}',{inOrganization.SponsorType},'{inOrganization.Title}',{inOrganization.FirstName},'{inOrganization.MiddleName}','{inOrganization.LastName}',{inOrganization.PhoneNumber})";

            string sqlstring = "SELECT OrganizationID, OrganizationName, OrganizationAddressID FROM OrganizationTable ORDER BY OrganizationID";

            //string sqlstring = $"INSERT INTO  OrganizationTable (OrganizationName, OrganizationAddressID) VALUES('{inOrganization.OrganizationName}',{inOrganization.OrganizationAddressID})";//OrganizationID, //{inOrganization.OrganizationId},?



            //string sqlstring = "SELECT EventID,EventName,EventPrice,EventDate,EventDateDetermination,EventCapacity FROM EventTable ORDER BY EventID";
            List<Organization> organization = new List<Organization>();//stores a list that stuff can be added to


            Organization mySingleOrganization = new Organization();
            List<Organization> myretOrganization = null;//lets me know if there is nothing in a list


            try
            {

                SqlClientFactory dbFactory = (SqlClientFactory)DbProviderFactories.GetFactory("System.Data.SqlClient");//Turning regular database to a MicrosofSQLClient database (MS SQL Database); Casts SqlClientFactory and takes in "Microsoft.Data.SqlClient"
                using (DbConnection dconnection = dbFactory.CreateConnection())//createConection is a property from SQLClientFactory
                {
                    if (dconnection != null)//if I was able to make a database; Connection sucssessful
                    {
                        dconnection.ConnectionString = constring;//ConnectionString is a property
                        dconnection.Open();
                        DbCommand myCommand = dconnection.CreateCommand();
                        myCommand.CommandText = sqlstring;//The select command; sqlstring sets your query
                        using (DbDataReader myReader = myCommand.ExecuteReader())//make a new reader by executing a command
                        {


                            while (myReader.Read())
                            {

                                mySingleOrganization = new Organization();
                                mySingleOrganization.OrganizationID = int.Parse(myReader["OrganizationID"].ToString());//takes in string then turns new guid into a value into the thing that comes out
                                mySingleOrganization.OrganizationName = myReader["OrganizationName"].ToString();
                                mySingleOrganization.OrganizationAddressID = int.Parse(myReader["OrganizationAddressID"].ToString());


                                /*if (myReader.IsDBNull(1))//each row is coming through;IsDBNull at position 5 which corresponds to capacity set to -1
                                {
                                    mySingleOrganization.SponsorType = -1;
                                }
                                else
                                {
                                    mySingleOrganization.SponsorType = int.Parse(myReader["SponsorType"].ToString());
                                    //it may not come back as an int, but rather a string
                                }*/


                                organization.Add(mySingleOrganization);//add to list of organization

                            }

                            if (organization != null && organization.Count > 0)
                            {

                                myretOrganization = organization;//sets myretOrganization = organization so your list can be returned
                            }

                        }
                    }
                }


                return myretOrganization;//if nothing is added returns to null

            }
            catch (Exception ex)
            {

                throw ex;
                //return null;
            }




        }

        public static Organization Select(int inOrganizationID)
        {

            Organization retOrganization = new Organization();
            string constring = ConfigurationManager.ConnectionStrings["HeirsProperty.Properties.Settings.HPDatabase"].ConnectionString;
            SqlConnection myConnection = new SqlConnection(constring);

            string sqlstring = $"SELECT OrganizationID, OrganizationName, OrganizationAddressID FROM OrganizationTable WHERE OrganizationID={inOrganizationID}";

            //string sqlstring = "SELECT OrganizationID, OrganizationName, OrganizationAddressID FROM OrganizationTable ORDER BY OrganizationID";


            List<Organization> organization = new List<Organization>();
            Organization mySingleOrganization = new Organization();



            try
            {
                Organization myretOrganization = null;


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
                            
                            //string sqlstring = $"SELECT OrganizationID, OrganizationName, OrganizationAddressID FROM OrganizationTable WHERE OrganizationID={inOrganizationID}";

                            while (myReader.Read())
                            {

                                mySingleOrganization = new Organization();
                                mySingleOrganization.OrganizationID = int.Parse(myReader["OrganizationID"].ToString());//takes in string then turns new guid into a value into the thing that comes out
                                mySingleOrganization.OrganizationName = myReader["OrganizationName"].ToString();
                                mySingleOrganization.OrganizationAddressID = int.Parse(myReader["OrganizationAddressID"].ToString());


                                /*if (myReader.IsDBNull(5))
                                {
                                    myTopEvent.EventCapacity = -1;
                                }
                                else
                                {
                                    myTopEvent.EventCapacity = int.Parse(myReader["EventCapacity"].ToString());
                                }
                                myTopEvent.EventDateDetermination = int.Parse(myReader["EventDateDetermination"].ToString());*/

                                organization.Add(mySingleOrganization);

                                if (organization != null && organization.Count > 0)
                                {

                                    myretOrganization = organization[0];

                                }
                            }
                        }
                    }
                }


                return myretOrganization;
            }
            catch (Exception ex)
            {

                throw ex;
                //return null;
            }


            //      return retOrganization;

        }

        public static bool UpdateOrganization(Organization inOrganization)
        {

            string constring = ConfigurationManager.ConnectionStrings["HeirsProperty.Properties.Settings.HPDatabase"].ConnectionString;
            SqlConnection myConnection = new SqlConnection(constring);

            string sqlstring = $"UPDATE OrganizationTable SET OrganizationName='{inOrganization.OrganizationName}', OrganizationAddressID={inOrganization.OrganizationAddressID} FROM OrganizationTable WHERE OrganizationID={inOrganization.OrganizationID}";

          //string sqlstring = $"UPDATE EventTable (SET EventName={inevent.EventName},EventPrice={inevent.EventPrice},EventDate={inevent.EventDate},EventDateDetermination={inevent.EventDateDetermination},EventCapacity={inevent.EventCapacity} FROM EventTable WHERE EventID={inevent.EventID}";


            //string sqlstring = $"SELECT OrganizationID, OrganizationName, OrganizationAddressID FROM OrganizationTable WHERE OrganizationID={inOrganizationID}";

            try
            {


                SqlClientFactory dbFactory = (SqlClientFactory)DbProviderFactories.GetFactory("System.Data.SqlClient");
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
                            if (myresp > 0)//should return 1
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

        public static bool DeleteOrganization(int inOrganizationID)
        {

            string constring = ConfigurationManager.ConnectionStrings["HeirsProperty.Properties.Settings.HPDatabase"].ConnectionString;
            SqlConnection myConnection = new SqlConnection(constring);
            string sqlstring = $"DELETE FROM OrganizationTable WHERE OrganizationID='{inOrganizationID}'";



            try
            {

                SqlClientFactory dbFactory = (SqlClientFactory)DbProviderFactories.GetFactory("System.Data.SqlClient");
                using (DbConnection dconnection = dbFactory.CreateConnection())
                {
                    if (dconnection != null)//successful
                    {
                        dconnection.ConnectionString = constring;
                        dconnection.Open();
                        DbCommand myCommand = dconnection.CreateCommand();
                        myCommand.CommandText = sqlstring;
                        int myresp = myCommand.ExecuteNonQuery();
                        {
                            if (myresp > 0)//Does 0 represent nothing chosen to be deleted?
                            {
                                return true;
                            }

                            //            string sqlstring = $"SELECT OrganizationID, OrganizationID, OrganizationID, OrganizationType, OrganizationAmount, OrganizationDescription, OrganizationDate, DonorStatus FROM OrganizationTable WHERE OrganizationID='{inOrganizationID}'";

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
            //Takes in an donation object and then updates the row on the table that has the same OrganizationID


            return false;
        }



    }
}
