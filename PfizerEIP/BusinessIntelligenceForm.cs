using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;


namespace PfizerEIP
{
    public partial class BusinessIntelligenceForm : Form
    {
        public BusinessIntelligenceForm()
        {
            InitializeComponent();

            foreach (ToolStripItem subSystem in perspectivesToolStripMenuItem.DropDownItems)
            {
                subSystem.Click += new EventHandler(subSystem_Click);
            }
        }

        private void subSystem_Click(object sender, EventArgs e)
        {
            //Add comments
            var selectedSubSystem = (ToolStripItem)sender;

            foreach (ToolStripItem subSystem in perspectivesToolStripMenuItem.DropDownItems)
            {
                subSystem.BackColor = Color.Transparent;
            }

            this.Text = selectedSubSystem.Text + " Management Dashboard";
            selectedSubSystem.BackColor = Color.Gainsboro;

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm frmAbout = new AboutForm();
            frmAbout.Show();
        }

        private void exitProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Closes the application
            Application.Exit();
        }

        private void selfHelpPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //This would be used to connect to the pdf file located in the DB.
                Process.Start("141.218.103.141\\ERP_DATA"); 
            }
            catch (Exception ex)
            { 
                //Exception thrown 
                MessageBox.Show(ex.Message); 
            }
        }

        private void BusinessIntelligenceForm_Load(object sender, EventArgs e)
        {
           
        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Performs calculation
        }

        private void clearFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clears fields of all content
        }

        private void returnToMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Returns the user back to the main navigation menu
        }
            
        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContactForm frmContact = new ContactForm();
            frmContact.Show();
        }

    }
}
