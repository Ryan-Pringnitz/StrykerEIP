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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Verify UserName, alert if user enterted invalid information and clear contents.  EDP
            if (lfUserNameTextBox.Text != "")
            {
                MessageBox.Show("Please Enter a Valid Login User Name", "Invalid Login UserName", MessageBoxButtons.OK);
                lfUserNameTextBox.Text = "";
                lfPasswordTextBox.Text = "";
            }
            else
            {
                if (lfPasswordTextBox.Text != "")
                {
                    MessageBox.Show("Please Enter a Valid Login Password", "Invalid Login Password", MessageBoxButtons.OK);
                    //biUserNameTextBox.Text = "";
                    //biPasswordTextBox.Text = "";
                }
                else
                {
                    //Upon successful login validation, enable perspectives selection and hide login request.
                    MainDashboardForm frmMD = new MainDashboardForm();
                    this.Hide();
                    frmMD.Show();
                }
            }
        }

        private void clearFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lfUserNameTextBox.Text = "";
            lfPasswordTextBox.Text = "";
        }

        private void exitProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContactForm FrmContact = new ContactForm();
            FrmContact.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm frmAbout = new AboutForm();
            frmAbout.Show();
        }

        private void lfClearButton_Click(object sender, EventArgs e)
        {
            lfUserNameTextBox.Text = "";
            lfPasswordTextBox.Text = "";
        }

        private void biLoginButton_Click(object sender, EventArgs e)
        {

            //Verify UserName, alert if user enterted invalid information and clear contents.  EDP
            if (lfUserNameTextBox.Text != "")
            {
                MessageBox.Show("Please Enter a Valid Login User Name", "Invalid Login UserName", MessageBoxButtons.OK);
                lfUserNameTextBox.Text = "";
                lfPasswordTextBox.Text = "";
            }
            else
            {
                if (lfPasswordTextBox.Text != "")
                {
                    MessageBox.Show("Please Enter a Valid Login Password", "Invalid Login Password", MessageBoxButtons.OK);
                    //biUserNameTextBox.Text = "";
                    //biPasswordTextBox.Text = "";
                }
                else
                {
                    //Upon successful login validation, enable perspectives selection and hide login request.
                    MainDashboardForm frmMD = new MainDashboardForm();
                    this.Hide();
                    frmMD.Show();
                }
            }
        }

        private void lfExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void biWelcomeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
