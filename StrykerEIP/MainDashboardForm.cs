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

            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
        }

        private void mdBusinessIntelligenceButton_Click(object sender, EventArgs e)
        {
            //Create click event to open Business Intelligence and close Main Dashboard.
            BusinessIntelligenceForm frmBI = new BusinessIntelligenceForm();
            this.Hide();
            frmBI.Show();
        }

        private void mdExitButton_Click(object sender, EventArgs e)
        {
            //Create Exit Button Click Event. EDP
            Application.Exit();
        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create Logout CLick Event. EDP
            LoginForm frmLogin = new LoginForm();
            this.Hide();
            frmLogin.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create Exit Menu Bar Item Click Event. EDP
            Application.Exit();
        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContactForm frmContact = new ContactForm();
            frmContact.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm frmAbout = new AboutForm();
            frmAbout.Show();
        }

        private void MainDashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void mdGlobalIntelligenceButton_Click(object sender, EventArgs e)
        {
            //Create click event to open Business Intelligence and close Main Dashboard.
            BusinessIntelligenceForm frmBI = new BusinessIntelligenceForm();
            this.Hide();
            frmBI.Show();
            frmBI.PreLoadGlobalIntelligence();
        }

        private void mdSustainabilityIntelligence_Click(object sender, EventArgs e)
        {
            //Create click event to open Business Intelligence and close Main Dashboard.
            BusinessIntelligenceForm frmBI = new BusinessIntelligenceForm();
            this.Hide();
            frmBI.Show();
            frmBI.PreLoadSustainabilityIntelligence();
        }

        private void mdBIButton_HoverOver(object sender, EventArgs e)
        {
            BIPictureBox.Image = StrykerEIP.Properties.Resources.BusinessIntelligenceIcon;
        }

        private void mdBIButton_Leave(object sender, EventArgs e)
        {
            BIPictureBox.Image = StrykerEIP.Properties.Resources.BlankIcon;
        }

        private void mdGIButton_MouseHover(object sender, EventArgs e)
        {
            BIPictureBox.Image = StrykerEIP.Properties.Resources.GlobalIntelligenceIcon;
        }

        private void mdGIButton_Leave(object sender, EventArgs e)
        {
            BIPictureBox.Image = StrykerEIP.Properties.Resources.BlankIcon;
        }

        private void mdSIButton_MouseHover(object sender, EventArgs e)
        {
            BIPictureBox.Image = StrykerEIP.Properties.Resources.SustainabilityIcon;
        }

        private void mdSIButton_Leave(object sender, EventArgs e)
        {
            BIPictureBox.Image = StrykerEIP.Properties.Resources.BlankIcon;
        }

        private void mdWelcomeLabel_Click(object sender, EventArgs e)
        {

        }



    }
}
