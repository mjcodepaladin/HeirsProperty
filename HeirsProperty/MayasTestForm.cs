using HeirsPropertyBusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeirsProperty
{
    public partial class MayasTestForm : Form
    {
        public MayasTestForm()
        {
            InitializeComponent();
        }

        private void btnTestButton_Click(object sender, EventArgs e)
        {
            string userin = txtInputBox.Text.Trim().ToUpper();
            string retresp = "";//
            retresp = this.TestCRUD(userin);

            //retresp = this.TestConfig(userin);
            txtOutputBox.Text = retresp;
        }

        /*
        private string TestConfig(string userin)
        {
            string conresp = "<NOPE>";
            if (userin.Trim().ToLower() == "l")
            {
                conresp = TestEngine.TestLibraryConfigs();

            }
            else if (userin.Trim().ToLower() == "a")
            {
                conresp = TestEngine.TestAppConfigs();
            }
            else if (userin.Trim().ToLower() == "k")
            {
                conresp = TestEngine.TestLibraryKeyList();
            }
            return conresp;
        }
        */

        //dad's PersonID: 18597AD8-0CCF-4A1C-9056-5B1E43914978

        private string TestCRUD(string userin)
        {
            string retstring = "<FAIL!!!>";
            if (userin == "C")
            {
                retstring = MayasOrganizationTestEngine.AddTestOrganization(1);//MayasTestEngine.AddTestDonation(0);//change
            }
            else if (userin == "RSINGLE")
            {
                retstring = MayasOrganizationTestEngine.GetSingleOrganization(2); //(new Guid("B0589A25-EA95-498C-AA9E-38CEA9EA7925"));//(Guid.Empty);//type a donation ID??????????????????????????
                                                                                           //Takes in dad's donationID which is connected to his PersonID
            }
            else if (userin == "RALL")
            {
                retstring = MayasOrganizationTestEngine.GetOrganizationAsString();
            }
            else if (userin == "U")
            {
                retstring = MayasOrganizationTestEngine.UpdateTestOrganization(2); //(new Guid("B0589A25-EA95-498C-AA9E-38CEA9EA7925"));//(Guid.Empty);// type a donation ID??????????????????????????
            }
            else if (userin == "D")
            {
                retstring = MayasOrganizationTestEngine.DeleteTestOrganization(3); //(new Guid("78CEF7F3-FCAC-49CE-B325-8F1AD21E685F"));//(Guid.Empty);//type a donation ID??????????????????????????
            }
            else
            {
                retstring = "<UNKNOWN input>";
            }
            return retstring;
        }


        //The below TestCRUD is for People

        /*
        private string TestCRUD(string userin)
        {
            string retstring = "<FAIL!!!>";
            if (userin == "C")
            {
                retstring = MayasPeopleTestEngine.AddTestPerson(0);//MayasTestEngine.AddTestDonation(0);//change
            }
            else if (userin == "RSINGLE")
            {
                retstring = MayasPeopleTestEngine.GetSinglePerson(new Guid("B0589A25-EA95-498C-AA9E-38CEA9EA7925"));//(Guid.Empty);//type a donation ID??????????????????????????
                                                                          //Takes in dad's donationID which is connected to his PersonID
            }
            else if (userin == "RALL")
            {
                retstring = MayasPeopleTestEngine.GetPeopleAsString();
            }
            else if (userin == "U")
            {
                retstring = MayasPeopleTestEngine.UpdateTestPerson(new Guid("B0589A25-EA95-498C-AA9E-38CEA9EA7925"));//(Guid.Empty);// type a donation ID??????????????????????????
            }
            else if (userin == "D")
            {
                retstring = MayasPeopleTestEngine.DeleteTestPerson(new Guid("78CEF7F3-FCAC-49CE-B325-8F1AD21E685F"));//(Guid.Empty);//type a donation ID??????????????????????????
            }
            else
            {
                retstring = "<UNKNOWN input>";
            }
            return retstring;
        }
        */

        /*
        
        //The below TestCRUD is for Donation

        private string TestCRUD(string userin)
        {
            string retstring = "<FAIL!!!>";
            if (userin == "C")
            {
                retstring = MayasTestEngine.AddTestDonation(0);//change
            }
            else if (userin == "RSINGLE")
            {
                retstring = MayasTestEngine.GetSingleDonation(new Guid("1680C465-A171-4A56-9EEB-DE6E1264FE4E"));//(Guid.Empty);//type a donation ID??????????????????????????
                                                                      //Takes in dad's donationID which is connected to his PersonID
            }
            else if (userin == "RALL")
            {
                retstring = MayasTestEngine.GetDonationsAsString();
            }
            else if (userin == "U")
            {
                retstring = MayasTestEngine.UpdateTestDonation(new Guid ("1680C465-A171-4A56-9EEB-DE6E1264FE4E"));//(Guid.Empty);// type a donation ID??????????????????????????
            }
            else if (userin == "D")
            {
                retstring = MayasTestEngine.DeleteTestDonation(new Guid ("574B86DF-C904-4960-87C7-53CFE7942695"));//(Guid.Empty);//type a donation ID??????????????????????????
            }
            else
            {
                retstring = "<UNKNOWN input>";
            }
            return retstring;
        }
        */

    }
}
