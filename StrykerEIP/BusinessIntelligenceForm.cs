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
        #region Global Variables
        private DataSet _globalBusinessProcessDataSet;
        //KPI 1 Variable Names
        private string _kpi1Var1Name = string.Empty;
        private string _kpi1Var2Name = string.Empty;
        private string _kpi1Var3Name = string.Empty;
        private string _kpi1Var4Name = string.Empty;
        private string _kpi1Var5Name = string.Empty;
        //KPI 2 Variable Names
        private string _kpi2Var1Name = string.Empty;
        private string _kpi2Var2Name = string.Empty;
        private string _kpi2Var3Name = string.Empty;
        private string _kpi2Var4Name = string.Empty;
        private string _kpi2Var5Name = string.Empty;
        //KPI 3 Variable Names
        private string _kpi3Var1Name = string.Empty;
        private string _kpi3Var2Name = string.Empty;
        private string _kpi3Var3Name = string.Empty;
        private string _kpi3Var4Name = string.Empty;
        private string _kpi3Var5Name = string.Empty;
        //KPI 4 Variable Names
        private string _kpi4Var1Name = string.Empty;
        private string _kpi4Var2Name = string.Empty;
        private string _kpi4Var3Name = string.Empty;
        private string _kpi4Var4Name = string.Empty;
        private string _kpi4Var5Name = string.Empty;
        #endregion

        public BusinessIntelligenceForm()
        {   
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            foreach (ToolStripItem subSystem in perspectivesToolStripMenuItem.DropDownItems)
            {
                subSystem.Click += new EventHandler(subSystem_Click);
            }

            KPI1_btnCalculate.Click += new EventHandler(KPI_btnCalculate_Click);
            KPI2_btnCalculate.Click += new EventHandler(KPI_btnCalculate_Click);
            KPI3_btnCalculate.Click += new EventHandler(KPI_btnCalculate_Click);
            KPI4_btnCalculate.Click += new EventHandler(KPI_btnCalculate_Click);

            KPI1_txtVar1.Text = DateTime.Now.ToString();
            KPI2_txtVar1.Text = DateTime.Now.ToString();
            KPI3_txtVar1.Text = DateTime.Now.ToString();
            KPI4_txtVar1.Text = DateTime.Now.ToString();
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
                _globalBusinessProcessDataSet = dataSetBusinessProcess;
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
                            kpiChartType = SeriesChartType.Column;
                            break;
                        case "PIE":
                            kpiChartType = SeriesChartType.Pie;
                            break;
                        case "LINE":
                            kpiChartType = SeriesChartType.Line;
                            break;
                        default:
                            kpiChartType = SeriesChartType.Column;
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
                            KPI1_txtKPISummary.Text = dtKPI.Rows[i]["Summary"].ToString().Replace("\\n", Environment.NewLine);
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
                            KPI2_txtKPISummary.Text = dtKPI.Rows[i]["Summary"].ToString().Replace("\\n", Environment.NewLine);
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
                            KPI3_txtKPISummary.Text = dtKPI.Rows[i]["Summary"].ToString().Replace("\\n", Environment.NewLine);
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
                            KPI4_txtKPISummary.Text = dtKPI.Rows[i]["Summary"].ToString().Replace("\\n", Environment.NewLine);
                            //}
                            break;
                    }
                }



                //Adds text to the labels for KPI #1
                #region

                string[] arr1 = new string[dataSetBusinessProcess.Tables[1].Columns.Count];
                for (int j = 0; j < dataSetBusinessProcess.Tables[1].Columns.Count; j++)
                {
                    arr1[j] = dataSetBusinessProcess.Tables[1].Columns[j].ToString();

                    if (j == 0)
                    {
                        KPI1_lblVar1.Text = arr1[0].ToString();
                        _kpi1Var1Name = arr1[0].ToString();
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
                        _kpi1Var1Name = arr1[0].ToString();
                        _kpi1Var2Name = arr1[1].ToString();
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
                        _kpi1Var1Name = arr1[0].ToString();
                        _kpi1Var2Name = arr1[1].ToString();
                        _kpi1Var3Name = arr1[2].ToString();
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
                        _kpi1Var1Name = arr1[0].ToString();
                        _kpi1Var2Name = arr1[1].ToString();
                        _kpi1Var3Name = arr1[2].ToString();
                        _kpi1Var4Name = arr1[3].ToString();
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
                        _kpi1Var1Name = arr1[0].ToString();
                        _kpi1Var2Name = arr1[1].ToString();
                        _kpi1Var3Name = arr1[2].ToString();
                        _kpi1Var4Name = arr1[3].ToString();
                        _kpi1Var5Name = arr1[4].ToString();
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
                #endregion
                //Adds text to the labels for KPI #2
                #region

                string[] arr2 = new string[dataSetBusinessProcess.Tables[2].Columns.Count];
                for (int j = 0; j < dataSetBusinessProcess.Tables[2].Columns.Count; j++)
                {
                    arr2[j] = dataSetBusinessProcess.Tables[2].Columns[j].ToString();

                    if (j == 0)
                    {
                        KPI2_lblVar1.Text = arr2[0].ToString();
                        _kpi2Var1Name = arr2[0].ToString();
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
                        _kpi2Var1Name = arr2[0].ToString();
                        _kpi2Var2Name = arr2[1].ToString();
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
                        _kpi2Var1Name = arr2[0].ToString();
                        _kpi2Var2Name = arr2[1].ToString();
                        _kpi2Var3Name = arr2[2].ToString();
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
                        _kpi2Var1Name = arr2[0].ToString();
                        _kpi2Var2Name = arr2[1].ToString();
                        _kpi2Var3Name = arr2[2].ToString();
                        _kpi2Var4Name = arr2[3].ToString();
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
                        _kpi2Var1Name = arr2[0].ToString();
                        _kpi2Var2Name = arr2[1].ToString();
                        _kpi2Var3Name = arr2[2].ToString();
                        _kpi2Var4Name = arr2[3].ToString();
                        _kpi2Var5Name = arr2[4].ToString();
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

                #endregion
                //Adds text to the labels for KPI #3
                #region

                string[] arr3 = new string[dataSetBusinessProcess.Tables[3].Columns.Count];
                for (int j = 0; j < dataSetBusinessProcess.Tables[3].Columns.Count; j++)
                {
                    arr3[j] = dataSetBusinessProcess.Tables[3].Columns[j].ToString();

                    if (j == 0)
                    {
                        KPI3_lblVar1.Text = arr3[0].ToString();
                        _kpi3Var1Name = arr3[0].ToString();
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
                        _kpi3Var1Name = arr3[0].ToString();
                        _kpi3Var2Name = arr3[1].ToString();
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
                        _kpi3Var1Name = arr3[0].ToString();
                        _kpi3Var2Name = arr3[1].ToString();
                        _kpi3Var3Name = arr3[2].ToString();
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
                        _kpi3Var1Name = arr3[0].ToString();
                        _kpi3Var2Name = arr3[1].ToString();
                        _kpi3Var3Name = arr3[2].ToString();
                        _kpi3Var4Name = arr3[3].ToString();
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
                        _kpi3Var1Name = arr3[0].ToString();
                        _kpi3Var2Name = arr3[1].ToString();
                        _kpi3Var3Name = arr3[2].ToString();
                        _kpi3Var4Name = arr3[3].ToString();
                        _kpi3Var5Name = arr3[4].ToString();
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
                #endregion
                //Adds text to the labels for KPI #4
                #region

                string[] arr4 = new string[dataSetBusinessProcess.Tables[4].Columns.Count];
                for (int j = 0; j < dataSetBusinessProcess.Tables[4].Columns.Count; j++)
                {
                    arr4[j] = dataSetBusinessProcess.Tables[4].Columns[j].ToString();

                    if (j == 0)
                    {
                        KPI4_lblVar1.Text = arr4[0].ToString();
                        _kpi4Var1Name = arr4[0].ToString();
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
                        _kpi4Var1Name = arr4[0].ToString();
                        _kpi4Var2Name = arr4[1].ToString();
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
                        _kpi4Var1Name = arr4[0].ToString();
                        _kpi4Var2Name = arr4[1].ToString();
                        _kpi4Var3Name = arr4[2].ToString();
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
                        _kpi4Var1Name = arr4[0].ToString();
                        _kpi4Var2Name = arr4[1].ToString();
                        _kpi4Var3Name = arr4[2].ToString();
                        _kpi4Var4Name = arr4[3].ToString();
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
                        _kpi4Var1Name = arr4[0].ToString();
                        _kpi4Var2Name = arr4[1].ToString();
                        _kpi4Var3Name = arr4[2].ToString();
                        _kpi4Var4Name = arr4[3].ToString();
                        _kpi4Var5Name = arr4[4].ToString();
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
                #endregion



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
            KPI_btnCalculate_Click(null, null);
        }

        private void clearFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clears fields of all content - KPI1
            KPI1_groupDecision.Visible = false;
            KPI1_btnSubmitDecision.Visible = false;
            KPI1_lblState.Visible = false;
            KPI1_lblState.Visible = false;
            KPI1_btnSubmitDecision.Visible = false;
            KPI1_lblResult.Visible = false;
            KPI1_txtVar2.Text = "";
            KPI1_txtVar3.Text = "";
            KPI1_txtVar4.Text = "";
            KPI1_txtVar5.Text = "";
            //Clears fields of all content - KPI2
            KPI2_groupDecision.Visible = false;
            KPI2_btnSubmitDecision.Visible = false;
            KPI2_lblState.Visible = false;
            KPI2_lblState.Visible = false;
            KPI2_btnSubmitDecision.Visible = false;
            KPI2_lblResult.Visible = false;
            KPI2_txtVar2.Text = "";
            KPI2_txtVar3.Text = "";
            KPI2_txtVar4.Text = "";
            KPI2_txtVar5.Text = "";
            //Clears fields of all content - KPI3
            KPI3_groupDecision.Visible = false;
            KPI3_btnSubmitDecision.Visible = false;
            KPI3_lblState.Visible = false;
            KPI3_lblState.Visible = false;
            KPI3_btnSubmitDecision.Visible = false;
            KPI3_lblResult.Visible = false;
            KPI3_txtVar2.Text = "";
            KPI3_txtVar3.Text = "";
            KPI3_txtVar4.Text = "";
            KPI3_txtVar5.Text = "";
            //Clears fields of all content - KPI4
            KPI4_groupDecision.Visible = false;
            KPI4_btnSubmitDecision.Visible = false;
            KPI4_lblState.Visible = false;
            KPI4_lblState.Visible = false;
            KPI4_btnSubmitDecision.Visible = false;
            KPI4_lblResult.Visible = false;
            KPI4_txtVar2.Text = "";
            KPI4_txtVar3.Text = "";
            KPI4_txtVar4.Text = "";
            KPI4_txtVar5.Text = "";
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

        private void KPI_btnCalculate_Click(object sender, EventArgs e)
        {
            //Displays controls
            #region
            //Clears fields of all content - KPI1
            KPI1_groupDecision.Visible = true;
            KPI1_btnSubmitDecision.Visible = true;
            KPI1_lblState.Visible = true;
            KPI1_lblState.Visible = true;
            KPI1_btnSubmitDecision.Visible = true;
            KPI1_lblResult.Visible = true;
            KPI1_txtVar2.Text = "";
            KPI1_txtVar3.Text = "";
            KPI1_txtVar4.Text = "";
            KPI1_txtVar5.Text = "";
            //Clears fields of all content - KPI2
            KPI2_groupDecision.Visible = true;
            KPI2_btnSubmitDecision.Visible = true;
            KPI2_lblState.Visible = true;
            KPI2_lblState.Visible = true;
            KPI2_btnSubmitDecision.Visible = true;
            KPI2_lblResult.Visible = true;
            KPI2_txtVar2.Text = "";
            KPI2_txtVar3.Text = "";
            KPI2_txtVar4.Text = "";
            KPI2_txtVar5.Text = "";
            //Clears fields of all content - KPI3
            KPI3_groupDecision.Visible = true;
            KPI3_btnSubmitDecision.Visible = true;
            KPI3_lblState.Visible = true;
            KPI3_lblState.Visible = true;
            KPI3_btnSubmitDecision.Visible = true;
            KPI3_lblResult.Visible = true;
            KPI3_txtVar2.Text = "";
            KPI3_txtVar3.Text = "";
            KPI3_txtVar4.Text = "";
            KPI3_txtVar5.Text = "";
            //Clears fields of all content - KPI4
            KPI4_groupDecision.Visible = true;
            KPI4_btnSubmitDecision.Visible = true;
            KPI4_lblState.Visible = true;
            KPI4_lblState.Visible = true;
            KPI4_btnSubmitDecision.Visible = true;
            KPI4_lblResult.Visible = true;
            KPI4_txtVar2.Text = "";
            KPI4_txtVar3.Text = "";
            KPI4_txtVar4.Text = "";
            KPI4_txtVar5.Text = "";
#endregion



            DataTable dtStates = _globalBusinessProcessDataSet.Tables["States"];
            DataTable dtKPI = _globalBusinessProcessDataSet.Tables["KPI"];
            DataTable dtDecisions = _globalBusinessProcessDataSet.Tables["Decisions"];
            var selectedTabIndex = KPIs_tabPage.SelectedTab.TabIndex;
            var kpiName = KPIs_tabPage.SelectedTab.Text;
            var drKPI = dtKPI.AsEnumerable().Where(dr => dr.Field<string>("Name") == kpiName);
            var kpiId = drKPI.First()["KPIID"].ToString().Trim();
            var drKPIStates = dtStates.AsEnumerable().Where(dr => dr.Field<string>("KPIID") == kpiId);
            double calculatedKPI;
            IEnumerable<DataRow> drkpiState;
            IEnumerable<DataRow> drCollectionKPIDecisions;
            string kpiState;
            int i;

            switch (kpiName)
            {
                // Customer Service KPIs
                #region Customer Complaints
                case "Customer Complaints":
                    calculatedKPI = double.Parse(KPI1_txtVar2.Text) / double.Parse(KPI1_txtVar3.Text);
                    KPI1_lblResult.Text = calculatedKPI.ToString("P");
                    drkpiState = drKPIStates.AsEnumerable().Where(item => (double.Parse(item.Field<decimal>("RangeMin").ToString()) <= calculatedKPI) && (double.Parse(item.Field<decimal>("RangeMax").ToString()) >= calculatedKPI));
                    kpiState = drkpiState.First()["State"].ToString().Trim();
                    drCollectionKPIDecisions = dtDecisions.AsEnumerable().Where(dt => dt.Field<string>("State") == kpiState && dt.Field<string>("KPIID") == kpiId);
                    i = 1;
                    foreach (DataRow dr in drCollectionKPIDecisions)
                    {
                        switch (i)
                        {
                            case 1:
                                KPI1_radioDecision1.Text = dr["Decision"].ToString();
                                break;
                            case 2:
                                KPI1_radioDecision2.Text = dr["Decision"].ToString();
                                break;
                            case 3:
                                KPI1_radioDecision3.Text = dr["Decision"].ToString();
                                break;
                            default:
                                break;
                        }
                        i++;
                    }

                    KPI1_lblState.Text = kpiState;
                    break;
                case "Customer Training":
                    TimeSpan kpiTemp = DateTime.Parse(KPI2_txtVar2.Text).Subtract(DateTime.Parse(KPI2_txtVar3.Text));
                    KPI2_lblResult.Text = kpiTemp.ToString();
                    drkpiState = drKPIStates.AsEnumerable().Where(item => (double.Parse(item.Field<decimal>("RangeMin").ToString()) <= kpiTemp.TotalDays) && (double.Parse(item.Field<decimal>("RangeMax").ToString()) >= kpiTemp.TotalDays));
                    kpiState = drkpiState.First()["State"].ToString().Trim();
                    drCollectionKPIDecisions = dtDecisions.AsEnumerable().Where(dt => dt.Field<string>("State") == kpiState && dt.Field<string>("KPIID") == kpiId);
                    i = 1;
                    foreach (DataRow dr in drCollectionKPIDecisions)
                    {
                        switch (i)
                        {
                            case 1:
                                KPI2_radioDecision1.Text = dr["Decision"].ToString();
                                break;
                            case 2:
                                KPI2_radioDecision2.Text = dr["Decision"].ToString();
                                break;
                            case 3:
                                KPI2_radioDecision3.Text = dr["Decision"].ToString();
                                break;
                            default:
                                break;
                        }
                        i++;
                    }

                    KPI2_lblState.Text = kpiState;
                    break;
                case "Frequency Complaints":
                    calculatedKPI = int.Parse(KPI3_txtVar2.Text) + int.Parse(KPI3_txtVar3.Text) + int.Parse(KPI3_txtVar4.Text);
                    KPI3_lblResult.Text = calculatedKPI.ToString();
                    drkpiState = drKPIStates.AsEnumerable().Where(item => (double.Parse(item.Field<decimal>("RangeMin").ToString()) <= calculatedKPI) && (double.Parse(item.Field<decimal>("RangeMax").ToString()) >= calculatedKPI));
                    kpiState = drkpiState.First()["State"].ToString().Trim();
                    drCollectionKPIDecisions = dtDecisions.AsEnumerable().Where(dt => dt.Field<string>("State") == kpiState && dt.Field<string>("KPIID") == kpiId);
                    i = 1;
                    foreach (DataRow dr in drCollectionKPIDecisions)
                    {
                        switch (i)
                        {
                            case 1:
                                KPI3_radioDecision1.Text = dr["Decision"].ToString();
                                break;
                            case 2:
                                KPI3_radioDecision2.Text = dr["Decision"].ToString();
                                break;
                            case 3:
                                KPI3_radioDecision3.Text = dr["Decision"].ToString();
                                break;
                            default:
                                break;
                        }
                        i++;
                    }

                    KPI3_lblState.Text = kpiState;
                    break;
                case "Troubleshooting":
                    calculatedKPI = int.Parse(KPI4_txtVar2.Text) - int.Parse(KPI4_txtVar3.Text);
                    KPI4_lblResult.Text = calculatedKPI.ToString();
                    drkpiState = drKPIStates.AsEnumerable().Where(item => (double.Parse(item.Field<decimal>("RangeMin").ToString()) <= calculatedKPI) && (double.Parse(item.Field<decimal>("RangeMax").ToString()) >= calculatedKPI));
                    kpiState = drkpiState.First()["State"].ToString().Trim();
                    drCollectionKPIDecisions = dtDecisions.AsEnumerable().Where(dt => dt.Field<string>("State") == kpiState && dt.Field<string>("KPIID") == kpiId);
                    i = 1;
                    foreach (DataRow dr in drCollectionKPIDecisions)
                    {
                        switch (i)
                        {
                            case 1:
                                KPI4_radioDecision1.Text = dr["Decision"].ToString();
                                break;
                            case 2:
                                KPI4_radioDecision2.Text = dr["Decision"].ToString();
                                break;
                            case 3:
                                KPI4_radioDecision3.Text = dr["Decision"].ToString();
                                break;
                            default:
                                break;
                        }
                        i++;
                    }

                    KPI4_lblState.Text = kpiState;
                    break;
                #endregion
                // EServices KPIs
                #region E-Services KPIs
                case "Employee Retention":
                    calculatedKPI = (double.Parse(KPI1_txtVar2.Text) - double.Parse(KPI1_txtVar3.Text)) / double.Parse(KPI1_txtVar2.Text);
                    KPI1_lblResult.Text = calculatedKPI.ToString();
                    drkpiState = drKPIStates.AsEnumerable().Where(item => (double.Parse(item.Field<decimal>("RangeMin").ToString()) <= calculatedKPI) && (double.Parse(item.Field<decimal>("RangeMax").ToString()) >= calculatedKPI));
                    kpiState = drkpiState.First()["State"].ToString().Trim();
                    drCollectionKPIDecisions = dtDecisions.AsEnumerable().Where(dt => dt.Field<string>("State") == kpiState && dt.Field<string>("KPIID") == kpiId);
                    i = 1;
                    foreach (DataRow dr in drCollectionKPIDecisions)
                    {
                        switch (i)
                        {
                            case 1:
                                KPI1_radioDecision1.Text = dr["Decision"].ToString();
                                break;
                            case 2:
                                KPI1_radioDecision2.Text = dr["Decision"].ToString();
                                break;
                            case 3:
                                KPI1_radioDecision3.Text = dr["Decision"].ToString();
                                break;
                            default:
                                break;
                        }
                        i++;
                    }

                    KPI1_lblState.Text = kpiState;
                    break;
                case "Market Share":
                    calculatedKPI = double.Parse(KPI2_txtVar2.Text) / double.Parse(KPI2_txtVar3.Text);
                    KPI2_lblResult.Text = calculatedKPI.ToString();
                    drkpiState = drKPIStates.AsEnumerable().Where(item => (double.Parse(item.Field<decimal>("RangeMin").ToString()) <= calculatedKPI) && (double.Parse(item.Field<decimal>("RangeMax").ToString()) >= calculatedKPI));
                    kpiState = drkpiState.First()["State"].ToString().Trim();
                    drCollectionKPIDecisions = dtDecisions.AsEnumerable().Where(dt => dt.Field<string>("State") == kpiState && dt.Field<string>("KPIID") == kpiId);
                    i = 1;
                    foreach (DataRow dr in drCollectionKPIDecisions)
                    {
                        switch (i)
                        {
                            case 1:
                                KPI2_radioDecision1.Text = dr["Decision"].ToString();
                                break;
                            case 2:
                                KPI2_radioDecision2.Text = dr["Decision"].ToString();
                                break;
                            case 3:
                                KPI2_radioDecision3.Text = dr["Decision"].ToString();
                                break;
                            default:
                                break;
                        }
                        i++;
                    }

                    KPI2_lblState.Text = kpiState;
                    break;
                case "Revenue Growth":
                    calculatedKPI = (double.Parse(KPI3_txtVar2.Text) - double.Parse(KPI3_txtVar3.Text)) / double.Parse(KPI3_txtVar4.Text);
                    KPI3_lblResult.Text = calculatedKPI.ToString();
                    drkpiState = drKPIStates.AsEnumerable().Where(item => (double.Parse(item.Field<decimal>("RangeMin").ToString()) <= calculatedKPI) && (double.Parse(item.Field<decimal>("RangeMax").ToString()) >= calculatedKPI));
                    kpiState = drkpiState.First()["State"].ToString().Trim();
                    drCollectionKPIDecisions = dtDecisions.AsEnumerable().Where(dt => dt.Field<string>("State") == kpiState && dt.Field<string>("KPIID") == kpiId);
                    i = 1;
                    foreach (DataRow dr in drCollectionKPIDecisions)
                    {
                        switch (i)
                        {
                            case 1:
                                KPI3_radioDecision1.Text = dr["Decision"].ToString();
                                break;
                            case 2:
                                KPI3_radioDecision2.Text = dr["Decision"].ToString();
                                break;
                            case 3:
                                KPI3_radioDecision3.Text = dr["Decision"].ToString();
                                break;
                            default:
                                break;
                        }
                        i++;
                    }

                    KPI3_lblState.Text = kpiState;
                    break;
                case "Target Growth Rate":
                    calculatedKPI = (double.Parse(KPI4_txtVar2.Text) - double.Parse(KPI4_txtVar3.Text)) / double.Parse(KPI4_txtVar3.Text);
                    KPI4_lblResult.Text = calculatedKPI.ToString();
                    drkpiState = drKPIStates.AsEnumerable().Where(item => (double.Parse(item.Field<decimal>("RangeMin").ToString()) <= calculatedKPI) && (double.Parse(item.Field<decimal>("RangeMax").ToString()) >= calculatedKPI));
                    kpiState = drkpiState.First()["State"].ToString().Trim();
                    drCollectionKPIDecisions = dtDecisions.AsEnumerable().Where(dt => dt.Field<string>("State") == kpiState && dt.Field<string>("KPIID") == kpiId);
                    i = 1;
                    foreach (DataRow dr in drCollectionKPIDecisions)
                    {
                        switch (i)
                        {
                            case 1:
                                KPI4_radioDecision1.Text = dr["Decision"].ToString();
                                break;
                            case 2:
                                KPI4_radioDecision2.Text = dr["Decision"].ToString();
                                break;
                            case 3:
                                KPI4_radioDecision3.Text = dr["Decision"].ToString();
                                break;
                            default:
                                break;
                        }
                        i++;
                    }

                    KPI4_lblState.Text = kpiState;
                    break;
                #endregion
                // Financial Accounting KPIs
                #region Financial Accounting
                case "Paying Emplopyees":
                    calculatedKPI = double.Parse(KPI1_txtVar2.Text) / double.Parse(KPI1_txtVar3.Text);
                    KPI1_lblResult.Text = calculatedKPI.ToString();
                    drkpiState = drKPIStates.AsEnumerable().Where(item => (double.Parse(item.Field<decimal>("RangeMin").ToString()) <= calculatedKPI) && (double.Parse(item.Field<decimal>("RangeMax").ToString()) >= calculatedKPI));
                    kpiState = drkpiState.First()["State"].ToString().Trim();
                    drCollectionKPIDecisions = dtDecisions.AsEnumerable().Where(dt => dt.Field<string>("State") == kpiState && dt.Field<string>("KPIID") == kpiId);
                    i = 1;
                    foreach (DataRow dr in drCollectionKPIDecisions)
                    {
                        switch (i)
                        {
                            case 1:
                                KPI1_radioDecision1.Text = dr["Decision"].ToString();
                                break;
                            case 2:
                                KPI1_radioDecision2.Text = dr["Decision"].ToString();
                                break;
                            case 3:
                                KPI1_radioDecision3.Text = dr["Decision"].ToString();
                                break;
                            default:
                                break;
                        }
                        i++;
                    }
                    KPI1_lblState.Text = kpiState;
                    break;
                
                case "Debiting Employers":
                    calculatedKPI = double.Parse(KPI2_txtVar2.Text) / double.Parse(KPI2_txtVar3.Text);
                    KPI2_lblResult.Text = calculatedKPI.ToString();
                    drkpiState = drKPIStates.AsEnumerable().Where(item => (double.Parse(item.Field<decimal>("RangeMin").ToString()) <= calculatedKPI) && (double.Parse(item.Field<decimal>("RangeMax").ToString()) >= calculatedKPI));
                    kpiState = drkpiState.First()["State"].ToString().Trim();
                    drCollectionKPIDecisions = dtDecisions.AsEnumerable().Where(dt => dt.Field<string>("State") == kpiState && dt.Field<string>("KPIID") == kpiId);
                    i = 1;
                    foreach (DataRow dr in drCollectionKPIDecisions)
                    {
                        switch (i)
                        {
                            case 1:
                                KPI2_radioDecision1.Text = dr["Decision"].ToString();
                                break;
                            case 2:
                                KPI2_radioDecision2.Text = dr["Decision"].ToString();
                                break;
                            case 3:
                                KPI2_radioDecision3.Text = dr["Decision"].ToString();
                                break;
                            default:
                                break;
                        }
                        i++;
                    }

                    KPI2_lblState.Text = kpiState;
                    break;
                
                case "Timekeeping for Employee Hours":
                    calculatedKPI = double.Parse(KPI4_txtVar2.Text) - double.Parse(KPI4_txtVar3.Text);
                    KPI3_lblResult.Text = calculatedKPI.ToString();
                    drkpiState = drKPIStates.AsEnumerable().Where(item => (double.Parse(item.Field<decimal>("RangeMin").ToString()) <= calculatedKPI) && (double.Parse(item.Field<decimal>("RangeMax").ToString()) >= calculatedKPI));
                    kpiState = drkpiState.First()["State"].ToString().Trim();
                    drCollectionKPIDecisions = dtDecisions.AsEnumerable().Where(dt => dt.Field<string>("State") == kpiState && dt.Field<string>("KPIID") == kpiId);
                    i = 1;
                    foreach (DataRow dr in drCollectionKPIDecisions)
                    {
                        switch (i)
                        {
                            case 1:
                                KPI4_radioDecision1.Text = dr["Decision"].ToString();
                                break;
                            case 2:
                                KPI4_radioDecision2.Text = dr["Decision"].ToString();
                                break;
                            case 3:
                                KPI4_radioDecision3.Text = dr["Decision"].ToString();
                                break;
                            default:
                                break;
                        }
                        i++;
                    }

                    KPI4_lblState.Text = kpiState;
                    break;
                
                case "Pay Period Information Access":
                    calculatedKPI = double.Parse(KPI4_txtVar2.Text) - double.Parse(KPI4_txtVar3.Text);
                    KPI4_lblResult.Text = calculatedKPI.ToString();
                    drkpiState = drKPIStates.AsEnumerable().Where(item => (double.Parse(item.Field<decimal>("RangeMin").ToString()) <= calculatedKPI) && (double.Parse(item.Field<decimal>("RangeMax").ToString()) >= calculatedKPI));
                    kpiState = drkpiState.First()["State"].ToString().Trim();
                    drCollectionKPIDecisions = dtDecisions.AsEnumerable().Where(dt => dt.Field<string>("State") == kpiState && dt.Field<string>("KPIID") == kpiId);
                    i = 1;
                    foreach (DataRow dr in drCollectionKPIDecisions)
                    {
                        switch (i)
                        {
                            case 1:
                                KPI4_radioDecision1.Text = dr["Decision"].ToString();
                                break;
                            case 2:
                                KPI4_radioDecision2.Text = dr["Decision"].ToString();
                                break;
                            case 3:
                                KPI4_radioDecision3.Text = dr["Decision"].ToString();
                                break;
                            default:
                                break;
                        }
                        i++;
                    }

                    KPI4_lblState.Text = kpiState;
                    break;
                #endregion
                // Human Resources KPIs
                #region Human Resources
                case "Customer Feedback":
                    calculatedKPI = double.Parse(KPI1_txtVar3.Text);
                    KPI1_lblResult.Text = calculatedKPI.ToString();
                    drkpiState = drKPIStates.AsEnumerable().Where(item => (double.Parse(item.Field<decimal>("RangeMin").ToString()) <= calculatedKPI) && (double.Parse(item.Field<decimal>("RangeMax").ToString()) >= calculatedKPI));
                    kpiState = drkpiState.First()["State"].ToString().Trim();
                    drCollectionKPIDecisions = dtDecisions.AsEnumerable().Where(dt => dt.Field<string>("State") == kpiState && dt.Field<string>("KPIID") == kpiId);
                    i = 1;
                    foreach (DataRow dr in drCollectionKPIDecisions)
                    {
                        switch (i)
                        {
                            case 1:
                                KPI1_radioDecision1.Text = dr["Decision"].ToString();
                                break;
                            case 2:
                                KPI1_radioDecision2.Text = dr["Decision"].ToString();
                                break;
                            case 3:
                                KPI1_radioDecision3.Text = dr["Decision"].ToString();
                                break;
                            default:
                                break;
                        }
                        i++;
                    }
                    KPI1_lblState.Text = kpiState;
                    break;
               case "Training Expense Measure":
                    calculatedKPI = double.Parse(KPI2_txtVar3.Text);
                    KPI2_lblResult.Text = calculatedKPI.ToString();
                    drkpiState = drKPIStates.AsEnumerable().Where(item => (double.Parse(item.Field<decimal>("RangeMin").ToString()) <= calculatedKPI) && (double.Parse(item.Field<decimal>("RangeMax").ToString()) >= calculatedKPI));
                    kpiState = drkpiState.First()["State"].ToString().Trim();
                    drCollectionKPIDecisions = dtDecisions.AsEnumerable().Where(dt => dt.Field<string>("State") == kpiState && dt.Field<string>("KPIID") == kpiId);
                    i = 1;
                    foreach (DataRow dr in drCollectionKPIDecisions)
                    {
                        switch (i)
                        {
                            case 1:
                                KPI2_radioDecision1.Text = dr["Decision"].ToString();
                                break;
                            case 2:
                                KPI2_radioDecision2.Text = dr["Decision"].ToString();
                                break;
                            case 3:
                                KPI2_radioDecision3.Text = dr["Decision"].ToString();
                                break;
                            default:
                                break;
                        }
                        i++;
                    }
                    KPI2_lblState.Text = kpiState;
                    break;
               case "Employee Loyalty":
                    calculatedKPI = double.Parse(KPI3_txtVar3.Text);
                    KPI3_lblResult.Text = calculatedKPI.ToString();
                    drkpiState = drKPIStates.AsEnumerable().Where(item => (double.Parse(item.Field<decimal>("RangeMin").ToString()) <= calculatedKPI) && (double.Parse(item.Field<decimal>("RangeMax").ToString()) >= calculatedKPI));
                    kpiState = drkpiState.First()["State"].ToString().Trim();
                    drCollectionKPIDecisions = dtDecisions.AsEnumerable().Where(dt => dt.Field<string>("State") == kpiState && dt.Field<string>("KPIID") == kpiId);
                    i = 1;
                    foreach (DataRow dr in drCollectionKPIDecisions)
                    {
                        switch (i)
                        {
                            case 1:
                                KPI3_radioDecision1.Text = dr["Decision"].ToString();
                                break;
                            case 2:
                                KPI3_radioDecision2.Text = dr["Decision"].ToString();
                                break;
                            case 3:
                                KPI3_radioDecision3.Text = dr["Decision"].ToString();
                                break;
                            default:
                                break;
                        }
                        i++;
                    }
                    KPI3_lblState.Text = kpiState;
                    break;
               case "New Jobs Created Measure":
                    calculatedKPI = double.Parse(KPI4_txtVar2.Text) / double.Parse(KPI4_txtVar3.Text);
                    KPI4_lblResult.Text = calculatedKPI.ToString();
                    drkpiState = drKPIStates.AsEnumerable().Where(item => (double.Parse(item.Field<decimal>("RangeMin").ToString()) <= calculatedKPI) && (double.Parse(item.Field<decimal>("RangeMax").ToString()) >= calculatedKPI));
                    kpiState = drkpiState.First()["State"].ToString().Trim();
                    drCollectionKPIDecisions = dtDecisions.AsEnumerable().Where(dt => dt.Field<string>("State") == kpiState && dt.Field<string>("KPIID") == kpiId);
                    i = 1;
                    foreach (DataRow dr in drCollectionKPIDecisions)
                    {
                        switch (i)
                        {
                            case 1:
                                KPI4_radioDecision1.Text = dr["Decision"].ToString();
                                break;
                            case 2:
                                KPI4_radioDecision2.Text = dr["Decision"].ToString();
                                break;
                            case 3:
                                KPI4_radioDecision3.Text = dr["Decision"].ToString();
                                break;
                            default:
                                break;
                        }
                        i++;
                    }
                    KPI4_lblState.Text = kpiState;
                    break;
                #endregion
                // Materials Management KPIs
                #region Materials Management
                case "Customer Cycle Time":
                    TimeSpan kpiCCT = DateTime.Parse(KPI1_txtVar2.Text).Subtract(DateTime.Parse(KPI1_txtVar3.Text));
                    KPI1_lblResult.Text = kpiCCT.ToString();
                    drkpiState = drKPIStates.AsEnumerable().Where(item => (double.Parse(item.Field<decimal>("RangeMin").ToString()) <= kpiCCT.TotalDays) && (double.Parse(item.Field<decimal>("RangeMax").ToString()) >= kpiCCT.TotalDays));
                    kpiState = drkpiState.First()["State"].ToString().Trim();
                    drCollectionKPIDecisions = dtDecisions.AsEnumerable().Where(dt => dt.Field<string>("State") == kpiState && dt.Field<string>("KPIID") == kpiId);
                    i = 1;
                    foreach (DataRow dr in drCollectionKPIDecisions)
                    {
                        switch (i)
                        {
                            case 1:
                                KPI1_radioDecision1.Text = dr["Decision"].ToString();
                                break;
                            case 2:
                                KPI1_radioDecision2.Text = dr["Decision"].ToString();
                                break;
                            case 3:
                                KPI1_radioDecision3.Text = dr["Decision"].ToString();
                                break;
                            default:
                                break;
                        }
                        i++;
                    }

                    KPI1_lblState.Text = kpiState;
                    break;

                case "Cycle Time Performance":
                    calculatedKPI = double.Parse(KPI2_txtVar2.Text) / double.Parse(KPI2_txtVar3.Text);
                    KPI2_lblResult.Text = calculatedKPI.ToString();
                    drkpiState = drKPIStates.AsEnumerable().Where(item => (double.Parse(item.Field<decimal>("RangeMin").ToString()) <= calculatedKPI) && (double.Parse(item.Field<decimal>("RangeMax").ToString()) >= calculatedKPI));
                    kpiState = drkpiState.First()["State"].ToString().Trim();
                    drCollectionKPIDecisions = dtDecisions.AsEnumerable().Where(dt => dt.Field<string>("State") == kpiState && dt.Field<string>("KPIID") == kpiId);
                    i = 1;
                    foreach (DataRow dr in drCollectionKPIDecisions)
                    {
                        switch (i)
                        {
                            case 1:
                                KPI2_radioDecision1.Text = dr["Decision"].ToString();
                                break;
                            case 2:
                                KPI2_radioDecision2.Text = dr["Decision"].ToString();
                                break;
                            case 3:
                                KPI2_radioDecision3.Text = dr["Decision"].ToString();
                                break;
                            default:
                                break;
                        }
                        i++;
                    }

                    KPI2_lblState.Text = kpiState;
                    break;

                case "Production Cycle Time":
                    TimeSpan kpiPCT = DateTime.Parse(KPI3_txtVar2.Text).Subtract(DateTime.Parse(KPI3_txtVar3.Text));
                    KPI3_lblResult.Text = kpiPCT.ToString();
                    drkpiState = drKPIStates.AsEnumerable().Where(item => (double.Parse(item.Field<decimal>("RangeMin").ToString()) <= kpiPCT.TotalDays) && (double.Parse(item.Field<decimal>("RangeMax").ToString()) >= kpiPCT.TotalDays));
                    kpiState = drkpiState.First()["State"].ToString().Trim();
                    drCollectionKPIDecisions = dtDecisions.AsEnumerable().Where(dt => dt.Field<string>("State") == kpiState && dt.Field<string>("KPIID") == kpiId);
                    i = 1;
                    foreach (DataRow dr in drCollectionKPIDecisions)
                    {
                        switch (i)
                        {
                            case 1:
                                KPI3_radioDecision1.Text = dr["Decision"].ToString();
                                break;
                            case 2:
                                KPI3_radioDecision2.Text = dr["Decision"].ToString();
                                break;
                            case 3:
                                KPI3_radioDecision3.Text = dr["Decision"].ToString();
                                break;
                            default:
                                break;
                        }
                        i++;
                    }

                    KPI3_lblState.Text = kpiState;
                    break;

                case "Throughput Performance Index":
                    calculatedKPI = double.Parse(KPI4_txtVar2.Text) / double.Parse(KPI4_txtVar3.Text);
                    KPI4_lblResult.Text = calculatedKPI.ToString();
                    drkpiState = drKPIStates.AsEnumerable().Where(item => (double.Parse(item.Field<decimal>("RangeMin").ToString()) <= calculatedKPI) && (double.Parse(item.Field<decimal>("RangeMax").ToString()) >= calculatedKPI));
                    kpiState = drkpiState.First()["State"].ToString().Trim();
                    drCollectionKPIDecisions = dtDecisions.AsEnumerable().Where(dt => dt.Field<string>("State") == kpiState && dt.Field<string>("KPIID") == kpiId);
                    i = 1;
                    foreach (DataRow dr in drCollectionKPIDecisions)
                    {
                        switch (i)
                        {
                            case 1:
                                KPI4_radioDecision1.Text = dr["Decision"].ToString();
                                break;
                            case 2:
                                KPI4_radioDecision2.Text = dr["Decision"].ToString();
                                break;
                            case 3:
                                KPI4_radioDecision3.Text = dr["Decision"].ToString();
                                break;
                            default:
                                break;
                        }
                        i++;
                    }

                    KPI4_lblState.Text = kpiState;
                    break;
                #endregion
                // Production KPIs
                #region Production
                case "Parts Per Day":
                    calculatedKPI = double.Parse(KPI1_txtVar2.Text);
                    KPI1_lblResult.Text = calculatedKPI.ToString();
                    drkpiState = drKPIStates.AsEnumerable().Where(item => (double.Parse(item.Field<decimal>("RangeMin").ToString()) <= calculatedKPI) && (double.Parse(item.Field<decimal>("RangeMax").ToString()) >= calculatedKPI));
                    kpiState = drkpiState.First()["State"].ToString().Trim();
                    drCollectionKPIDecisions = dtDecisions.AsEnumerable().Where(dt => dt.Field<string>("State") == kpiState && dt.Field<string>("KPIID") == kpiId);
                    i = 1;
                    foreach (DataRow dr in drCollectionKPIDecisions)
                    {
                        switch (i)
                        {
                            case 1:
                                KPI1_radioDecision1.Text = dr["Decision"].ToString();
                                break;
                            case 2:
                                KPI1_radioDecision2.Text = dr["Decision"].ToString();
                                break;
                            case 3:
                                KPI1_radioDecision3.Text = dr["Decision"].ToString();
                                break;
                            default:
                                break;
                        }
                        i++;
                    }

                    KPI1_lblState.Text = kpiState;
                    break;
                case "Mean Time Between Failures":
                    calculatedKPI = double.Parse(KPI2_txtVar2.Text);
                    KPI2_lblResult.Text = calculatedKPI.ToString();
                    drkpiState = drKPIStates.AsEnumerable().Where(item => (double.Parse(item.Field<decimal>("RangeMin").ToString()) <= calculatedKPI) && (double.Parse(item.Field<decimal>("RangeMax").ToString()) >= calculatedKPI));
                    kpiState = drkpiState.First()["State"].ToString().Trim();
                    drCollectionKPIDecisions = dtDecisions.AsEnumerable().Where(dt => dt.Field<string>("State") == kpiState && dt.Field<string>("KPIID") == kpiId);
                    i = 1;
                    foreach (DataRow dr in drCollectionKPIDecisions)
                    {
                        switch (i)
                        {
                            case 1:
                                KPI2_radioDecision1.Text = dr["Decision"].ToString();
                                break;
                            case 2:
                                KPI2_radioDecision2.Text = dr["Decision"].ToString();
                                break;
                            case 3:
                                KPI2_radioDecision3.Text = dr["Decision"].ToString();
                                break;
                            default:
                                break;
                        }
                        i++;
                    }

                    KPI2_lblState.Text = kpiState;
                    break;
                case "Takt Time":
                    calculatedKPI = double.Parse(KPI3_txtVar2.Text);
                    KPI3_lblResult.Text = calculatedKPI.ToString();
                    drkpiState = drKPIStates.AsEnumerable().Where(item => (double.Parse(item.Field<decimal>("RangeMin").ToString()) <= calculatedKPI) && (double.Parse(item.Field<decimal>("RangeMax").ToString()) >= calculatedKPI));
                    kpiState = drkpiState.First()["State"].ToString().Trim();
                    drCollectionKPIDecisions = dtDecisions.AsEnumerable().Where(dt => dt.Field<string>("State") == kpiState && dt.Field<string>("KPIID") == kpiId);
                    i = 1;
                    foreach (DataRow dr in drCollectionKPIDecisions)
                    {
                        switch (i)
                        {
                            case 1:
                                KPI3_radioDecision1.Text = dr["Decision"].ToString();
                                break;
                            case 2:
                                KPI3_radioDecision2.Text = dr["Decision"].ToString();
                                break;
                            case 3:
                                KPI3_radioDecision3.Text = dr["Decision"].ToString();
                                break;
                            default:
                                break;
                        }
                        i++;
                    }

                    KPI3_lblState.Text = kpiState;
                    break;
                case "Daily Defect Ratio":
                    calculatedKPI = double.Parse(KPI4_txtVar2.Text) / double.Parse(KPI4_txtVar3.Text);
                    KPI4_lblResult.Text = calculatedKPI.ToString();
                    drkpiState = drKPIStates.AsEnumerable().Where(item => (double.Parse(item.Field<decimal>("RangeMin").ToString()) <= calculatedKPI) && (double.Parse(item.Field<decimal>("RangeMax").ToString()) >= calculatedKPI));
                    kpiState = drkpiState.First()["State"].ToString().Trim();
                    drCollectionKPIDecisions = dtDecisions.AsEnumerable().Where(dt => dt.Field<string>("State") == kpiState && dt.Field<string>("KPIID") == kpiId);
                    i = 1;
                    foreach (DataRow dr in drCollectionKPIDecisions)
                    {
                        switch (i)
                        {
                            case 1:
                                KPI4_radioDecision1.Text = dr["Decision"].ToString();
                                break;
                            case 2:
                                KPI4_radioDecision2.Text = dr["Decision"].ToString();
                                break;
                            case 3:
                                KPI4_radioDecision3.Text = dr["Decision"].ToString();
                                break;
                            default:
                                break;
                        }
                        i++;
                    }

                    KPI4_lblState.Text = kpiState;
                    break;
                #endregion
                default:
                    break;
            }

            Button clickedButton = (Button)sender;

            switch (clickedButton.Name)
            {
                case "KPI1_btnCalculate":
                    KPI1_groupDecision.Visible = true;
                    KPI1_btnSubmitDecision.Visible = true;
                    KPI1_lblState.Visible = true;
                    //Changes the color of the state text, depending on the state.
                    switch (KPI1_lblState.Text)
                    {
                        case "Success":
                            KPI1_lblState.ForeColor = System.Drawing.Color.LimeGreen; //Success State
                            break;
                        case "Normal":
                            KPI1_lblState.ForeColor = System.Drawing.Color.Blue; //Normal State
                            break;
                        case "Conflict":
                            KPI1_lblState.ForeColor = System.Drawing.Color.Goldenrod; //Conflict State
                            break;
                        case "Crisis":
                            KPI1_lblState.ForeColor = System.Drawing.Color.DarkOrange; //Crisis State
                            break;
                        case "Failure":
                            KPI1_lblState.ForeColor = System.Drawing.Color.Red; //Failure State
                            break;
                        default:
                            break;
                    }
                    break;
                case "KPI2_btnCalculate":
                    KPI2_groupDecision.Visible = true;
                    KPI2_btnSubmitDecision.Visible = true;
                    KPI2_lblState.Visible = true;
                    //Changes the color of the state text, depending on the state.
                    switch (KPI2_lblState.Text)
                    {
                        case "Success":
                            KPI2_lblState.ForeColor = System.Drawing.Color.Blue; //Success State
                            break;
                        case "Normal":
                            KPI2_lblState.ForeColor = System.Drawing.Color.Green; //Normal State
                            break;
                        case "Conflict":
                            KPI2_lblState.ForeColor = System.Drawing.Color.Goldenrod; //Conflict State
                            break;
                        case "Crisis":
                            KPI2_lblState.ForeColor = System.Drawing.Color.DarkOrange; //Crisis State
                            break;
                        case "Failure":
                            KPI2_lblState.ForeColor = System.Drawing.Color.Red; //Failure State
                            break;
                        default:
                            break;
                    }
                    break;
                case "KPI3_btnCalculate":
                    KPI3_groupDecision.Visible = true;
                    KPI3_btnSubmitDecision.Visible = true;
                    KPI3_lblState.Visible = true;
                    //Changes the color of the state text, depending on the state.
                    switch (KPI3_lblState.Text)
                    {
                        case "Success":
                            KPI3_lblState.ForeColor = System.Drawing.Color.Blue; //Success State
                            break;
                        case "Normal":
                            KPI3_lblState.ForeColor = System.Drawing.Color.Green; //Normal State
                            break;
                        case "Conflict":
                            KPI3_lblState.ForeColor = System.Drawing.Color.Goldenrod; //Conflict State
                            break;
                        case "Crisis":
                            KPI3_lblState.ForeColor = System.Drawing.Color.DarkOrange; //Crisis State
                            break;
                        case "Failure":
                            KPI3_lblState.ForeColor = System.Drawing.Color.Red; //Failure State
                            break;
                        default:
                            break;
                    }
                    break;
                case "KPI4_btnCalculate":
                    KPI4_groupDecision.Visible = true;
                    KPI4_btnSubmitDecision.Visible = true;
                    KPI4_lblState.Visible = true;
                    //Changes the color of the state text, depending on the state.
                    switch (KPI4_lblState.Text)
                    {
                        case "Success":
                            KPI4_lblState.ForeColor = System.Drawing.Color.Blue; //Success State
                            break;
                        case "Normal":
                            KPI4_lblState.ForeColor = System.Drawing.Color.Green; //Normal State
                            break;
                        case "Conflict":
                            KPI4_lblState.ForeColor = System.Drawing.Color.Goldenrod; //Conflict State
                            break;
                        case "Crisis":
                            KPI4_lblState.ForeColor = System.Drawing.Color.DarkOrange; //Crisis State
                            break;
                        case "Failure":
                            KPI4_lblState.ForeColor = System.Drawing.Color.Red; //Failure State
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }


        //Following are the "Submit Decision" button commands
        //KPI 1
        #region

        private void KPI1_btnSubmitDecision_Click(object sender, EventArgs e)
        {
            
            if (KPI1_radioDecision1.Checked == true)
            {
                KPI1_lblDecisionFinal.Text = KPI1_radioDecision1.Text;
            }
            else
            if (KPI1_radioDecision2.Checked == true)
            {
                KPI1_lblDecisionFinal.Text = KPI1_radioDecision2.Text;
            }
            else
            if (KPI1_radioDecision3.Checked == true)
            {
                KPI1_lblDecisionFinal.Text = KPI1_radioDecision3.Text;
            }
        }
        #endregion
        //KPI2
        #region
        private void KPI2_btnSubmitDecision_Click(object sender, EventArgs e)
        {

            if (KPI2_radioDecision1.Checked == true)
            {
                KPI2_lblDecisionFinal.Text = KPI2_radioDecision1.Text;
            }
            else
            if (KPI2_radioDecision2.Checked == true)
            {
                KPI2_lblDecisionFinal.Text = KPI2_radioDecision2.Text;
            }
            else
            if (KPI2_radioDecision3.Checked == true)
            {
                KPI2_lblDecisionFinal.Text = KPI2_radioDecision3.Text;
            }
        }
        #endregion
        //KPI3
        #region
        private void KPI3_btnSubmitDecision_Click(object sender, EventArgs e)
        {

            if (KPI3_radioDecision1.Checked == true)
            {
                KPI3_lblDecisionFinal.Text = KPI3_radioDecision1.Text;
            }
            else
            if (KPI3_radioDecision2.Checked == true)
            {
                KPI3_lblDecisionFinal.Text = KPI3_radioDecision2.Text;
            }
            else
            if (KPI3_radioDecision3.Checked == true)
            {
                KPI3_lblDecisionFinal.Text = KPI3_radioDecision3.Text;
            }
        }
        #endregion
        //KPI4
        #region
        private void KPI4_btnSubmitDecision_Click(object sender, EventArgs e)
        {

            if (KPI4_radioDecision1.Checked == true)
            {
                KPI4_lblDecisionFinal.Text = KPI4_radioDecision1.Text;
            }
            else
            if (KPI4_radioDecision2.Checked == true)
            {
                KPI4_lblDecisionFinal.Text = KPI4_radioDecision2.Text;
            }
            else
            if (KPI4_radioDecision3.Checked == true)
            {
                KPI4_lblDecisionFinal.Text = KPI4_radioDecision3.Text;
            }
        }
        #endregion

        private void BusinessIntelligenceForm_Load(object sender, EventArgs e)
        {

        }
    }
}