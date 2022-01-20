using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeirsPropertyDataLayer.Models;

namespace HeirsPropertyBusinessLogic
{
    public static class MayasPeopleTestEngine
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

        public static string AddTestPerson(int indexe = 0)
        {
            /*
            People myPerson = new People();
            //FIX the PersonID line below?
            //myPerson.PersonId = new Guid("60342F08-7E88-416B-9C5D-1A0CD6E8FE61");//Craig's Guid Number
            myPerson.SponsorType = -1;
            myPerson.Title = "N/A";
            myPerson.FirstName = "Test Maya";
            myPerson.MiddleName = "Test Jessica";
            myPerson.LastName = "Test Brown";
            myPerson.PhoneNumber = "(111)111-1111";
            */
            /*
            People myPerson = new People();
            //FIX the PersonID line below?
            //myPerson.PersonId = new Guid("60342F08-7E88-416B-9C5D-1A0CD6E8FE61");//Craig's Guid Number
            myPerson.SponsorType = -1;
            myPerson.Title = "Dr.";
            myPerson.FirstName = "Test Tim";
            myPerson.MiddleName = "Test Turner";
            myPerson.LastName = "Test Thompson";
            myPerson.PhoneNumber = "(222)222-2222";
            */

            
            People myPerson = new People();
            //FIX the PersonID line below?
            //myPerson.PersonId = new Guid("60342F08-7E88-416B-9C5D-1A0CD6E8FE61");//Craig's Guid Number
            myPerson.SponsorType = -1;
            myPerson.Title = "Miss";
            myPerson.FirstName = "Test Sarah";
            myPerson.MiddleName = "Test Sally";
            myPerson.LastName = "Test Sinek";
            myPerson.PhoneNumber = "(333)333-3333";
            

            var returnPerson = People.InsertPerson(myPerson);

            string retMessage = $"Tried to insert aPerson Called:{returnPerson.FirstName}";//, Its new ID is: {returnPerson.PersonID} ";? Come back to 

            return retMessage;

        }

        public static string UpdateTestPerson(Guid inPersonID)//Takes in the donation ID so this needs to be passed in MayasPeopleTestEngine
        {
            HeirsPropertyDataLayer.Models.People myPerson = new HeirsPropertyDataLayer.Models.People();


            myPerson.PersonId = new Guid("B0589A25-EA95-498C-AA9E-38CEA9EA7925");//Craig's Guid Number
            myPerson.SponsorType = -1;
            myPerson.Title = "N/A";
            myPerson.FirstName = "Updated Maya";
            myPerson.MiddleName = "Updated Jessica";
            myPerson.LastName = "Updated Brown";
            myPerson.PhoneNumber = "(123)111-1111";

            /*
            myPerson.PersonId = new Guid("60342F08-7E88-416B-9C5D-1A0CD6E8FE61");
            myPerson.SponsorType = -1;
            myPerson.Title = "Dr.";
            myPerson.FirstName = "Updated Test Tim";
            myPerson.MiddleName = "Updated Test Turner";
            myPerson.LastName = "Updated Test Thompson";
            myPerson.PhoneNumber = "(123)222-2222";
            */

            /*
            myPerson.PersonId = new Guid("78CEF7F3-FCAC-49CE-B325-8F1AD21E685F");
            myPerson.SponsorType = -1;
            myPerson.Title = "Miss";
            myPerson.FirstName = "Updated Test Sarah";
            myPerson.MiddleName = "Updated Test Sally";
            myPerson.LastName = "Updated Test Sinek";
            myPerson.PhoneNumber = "(123)333-3333";
            */

            var returnPerson = HeirsPropertyDataLayer.Models.People.UpdatePerson(myPerson);

            string retMessage = $"Tried to Update Person with ID: {inPersonID} aPerson Called:{myPerson.FirstName}, the UPDATE STATUS WAS :: {returnPerson.ToString()} ";

            //string retMessage = $"Tried to Update Person with ID: {inPersonID} aPerson Called:{myPerson.PersonAmount}, Its new ID is: {myPerson.PersonID} the UPDATE STATUS WAS :: {returnPerson.ToString()} ";


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



            foreach (ConnectionStringSettings acofig in myappsettings)
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

        public static string DeleteTestPerson(Guid inPerson)
        {
            string retstring = "<Person Delete Fail>";
            if (People.DeletePerson(inPerson))
            {
                retstring = "Person Successfully Deleted";

            }

            return retstring;
        }

        public static string GetSinglePerson(Guid inPerson)
        {
            People myPerson = People.Select(inPerson);
            string retstring = MayasPeopleTestEngine.SinglePersonToString(myPerson);
            return retstring;
        }

        public static string GetPeopleAsString()
        {
            var myPeople = MayasPeopleTestEngine.GetPeople();
            string retstring = MayasPeopleTestEngine.TestPeopleToString(myPeople);
            return retstring;
        }

        /* Not needed for donation?
         * 
        public static string Add3People(string v)
        {
            return v + TestEngine.AddNPeople(3);
        }
        */

        private static string AddNPeople(int newPerson)//should this be taking in a guid for donation or people? originally int v
        {
            StringBuilder retbuild = new StringBuilder();
            for (int n = 0; n < newPerson; n++)
            {
                retbuild.AppendLine(MayasPeopleTestEngine.AddTestPerson(newPerson));
            }
            return retbuild.ToString();

        }

        public static List<People> GetPeople()//<People>
        {
            var myReturnPeople = People.SelectAll();

            return myReturnPeople;

        }


        public static string TestPeopleToString(List<People> inPeople)
        {
            string retstring = "";

            StringBuilder builder = new StringBuilder();

            foreach (People aPerson in inPeople)
            {
                builder.AppendLine(MayasPeopleTestEngine.SinglePersonToString(aPerson));
            }

            retstring = builder.ToString();

            return retstring;

        }

        private static string SinglePersonToString(People aPerson)//come back
        {
            StringBuilder builder = new StringBuilder();


            builder.AppendLine("*********");
            builder.AppendLine($"PersonID:{aPerson.PersonId}");
            builder.AppendLine($"SponsorType:{aPerson.SponsorType}");
            builder.AppendLine($"Title:{aPerson.Title}");
            builder.AppendLine($"FirstName:${aPerson.FirstName}");
            builder.AppendLine($"MiddleName:{aPerson.MiddleName}");
            builder.AppendLine($"LastName:{aPerson.LastName}");
            builder.AppendLine($"PhoneNumber:{aPerson.PhoneNumber}");
            builder.AppendLine("*********");

            /*builder.AppendLine("*********");
            builder.AppendLine($"PersonName:{aPerson.PersonName}");
            builder.AppendLine($"PersonID:{aPerson.PersonID}");
            builder.AppendLine($"PersonPrice:${aPerson.PersonPrice}");
            builder.AppendLine($"PersonCapacity:{aPerson.PersonCapacity}");
            builder.AppendLine($"PersonDate:{aPerson.PersonDate.ToString()}");
            builder.AppendLine($"PersonDeterminationINT:{aPerson.PersonDateDetermination}");
            builder.AppendLine($"PersonDeterminationBOOL:{aPerson.PersonDateDeterminationBool.ToString()}");
            builder.AppendLine("*********");
            */

            return builder.ToString();

        }

    }
}
