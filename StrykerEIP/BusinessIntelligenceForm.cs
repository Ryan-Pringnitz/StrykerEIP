using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;


namespace StrykerEIP
{
    public partial class BusinessIntelligenceForm : Form
    {
        public BusinessIntelligenceForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

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



            try
            {
                // Pull data for selected business process
                DataServices objDataServices = new DataServices();
                DataSet dataSetBusinessProcess = objDataServices.GetBusinessProcessInfo(selectedSubSystem.Text.Replace(" ", "").Replace("-", "").Trim());
                DataTable dtKPIResult1 = dataSetBusinessProcess.Tables["KPIResult1"];
                DataTable dtKPIResult2 = dataSetBusinessProcess.Tables["KPIResult2"];
                DataTable dtKPIResult3 = dataSetBusinessProcess.Tables["KPIResult3"];
                DataTable dtKPIResult4 = dataSetBusinessProcess.Tables["KPIResult4"];
                CustomerChart.DataSource = dtKPIResult1;
                FinancialChart.DataSource = dtKPIResult2;
                OperationsChart.DataSource = dtKPIResult3;
                InnovationsChart.DataSource = dtKPIResult4;

                // Get and change chart type
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType kpiChartType;
                DataTable dtKPI = dataSetBusinessProcess.Tables["KPI"];
                for (int i = 0; i < dtKPI.Rows.Count; i++)
                {
                    switch (dtKPI.Rows[i]["GraphType"].ToString().ToUpper())
                    {
                        case "BAR":
                            kpiChartType = SeriesChartType.Bar;
                            break;
                        case "PIE":
                            kpiChartType = SeriesChartType.Pie;
                            break;
                        case "LINE":
                            kpiChartType = SeriesChartType.Line;
                            break;
                        default:
                            kpiChartType = SeriesChartType.Bar;
                            break;
                    }
                    switch (i)
                    {
                        case 0:
                            CustomerChart.Series["CustomerSeries"].ChartType = kpiChartType;
                            if (kpiChartType != SeriesChartType.Pie)
                            {
                                CustomerChart.Series["CustomerSeries"].XValueMember = "Date";
                                CustomerChart.Series["CustomerSeries"].YValueMembers = "KPIValue";
                            }
                            break;
                        case 1:
                            FinancialChart.Series["FinancialSeries"].ChartType = kpiChartType;
                            if (kpiChartType != SeriesChartType.Pie)
                            {
                                OperationsChart.Series["OperationsSeries"].XValueMember = "Date";
                                OperationsChart.Series["OperationsSeries"].YValueMembers = "KPIValue";
                            }
                            break;
                        case 2:
                            OperationsChart.Series["OperationsSeries"].ChartType = kpiChartType;
                            if (kpiChartType != SeriesChartType.Pie)
                            {
                                FinancialChart.Series["FinancialSeries"].XValueMember = "Date";
                                FinancialChart.Series["FinancialSeries"].YValueMembers = "KPIValue";
                            }
                            break;
                        case 3:
                            InnovationsChart.Series["InnovationsSeries"].ChartType = kpiChartType;
                            if (kpiChartType != SeriesChartType.Pie)
                            {
                                InnovationsChart.Series["InnovationsSeries"].XValueMember = "Date";
                                InnovationsChart.Series["InnovationsSeries"].YValueMembers = "KPIValue";
                            }
                            break;
                    }
                }

                CustomerChart.DataBind();
                FinancialChart.DataBind();
                OperationsChart.DataBind();
                InnovationsChart.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
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