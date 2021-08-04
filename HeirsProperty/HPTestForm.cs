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
    public partial class HPTestForm : Form
    {
        public HPTestForm()
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

        private string TestConfig(string userin)
        {
            string conresp = "<NOPE>";
            if(userin.Trim().ToLower() == "l")
            {
                conresp = TestEngine.TestLibraryConfigs();

            }
            else if(userin.Trim().ToLower() == "a")
            {
                conresp = TestEngine.TestAppConfigs();
            }
            else if(userin.Trim().ToLower() == "k")
            {
                conresp = TestEngine.TestLibraryKeyList();
            }
            return conresp;
        }

        private string TestCRUD(string userin)
        {
            string retstring = "<FAIL!!!>";
           if(userin == "A")
            {
                retstring = TestEngine.AddTestEvent(0);
            }
           else if(userin == "C")
            {
                retstring = TestEngine.Add3Events("T");
            }
           else if(userin == "R")
            { 
                retstring = TestEngine.GetEventsAsString(); 
            }
            else if (userin == "U")
            {
                retstring = TestEngine.UpdateTestEvent(2);
            }
            else if (userin == "D")
            {
                retstring = TestEngine.DeleteTestEvent(1);
            }
            else if (userin == "S")
            {
                retstring = TestEngine.GetSingleEvent(2);
            }
           else
            {
                retstring = "<UNKNOWN input>";
            }
            return retstring;
        }

        private void HPTestForm_Load(object sender, EventArgs e)
        {

        }

        private void txtInputBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
