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
    public partial class BusinessIntelligenceLoginForm : Form
    {
        public BusinessIntelligenceLoginForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void biLoginButton_Click(object sender, EventArgs e)
        {

            //Verify UserName, alert if user enterted invalid information and clear contents.  EDP
            if (biUserNameTextBox.Text != "")
            {
                MessageBox.Show("Please Enter a Valid Login User Name", "Invalid Login UserName", MessageBoxButtons.OK);
                biUserNameTextBox.Text = "";
                biPasswordTextBox.Text = "";
            }
            else
            {
                if (biPasswordTextBox.Text != "")
                {
                    MessageBox.Show("Please Enter a Valid Login Password", "Invalid Login Password", MessageBoxButtons.OK);
                    //biUserNameTextBox.Text = "";
                    //biPasswordTextBox.Text = "";
                }
                else
                {
                    //Upon successful login validation, enable perspectives selection and hide login request.
                    BusinessIntelligenceForm frmBI = new BusinessIntelligenceForm();
                    this.Hide();
                    frmBI.Show();
                }
            }
        }

        private void biLoginClearButton_Click(object sender, EventArgs e)
        {
            biUserNameTextBox.Text = "";
            biPasswordTextBox.Text = "";
        }

        private void biLoginExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void biLoginCancelButton_Click(object sender, EventArgs e)
        {
            MainDashboardForm frmMD = new MainDashboardForm();
            this.Hide();
            frmMD.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Verify UserName, alert if user enterted invalid information and clear contents.  EDP
            if (biUserNameTextBox.Text != "CIS4990")
            {
                MessageBox.Show("Please Enter a Valid Login User Name", "Invalid Login UserName", MessageBoxButtons.OK);
                biUserNameTextBox.Text = "";
                biPasswordTextBox.Text = "";
            }
            else
            {
                if (biPasswordTextBox.Text != "CIS4990")
                {
                    MessageBox.Show("Please Enter a Valid Login Password", "Invalid Login Password", MessageBoxButtons.OK);
                    //biUserNameTextBox.Text = "";
                    //biPasswordTextBox.Text = "";
                }
                else
                {
                    //Upon successful login validation, enable perspectives selection and hide login request. ED
                    BusinessIntelligenceForm frmBI = new BusinessIntelligenceForm();
                    this.Hide();
                    frmBI.Show();
                }
            }
        }

        private void clearFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            biUserNameTextBox.Text = "";
            biPasswordTextBox.Text = "";
        }

        private void returnToMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainDashboardForm frmMD = new MainDashboardForm();
            this.Hide();
            frmMD.Show();
        }

        private void exitProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void selfhelpPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContactForm frmContact = new ContactForm();
            this.Hide();
            frmContact.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm frmAbout = new AboutForm();
            this.Hide();
            frmAbout.Show();
        }
    }
}