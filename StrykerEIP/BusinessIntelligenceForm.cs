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

            lblBusinessProcessName.Text = selectedSubSystem.Text + " Management Dashboard";

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
                            //if (kpiChartType != SeriesChartType.Pie)
                            //{
                            CustomerChart.Series["CustomerSeries"].XValueMember = "Date";
                            CustomerChart.Series["CustomerSeries"].XValueType = ChartValueType.Date;
                            CustomerChart.Series["CustomerSeries"].YValueMembers = "KPIValue";
                            lblKPI1Name.Text = dtKPI.Rows[i]["Name"].ToString();
                            KPI1_tabPage.Text = dtKPI.Rows[i]["Name"].ToString();
                            //}
                            //else
                            //{

                            //}
                            break;
                        case 1:
                            OperationsChart.Series["OperationsSeries"].ChartType = kpiChartType;
                            //if (kpiChartType != SeriesChartType.Pie)
                            //{
                            OperationsChart.Series["OperationsSeries"].XValueMember = "Date";
                            OperationsChart.Series["OperationsSeries"].XValueType = ChartValueType.Date;
                            OperationsChart.Series["OperationsSeries"].YValueMembers = "KPIValue";
                            lblKPI2Name.Text = dtKPI.Rows[i]["Name"].ToString();
                            KPI2_tabPage.Text = dtKPI.Rows[i]["Name"].ToString();
                            //}
                            break;
                        case 2:
                            FinancialChart.Series["FinancialSeries"].ChartType = kpiChartType;
                            //if (kpiChartType != SeriesChartType.Pie)
                            //{
                            FinancialChart.Series["FinancialSeries"].XValueMember = "Date";
                            FinancialChart.Series["FinancialSeries"].XValueType = ChartValueType.Date;
                            FinancialChart.Series["FinancialSeries"].YValueMembers = "KPIValue";
                            lblKPI3Name.Text = dtKPI.Rows[i]["Name"].ToString();
                            KPI3_tabPage.Text = dtKPI.Rows[i]["Name"].ToString();
                            //}
                            break;
                        case 3:
                            InnovationsChart.Series["InnovationsSeries"].ChartType = kpiChartType;
                            //if (kpiChartType != SeriesChartType.Pie)
                            //{
                            InnovationsChart.Series["InnovationsSeries"].XValueMember = "Date";
                            InnovationsChart.Series["InnovationsSeries"].XValueType = ChartValueType.Date;
                            InnovationsChart.Series["InnovationsSeries"].YValueMembers = "KPIValue";
                            lblKPI4Name.Text = dtKPI.Rows[i]["Name"].ToString();
                            KPI4_tabPage.Text = dtKPI.Rows[i]["Name"].ToString();
                            //}
                            break;
                    }
                }



                //Adds text to the labels for KPI #1
                string[] arr1 = new string[dataSetBusinessProcess.Tables[1].Columns.Count];
                for (int j = 0; j < dataSetBusinessProcess.Tables[1].Columns.Count; j++)
                {
                    arr1[j] = dataSetBusinessProcess.Tables[1].Columns[j].ToString();

                    if (j == 0)
                    {
                        KPI1_lblVar1.Text = arr1[0].ToString();
                        KPI1_lblVar1.Visible = true;
                        KPI1_lblVar2.Visible = false;
                        KPI1_lblVar3.Visible = false;
                        KPI1_lblVar4.Visible = false;
                        KPI1_lblVar5.Visible = false;
                        KPI1_txtVar1.Visible = true;
                        KPI1_txtVar2.Visible = false;
                        KPI1_txtVar3.Visible = false;
                        KPI1_txtVar4.Visible = false;
                        KPI1_txtVar5.Visible = false;

                    }

                    if (j == 1)
                    {
                        KPI1_lblVar1.Text = arr1[0].ToString();
                        KPI1_lblVar2.Text = arr1[1].ToString();
                        KPI1_lblVar1.Visible = true;
                        KPI1_lblVar2.Visible = true;
                        KPI1_lblVar3.Visible = false;
                        KPI1_lblVar4.Visible = false;
                        KPI1_lblVar5.Visible = false;
                        KPI1_txtVar1.Visible = true;
                        KPI1_txtVar2.Visible = true;
                        KPI1_txtVar3.Visible = false;
                        KPI1_txtVar4.Visible = false;
                        KPI1_txtVar5.Visible = false;
                    }


                    if (j == 2)
                    {
                        KPI1_lblVar1.Text = arr1[0].ToString();
                        KPI1_lblVar2.Text = arr1[1].ToString();
                        KPI1_lblVar3.Text = arr1[2].ToString();
                        KPI1_lblVar1.Visible = true;
                        KPI1_lblVar2.Visible = true;
                        KPI1_lblVar3.Visible = true;
                        KPI1_lblVar4.Visible = false;
                        KPI1_lblVar5.Visible = false;
                        KPI1_txtVar1.Visible = true;
                        KPI1_txtVar2.Visible = true;
                        KPI1_txtVar3.Visible = true;
                        KPI1_txtVar4.Visible = false;
                        KPI1_txtVar5.Visible = false;
                    }
                    else { KPI1_lblVar3.Visible = false; KPI1_lblVar4.Visible = false; KPI1_lblVar5.Visible = false; }


                    if (j == 3)
                    {
                        KPI1_lblVar1.Text = arr1[0].ToString();
                        KPI1_lblVar2.Text = arr1[1].ToString();
                        KPI1_lblVar3.Text = arr1[2].ToString();
                        KPI1_lblVar4.Text = arr1[3].ToString();
                        KPI1_lblVar1.Visible = true;
                        KPI1_lblVar2.Visible = true;
                        KPI1_lblVar3.Visible = true;
                        KPI1_lblVar4.Visible = true;
                        KPI1_lblVar5.Visible = false;
                        KPI1_txtVar1.Visible = true;
                        KPI1_txtVar2.Visible = true;
                        KPI1_txtVar3.Visible = true;
                        KPI1_txtVar4.Visible = true;
                        KPI1_txtVar5.Visible = false;
                    }
                    else { KPI1_lblVar4.Visible = false; KPI1_lblVar5.Visible = false; }


                    if (j == 4)
                    {
                        KPI1_lblVar1.Text = arr1[0].ToString();
                        KPI1_lblVar2.Text = arr1[1].ToString();
                        KPI1_lblVar3.Text = arr1[2].ToString();
                        KPI1_lblVar4.Text = arr1[3].ToString();
                        KPI1_lblVar5.Text = arr1[4].ToString();
                        KPI1_lblVar1.Visible = true;
                        KPI1_lblVar2.Visible = true;
                        KPI1_lblVar3.Visible = true;
                        KPI1_lblVar4.Visible = true;
                        KPI1_lblVar5.Visible = true;
                        KPI1_txtVar1.Visible = true;
                        KPI1_txtVar2.Visible = true;
                        KPI1_txtVar3.Visible = true;
                        KPI1_txtVar4.Visible = true;
                        KPI1_txtVar5.Visible = true;
                    }
                }



                //Adds text to the labels for KPI #2
                string[] arr2 = new string[dataSetBusinessProcess.Tables[2].Columns.Count];
                for (int j = 0; j < dataSetBusinessProcess.Tables[2].Columns.Count; j++)
                {
                    arr2[j] = dataSetBusinessProcess.Tables[2].Columns[j].ToString();

                    if (j == 0)
                    {
                        KPI2_lblVar1.Text = arr2[0].ToString();
                        KPI2_lblVar1.Visible = true;
                        KPI2_lblVar2.Visible = false;
                        KPI2_lblVar3.Visible = false;
                        KPI2_lblVar4.Visible = false;
                        KPI2_lblVar5.Visible = false;
                        KPI2_txtVar1.Visible = true;
                        KPI2_txtVar2.Visible = false;
                        KPI2_txtVar3.Visible = false;
                        KPI2_txtVar4.Visible = false;
                        KPI2_txtVar5.Visible = false;

                    }

                    if (j == 1)
                    {
                        KPI2_lblVar1.Text = arr2[0].ToString();
                        KPI2_lblVar2.Text = arr2[1].ToString();
                        KPI2_lblVar1.Visible = true;
                        KPI2_lblVar2.Visible = true;
                        KPI2_lblVar3.Visible = false;
                        KPI2_lblVar4.Visible = false;
                        KPI2_lblVar5.Visible = false;
                        KPI2_txtVar1.Visible = true;
                        KPI2_txtVar2.Visible = true;
                        KPI2_txtVar3.Visible = false;
                        KPI2_txtVar4.Visible = false;
                        KPI2_txtVar5.Visible = false;
                    }


                    if (j == 2)
                    {
                        KPI2_lblVar1.Text = arr2[0].ToString();
                        KPI2_lblVar2.Text = arr2[1].ToString();
                        KPI2_lblVar3.Text = arr2[2].ToString();
                        KPI2_lblVar1.Visible = true;
                        KPI2_lblVar2.Visible = true;
                        KPI2_lblVar3.Visible = true;
                        KPI2_lblVar4.Visible = false;
                        KPI2_lblVar5.Visible = false;
                        KPI2_txtVar1.Visible = true;
                        KPI2_txtVar2.Visible = true;
                        KPI2_txtVar3.Visible = true;
                        KPI2_txtVar4.Visible = false;
                        KPI2_txtVar5.Visible = false;
                    }
                    else { KPI2_lblVar3.Visible = false; KPI2_lblVar4.Visible = false; KPI2_lblVar5.Visible = false; }


                    if (j == 3)
                    {
                        KPI2_lblVar1.Text = arr2[0].ToString();
                        KPI2_lblVar2.Text = arr2[1].ToString();
                        KPI2_lblVar3.Text = arr2[2].ToString();
                        KPI2_lblVar4.Text = arr2[3].ToString();
                        KPI2_lblVar1.Visible = true;
                        KPI2_lblVar2.Visible = true;
                        KPI2_lblVar3.Visible = true;
                        KPI2_lblVar4.Visible = true;
                        KPI2_lblVar5.Visible = false;
                        KPI2_txtVar1.Visible = true;
                        KPI2_txtVar2.Visible = true;
                        KPI2_txtVar3.Visible = true;
                        KPI2_txtVar4.Visible = true;
                        KPI2_txtVar5.Visible = false;
                    }
                    else { KPI2_lblVar4.Visible = false; KPI2_lblVar5.Visible = false; }


                    if (j == 4)
                    {
                        KPI2_lblVar1.Text = arr2[0].ToString();
                        KPI2_lblVar2.Text = arr2[1].ToString();
                        KPI2_lblVar3.Text = arr2[2].ToString();
                        KPI2_lblVar4.Text = arr2[3].ToString();
                        KPI2_lblVar5.Text = arr2[4].ToString();
                        KPI2_lblVar1.Visible = true;
                        KPI2_lblVar2.Visible = true;
                        KPI2_lblVar3.Visible = true;
                        KPI2_lblVar4.Visible = true;
                        KPI2_lblVar5.Visible = true;
                        KPI2_txtVar1.Visible = true;
                        KPI2_txtVar2.Visible = true;
                        KPI2_txtVar3.Visible = true;
                        KPI2_txtVar4.Visible = true;
                        KPI2_txtVar5.Visible = true;
                    }
                }



                //Adds text to the labels for KPI #3
                string[] arr3 = new string[dataSetBusinessProcess.Tables[3].Columns.Count];
                for (int j = 0; j < dataSetBusinessProcess.Tables[3].Columns.Count; j++)
                {
                    arr3[j] = dataSetBusinessProcess.Tables[3].Columns[j].ToString();

                    if (j == 0)
                    {
                        KPI3_lblVar1.Text = arr3[0].ToString();
                        KPI3_lblVar1.Visible = true;
                        KPI3_lblVar2.Visible = false;
                        KPI3_lblVar3.Visible = false;
                        KPI3_lblVar4.Visible = false;
                        KPI3_lblVar5.Visible = false;
                        KPI3_txtVar1.Visible = true;
                        KPI3_txtVar2.Visible = false;
                        KPI3_txtVar3.Visible = false;
                        KPI3_txtVar4.Visible = false;
                        KPI3_txtVar5.Visible = false;

                    }

                    if (j == 1)
                    {
                        KPI3_lblVar1.Text = arr3[0].ToString();
                        KPI3_lblVar2.Text = arr3[1].ToString();
                        KPI3_lblVar1.Visible = true;
                        KPI3_lblVar2.Visible = true;
                        KPI3_lblVar3.Visible = false;
                        KPI3_lblVar4.Visible = false;
                        KPI3_lblVar5.Visible = false;
                        KPI3_txtVar1.Visible = true;
                        KPI3_txtVar2.Visible = true;
                        KPI3_txtVar3.Visible = false;
                        KPI3_txtVar4.Visible = false;
                        KPI3_txtVar5.Visible = false;
                    }


                    if (j == 2)
                    {
                        KPI3_lblVar1.Text = arr3[0].ToString();
                        KPI3_lblVar2.Text = arr3[1].ToString();
                        KPI3_lblVar3.Text = arr3[2].ToString();
                        KPI3_lblVar1.Visible = true;
                        KPI3_lblVar2.Visible = true;
                        KPI3_lblVar3.Visible = true;
                        KPI3_lblVar4.Visible = false;
                        KPI3_lblVar5.Visible = false;
                        KPI3_txtVar1.Visible = true;
                        KPI3_txtVar2.Visible = true;
                        KPI3_txtVar3.Visible = true;
                        KPI3_txtVar4.Visible = false;
                        KPI3_txtVar5.Visible = false;
                    }

                    if (j == 3)
                    {
                        KPI3_lblVar1.Text = arr3[0].ToString();
                        KPI3_lblVar2.Text = arr3[1].ToString();
                        KPI3_lblVar3.Text = arr3[2].ToString();
                        KPI3_lblVar4.Text = arr3[3].ToString();
                        KPI3_lblVar1.Visible = true;
                        KPI3_lblVar2.Visible = true;
                        KPI3_lblVar3.Visible = true;
                        KPI3_lblVar4.Visible = true;
                        KPI3_lblVar5.Visible = false;
                        KPI3_txtVar1.Visible = true;
                        KPI3_txtVar2.Visible = true;
                        KPI3_txtVar3.Visible = true;
                        KPI3_txtVar4.Visible = true;
                        KPI3_txtVar5.Visible = false;
                    }

                    if (j == 4)
                    {
                        KPI3_lblVar1.Text = arr3[0].ToString();
                        KPI3_lblVar2.Text = arr3[1].ToString();
                        KPI3_lblVar3.Text = arr3[2].ToString();
                        KPI3_lblVar4.Text = arr3[3].ToString();
                        KPI3_lblVar5.Text = arr3[4].ToString();
                        KPI3_lblVar1.Visible = true;
                        KPI3_lblVar2.Visible = true;
                        KPI3_lblVar3.Visible = true;
                        KPI3_lblVar4.Visible = true;
                        KPI3_lblVar5.Visible = true;
                        KPI3_txtVar1.Visible = true;
                        KPI3_txtVar2.Visible = true;
                        KPI3_txtVar3.Visible = true;
                        KPI3_txtVar4.Visible = true;
                        KPI3_txtVar5.Visible = true;
                    }
                }




                //Adds text to the labels for KPI #4
                string[] arr4 = new string[dataSetBusinessProcess.Tables[4].Columns.Count];
                for (int j = 0; j < dataSetBusinessProcess.Tables[4].Columns.Count; j++)
                {
                    arr4[j] = dataSetBusinessProcess.Tables[4].Columns[j].ToString();

                    if (j == 0)
                    {
                        KPI4_lblVar1.Text = arr4[0].ToString();
                        KPI4_lblVar1.Visible = true;
                        KPI4_lblVar2.Visible = false;
                        KPI4_lblVar3.Visible = false;
                        KPI4_lblVar4.Visible = false;
                        KPI4_lblVar5.Visible = false;
                        KPI4_txtVar1.Visible = true;
                        KPI4_txtVar2.Visible = false;
                        KPI4_txtVar3.Visible = false;
                        KPI4_txtVar4.Visible = false;
                        KPI4_txtVar5.Visible = false;

                    }

                    if (j == 1)
                    {
                        KPI4_lblVar1.Text = arr4[0].ToString();
                        KPI4_lblVar2.Text = arr4[1].ToString();
                        KPI4_lblVar1.Visible = true;
                        KPI4_lblVar2.Visible = true;
                        KPI4_lblVar3.Visible = false;
                        KPI4_lblVar4.Visible = false;
                        KPI4_lblVar5.Visible = false;
                        KPI4_txtVar1.Visible = true;
                        KPI4_txtVar2.Visible = true;
                        KPI4_txtVar3.Visible = false;
                        KPI4_txtVar4.Visible = false;
                        KPI4_txtVar5.Visible = false;
                    }


                    if (j == 2)
                    {
                        KPI4_lblVar1.Text = arr4[0].ToString();
                        KPI4_lblVar2.Text = arr4[1].ToString();
                        KPI4_lblVar3.Text = arr4[2].ToString();
                        KPI4_lblVar1.Visible = true;
                        KPI4_lblVar2.Visible = true;
                        KPI4_lblVar3.Visible = true;
                        KPI4_lblVar4.Visible = false;
                        KPI4_lblVar5.Visible = false;
                        KPI4_txtVar1.Visible = true;
                        KPI4_txtVar2.Visible = true;
                        KPI4_txtVar3.Visible = true;
                        KPI4_txtVar4.Visible = false;
                        KPI4_txtVar5.Visible = false;
                    }
                    else { KPI4_lblVar3.Visible = false; KPI4_lblVar4.Visible = false; KPI4_lblVar5.Visible = false; }


                    if (j == 3)
                    {
                        KPI4_lblVar1.Text = arr4[0].ToString();
                        KPI4_lblVar2.Text = arr4[1].ToString();
                        KPI4_lblVar3.Text = arr4[2].ToString();
                        KPI4_lblVar4.Text = arr4[3].ToString();
                        KPI4_lblVar1.Visible = true;
                        KPI4_lblVar2.Visible = true;
                        KPI4_lblVar3.Visible = true;
                        KPI4_lblVar4.Visible = true;
                        KPI4_lblVar5.Visible = false;
                        KPI4_txtVar1.Visible = true;
                        KPI4_txtVar2.Visible = true;
                        KPI4_txtVar3.Visible = true;
                        KPI4_txtVar4.Visible = true;
                        KPI4_txtVar5.Visible = false;
                    }
                    else { KPI4_lblVar4.Visible = false; KPI4_lblVar5.Visible = false; }


                    if (j == 4)
                    {
                        KPI4_lblVar1.Text = arr4[0].ToString();
                        KPI4_lblVar2.Text = arr4[1].ToString();
                        KPI4_lblVar3.Text = arr4[2].ToString();
                        KPI4_lblVar4.Text = arr4[3].ToString();
                        KPI4_lblVar5.Text = arr4[4].ToString();
                        KPI4_lblVar1.Visible = true;
                        KPI4_lblVar2.Visible = true;
                        KPI4_lblVar3.Visible = true;
                        KPI4_lblVar4.Visible = true;
                        KPI4_lblVar5.Visible = true;
                        KPI4_txtVar1.Visible = true;
                        KPI4_txtVar2.Visible = true;
                        KPI4_txtVar3.Visible = true;
                        KPI4_txtVar4.Visible = true;
                        KPI4_txtVar5.Visible = true;
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

        private void BusinessIntelligenceForm_Load(object sender, EventArgs e)
        {

        }
    }
}