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
    public partial class MainDashboard : Form
    {
        public MainDashboard()
        {
           
            InitializeComponent();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            HPropFrontEngine.NavigateOpenEventDashboard();
        }

        private void btnDonorInvDash_Click(object sender, EventArgs e)
        {
            HPropFrontEngine.NavigateDonorInviteDash();

        }

        private void btnDonationDash_Click(object sender, EventArgs e)
        {
            HPropFrontEngine.NavigateDonorDash();
        }

        private void btnStatisticsDash_Click(object sender, EventArgs e)
        {

            HPropFrontEngine.NavigateStatisticsDash();
        }

        private void btnQuickTest_Click(object sender, EventArgs e)
        {
            HPTestForm testForm = new HPTestForm();
            testForm.Show();
        }
    }
}
