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
    public static class MayasTestEngine
    {
        /*
        public Guid DonationID { get; set; }
        public Guid PersonID { get; set; }//Not Null //Do I need a get/set for this if these IDs are not being autogenerated but rather grabbed from previous autogen IDs
        //Changed the above to type Guid because it is generated as a Guid in sql thus coming into the c# program as a Guid
        public int OrganizationID { get; set; }//Null 

        public string DonationType { get; set; }//Not Null  //Should this be an int or a string? In SQL it is under nvarchar, but should we make another table to store the various donation types and keep track of them through numbers?
        public decimal DonationAmount { get; set; }//Null  
        public string DonationDescription { get; set; }//Null  updat ppp for a person to enter a comment
        public DateTime DonationDate { get; set; }//Null  
        public int DonorStatus { get; set; }//Null  //A donor status table still needs to be made.....? Still needs to add in test
         */
        public static string AddTestDonation(int indexe = 0)
        {

            //dad's PersonID: 18597AD8-0CCF-4A1C-9056-5B1E43914978

           
            //I'm trying to connect my personID with my donation?

            /*
            Donation myDonation = new Donation();
            myDonation.PersonID = new Guid("18597AD8-0CCF-4A1C-9056-5B1E43914978");//dads Guid Number
            myDonation.OrganizationID = -1;//we need a number to represent no organization affiliation as null cannot be converted to int?
            myDonation.DonationType = $"TestArt";//what are the colons used for?//::TestAdd:: {indexe}
            myDonation.DonationAmount = 150 + indexe;
            myDonation.DonationDescription = "Vintage Oil Painting";
            myDonation.DonationDate = DateTime.Now.AddDays((double)indexe);
            */
            
            /*
            Donation myDonation = new Donation();
            myDonation.PersonID = new Guid("2CEDF00F-EFD7-47C9-829F-F7E8C9E2CA2F");//Jojo/Charles Guid Number
            myDonation.OrganizationID = -1;
            myDonation.DonationType = $"TestCar";
            myDonation.DonationAmount = 0;
            myDonation.DonationDescription = "Classic Ford Model T (Not Appraised)";
            myDonation.DonationDate = DateTime.Now.AddDays((double)indexe);
            */

            
            Donation myDonation = new Donation();
            myDonation.PersonID = new Guid("60342F08-7E88-416B-9C5D-1A0CD6E8FE61");//Craig's Guid Number
            myDonation.OrganizationID = -1;
            myDonation.DonationType = $"TestObject";
            myDonation.DonationAmount = 0;
            myDonation.DonationDescription = "Glass Vase (Not Appraised)";
            myDonation.DonationDate = DateTime.Now.AddDays((double)indexe);
            

            var returnDonation = Donation.InsertDonation(myDonation);

            string retMessage = $"Tried to insert aDonation Called:{returnDonation.DonationType}";//, Its new ID is: {returnDonation.DonationID} ";? Come back to 

            return retMessage;

        }

        public static string UpdateTestDonation(Guid inDonationID)//Takes in the donation ID so this needs to be passed in MayasTestEngine
        {
            HeirsPropertyDataLayer.Models.Donation myDonation = new HeirsPropertyDataLayer.Models.Donation();

            /*
                        MJS Example
            myDonation.EventName = $"Test Fund Dinner::Updated {999}";
            myDonation.EventCapacity = 120;
            myDonation.EventPrice = 175.00M;
            myDonation.EventDateDeterminationBool = false;
            myDonation.EventDate = DateTime.Now;
            */

            myDonation.DonationID = inDonationID;
            myDonation.PersonID = new Guid("18597AD8-0CCF-4A1C-9056-5B1E43914978");//new Guid("18597AD8-0CCF-4A1C-9056-5B1E43914978;");//dads Guid Number
            myDonation.OrganizationID = -1;//we need a number to represent no organization affiliation as null cannot be converted to int?
            myDonation.DonationType = $"TestArt";
            myDonation.DonationAmount = 500;
            myDonation.DonationDescription = "Updated Vintage Oil Painting";
            myDonation.DonationDate = DateTime.Now;

            /*
            Donation myDonation = new Donation();
            myDonation.DonationType = $"TestCar";
            myDonation.DonationAmount = 20,000;
            myDonation.DonationDescription = "Classic Ford Model T (Appraised)";
            myDonation.DonationDate = DateTime.Now.AddDays((double)indexe);
            */

            /*
            Donation myDonation = new Donation();
            myDonation.DonationType = $"TestObject";
            myDonation.DonationAmount = 350;
            myDonation.DonationDescription = "Glass Vase (Appraised)";
            myDonation.DonationDate = DateTime.Now.AddDays((double)indexe);
            */

            var returnDonation = HeirsPropertyDataLayer.Models.Donation.UpdateDonation(myDonation);

            string retMessage = $"Tried to Update Donation with ID: {inDonationID} aDonation Called:{myDonation.DonationAmount}, the UPDATE STATUS WAS :: {returnDonation.ToString()} ";

            //string retMessage = $"Tried to Update Donation with ID: {inDonationID} aDonation Called:{myDonation.DonationAmount}, Its new ID is: {myDonation.DonationID} the UPDATE STATUS WAS :: {returnDonation.ToString()} ";


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

        public static string DeleteTestDonation(Guid inDonation)
        {
            string retstring = "<Donation Delete Fail>";
            if (Donation.DeleteDonation(inDonation))
            {
                retstring = "Donation Successfully Deleted";

            }

            return retstring;
        }

        public static string GetSingleDonation(Guid inDonation)
        {
            Donation myDonation = Donation.Select(inDonation);
            string retstring = MayasTestEngine.SingleDonationToString(myDonation);
            return retstring;
        }

        public static string GetDonationsAsString()
        {
            var myDonations = MayasTestEngine.GetDonations();
            string retstring = MayasTestEngine.TestDonationsToString(myDonations);
            return retstring;
        }

        /* Not needed for donation?
         * 
        public static string Add3Donations(string v)
        {
            return v + TestEngine.AddNDonations(3);
        }
        */

        private static string AddNDonations(int newDonation)//should this be taking in a guid for donation or people? originally int v
        {
            StringBuilder retbuild = new StringBuilder();
            for (int n = 0; n < newDonation; n++)
            {
                retbuild.AppendLine(MayasTestEngine.AddTestDonation(newDonation));
            }
            return retbuild.ToString();

        }

        public static List<Donation> GetDonations()
        {
            var myReturnDonations = Donation.SelectAll();



            return myReturnDonations;

        }




        public static string TestDonationsToString(List<Donation> inDonations)
        {
            string retstring = "";

            StringBuilder builder = new StringBuilder();

            foreach (Donation aDonation in inDonations)
            {
                builder.AppendLine(MayasTestEngine.SingleDonationToString(aDonation));
            }

            retstring = builder.ToString();

            return retstring;


        }

        private static string SingleDonationToString(Donation aDonation)
        {
            StringBuilder builder = new StringBuilder();

          
            builder.AppendLine("*********");
            builder.AppendLine($"DonationID:{aDonation.DonationID}");
            builder.AppendLine($"PersonID:{aDonation.PersonID}");
            builder.AppendLine($"OrganizationID:{aDonation.OrganizationID}");

            builder.AppendLine($"DonationType:{aDonation.DonationType}");
            builder.AppendLine($"DonationAmount:${aDonation.DonationAmount}");
            builder.AppendLine($"DonationDescription:{aDonation.DonationDescription}");
            builder.AppendLine($"DonationDate:{aDonation.DonationDate.ToString()}");
            builder.AppendLine($"DonorStatus:{aDonation.DonorStatus}");
            builder.AppendLine("*********");

            /*builder.AppendLine("*********");
            builder.AppendLine($"DonationName:{aDonation.DonationName}");
            builder.AppendLine($"DonationID:{aDonation.DonationID}");
            builder.AppendLine($"DonationPrice:${aDonation.DonationPrice}");
            builder.AppendLine($"DonationCapacity:{aDonation.DonationCapacity}");
            builder.AppendLine($"DonationDate:{aDonation.DonationDate.ToString()}");
            builder.AppendLine($"DonationDeterminationINT:{aDonation.DonationDateDetermination}");
            builder.AppendLine($"DonationDeterminationBOOL:{aDonation.DonationDateDeterminationBool.ToString()}");
            builder.AppendLine("*********");
            */


            return builder.ToString();


        }

    }
}
