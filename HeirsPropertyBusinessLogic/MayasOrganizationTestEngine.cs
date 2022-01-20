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
    public class MayasOrganizationTestEngine
    {


        public static string AddTestOrganization(int indexe = 0)
        {
            /*
            Organization myOrganization = new Organization();
            //myOrganization.OrganizationID = inOrganizationID;
            //myOrganization.OrganizationName = $"TestToysForTots::TestAdd:: {indexe}";//What are the various colons used for?
            //myOrganization.OrganizationAddressID = ;
            */

            /*
            Organization myOrganization = new Organization();
            //myOrganization.OrganizationID = inOrganizationID;
            myOrganization.OrganizationName = $"TestStJudes::TestAdd:: {indexe}";//What are the various colons used for?
            //myOrganization.OrganizationAddressID = ;
            */

            
            Organization myOrganization = new Organization();
            //myOrganization.OrganizationID = inOrganizationID;
            myOrganization.OrganizationName = $"TestASPCAs::TestAdd:: {indexe}";//What are the various colons used for?
            //myOrganization.OrganizationAddressID = ;
            

            /*
            Event myEvent = new Event();
            myEvent.EventName = $"Test Fund Dinner::TestAdd:: {indexe}";
            myEvent.EventCapacity = 120 + indexe;
            myEvent.EventPrice = 175.00M + (indexe * 50);
            myEvent.EventDateDeterminationBool = false;
            myEvent.EventDate = DateTime.Now.AddDays((double)indexe);
            */


            var returnOrganization = Organization.InsertOrganization(myOrganization);

            string retMessage = $"Tried to insert anOrganization Called:{returnOrganization.OrganizationName}";//, Its new ID is: {returnOrganization.OrganizationID} ";? Come back to 

            return retMessage;

        }

        public static string UpdateTestOrganization(int inOrganizationID)//Takes in the donation ID so this needs to be passed in MayasOrganizationTestEngine
        {
            HeirsPropertyDataLayer.Models.Organization myOrganization = new HeirsPropertyDataLayer.Models.Organization();

            /*
            HeirsPropertyDataLayer.Models.Event myEvent = new HeirsPropertyDataLayer.Models.Event();
            myEvent.EventName = $"Test Fund Dinner::Updated {999}";
            myEvent.EventCapacity = 120;
            myEvent.EventPrice = 175.00M;
            myEvent.EventDateDeterminationBool = false;
            myEvent.EventDate = DateTime.Now;
            */

            /*
            myOrganization.OrganizationID = inOrganizationID;
            myOrganization.OrganizationName = $"TestUpdatedToysForTots::Updated {999}";//This is the only line that should be active?
            //myOrganization.OrganizationAddressID = ;
            */


            
            myOrganization.OrganizationID = inOrganizationID;
            myOrganization.OrganizationName = $"TestUpdatedStJudes::Updated {1000}";//This is the only line that should be active?
            //myOrganization.OrganizationAddressID = ;
            

            /*
            myOrganization.OrganizationID = inOrganizationID;
            myOrganization.OrganizationName = $"TestUpdatedASPCA::Updated {1001}";//This is the only line that should be active?
            //myOrganization.OrganizationAddressID = ;
            */


            var returnOrganization = HeirsPropertyDataLayer.Models.Organization.UpdateOrganization(myOrganization);

            string retMessage = $"Tried to Update Organization with ID: {inOrganizationID} anOrganization Called:{myOrganization.OrganizationName}, the UPDATE STATUS WAS :: {returnOrganization.ToString()} ";

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

        public static string DeleteTestOrganization(int inOrganization)
        {
            string retstring = "<Organization Delete Fail>";
            if (Organization.DeleteOrganization(inOrganization))
            {
                retstring = "Organization Successfully Deleted";

            }

            return retstring;
        }

        public static string GetSingleOrganization(int inOrganization)
        {
            Organization myOrganization = Organization.Select(inOrganization);
            string retstring = MayasOrganizationTestEngine.SingleOrganizationToString(myOrganization);
            return retstring;
        }

        public static string GetOrganizationAsString()
        {
            var myOrganization = MayasOrganizationTestEngine.GetOrganization();
            string retstring = MayasOrganizationTestEngine.TestOrganizationToString(myOrganization);
            return retstring;
        }

        /* Not needed for Organization?
         * 
        public static string Add3Organization(string v)
        {
            return v + TestEngine.AddNOrganization(3);
        }
        */

        private static string AddNOrganization(int newOrganization)//should this be taking in a guid for donation or people? originally int v
        {
            StringBuilder retbuild = new StringBuilder();
            for (int n = 0; n < newOrganization; n++)
            {
                retbuild.AppendLine(MayasOrganizationTestEngine.AddTestOrganization(newOrganization));
            }
            return retbuild.ToString();

        }

        public static List<Organization> GetOrganization()//<Organization>
        {
            var myReturnOrganization = Organization.SelectAll();

            return myReturnOrganization;

        }


        public static string TestOrganizationToString(List<Organization> inOrganization)
        {
            string retstring = "";

            StringBuilder builder = new StringBuilder();

            foreach (Organization anOrganization in inOrganization)
            {
                builder.AppendLine(MayasOrganizationTestEngine.SingleOrganizationToString(anOrganization));
            }

            retstring = builder.ToString();

            return retstring;

        }

        private static string SingleOrganizationToString(Organization anOrganization)//come back
        {
            StringBuilder builder = new StringBuilder();


            builder.AppendLine("*********");
            builder.AppendLine($"OrganizationID:{anOrganization.OrganizationID}");
            builder.AppendLine($"OrganizationName:{anOrganization.OrganizationName}");
            builder.AppendLine($"OrganizationAddressID:{anOrganization.OrganizationAddressID}");
            builder.AppendLine("*********");

            return builder.ToString();

        }

    }

}
