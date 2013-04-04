using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StrykerEIP
{
    public partial class MainDashboardForm : Form
    {
        public MainDashboardForm()
        {
            InitializeComponent();
        }

        private void mdBusinessIntelligenceButton_Click(object sender, EventArgs e)
        {
            //Create click event to open Business Intelligence and close Main Dashboard.
            BusinessIntelligenceLoginForm frmBILogin = new BusinessIntelligenceLoginForm();
            this.Hide();
            frmBILogin.Show();

        }

        private void mdExitButton_Click(object sender, EventArgs e)
        {
            //Create Exit Button Click Event. EDP
            Application.Exit();
        }
    }
}
