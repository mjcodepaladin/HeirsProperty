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
    public partial class EventDashboard : Form
    {
        public EventDashboard()
        {
            InitializeComponent();
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            HPropFrontEngine.NavigateEventCreation();
        }
    }
}
