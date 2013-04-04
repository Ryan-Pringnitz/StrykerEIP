using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;


namespace StrykerEIP
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

            // Pull data for selected business process
            DataServices objDataServices = new DataServices();
            DataSet dataSetBusinessProcess = objDataServices.GetBusinessProcessInfo(selectedSubSystem.Text.Replace(" ", "").Replace("-", "").Trim());
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

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Performs calculation
        }

        private void clearFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clears fields of all content
            KPI1_txtDecisionSummary.Visible = false;
            KPI1_groupDecision.Visible = false;
            KPI1_btnSubmitDecision.Visible = false;
            KPI1_lblState.Visible = false;

            KPI1_txtVar1.Text = "";
            KPI1_txtVar2.Text = "";
            KPI1_txtVar3.Text = "";
            KPI1_txtVar4.Text = "";
            KPI1_txtVar5.Text = "";

        }

        private void returnToMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Returns the user back to the main navigation menu. EDP
            MainDashboardForm frmMD = new MainDashboardForm();
            this.Hide();
            frmMD.Show();
        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContactForm frmContact = new ContactForm();
            frmContact.Show();
        }

        private void KPI1_btnCalculate_Click(object sender, EventArgs e)
        {
            KPI1_txtDecisionSummary.Visible = true;
            KPI1_groupDecision.Visible = true;
            KPI1_btnSubmitDecision.Visible = true;
            KPI1_lblState.Visible = true;

            KPI1_lblState.Text = "Failure";

            //Changes the color of the state text, depending on the state.
            if (KPI1_lblState.Text == "Success")
            {
                KPI1_lblState.ForeColor = System.Drawing.Color.Blue; //Success State
            }

            if (KPI1_lblState.Text == "Normal")
            {
                KPI1_lblState.ForeColor = System.Drawing.Color.Green; //Normal State
            }

            if (KPI1_lblState.Text == "Conflict")
            {
                KPI1_lblState.ForeColor = System.Drawing.Color.Purple; //Conflict State
            }

            if (KPI1_lblState.Text == "Crisis")
            {
                KPI1_lblState.ForeColor = System.Drawing.Color.DarkOrange; //Crisis State
            }

            if (KPI1_lblState.Text == "Failure")
            {
                KPI1_lblState.ForeColor = System.Drawing.Color.Red; //Failure State
            }
        }
     }
}