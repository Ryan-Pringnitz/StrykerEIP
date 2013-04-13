using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace StrykerEIP
{
    partial class BusinessIntelligenceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.CustomerChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.OperationsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.InnovationsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.clearFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perspectivesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financialAccountingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialsManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.humanResourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.globalIntellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.sustainableIntelligencToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selfHelpPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FinancialChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblBusinessProcessName = new System.Windows.Forms.Label();
            this.lblKPI1Name = new System.Windows.Forms.Label();
            this.lblKPI2Name = new System.Windows.Forms.Label();
            this.lblKPI3Name = new System.Windows.Forms.Label();
            this.lblKPI4Name = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.KPI1_tabPage = new System.Windows.Forms.TabPage();
            this.label54 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.KPI1_lblDecisionFinal = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.KPI1_lblResult = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.KPI1_txtVar5 = new System.Windows.Forms.TextBox();
            this.KPI1_txtVar4 = new System.Windows.Forms.TextBox();
            this.KPI1_txtVar3 = new System.Windows.Forms.TextBox();
            this.KPI1_txtVar2 = new System.Windows.Forms.TextBox();
            this.KPI1_txtVar1 = new System.Windows.Forms.TextBox();
            this.KPI1_txtKPISummary = new System.Windows.Forms.RichTextBox();
            this.KPI1_lblVar5 = new System.Windows.Forms.Label();
            this.KPI1_lblState = new System.Windows.Forms.Label();
            this.KPI1_btnCalculate = new System.Windows.Forms.Button();
            this.KPI1_lblVar4 = new System.Windows.Forms.Label();
            this.KPI1_lblVar3 = new System.Windows.Forms.Label();
            this.KPI1_lblVar2 = new System.Windows.Forms.Label();
            this.KPI1_lblVar1 = new System.Windows.Forms.Label();
            this.KPI1_btnSubmitDecision = new System.Windows.Forms.Button();
            this.KPI1_groupDecision = new System.Windows.Forms.GroupBox();
            this.KPI1_radioDecision3 = new System.Windows.Forms.RadioButton();
            this.KPI1_radioDecision2 = new System.Windows.Forms.RadioButton();
            this.KPI1_radioDecision1 = new System.Windows.Forms.RadioButton();
            this.KPI1_lblDecisionLogo = new System.Windows.Forms.Label();
            this.KPI1_lblStateLogo = new System.Windows.Forms.Label();
            this.KPI1_lblCalculateLogo = new System.Windows.Forms.Label();
            this.KPI1_lblSummaryLogo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblColumn1 = new System.Windows.Forms.Label();
            this.KPI4_txtKPISummary = new System.Windows.Forms.TabControl();
            this.KPI2_tabPage = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.KPI2_lblDecisionFinal = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.KPI2_lblResult = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.KPI2_txtVar5 = new System.Windows.Forms.TextBox();
            this.KPI2_txtVar4 = new System.Windows.Forms.TextBox();
            this.KPI2_txtVar3 = new System.Windows.Forms.TextBox();
            this.KPI2_txtVar2 = new System.Windows.Forms.TextBox();
            this.KPI2_txtVar1 = new System.Windows.Forms.TextBox();
            this.KPI2_txtKPISummary = new System.Windows.Forms.RichTextBox();
            this.KPI2_lblVar5 = new System.Windows.Forms.Label();
            this.KPI2_lblState = new System.Windows.Forms.Label();
            this.KPI2_btnCalculate = new System.Windows.Forms.Button();
            this.KPI2_lblVar4 = new System.Windows.Forms.Label();
            this.KPI2_lblVar3 = new System.Windows.Forms.Label();
            this.KPI2_lblVar2 = new System.Windows.Forms.Label();
            this.KPI2_lblVar1 = new System.Windows.Forms.Label();
            this.KPI2_btnSubmitDecision = new System.Windows.Forms.Button();
            this.KPI2_groupDecision = new System.Windows.Forms.GroupBox();
            this.KPI2_radioDecision3 = new System.Windows.Forms.RadioButton();
            this.KPI2_radioDecision2 = new System.Windows.Forms.RadioButton();
            this.KPI2_radioDecision1 = new System.Windows.Forms.RadioButton();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.KPI3_tabPage = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.KPI3_lblDecisionFinal = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.KPI3_lblResult = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.KPI3_txtVar5 = new System.Windows.Forms.TextBox();
            this.KPI3_txtVar4 = new System.Windows.Forms.TextBox();
            this.KPI3_txtVar3 = new System.Windows.Forms.TextBox();
            this.KPI3_txtVar2 = new System.Windows.Forms.TextBox();
            this.KPI3_txtVar1 = new System.Windows.Forms.TextBox();
            this.KPI3_txtKPISummary = new System.Windows.Forms.RichTextBox();
            this.KPI3_lblVar5 = new System.Windows.Forms.Label();
            this.KPI3_lblState = new System.Windows.Forms.Label();
            this.KPI3_btnCalculate = new System.Windows.Forms.Button();
            this.KPI3_lblVar4 = new System.Windows.Forms.Label();
            this.KPI3_lblVar3 = new System.Windows.Forms.Label();
            this.KPI3_lblVar2 = new System.Windows.Forms.Label();
            this.KPI3_lblVar1 = new System.Windows.Forms.Label();
            this.KPI3_btnSubmitDecision = new System.Windows.Forms.Button();
            this.KPI3_groupDecision = new System.Windows.Forms.GroupBox();
            this.KPI3_radioDecision3 = new System.Windows.Forms.RadioButton();
            this.KPI3_radioDecision2 = new System.Windows.Forms.RadioButton();
            this.KPI3_radioDecision1 = new System.Windows.Forms.RadioButton();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.KPI4_tabPage = new System.Windows.Forms.TabPage();
            this.label33 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.KPI4_lblDecisionFinal = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.KPI4_lblResult = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.KPI4_txtVar5 = new System.Windows.Forms.TextBox();
            this.KPI4_txtVar4 = new System.Windows.Forms.TextBox();
            this.KPI4_txtVar3 = new System.Windows.Forms.TextBox();
            this.KPI4_txtVar2 = new System.Windows.Forms.TextBox();
            this.KPI4_txtVar1 = new System.Windows.Forms.TextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.KPI4_lblVar5 = new System.Windows.Forms.Label();
            this.KPI4_lblState = new System.Windows.Forms.Label();
            this.KPI4_btnCalculate = new System.Windows.Forms.Button();
            this.KPI4_lblVar4 = new System.Windows.Forms.Label();
            this.KPI4_lblVar3 = new System.Windows.Forms.Label();
            this.KPI4_lblVar2 = new System.Windows.Forms.Label();
            this.KPI4_lblVar1 = new System.Windows.Forms.Label();
            this.KPI4_btnSubmitDecision = new System.Windows.Forms.Button();
            this.KPI4_groupDecision = new System.Windows.Forms.GroupBox();
            this.KPI4_radioDecision3 = new System.Windows.Forms.RadioButton();
            this.KPI4_radioDecision2 = new System.Windows.Forms.RadioButton();
            this.KPI4_radioDecision1 = new System.Windows.Forms.RadioButton();
            this.label74 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InnovationsChart)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FinancialChart)).BeginInit();
            this.KPI1_tabPage.SuspendLayout();
            this.KPI1_groupDecision.SuspendLayout();
            this.KPI4_txtKPISummary.SuspendLayout();
            this.KPI2_tabPage.SuspendLayout();
            this.KPI2_groupDecision.SuspendLayout();
            this.KPI3_tabPage.SuspendLayout();
            this.KPI3_groupDecision.SuspendLayout();
            this.KPI4_tabPage.SuspendLayout();
            this.KPI4_groupDecision.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerChart
            // 
            this.CustomerChart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CustomerChart.BackColor = System.Drawing.Color.Lavender;
            this.CustomerChart.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.CustomerChart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.CustomerChart.Legends.Add(legend1);
            this.CustomerChart.Location = new System.Drawing.Point(4, 122);
            this.CustomerChart.Name = "CustomerChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "CustomerSeries";
            this.CustomerChart.Series.Add(series1);
            this.CustomerChart.Size = new System.Drawing.Size(269, 178);
            this.CustomerChart.TabIndex = 1;
            this.CustomerChart.Text = "chart1";
            // 
            // OperationsChart
            // 
            this.OperationsChart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OperationsChart.BackColor = System.Drawing.Color.Lavender;
            this.OperationsChart.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.OperationsChart.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.OperationsChart.Legends.Add(legend2);
            this.OperationsChart.Location = new System.Drawing.Point(584, 122);
            this.OperationsChart.Name = "OperationsChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "OperationsSeries";
            this.OperationsChart.Series.Add(series2);
            this.OperationsChart.Size = new System.Drawing.Size(269, 178);
            this.OperationsChart.TabIndex = 3;
            this.OperationsChart.Text = "chart3";
            // 
            // InnovationsChart
            // 
            this.InnovationsChart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InnovationsChart.BackColor = System.Drawing.Color.Lavender;
            this.InnovationsChart.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.InnovationsChart.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.InnovationsChart.Legends.Add(legend3);
            this.InnovationsChart.Location = new System.Drawing.Point(874, 122);
            this.InnovationsChart.Name = "InnovationsChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "InnovationsSeries";
            this.InnovationsChart.Series.Add(series3);
            this.InnovationsChart.Size = new System.Drawing.Size(269, 178);
            this.InnovationsChart.TabIndex = 4;
            this.InnovationsChart.Text = "chart4";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.perspectivesToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1147, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateToolStripMenuItem,
            this.toolStripSeparator1,
            this.clearFormToolStripMenuItem,
            this.returnToMenuToolStripMenuItem,
            this.exitProgramToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.calculateToolStripMenuItem.Text = "Calculate";
            this.calculateToolStripMenuItem.Click += new System.EventHandler(this.calculateToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // clearFormToolStripMenuItem
            // 
            this.clearFormToolStripMenuItem.Name = "clearFormToolStripMenuItem";
            this.clearFormToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.clearFormToolStripMenuItem.Text = "Clear Form";
            this.clearFormToolStripMenuItem.Click += new System.EventHandler(this.clearFormToolStripMenuItem_Click);
            // 
            // returnToMenuToolStripMenuItem
            // 
            this.returnToMenuToolStripMenuItem.Name = "returnToMenuToolStripMenuItem";
            this.returnToMenuToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.returnToMenuToolStripMenuItem.Text = "Return to Menu";
            this.returnToMenuToolStripMenuItem.Click += new System.EventHandler(this.returnToMenuToolStripMenuItem_Click);
            // 
            // exitProgramToolStripMenuItem
            // 
            this.exitProgramToolStripMenuItem.Name = "exitProgramToolStripMenuItem";
            this.exitProgramToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.exitProgramToolStripMenuItem.Text = "Exit Program";
            this.exitProgramToolStripMenuItem.Click += new System.EventHandler(this.exitProgramToolStripMenuItem_Click);
            // 
            // perspectivesToolStripMenuItem
            // 
            this.perspectivesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eServicesToolStripMenuItem,
            this.financialAccountingToolStripMenuItem,
            this.materialsManagementToolStripMenuItem,
            this.productionToolStripMenuItem,
            this.customerServiceToolStripMenuItem,
            this.humanResourcesToolStripMenuItem,
            this.toolStripSeparator2,
            this.globalIntellToolStripMenuItem,
            this.toolStripSeparator3,
            this.sustainableIntelligencToolStripMenuItem});
            this.perspectivesToolStripMenuItem.Name = "perspectivesToolStripMenuItem";
            this.perspectivesToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.perspectivesToolStripMenuItem.Text = "Perspective";
            // 
            // eServicesToolStripMenuItem
            // 
            this.eServicesToolStripMenuItem.Name = "eServicesToolStripMenuItem";
            this.eServicesToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.eServicesToolStripMenuItem.Text = "E-Services";
            // 
            // financialAccountingToolStripMenuItem
            // 
            this.financialAccountingToolStripMenuItem.Name = "financialAccountingToolStripMenuItem";
            this.financialAccountingToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.financialAccountingToolStripMenuItem.Text = "Financial Accounting";
            // 
            // materialsManagementToolStripMenuItem
            // 
            this.materialsManagementToolStripMenuItem.Name = "materialsManagementToolStripMenuItem";
            this.materialsManagementToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.materialsManagementToolStripMenuItem.Text = "Materials Management";
            // 
            // productionToolStripMenuItem
            // 
            this.productionToolStripMenuItem.Name = "productionToolStripMenuItem";
            this.productionToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.productionToolStripMenuItem.Text = "Production";
            // 
            // customerServiceToolStripMenuItem
            // 
            this.customerServiceToolStripMenuItem.Name = "customerServiceToolStripMenuItem";
            this.customerServiceToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.customerServiceToolStripMenuItem.Text = "Customer Service";
            // 
            // humanResourcesToolStripMenuItem
            // 
            this.humanResourcesToolStripMenuItem.Name = "humanResourcesToolStripMenuItem";
            this.humanResourcesToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.humanResourcesToolStripMenuItem.Text = "Human Resources";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(203, 6);
            // 
            // globalIntellToolStripMenuItem
            // 
            this.globalIntellToolStripMenuItem.Name = "globalIntellToolStripMenuItem";
            this.globalIntellToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.globalIntellToolStripMenuItem.Text = "Global Intelligence";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(203, 6);
            // 
            // sustainableIntelligencToolStripMenuItem
            // 
            this.sustainableIntelligencToolStripMenuItem.Name = "sustainableIntelligencToolStripMenuItem";
            this.sustainableIntelligencToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.sustainableIntelligencToolStripMenuItem.Text = "Sustainability Intelligence";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selfHelpPDFToolStripMenuItem,
            this.contactToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // selfHelpPDFToolStripMenuItem
            // 
            this.selfHelpPDFToolStripMenuItem.Name = "selfHelpPDFToolStripMenuItem";
            this.selfHelpPDFToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.selfHelpPDFToolStripMenuItem.Text = "Self-Help PDF";
            this.selfHelpPDFToolStripMenuItem.Click += new System.EventHandler(this.selfHelpPDFToolStripMenuItem_Click);
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.contactToolStripMenuItem.Text = "Contact";
            this.contactToolStripMenuItem.Click += new System.EventHandler(this.contactToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // FinancialChart
            // 
            this.FinancialChart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FinancialChart.BackColor = System.Drawing.Color.Lavender;
            this.FinancialChart.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.FinancialChart.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "ChartArea1";
            this.FinancialChart.ChartAreas.Add(chartArea4);
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.FinancialChart.Legends.Add(legend4);
            this.FinancialChart.Location = new System.Drawing.Point(294, 122);
            this.FinancialChart.Name = "FinancialChart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid;
            series4.Legend = "Legend1";
            series4.Name = "FinancialSeries";
            this.FinancialChart.Series.Add(series4);
            this.FinancialChart.Size = new System.Drawing.Size(269, 178);
            this.FinancialChart.TabIndex = 2;
            this.FinancialChart.Text = "chart2";
            // 
            // lblBusinessProcessName
            // 
            this.lblBusinessProcessName.BackColor = System.Drawing.Color.Transparent;
            this.lblBusinessProcessName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBusinessProcessName.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusinessProcessName.ForeColor = System.Drawing.Color.Khaki;
            this.lblBusinessProcessName.Location = new System.Drawing.Point(0, 24);
            this.lblBusinessProcessName.Name = "lblBusinessProcessName";
            this.lblBusinessProcessName.Size = new System.Drawing.Size(1147, 63);
            this.lblBusinessProcessName.TabIndex = 6;
            this.lblBusinessProcessName.Text = "Stryker Management Dashboard";
            this.lblBusinessProcessName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblKPI1Name
            // 
            this.lblKPI1Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKPI1Name.BackColor = System.Drawing.Color.Transparent;
            this.lblKPI1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKPI1Name.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblKPI1Name.Location = new System.Drawing.Point(4, 84);
            this.lblKPI1Name.Name = "lblKPI1Name";
            this.lblKPI1Name.Size = new System.Drawing.Size(269, 37);
            this.lblKPI1Name.TabIndex = 18;
            this.lblKPI1Name.Text = "KPI Name";
            this.lblKPI1Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKPI2Name
            // 
            this.lblKPI2Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKPI2Name.BackColor = System.Drawing.Color.Transparent;
            this.lblKPI2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKPI2Name.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblKPI2Name.Location = new System.Drawing.Point(294, 84);
            this.lblKPI2Name.Name = "lblKPI2Name";
            this.lblKPI2Name.Size = new System.Drawing.Size(269, 37);
            this.lblKPI2Name.TabIndex = 19;
            this.lblKPI2Name.Text = "KPI Name";
            this.lblKPI2Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKPI3Name
            // 
            this.lblKPI3Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKPI3Name.BackColor = System.Drawing.Color.Transparent;
            this.lblKPI3Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKPI3Name.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblKPI3Name.Location = new System.Drawing.Point(584, 84);
            this.lblKPI3Name.Name = "lblKPI3Name";
            this.lblKPI3Name.Size = new System.Drawing.Size(269, 37);
            this.lblKPI3Name.TabIndex = 20;
            this.lblKPI3Name.Text = "KPI Name";
            this.lblKPI3Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKPI4Name
            // 
            this.lblKPI4Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKPI4Name.BackColor = System.Drawing.Color.Transparent;
            this.lblKPI4Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKPI4Name.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblKPI4Name.Location = new System.Drawing.Point(874, 84);
            this.lblKPI4Name.Name = "lblKPI4Name";
            this.lblKPI4Name.Size = new System.Drawing.Size(269, 37);
            this.lblKPI4Name.TabIndex = 21;
            this.lblKPI4Name.Text = "KPI Name";
            this.lblKPI4Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.BackColor = System.Drawing.Color.Transparent;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(40, 956);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(368, 20);
            this.label49.TabIndex = 23;
            this.label49.Text = "Building Medical Technology for a Healthier Society";
            // 
            // KPI1_tabPage
            // 
            this.KPI1_tabPage.BackColor = System.Drawing.Color.AliceBlue;
            this.KPI1_tabPage.BackgroundImage = global::StrykerEIP.Properties.Resources.G4WhiteToBrownGradient;
            this.KPI1_tabPage.Controls.Add(this.label54);
            this.KPI1_tabPage.Controls.Add(this.label44);
            this.KPI1_tabPage.Controls.Add(this.label43);
            this.KPI1_tabPage.Controls.Add(this.label42);
            this.KPI1_tabPage.Controls.Add(this.label34);
            this.KPI1_tabPage.Controls.Add(this.KPI1_lblDecisionFinal);
            this.KPI1_tabPage.Controls.Add(this.label53);
            this.KPI1_tabPage.Controls.Add(this.KPI1_lblResult);
            this.KPI1_tabPage.Controls.Add(this.label48);
            this.KPI1_tabPage.Controls.Add(this.label45);
            this.KPI1_tabPage.Controls.Add(this.KPI1_txtVar5);
            this.KPI1_tabPage.Controls.Add(this.KPI1_txtVar4);
            this.KPI1_tabPage.Controls.Add(this.KPI1_txtVar3);
            this.KPI1_tabPage.Controls.Add(this.KPI1_txtVar2);
            this.KPI1_tabPage.Controls.Add(this.KPI1_txtVar1);
            this.KPI1_tabPage.Controls.Add(this.KPI1_txtKPISummary);
            this.KPI1_tabPage.Controls.Add(this.KPI1_lblVar5);
            this.KPI1_tabPage.Controls.Add(this.KPI1_lblState);
            this.KPI1_tabPage.Controls.Add(this.KPI1_btnCalculate);
            this.KPI1_tabPage.Controls.Add(this.KPI1_lblVar4);
            this.KPI1_tabPage.Controls.Add(this.KPI1_lblVar3);
            this.KPI1_tabPage.Controls.Add(this.KPI1_lblVar2);
            this.KPI1_tabPage.Controls.Add(this.KPI1_lblVar1);
            this.KPI1_tabPage.Controls.Add(this.KPI1_btnSubmitDecision);
            this.KPI1_tabPage.Controls.Add(this.KPI1_groupDecision);
            this.KPI1_tabPage.Controls.Add(this.KPI1_lblDecisionLogo);
            this.KPI1_tabPage.Controls.Add(this.KPI1_lblStateLogo);
            this.KPI1_tabPage.Controls.Add(this.KPI1_lblCalculateLogo);
            this.KPI1_tabPage.Controls.Add(this.KPI1_lblSummaryLogo);
            this.KPI1_tabPage.Controls.Add(this.label2);
            this.KPI1_tabPage.Controls.Add(this.label1);
            this.KPI1_tabPage.Controls.Add(this.lblColumn1);
            this.KPI1_tabPage.Location = new System.Drawing.Point(4, 22);
            this.KPI1_tabPage.Name = "KPI1_tabPage";
            this.KPI1_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.KPI1_tabPage.Size = new System.Drawing.Size(1139, 275);
            this.KPI1_tabPage.TabIndex = 0;
            this.KPI1_tabPage.Text = "Customer";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.BackColor = System.Drawing.Color.Transparent;
            this.label54.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.Location = new System.Drawing.Point(549, 19);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(90, 17);
            this.label54.TabIndex = 67;
            this.label54.Text = "Expert System";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.Transparent;
            this.label44.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(986, 230);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(123, 37);
            this.label44.TabIndex = 66;
            this.label44.Text = "Wisdom";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.Color.Transparent;
            this.label43.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(754, 230);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(162, 37);
            this.label43.TabIndex = 65;
            this.label43.Text = "Knowledge";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.Color.Transparent;
            this.label42.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(557, 230);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(123, 37);
            this.label42.TabIndex = 64;
            this.label42.Text = "Concept";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(230, 230);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(258, 37);
            this.label34.TabIndex = 63;
            this.label34.Text = "Data - Information";
            // 
            // KPI1_lblDecisionFinal
            // 
            this.KPI1_lblDecisionFinal.BackColor = System.Drawing.Color.Transparent;
            this.KPI1_lblDecisionFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.KPI1_lblDecisionFinal.Location = new System.Drawing.Point(966, 42);
            this.KPI1_lblDecisionFinal.Name = "KPI1_lblDecisionFinal";
            this.KPI1_lblDecisionFinal.Size = new System.Drawing.Size(165, 172);
            this.KPI1_lblDecisionFinal.TabIndex = 57;
            this.KPI1_lblDecisionFinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.BackColor = System.Drawing.Color.Transparent;
            this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label53.Location = new System.Drawing.Point(962, 3);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(57, 17);
            this.label53.TabIndex = 56;
            this.label53.Text = "Choice";
            // 
            // KPI1_lblResult
            // 
            this.KPI1_lblResult.BackColor = System.Drawing.Color.Transparent;
            this.KPI1_lblResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KPI1_lblResult.Location = new System.Drawing.Point(548, 129);
            this.KPI1_lblResult.Name = "KPI1_lblResult";
            this.KPI1_lblResult.Size = new System.Drawing.Size(140, 90);
            this.KPI1_lblResult.TabIndex = 51;
            this.KPI1_lblResult.Text = "Result";
            this.KPI1_lblResult.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.KPI1_lblResult.Visible = false;
            // 
            // label48
            // 
            this.label48.BackColor = System.Drawing.Color.Silver;
            this.label48.Location = new System.Drawing.Point(953, -1);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(4, 285);
            this.label48.TabIndex = 50;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(1281, 264);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(45, 13);
            this.label45.TabIndex = 49;
            this.label45.Text = "Wisdom";
            // 
            // KPI1_txtVar5
            // 
            this.KPI1_txtVar5.Location = new System.Drawing.Point(313, 194);
            this.KPI1_txtVar5.Name = "KPI1_txtVar5";
            this.KPI1_txtVar5.Size = new System.Drawing.Size(130, 20);
            this.KPI1_txtVar5.TabIndex = 21;
            // 
            // KPI1_txtVar4
            // 
            this.KPI1_txtVar4.Location = new System.Drawing.Point(313, 153);
            this.KPI1_txtVar4.Name = "KPI1_txtVar4";
            this.KPI1_txtVar4.Size = new System.Drawing.Size(130, 20);
            this.KPI1_txtVar4.TabIndex = 13;
            // 
            // KPI1_txtVar3
            // 
            this.KPI1_txtVar3.Location = new System.Drawing.Point(313, 112);
            this.KPI1_txtVar3.Name = "KPI1_txtVar3";
            this.KPI1_txtVar3.Size = new System.Drawing.Size(130, 20);
            this.KPI1_txtVar3.TabIndex = 12;
            // 
            // KPI1_txtVar2
            // 
            this.KPI1_txtVar2.Location = new System.Drawing.Point(313, 71);
            this.KPI1_txtVar2.Name = "KPI1_txtVar2";
            this.KPI1_txtVar2.Size = new System.Drawing.Size(130, 20);
            this.KPI1_txtVar2.TabIndex = 11;
            // 
            // KPI1_txtVar1
            // 
            this.KPI1_txtVar1.Location = new System.Drawing.Point(313, 30);
            this.KPI1_txtVar1.Name = "KPI1_txtVar1";
            this.KPI1_txtVar1.ReadOnly = true;
            this.KPI1_txtVar1.Size = new System.Drawing.Size(130, 20);
            this.KPI1_txtVar1.TabIndex = 10;
            // 
            // KPI1_txtKPISummary
            // 
            this.KPI1_txtKPISummary.ForeColor = System.Drawing.Color.Black;
            this.KPI1_txtKPISummary.Location = new System.Drawing.Point(3, 23);
            this.KPI1_txtKPISummary.Name = "KPI1_txtKPISummary";
            this.KPI1_txtKPISummary.ReadOnly = true;
            this.KPI1_txtKPISummary.Size = new System.Drawing.Size(189, 252);
            this.KPI1_txtKPISummary.TabIndex = 3;
            this.KPI1_txtKPISummary.Text = "";
            // 
            // KPI1_lblVar5
            // 
            this.KPI1_lblVar5.AutoEllipsis = true;
            this.KPI1_lblVar5.BackColor = System.Drawing.Color.Transparent;
            this.KPI1_lblVar5.Location = new System.Drawing.Point(203, 194);
            this.KPI1_lblVar5.Name = "KPI1_lblVar5";
            this.KPI1_lblVar5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.KPI1_lblVar5.Size = new System.Drawing.Size(104, 36);
            this.KPI1_lblVar5.TabIndex = 20;
            this.KPI1_lblVar5.Text = "Variable 5";
            // 
            // KPI1_lblState
            // 
            this.KPI1_lblState.AutoSize = true;
            this.KPI1_lblState.BackColor = System.Drawing.Color.Transparent;
            this.KPI1_lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KPI1_lblState.Location = new System.Drawing.Point(539, 70);
            this.KPI1_lblState.Margin = new System.Windows.Forms.Padding(0);
            this.KPI1_lblState.Name = "KPI1_lblState";
            this.KPI1_lblState.Size = new System.Drawing.Size(114, 44);
            this.KPI1_lblState.TabIndex = 19;
            this.KPI1_lblState.Text = "State";
            this.KPI1_lblState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KPI1_lblState.Visible = false;
            // 
            // KPI1_btnCalculate
            // 
            this.KPI1_btnCalculate.BackColor = System.Drawing.Color.Ivory;
            this.KPI1_btnCalculate.Location = new System.Drawing.Point(450, 29);
            this.KPI1_btnCalculate.Name = "KPI1_btnCalculate";
            this.KPI1_btnCalculate.Size = new System.Drawing.Size(75, 185);
            this.KPI1_btnCalculate.TabIndex = 18;
            this.KPI1_btnCalculate.Text = "Calculate";
            this.KPI1_btnCalculate.UseVisualStyleBackColor = false;
            this.KPI1_btnCalculate.Click += new System.EventHandler(this.KPI_btnCalculate_Click);
            // 
            // KPI1_lblVar4
            // 
            this.KPI1_lblVar4.AutoEllipsis = true;
            this.KPI1_lblVar4.BackColor = System.Drawing.Color.Transparent;
            this.KPI1_lblVar4.Location = new System.Drawing.Point(203, 153);
            this.KPI1_lblVar4.Name = "KPI1_lblVar4";
            this.KPI1_lblVar4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.KPI1_lblVar4.Size = new System.Drawing.Size(104, 36);
            this.KPI1_lblVar4.TabIndex = 17;
            this.KPI1_lblVar4.Text = "Variable 4";
            // 
            // KPI1_lblVar3
            // 
            this.KPI1_lblVar3.AutoEllipsis = true;
            this.KPI1_lblVar3.BackColor = System.Drawing.Color.Transparent;
            this.KPI1_lblVar3.Location = new System.Drawing.Point(203, 112);
            this.KPI1_lblVar3.Name = "KPI1_lblVar3";
            this.KPI1_lblVar3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.KPI1_lblVar3.Size = new System.Drawing.Size(104, 36);
            this.KPI1_lblVar3.TabIndex = 16;
            this.KPI1_lblVar3.Text = "Variable 3";
            // 
            // KPI1_lblVar2
            // 
            this.KPI1_lblVar2.AutoEllipsis = true;
            this.KPI1_lblVar2.BackColor = System.Drawing.Color.Transparent;
            this.KPI1_lblVar2.Location = new System.Drawing.Point(203, 71);
            this.KPI1_lblVar2.Name = "KPI1_lblVar2";
            this.KPI1_lblVar2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.KPI1_lblVar2.Size = new System.Drawing.Size(104, 36);
            this.KPI1_lblVar2.TabIndex = 15;
            this.KPI1_lblVar2.Text = "Variable 2";
            // 
            // KPI1_lblVar1
            // 
            this.KPI1_lblVar1.AutoEllipsis = true;
            this.KPI1_lblVar1.BackColor = System.Drawing.Color.Transparent;
            this.KPI1_lblVar1.Location = new System.Drawing.Point(203, 30);
            this.KPI1_lblVar1.Name = "KPI1_lblVar1";
            this.KPI1_lblVar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.KPI1_lblVar1.Size = new System.Drawing.Size(104, 36);
            this.KPI1_lblVar1.TabIndex = 14;
            this.KPI1_lblVar1.Text = "Variable 1";
            // 
            // KPI1_btnSubmitDecision
            // 
            this.KPI1_btnSubmitDecision.BackColor = System.Drawing.Color.Ivory;
            this.KPI1_btnSubmitDecision.Location = new System.Drawing.Point(848, 185);
            this.KPI1_btnSubmitDecision.Name = "KPI1_btnSubmitDecision";
            this.KPI1_btnSubmitDecision.Size = new System.Drawing.Size(91, 39);
            this.KPI1_btnSubmitDecision.TabIndex = 9;
            this.KPI1_btnSubmitDecision.Text = "Submit Decision";
            this.KPI1_btnSubmitDecision.UseVisualStyleBackColor = false;
            this.KPI1_btnSubmitDecision.Visible = false;
            this.KPI1_btnSubmitDecision.Click += new System.EventHandler(this.KPI1_btnSubmitDecision_Click);
            // 
            // KPI1_groupDecision
            // 
            this.KPI1_groupDecision.BackColor = System.Drawing.Color.Transparent;
            this.KPI1_groupDecision.Controls.Add(this.KPI1_radioDecision3);
            this.KPI1_groupDecision.Controls.Add(this.KPI1_radioDecision2);
            this.KPI1_groupDecision.Controls.Add(this.KPI1_radioDecision1);
            this.KPI1_groupDecision.Location = new System.Drawing.Point(725, 23);
            this.KPI1_groupDecision.Name = "KPI1_groupDecision";
            this.KPI1_groupDecision.Size = new System.Drawing.Size(224, 156);
            this.KPI1_groupDecision.TabIndex = 8;
            this.KPI1_groupDecision.TabStop = false;
            this.KPI1_groupDecision.Visible = false;
            // 
            // KPI1_radioDecision3
            // 
            this.KPI1_radioDecision3.Location = new System.Drawing.Point(7, 108);
            this.KPI1_radioDecision3.Name = "KPI1_radioDecision3";
            this.KPI1_radioDecision3.Size = new System.Drawing.Size(200, 40);
            this.KPI1_radioDecision3.TabIndex = 2;
            this.KPI1_radioDecision3.TabStop = true;
            this.KPI1_radioDecision3.Text = "Choice 3";
            this.KPI1_radioDecision3.UseVisualStyleBackColor = true;
            // 
            // KPI1_radioDecision2
            // 
            this.KPI1_radioDecision2.Location = new System.Drawing.Point(7, 63);
            this.KPI1_radioDecision2.Name = "KPI1_radioDecision2";
            this.KPI1_radioDecision2.Size = new System.Drawing.Size(200, 40);
            this.KPI1_radioDecision2.TabIndex = 1;
            this.KPI1_radioDecision2.TabStop = true;
            this.KPI1_radioDecision2.Text = "Choice 2";
            this.KPI1_radioDecision2.UseVisualStyleBackColor = true;
            // 
            // KPI1_radioDecision1
            // 
            this.KPI1_radioDecision1.Location = new System.Drawing.Point(7, 20);
            this.KPI1_radioDecision1.Name = "KPI1_radioDecision1";
            this.KPI1_radioDecision1.Size = new System.Drawing.Size(200, 40);
            this.KPI1_radioDecision1.TabIndex = 0;
            this.KPI1_radioDecision1.TabStop = true;
            this.KPI1_radioDecision1.Text = "Choice 1";
            this.KPI1_radioDecision1.UseVisualStyleBackColor = true;
            // 
            // KPI1_lblDecisionLogo
            // 
            this.KPI1_lblDecisionLogo.AutoSize = true;
            this.KPI1_lblDecisionLogo.BackColor = System.Drawing.Color.Transparent;
            this.KPI1_lblDecisionLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.KPI1_lblDecisionLogo.Location = new System.Drawing.Point(724, 3);
            this.KPI1_lblDecisionLogo.Name = "KPI1_lblDecisionLogo";
            this.KPI1_lblDecisionLogo.Size = new System.Drawing.Size(202, 17);
            this.KPI1_lblDecisionLogo.TabIndex = 7;
            this.KPI1_lblDecisionLogo.Text = "Business Knowledge Rules";
            // 
            // KPI1_lblStateLogo
            // 
            this.KPI1_lblStateLogo.AutoSize = true;
            this.KPI1_lblStateLogo.BackColor = System.Drawing.Color.Transparent;
            this.KPI1_lblStateLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.KPI1_lblStateLogo.Location = new System.Drawing.Point(539, 3);
            this.KPI1_lblStateLogo.Name = "KPI1_lblStateLogo";
            this.KPI1_lblStateLogo.Size = new System.Drawing.Size(117, 17);
            this.KPI1_lblStateLogo.TabIndex = 6;
            this.KPI1_lblStateLogo.Text = "State of Affairs";
            // 
            // KPI1_lblCalculateLogo
            // 
            this.KPI1_lblCalculateLogo.AutoSize = true;
            this.KPI1_lblCalculateLogo.BackColor = System.Drawing.Color.Transparent;
            this.KPI1_lblCalculateLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.KPI1_lblCalculateLogo.Location = new System.Drawing.Point(203, 3);
            this.KPI1_lblCalculateLogo.Name = "KPI1_lblCalculateLogo";
            this.KPI1_lblCalculateLogo.Size = new System.Drawing.Size(63, 17);
            this.KPI1_lblCalculateLogo.TabIndex = 5;
            this.KPI1_lblCalculateLogo.Text = "Change";
            // 
            // KPI1_lblSummaryLogo
            // 
            this.KPI1_lblSummaryLogo.AutoSize = true;
            this.KPI1_lblSummaryLogo.BackColor = System.Drawing.Color.Transparent;
            this.KPI1_lblSummaryLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.KPI1_lblSummaryLogo.Location = new System.Drawing.Point(6, 3);
            this.KPI1_lblSummaryLogo.Name = "KPI1_lblSummaryLogo";
            this.KPI1_lblSummaryLogo.Size = new System.Drawing.Size(103, 17);
            this.KPI1_lblSummaryLogo.TabIndex = 4;
            this.KPI1_lblSummaryLogo.Text = "KPI Summary";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(716, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(4, 285);
            this.label2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(531, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(4, 285);
            this.label1.TabIndex = 1;
            // 
            // lblColumn1
            // 
            this.lblColumn1.BackColor = System.Drawing.Color.Silver;
            this.lblColumn1.Location = new System.Drawing.Point(196, 0);
            this.lblColumn1.Name = "lblColumn1";
            this.lblColumn1.Size = new System.Drawing.Size(4, 285);
            this.lblColumn1.TabIndex = 0;
            // 
            // KPI4_txtKPISummary
            // 
            this.KPI4_txtKPISummary.Controls.Add(this.KPI1_tabPage);
            this.KPI4_txtKPISummary.Controls.Add(this.KPI2_tabPage);
            this.KPI4_txtKPISummary.Controls.Add(this.KPI3_tabPage);
            this.KPI4_txtKPISummary.Controls.Add(this.KPI4_tabPage);
            this.KPI4_txtKPISummary.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.KPI4_txtKPISummary.Location = new System.Drawing.Point(0, 301);
            this.KPI4_txtKPISummary.Name = "KPI4_txtKPISummary";
            this.KPI4_txtKPISummary.SelectedIndex = 0;
            this.KPI4_txtKPISummary.Size = new System.Drawing.Size(1147, 301);
            this.KPI4_txtKPISummary.TabIndex = 0;
            // 
            // KPI2_tabPage
            // 
            this.KPI2_tabPage.BackColor = System.Drawing.Color.AliceBlue;
            this.KPI2_tabPage.BackgroundImage = global::StrykerEIP.Properties.Resources.G4WhiteToBrownGradient;
            this.KPI2_tabPage.Controls.Add(this.label3);
            this.KPI2_tabPage.Controls.Add(this.label4);
            this.KPI2_tabPage.Controls.Add(this.label5);
            this.KPI2_tabPage.Controls.Add(this.label6);
            this.KPI2_tabPage.Controls.Add(this.label7);
            this.KPI2_tabPage.Controls.Add(this.KPI2_lblDecisionFinal);
            this.KPI2_tabPage.Controls.Add(this.label16);
            this.KPI2_tabPage.Controls.Add(this.KPI2_lblResult);
            this.KPI2_tabPage.Controls.Add(this.label36);
            this.KPI2_tabPage.Controls.Add(this.label37);
            this.KPI2_tabPage.Controls.Add(this.KPI2_txtVar5);
            this.KPI2_tabPage.Controls.Add(this.KPI2_txtVar4);
            this.KPI2_tabPage.Controls.Add(this.KPI2_txtVar3);
            this.KPI2_tabPage.Controls.Add(this.KPI2_txtVar2);
            this.KPI2_tabPage.Controls.Add(this.KPI2_txtVar1);
            this.KPI2_tabPage.Controls.Add(this.KPI2_txtKPISummary);
            this.KPI2_tabPage.Controls.Add(this.KPI2_lblVar5);
            this.KPI2_tabPage.Controls.Add(this.KPI2_lblState);
            this.KPI2_tabPage.Controls.Add(this.KPI2_btnCalculate);
            this.KPI2_tabPage.Controls.Add(this.KPI2_lblVar4);
            this.KPI2_tabPage.Controls.Add(this.KPI2_lblVar3);
            this.KPI2_tabPage.Controls.Add(this.KPI2_lblVar2);
            this.KPI2_tabPage.Controls.Add(this.KPI2_lblVar1);
            this.KPI2_tabPage.Controls.Add(this.KPI2_btnSubmitDecision);
            this.KPI2_tabPage.Controls.Add(this.KPI2_groupDecision);
            this.KPI2_tabPage.Controls.Add(this.label57);
            this.KPI2_tabPage.Controls.Add(this.label58);
            this.KPI2_tabPage.Controls.Add(this.label59);
            this.KPI2_tabPage.Controls.Add(this.label60);
            this.KPI2_tabPage.Controls.Add(this.label61);
            this.KPI2_tabPage.Controls.Add(this.label62);
            this.KPI2_tabPage.Controls.Add(this.label63);
            this.KPI2_tabPage.Location = new System.Drawing.Point(4, 22);
            this.KPI2_tabPage.Name = "KPI2_tabPage";
            this.KPI2_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.KPI2_tabPage.Size = new System.Drawing.Size(1139, 275);
            this.KPI2_tabPage.TabIndex = 3;
            this.KPI2_tabPage.Text = "Financial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(549, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 67;
            this.label3.Text = "Expert System";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(986, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 37);
            this.label4.TabIndex = 66;
            this.label4.Text = "Wisdom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(754, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 37);
            this.label5.TabIndex = 65;
            this.label5.Text = "Knowledge";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(557, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 37);
            this.label6.TabIndex = 64;
            this.label6.Text = "Concept";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(230, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(258, 37);
            this.label7.TabIndex = 63;
            this.label7.Text = "Data - Information";
            // 
            // KPI2_lblDecisionFinal
            // 
            this.KPI2_lblDecisionFinal.BackColor = System.Drawing.Color.Transparent;
            this.KPI2_lblDecisionFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.KPI2_lblDecisionFinal.Location = new System.Drawing.Point(966, 42);
            this.KPI2_lblDecisionFinal.Name = "KPI2_lblDecisionFinal";
            this.KPI2_lblDecisionFinal.Size = new System.Drawing.Size(165, 172);
            this.KPI2_lblDecisionFinal.TabIndex = 57;
            this.KPI2_lblDecisionFinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(962, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 17);
            this.label16.TabIndex = 56;
            this.label16.Text = "Choice";
            // 
            // KPI2_lblResult
            // 
            this.KPI2_lblResult.BackColor = System.Drawing.Color.Transparent;
            this.KPI2_lblResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KPI2_lblResult.Location = new System.Drawing.Point(548, 129);
            this.KPI2_lblResult.Name = "KPI2_lblResult";
            this.KPI2_lblResult.Size = new System.Drawing.Size(140, 90);
            this.KPI2_lblResult.TabIndex = 51;
            this.KPI2_lblResult.Text = "Result";
            this.KPI2_lblResult.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.KPI2_lblResult.Visible = false;
            // 
            // label36
            // 
            this.label36.BackColor = System.Drawing.Color.Silver;
            this.label36.Location = new System.Drawing.Point(953, -1);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(4, 285);
            this.label36.TabIndex = 50;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(1281, 264);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(45, 13);
            this.label37.TabIndex = 49;
            this.label37.Text = "Wisdom";
            // 
            // KPI2_txtVar5
            // 
            this.KPI2_txtVar5.Location = new System.Drawing.Point(313, 194);
            this.KPI2_txtVar5.Name = "KPI2_txtVar5";
            this.KPI2_txtVar5.Size = new System.Drawing.Size(130, 20);
            this.KPI2_txtVar5.TabIndex = 21;
            // 
            // KPI2_txtVar4
            // 
            this.KPI2_txtVar4.Location = new System.Drawing.Point(313, 153);
            this.KPI2_txtVar4.Name = "KPI2_txtVar4";
            this.KPI2_txtVar4.Size = new System.Drawing.Size(130, 20);
            this.KPI2_txtVar4.TabIndex = 13;
            // 
            // KPI2_txtVar3
            // 
            this.KPI2_txtVar3.Location = new System.Drawing.Point(313, 112);
            this.KPI2_txtVar3.Name = "KPI2_txtVar3";
            this.KPI2_txtVar3.Size = new System.Drawing.Size(130, 20);
            this.KPI2_txtVar3.TabIndex = 12;
            // 
            // KPI2_txtVar2
            // 
            this.KPI2_txtVar2.Location = new System.Drawing.Point(313, 71);
            this.KPI2_txtVar2.Name = "KPI2_txtVar2";
            this.KPI2_txtVar2.Size = new System.Drawing.Size(130, 20);
            this.KPI2_txtVar2.TabIndex = 11;
            // 
            // KPI2_txtVar1
            // 
            this.KPI2_txtVar1.Location = new System.Drawing.Point(313, 30);
            this.KPI2_txtVar1.Name = "KPI2_txtVar1";
            this.KPI2_txtVar1.ReadOnly = true;
            this.KPI2_txtVar1.Size = new System.Drawing.Size(130, 20);
            this.KPI2_txtVar1.TabIndex = 10;
            // 
            // KPI2_txtKPISummary
            // 
            this.KPI2_txtKPISummary.ForeColor = System.Drawing.Color.Black;
            this.KPI2_txtKPISummary.Location = new System.Drawing.Point(3, 23);
            this.KPI2_txtKPISummary.Name = "KPI2_txtKPISummary";
            this.KPI2_txtKPISummary.ReadOnly = true;
            this.KPI2_txtKPISummary.Size = new System.Drawing.Size(189, 252);
            this.KPI2_txtKPISummary.TabIndex = 3;
            this.KPI2_txtKPISummary.Text = "";
            // 
            // KPI2_lblVar5
            // 
            this.KPI2_lblVar5.AutoEllipsis = true;
            this.KPI2_lblVar5.BackColor = System.Drawing.Color.Transparent;
            this.KPI2_lblVar5.Location = new System.Drawing.Point(203, 194);
            this.KPI2_lblVar5.Name = "KPI2_lblVar5";
            this.KPI2_lblVar5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.KPI2_lblVar5.Size = new System.Drawing.Size(104, 36);
            this.KPI2_lblVar5.TabIndex = 20;
            this.KPI2_lblVar5.Text = "Variable 5";
            // 
            // KPI2_lblState
            // 
            this.KPI2_lblState.AutoSize = true;
            this.KPI2_lblState.BackColor = System.Drawing.Color.Transparent;
            this.KPI2_lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KPI2_lblState.Location = new System.Drawing.Point(539, 70);
            this.KPI2_lblState.Margin = new System.Windows.Forms.Padding(0);
            this.KPI2_lblState.Name = "KPI2_lblState";
            this.KPI2_lblState.Size = new System.Drawing.Size(114, 44);
            this.KPI2_lblState.TabIndex = 19;
            this.KPI2_lblState.Text = "State";
            this.KPI2_lblState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KPI2_lblState.Visible = false;
            // 
            // KPI2_btnCalculate
            // 
            this.KPI2_btnCalculate.BackColor = System.Drawing.Color.Ivory;
            this.KPI2_btnCalculate.Location = new System.Drawing.Point(450, 29);
            this.KPI2_btnCalculate.Name = "KPI2_btnCalculate";
            this.KPI2_btnCalculate.Size = new System.Drawing.Size(75, 185);
            this.KPI2_btnCalculate.TabIndex = 18;
            this.KPI2_btnCalculate.Text = "Calculate";
            this.KPI2_btnCalculate.UseVisualStyleBackColor = false;
            // 
            // KPI2_lblVar4
            // 
            this.KPI2_lblVar4.AutoEllipsis = true;
            this.KPI2_lblVar4.BackColor = System.Drawing.Color.Transparent;
            this.KPI2_lblVar4.Location = new System.Drawing.Point(203, 153);
            this.KPI2_lblVar4.Name = "KPI2_lblVar4";
            this.KPI2_lblVar4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.KPI2_lblVar4.Size = new System.Drawing.Size(104, 36);
            this.KPI2_lblVar4.TabIndex = 17;
            this.KPI2_lblVar4.Text = "Variable 4";
            // 
            // KPI2_lblVar3
            // 
            this.KPI2_lblVar3.AutoEllipsis = true;
            this.KPI2_lblVar3.BackColor = System.Drawing.Color.Transparent;
            this.KPI2_lblVar3.Location = new System.Drawing.Point(203, 112);
            this.KPI2_lblVar3.Name = "KPI2_lblVar3";
            this.KPI2_lblVar3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.KPI2_lblVar3.Size = new System.Drawing.Size(104, 36);
            this.KPI2_lblVar3.TabIndex = 16;
            this.KPI2_lblVar3.Text = "Variable 3";
            // 
            // KPI2_lblVar2
            // 
            this.KPI2_lblVar2.AutoEllipsis = true;
            this.KPI2_lblVar2.BackColor = System.Drawing.Color.Transparent;
            this.KPI2_lblVar2.Location = new System.Drawing.Point(203, 71);
            this.KPI2_lblVar2.Name = "KPI2_lblVar2";
            this.KPI2_lblVar2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.KPI2_lblVar2.Size = new System.Drawing.Size(104, 36);
            this.KPI2_lblVar2.TabIndex = 15;
            this.KPI2_lblVar2.Text = "Variable 2";
            // 
            // KPI2_lblVar1
            // 
            this.KPI2_lblVar1.AutoEllipsis = true;
            this.KPI2_lblVar1.BackColor = System.Drawing.Color.Transparent;
            this.KPI2_lblVar1.Location = new System.Drawing.Point(203, 30);
            this.KPI2_lblVar1.Name = "KPI2_lblVar1";
            this.KPI2_lblVar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.KPI2_lblVar1.Size = new System.Drawing.Size(104, 36);
            this.KPI2_lblVar1.TabIndex = 14;
            this.KPI2_lblVar1.Text = "Variable 1";
            // 
            // KPI2_btnSubmitDecision
            // 
            this.KPI2_btnSubmitDecision.BackColor = System.Drawing.Color.Ivory;
            this.KPI2_btnSubmitDecision.Location = new System.Drawing.Point(848, 185);
            this.KPI2_btnSubmitDecision.Name = "KPI2_btnSubmitDecision";
            this.KPI2_btnSubmitDecision.Size = new System.Drawing.Size(91, 39);
            this.KPI2_btnSubmitDecision.TabIndex = 9;
            this.KPI2_btnSubmitDecision.Text = "Submit Decision";
            this.KPI2_btnSubmitDecision.UseVisualStyleBackColor = false;
            this.KPI2_btnSubmitDecision.Visible = false;
            // 
            // KPI2_groupDecision
            // 
            this.KPI2_groupDecision.BackColor = System.Drawing.Color.Transparent;
            this.KPI2_groupDecision.Controls.Add(this.KPI2_radioDecision3);
            this.KPI2_groupDecision.Controls.Add(this.KPI2_radioDecision2);
            this.KPI2_groupDecision.Controls.Add(this.KPI2_radioDecision1);
            this.KPI2_groupDecision.Location = new System.Drawing.Point(725, 23);
            this.KPI2_groupDecision.Name = "KPI2_groupDecision";
            this.KPI2_groupDecision.Size = new System.Drawing.Size(224, 156);
            this.KPI2_groupDecision.TabIndex = 8;
            this.KPI2_groupDecision.TabStop = false;
            this.KPI2_groupDecision.Visible = false;
            // 
            // KPI2_radioDecision3
            // 
            this.KPI2_radioDecision3.Location = new System.Drawing.Point(7, 108);
            this.KPI2_radioDecision3.Name = "KPI2_radioDecision3";
            this.KPI2_radioDecision3.Size = new System.Drawing.Size(200, 40);
            this.KPI2_radioDecision3.TabIndex = 2;
            this.KPI2_radioDecision3.TabStop = true;
            this.KPI2_radioDecision3.Text = "Choice 3";
            this.KPI2_radioDecision3.UseVisualStyleBackColor = true;
            // 
            // KPI2_radioDecision2
            // 
            this.KPI2_radioDecision2.Location = new System.Drawing.Point(7, 63);
            this.KPI2_radioDecision2.Name = "KPI2_radioDecision2";
            this.KPI2_radioDecision2.Size = new System.Drawing.Size(200, 40);
            this.KPI2_radioDecision2.TabIndex = 1;
            this.KPI2_radioDecision2.TabStop = true;
            this.KPI2_radioDecision2.Text = "Choice 2";
            this.KPI2_radioDecision2.UseVisualStyleBackColor = true;
            // 
            // KPI2_radioDecision1
            // 
            this.KPI2_radioDecision1.Location = new System.Drawing.Point(7, 20);
            this.KPI2_radioDecision1.Name = "KPI2_radioDecision1";
            this.KPI2_radioDecision1.Size = new System.Drawing.Size(200, 40);
            this.KPI2_radioDecision1.TabIndex = 0;
            this.KPI2_radioDecision1.TabStop = true;
            this.KPI2_radioDecision1.Text = "Choice 1";
            this.KPI2_radioDecision1.UseVisualStyleBackColor = true;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.BackColor = System.Drawing.Color.Transparent;
            this.label57.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label57.Location = new System.Drawing.Point(724, 3);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(202, 17);
            this.label57.TabIndex = 7;
            this.label57.Text = "Business Knowledge Rules";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.BackColor = System.Drawing.Color.Transparent;
            this.label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label58.Location = new System.Drawing.Point(539, 3);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(117, 17);
            this.label58.TabIndex = 6;
            this.label58.Text = "State of Affairs";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.BackColor = System.Drawing.Color.Transparent;
            this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label59.Location = new System.Drawing.Point(203, 3);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(63, 17);
            this.label59.TabIndex = 5;
            this.label59.Text = "Change";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.BackColor = System.Drawing.Color.Transparent;
            this.label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label60.Location = new System.Drawing.Point(6, 3);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(103, 17);
            this.label60.TabIndex = 4;
            this.label60.Text = "KPI Summary";
            // 
            // label61
            // 
            this.label61.BackColor = System.Drawing.Color.Silver;
            this.label61.Location = new System.Drawing.Point(716, 0);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(4, 285);
            this.label61.TabIndex = 2;
            // 
            // label62
            // 
            this.label62.BackColor = System.Drawing.Color.Silver;
            this.label62.Location = new System.Drawing.Point(531, 0);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(4, 285);
            this.label62.TabIndex = 1;
            // 
            // label63
            // 
            this.label63.BackColor = System.Drawing.Color.Silver;
            this.label63.Location = new System.Drawing.Point(196, 0);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(4, 285);
            this.label63.TabIndex = 0;
            // 
            // KPI3_tabPage
            // 
            this.KPI3_tabPage.BackColor = System.Drawing.Color.AliceBlue;
            this.KPI3_tabPage.BackgroundImage = global::StrykerEIP.Properties.Resources.G4WhiteToBrownGradient;
            this.KPI3_tabPage.Controls.Add(this.label9);
            this.KPI3_tabPage.Controls.Add(this.label10);
            this.KPI3_tabPage.Controls.Add(this.label11);
            this.KPI3_tabPage.Controls.Add(this.label12);
            this.KPI3_tabPage.Controls.Add(this.label13);
            this.KPI3_tabPage.Controls.Add(this.KPI3_lblDecisionFinal);
            this.KPI3_tabPage.Controls.Add(this.label15);
            this.KPI3_tabPage.Controls.Add(this.KPI3_lblResult);
            this.KPI3_tabPage.Controls.Add(this.label18);
            this.KPI3_tabPage.Controls.Add(this.label19);
            this.KPI3_tabPage.Controls.Add(this.KPI3_txtVar5);
            this.KPI3_tabPage.Controls.Add(this.KPI3_txtVar4);
            this.KPI3_tabPage.Controls.Add(this.KPI3_txtVar3);
            this.KPI3_tabPage.Controls.Add(this.KPI3_txtVar2);
            this.KPI3_tabPage.Controls.Add(this.KPI3_txtVar1);
            this.KPI3_tabPage.Controls.Add(this.KPI3_txtKPISummary);
            this.KPI3_tabPage.Controls.Add(this.KPI3_lblVar5);
            this.KPI3_tabPage.Controls.Add(this.KPI3_lblState);
            this.KPI3_tabPage.Controls.Add(this.KPI3_btnCalculate);
            this.KPI3_tabPage.Controls.Add(this.KPI3_lblVar4);
            this.KPI3_tabPage.Controls.Add(this.KPI3_lblVar3);
            this.KPI3_tabPage.Controls.Add(this.KPI3_lblVar2);
            this.KPI3_tabPage.Controls.Add(this.KPI3_lblVar1);
            this.KPI3_tabPage.Controls.Add(this.KPI3_btnSubmitDecision);
            this.KPI3_tabPage.Controls.Add(this.KPI3_groupDecision);
            this.KPI3_tabPage.Controls.Add(this.label26);
            this.KPI3_tabPage.Controls.Add(this.label27);
            this.KPI3_tabPage.Controls.Add(this.label28);
            this.KPI3_tabPage.Controls.Add(this.label29);
            this.KPI3_tabPage.Controls.Add(this.label30);
            this.KPI3_tabPage.Controls.Add(this.label31);
            this.KPI3_tabPage.Controls.Add(this.label32);
            this.KPI3_tabPage.Location = new System.Drawing.Point(4, 22);
            this.KPI3_tabPage.Name = "KPI3_tabPage";
            this.KPI3_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.KPI3_tabPage.Size = new System.Drawing.Size(1139, 275);
            this.KPI3_tabPage.TabIndex = 4;
            this.KPI3_tabPage.Text = "Operations";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(549, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 17);
            this.label9.TabIndex = 67;
            this.label9.Text = "Expert System";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(986, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 37);
            this.label10.TabIndex = 66;
            this.label10.Text = "Wisdom";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(754, 230);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 37);
            this.label11.TabIndex = 65;
            this.label11.Text = "Knowledge";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(557, 230);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 37);
            this.label12.TabIndex = 64;
            this.label12.Text = "Concept";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(230, 230);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(258, 37);
            this.label13.TabIndex = 63;
            this.label13.Text = "Data - Information";
            // 
            // KPI3_lblDecisionFinal
            // 
            this.KPI3_lblDecisionFinal.BackColor = System.Drawing.Color.Transparent;
            this.KPI3_lblDecisionFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.KPI3_lblDecisionFinal.Location = new System.Drawing.Point(966, 42);
            this.KPI3_lblDecisionFinal.Name = "KPI3_lblDecisionFinal";
            this.KPI3_lblDecisionFinal.Size = new System.Drawing.Size(165, 172);
            this.KPI3_lblDecisionFinal.TabIndex = 57;
            this.KPI3_lblDecisionFinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(962, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 17);
            this.label15.TabIndex = 56;
            this.label15.Text = "Choice";
            // 
            // KPI3_lblResult
            // 
            this.KPI3_lblResult.BackColor = System.Drawing.Color.Transparent;
            this.KPI3_lblResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KPI3_lblResult.Location = new System.Drawing.Point(548, 129);
            this.KPI3_lblResult.Name = "KPI3_lblResult";
            this.KPI3_lblResult.Size = new System.Drawing.Size(140, 90);
            this.KPI3_lblResult.TabIndex = 51;
            this.KPI3_lblResult.Text = "Result";
            this.KPI3_lblResult.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.KPI3_lblResult.Visible = false;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Silver;
            this.label18.Location = new System.Drawing.Point(953, -1);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(4, 285);
            this.label18.TabIndex = 50;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1281, 264);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 13);
            this.label19.TabIndex = 49;
            this.label19.Text = "Wisdom";
            // 
            // KPI3_txtVar5
            // 
            this.KPI3_txtVar5.Location = new System.Drawing.Point(313, 194);
            this.KPI3_txtVar5.Name = "KPI3_txtVar5";
            this.KPI3_txtVar5.Size = new System.Drawing.Size(130, 20);
            this.KPI3_txtVar5.TabIndex = 21;
            // 
            // KPI3_txtVar4
            // 
            this.KPI3_txtVar4.Location = new System.Drawing.Point(313, 153);
            this.KPI3_txtVar4.Name = "KPI3_txtVar4";
            this.KPI3_txtVar4.Size = new System.Drawing.Size(130, 20);
            this.KPI3_txtVar4.TabIndex = 13;
            // 
            // KPI3_txtVar3
            // 
            this.KPI3_txtVar3.Location = new System.Drawing.Point(313, 112);
            this.KPI3_txtVar3.Name = "KPI3_txtVar3";
            this.KPI3_txtVar3.Size = new System.Drawing.Size(130, 20);
            this.KPI3_txtVar3.TabIndex = 12;
            // 
            // KPI3_txtVar2
            // 
            this.KPI3_txtVar2.Location = new System.Drawing.Point(313, 71);
            this.KPI3_txtVar2.Name = "KPI3_txtVar2";
            this.KPI3_txtVar2.Size = new System.Drawing.Size(130, 20);
            this.KPI3_txtVar2.TabIndex = 11;
            // 
            // KPI3_txtVar1
            // 
            this.KPI3_txtVar1.Location = new System.Drawing.Point(313, 30);
            this.KPI3_txtVar1.Name = "KPI3_txtVar1";
            this.KPI3_txtVar1.ReadOnly = true;
            this.KPI3_txtVar1.Size = new System.Drawing.Size(130, 20);
            this.KPI3_txtVar1.TabIndex = 10;
            // 
            // KPI3_txtKPISummary
            // 
            this.KPI3_txtKPISummary.ForeColor = System.Drawing.Color.Black;
            this.KPI3_txtKPISummary.Location = new System.Drawing.Point(3, 23);
            this.KPI3_txtKPISummary.Name = "KPI3_txtKPISummary";
            this.KPI3_txtKPISummary.ReadOnly = true;
            this.KPI3_txtKPISummary.Size = new System.Drawing.Size(189, 252);
            this.KPI3_txtKPISummary.TabIndex = 3;
            this.KPI3_txtKPISummary.Text = "";
            // 
            // KPI3_lblVar5
            // 
            this.KPI3_lblVar5.AutoEllipsis = true;
            this.KPI3_lblVar5.BackColor = System.Drawing.Color.Transparent;
            this.KPI3_lblVar5.Location = new System.Drawing.Point(203, 194);
            this.KPI3_lblVar5.Name = "KPI3_lblVar5";
            this.KPI3_lblVar5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.KPI3_lblVar5.Size = new System.Drawing.Size(104, 36);
            this.KPI3_lblVar5.TabIndex = 20;
            this.KPI3_lblVar5.Text = "Variable 5";
            // 
            // KPI3_lblState
            // 
            this.KPI3_lblState.AutoSize = true;
            this.KPI3_lblState.BackColor = System.Drawing.Color.Transparent;
            this.KPI3_lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KPI3_lblState.Location = new System.Drawing.Point(539, 70);
            this.KPI3_lblState.Margin = new System.Windows.Forms.Padding(0);
            this.KPI3_lblState.Name = "KPI3_lblState";
            this.KPI3_lblState.Size = new System.Drawing.Size(114, 44);
            this.KPI3_lblState.TabIndex = 19;
            this.KPI3_lblState.Text = "State";
            this.KPI3_lblState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KPI3_lblState.Visible = false;
            // 
            // KPI3_btnCalculate
            // 
            this.KPI3_btnCalculate.BackColor = System.Drawing.Color.Ivory;
            this.KPI3_btnCalculate.Location = new System.Drawing.Point(450, 29);
            this.KPI3_btnCalculate.Name = "KPI3_btnCalculate";
            this.KPI3_btnCalculate.Size = new System.Drawing.Size(75, 185);
            this.KPI3_btnCalculate.TabIndex = 18;
            this.KPI3_btnCalculate.Text = "Calculate";
            this.KPI3_btnCalculate.UseVisualStyleBackColor = false;
            // 
            // KPI3_lblVar4
            // 
            this.KPI3_lblVar4.AutoEllipsis = true;
            this.KPI3_lblVar4.BackColor = System.Drawing.Color.Transparent;
            this.KPI3_lblVar4.Location = new System.Drawing.Point(203, 153);
            this.KPI3_lblVar4.Name = "KPI3_lblVar4";
            this.KPI3_lblVar4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.KPI3_lblVar4.Size = new System.Drawing.Size(104, 36);
            this.KPI3_lblVar4.TabIndex = 17;
            this.KPI3_lblVar4.Text = "Variable 4";
            // 
            // KPI3_lblVar3
            // 
            this.KPI3_lblVar3.AutoEllipsis = true;
            this.KPI3_lblVar3.BackColor = System.Drawing.Color.Transparent;
            this.KPI3_lblVar3.Location = new System.Drawing.Point(203, 112);
            this.KPI3_lblVar3.Name = "KPI3_lblVar3";
            this.KPI3_lblVar3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.KPI3_lblVar3.Size = new System.Drawing.Size(104, 36);
            this.KPI3_lblVar3.TabIndex = 16;
            this.KPI3_lblVar3.Text = "Variable 3";
            // 
            // KPI3_lblVar2
            // 
            this.KPI3_lblVar2.AutoEllipsis = true;
            this.KPI3_lblVar2.BackColor = System.Drawing.Color.Transparent;
            this.KPI3_lblVar2.Location = new System.Drawing.Point(203, 71);
            this.KPI3_lblVar2.Name = "KPI3_lblVar2";
            this.KPI3_lblVar2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.KPI3_lblVar2.Size = new System.Drawing.Size(104, 36);
            this.KPI3_lblVar2.TabIndex = 15;
            this.KPI3_lblVar2.Text = "Variable 2";
            // 
            // KPI3_lblVar1
            // 
            this.KPI3_lblVar1.AutoEllipsis = true;
            this.KPI3_lblVar1.BackColor = System.Drawing.Color.Transparent;
            this.KPI3_lblVar1.Location = new System.Drawing.Point(203, 30);
            this.KPI3_lblVar1.Name = "KPI3_lblVar1";
            this.KPI3_lblVar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.KPI3_lblVar1.Size = new System.Drawing.Size(104, 36);
            this.KPI3_lblVar1.TabIndex = 14;
            this.KPI3_lblVar1.Text = "Variable 1";
            // 
            // KPI3_btnSubmitDecision
            // 
            this.KPI3_btnSubmitDecision.BackColor = System.Drawing.Color.Ivory;
            this.KPI3_btnSubmitDecision.Location = new System.Drawing.Point(848, 185);
            this.KPI3_btnSubmitDecision.Name = "KPI3_btnSubmitDecision";
            this.KPI3_btnSubmitDecision.Size = new System.Drawing.Size(91, 39);
            this.KPI3_btnSubmitDecision.TabIndex = 9;
            this.KPI3_btnSubmitDecision.Text = "Submit Decision";
            this.KPI3_btnSubmitDecision.UseVisualStyleBackColor = false;
            this.KPI3_btnSubmitDecision.Visible = false;
            // 
            // KPI3_groupDecision
            // 
            this.KPI3_groupDecision.BackColor = System.Drawing.Color.Transparent;
            this.KPI3_groupDecision.Controls.Add(this.KPI3_radioDecision3);
            this.KPI3_groupDecision.Controls.Add(this.KPI3_radioDecision2);
            this.KPI3_groupDecision.Controls.Add(this.KPI3_radioDecision1);
            this.KPI3_groupDecision.Location = new System.Drawing.Point(725, 23);
            this.KPI3_groupDecision.Name = "KPI3_groupDecision";
            this.KPI3_groupDecision.Size = new System.Drawing.Size(224, 156);
            this.KPI3_groupDecision.TabIndex = 8;
            this.KPI3_groupDecision.TabStop = false;
            this.KPI3_groupDecision.Visible = false;
            // 
            // KPI3_radioDecision3
            // 
            this.KPI3_radioDecision3.Location = new System.Drawing.Point(7, 108);
            this.KPI3_radioDecision3.Name = "KPI3_radioDecision3";
            this.KPI3_radioDecision3.Size = new System.Drawing.Size(200, 40);
            this.KPI3_radioDecision3.TabIndex = 2;
            this.KPI3_radioDecision3.TabStop = true;
            this.KPI3_radioDecision3.Text = "Choice 3";
            this.KPI3_radioDecision3.UseVisualStyleBackColor = true;
            // 
            // KPI3_radioDecision2
            // 
            this.KPI3_radioDecision2.Location = new System.Drawing.Point(7, 63);
            this.KPI3_radioDecision2.Name = "KPI3_radioDecision2";
            this.KPI3_radioDecision2.Size = new System.Drawing.Size(200, 40);
            this.KPI3_radioDecision2.TabIndex = 1;
            this.KPI3_radioDecision2.TabStop = true;
            this.KPI3_radioDecision2.Text = "Choice 2";
            this.KPI3_radioDecision2.UseVisualStyleBackColor = true;
            // 
            // KPI3_radioDecision1
            // 
            this.KPI3_radioDecision1.Location = new System.Drawing.Point(7, 20);
            this.KPI3_radioDecision1.Name = "KPI3_radioDecision1";
            this.KPI3_radioDecision1.Size = new System.Drawing.Size(200, 40);
            this.KPI3_radioDecision1.TabIndex = 0;
            this.KPI3_radioDecision1.TabStop = true;
            this.KPI3_radioDecision1.Text = "Choice 1";
            this.KPI3_radioDecision1.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label26.Location = new System.Drawing.Point(724, 3);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(202, 17);
            this.label26.TabIndex = 7;
            this.label26.Text = "Business Knowledge Rules";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label27.Location = new System.Drawing.Point(539, 3);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(117, 17);
            this.label27.TabIndex = 6;
            this.label27.Text = "State of Affairs";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label28.Location = new System.Drawing.Point(203, 3);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(63, 17);
            this.label28.TabIndex = 5;
            this.label28.Text = "Change";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label29.Location = new System.Drawing.Point(6, 3);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(103, 17);
            this.label29.TabIndex = 4;
            this.label29.Text = "KPI Summary";
            // 
            // label30
            // 
            this.label30.BackColor = System.Drawing.Color.Silver;
            this.label30.Location = new System.Drawing.Point(716, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(4, 285);
            this.label30.TabIndex = 2;
            // 
            // label31
            // 
            this.label31.BackColor = System.Drawing.Color.Silver;
            this.label31.Location = new System.Drawing.Point(531, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(4, 285);
            this.label31.TabIndex = 1;
            // 
            // label32
            // 
            this.label32.BackColor = System.Drawing.Color.Silver;
            this.label32.Location = new System.Drawing.Point(196, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(4, 285);
            this.label32.TabIndex = 0;
            // 
            // KPI4_tabPage
            // 
            this.KPI4_tabPage.BackColor = System.Drawing.Color.AliceBlue;
            this.KPI4_tabPage.BackgroundImage = global::StrykerEIP.Properties.Resources.G4WhiteToBrownGradient;
            this.KPI4_tabPage.Controls.Add(this.label33);
            this.KPI4_tabPage.Controls.Add(this.label46);
            this.KPI4_tabPage.Controls.Add(this.label47);
            this.KPI4_tabPage.Controls.Add(this.label50);
            this.KPI4_tabPage.Controls.Add(this.label51);
            this.KPI4_tabPage.Controls.Add(this.KPI4_lblDecisionFinal);
            this.KPI4_tabPage.Controls.Add(this.label64);
            this.KPI4_tabPage.Controls.Add(this.KPI4_lblResult);
            this.KPI4_tabPage.Controls.Add(this.label66);
            this.KPI4_tabPage.Controls.Add(this.label67);
            this.KPI4_tabPage.Controls.Add(this.KPI4_txtVar5);
            this.KPI4_tabPage.Controls.Add(this.KPI4_txtVar4);
            this.KPI4_tabPage.Controls.Add(this.KPI4_txtVar3);
            this.KPI4_tabPage.Controls.Add(this.KPI4_txtVar2);
            this.KPI4_tabPage.Controls.Add(this.KPI4_txtVar1);
            this.KPI4_tabPage.Controls.Add(this.richTextBox3);
            this.KPI4_tabPage.Controls.Add(this.KPI4_lblVar5);
            this.KPI4_tabPage.Controls.Add(this.KPI4_lblState);
            this.KPI4_tabPage.Controls.Add(this.KPI4_btnCalculate);
            this.KPI4_tabPage.Controls.Add(this.KPI4_lblVar4);
            this.KPI4_tabPage.Controls.Add(this.KPI4_lblVar3);
            this.KPI4_tabPage.Controls.Add(this.KPI4_lblVar2);
            this.KPI4_tabPage.Controls.Add(this.KPI4_lblVar1);
            this.KPI4_tabPage.Controls.Add(this.KPI4_btnSubmitDecision);
            this.KPI4_tabPage.Controls.Add(this.KPI4_groupDecision);
            this.KPI4_tabPage.Controls.Add(this.label74);
            this.KPI4_tabPage.Controls.Add(this.label75);
            this.KPI4_tabPage.Controls.Add(this.label76);
            this.KPI4_tabPage.Controls.Add(this.label77);
            this.KPI4_tabPage.Controls.Add(this.label78);
            this.KPI4_tabPage.Controls.Add(this.label79);
            this.KPI4_tabPage.Controls.Add(this.label80);
            this.KPI4_tabPage.Location = new System.Drawing.Point(4, 22);
            this.KPI4_tabPage.Name = "KPI4_tabPage";
            this.KPI4_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.KPI4_tabPage.Size = new System.Drawing.Size(1139, 275);
            this.KPI4_tabPage.TabIndex = 5;
            this.KPI4_tabPage.Text = "Innovations";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(549, 19);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(90, 17);
            this.label33.TabIndex = 67;
            this.label33.Text = "Expert System";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.BackColor = System.Drawing.Color.Transparent;
            this.label46.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(986, 230);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(123, 37);
            this.label46.TabIndex = 66;
            this.label46.Text = "Wisdom";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.BackColor = System.Drawing.Color.Transparent;
            this.label47.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(754, 230);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(162, 37);
            this.label47.TabIndex = 65;
            this.label47.Text = "Knowledge";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.BackColor = System.Drawing.Color.Transparent;
            this.label50.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(557, 230);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(123, 37);
            this.label50.TabIndex = 64;
            this.label50.Text = "Concept";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.BackColor = System.Drawing.Color.Transparent;
            this.label51.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.Location = new System.Drawing.Point(230, 230);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(258, 37);
            this.label51.TabIndex = 63;
            this.label51.Text = "Data - Information";
            // 
            // KPI4_lblDecisionFinal
            // 
            this.KPI4_lblDecisionFinal.BackColor = System.Drawing.Color.Transparent;
            this.KPI4_lblDecisionFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.KPI4_lblDecisionFinal.Location = new System.Drawing.Point(966, 42);
            this.KPI4_lblDecisionFinal.Name = "KPI4_lblDecisionFinal";
            this.KPI4_lblDecisionFinal.Size = new System.Drawing.Size(165, 172);
            this.KPI4_lblDecisionFinal.TabIndex = 57;
            this.KPI4_lblDecisionFinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.BackColor = System.Drawing.Color.Transparent;
            this.label64.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label64.Location = new System.Drawing.Point(962, 3);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(57, 17);
            this.label64.TabIndex = 56;
            this.label64.Text = "Choice";
            // 
            // KPI4_lblResult
            // 
            this.KPI4_lblResult.BackColor = System.Drawing.Color.Transparent;
            this.KPI4_lblResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KPI4_lblResult.Location = new System.Drawing.Point(548, 129);
            this.KPI4_lblResult.Name = "KPI4_lblResult";
            this.KPI4_lblResult.Size = new System.Drawing.Size(140, 90);
            this.KPI4_lblResult.TabIndex = 51;
            this.KPI4_lblResult.Text = "Result";
            this.KPI4_lblResult.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.KPI4_lblResult.Visible = false;
            // 
            // label66
            // 
            this.label66.BackColor = System.Drawing.Color.Silver;
            this.label66.Location = new System.Drawing.Point(953, -1);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(4, 285);
            this.label66.TabIndex = 50;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(1281, 264);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(45, 13);
            this.label67.TabIndex = 49;
            this.label67.Text = "Wisdom";
            // 
            // KPI4_txtVar5
            // 
            this.KPI4_txtVar5.Location = new System.Drawing.Point(313, 194);
            this.KPI4_txtVar5.Name = "KPI4_txtVar5";
            this.KPI4_txtVar5.Size = new System.Drawing.Size(130, 20);
            this.KPI4_txtVar5.TabIndex = 21;
            // 
            // KPI4_txtVar4
            // 
            this.KPI4_txtVar4.Location = new System.Drawing.Point(313, 153);
            this.KPI4_txtVar4.Name = "KPI4_txtVar4";
            this.KPI4_txtVar4.Size = new System.Drawing.Size(130, 20);
            this.KPI4_txtVar4.TabIndex = 13;
            // 
            // KPI4_txtVar3
            // 
            this.KPI4_txtVar3.Location = new System.Drawing.Point(313, 112);
            this.KPI4_txtVar3.Name = "KPI4_txtVar3";
            this.KPI4_txtVar3.Size = new System.Drawing.Size(130, 20);
            this.KPI4_txtVar3.TabIndex = 12;
            // 
            // KPI4_txtVar2
            // 
            this.KPI4_txtVar2.Location = new System.Drawing.Point(313, 71);
            this.KPI4_txtVar2.Name = "KPI4_txtVar2";
            this.KPI4_txtVar2.Size = new System.Drawing.Size(130, 20);
            this.KPI4_txtVar2.TabIndex = 11;
            // 
            // KPI4_txtVar1
            // 
            this.KPI4_txtVar1.Location = new System.Drawing.Point(313, 30);
            this.KPI4_txtVar1.Name = "KPI4_txtVar1";
            this.KPI4_txtVar1.ReadOnly = true;
            this.KPI4_txtVar1.Size = new System.Drawing.Size(130, 20);
            this.KPI4_txtVar1.TabIndex = 10;
            // 
            // richTextBox3
            // 
            this.richTextBox3.ForeColor = System.Drawing.Color.Black;
            this.richTextBox3.Location = new System.Drawing.Point(3, 23);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(189, 252);
            this.richTextBox3.TabIndex = 3;
            this.richTextBox3.Text = "";
            // 
            // KPI4_lblVar5
            // 
            this.KPI4_lblVar5.AutoEllipsis = true;
            this.KPI4_lblVar5.BackColor = System.Drawing.Color.Transparent;
            this.KPI4_lblVar5.Location = new System.Drawing.Point(203, 194);
            this.KPI4_lblVar5.Name = "KPI4_lblVar5";
            this.KPI4_lblVar5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.KPI4_lblVar5.Size = new System.Drawing.Size(104, 36);
            this.KPI4_lblVar5.TabIndex = 20;
            this.KPI4_lblVar5.Text = "Variable 5";
            // 
            // KPI4_lblState
            // 
            this.KPI4_lblState.AutoSize = true;
            this.KPI4_lblState.BackColor = System.Drawing.Color.Transparent;
            this.KPI4_lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KPI4_lblState.Location = new System.Drawing.Point(539, 70);
            this.KPI4_lblState.Margin = new System.Windows.Forms.Padding(0);
            this.KPI4_lblState.Name = "KPI4_lblState";
            this.KPI4_lblState.Size = new System.Drawing.Size(114, 44);
            this.KPI4_lblState.TabIndex = 19;
            this.KPI4_lblState.Text = "State";
            this.KPI4_lblState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KPI4_lblState.Visible = false;
            // 
            // KPI4_btnCalculate
            // 
            this.KPI4_btnCalculate.BackColor = System.Drawing.Color.Ivory;
            this.KPI4_btnCalculate.Location = new System.Drawing.Point(450, 29);
            this.KPI4_btnCalculate.Name = "KPI4_btnCalculate";
            this.KPI4_btnCalculate.Size = new System.Drawing.Size(75, 185);
            this.KPI4_btnCalculate.TabIndex = 18;
            this.KPI4_btnCalculate.Text = "Calculate";
            this.KPI4_btnCalculate.UseVisualStyleBackColor = false;
            // 
            // KPI4_lblVar4
            // 
            this.KPI4_lblVar4.AutoEllipsis = true;
            this.KPI4_lblVar4.BackColor = System.Drawing.Color.Transparent;
            this.KPI4_lblVar4.Location = new System.Drawing.Point(203, 153);
            this.KPI4_lblVar4.Name = "KPI4_lblVar4";
            this.KPI4_lblVar4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.KPI4_lblVar4.Size = new System.Drawing.Size(104, 36);
            this.KPI4_lblVar4.TabIndex = 17;
            this.KPI4_lblVar4.Text = "Variable 4";
            // 
            // KPI4_lblVar3
            // 
            this.KPI4_lblVar3.AutoEllipsis = true;
            this.KPI4_lblVar3.BackColor = System.Drawing.Color.Transparent;
            this.KPI4_lblVar3.Location = new System.Drawing.Point(203, 112);
            this.KPI4_lblVar3.Name = "KPI4_lblVar3";
            this.KPI4_lblVar3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.KPI4_lblVar3.Size = new System.Drawing.Size(104, 36);
            this.KPI4_lblVar3.TabIndex = 16;
            this.KPI4_lblVar3.Text = "Variable 3";
            // 
            // KPI4_lblVar2
            // 
            this.KPI4_lblVar2.AutoEllipsis = true;
            this.KPI4_lblVar2.BackColor = System.Drawing.Color.Transparent;
            this.KPI4_lblVar2.Location = new System.Drawing.Point(203, 71);
            this.KPI4_lblVar2.Name = "KPI4_lblVar2";
            this.KPI4_lblVar2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.KPI4_lblVar2.Size = new System.Drawing.Size(104, 36);
            this.KPI4_lblVar2.TabIndex = 15;
            this.KPI4_lblVar2.Text = "Variable 2";
            // 
            // KPI4_lblVar1
            // 
            this.KPI4_lblVar1.AutoEllipsis = true;
            this.KPI4_lblVar1.BackColor = System.Drawing.Color.Transparent;
            this.KPI4_lblVar1.Location = new System.Drawing.Point(203, 30);
            this.KPI4_lblVar1.Name = "KPI4_lblVar1";
            this.KPI4_lblVar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.KPI4_lblVar1.Size = new System.Drawing.Size(104, 36);
            this.KPI4_lblVar1.TabIndex = 14;
            this.KPI4_lblVar1.Text = "Variable 1";
            // 
            // KPI4_btnSubmitDecision
            // 
            this.KPI4_btnSubmitDecision.BackColor = System.Drawing.Color.Ivory;
            this.KPI4_btnSubmitDecision.Location = new System.Drawing.Point(848, 185);
            this.KPI4_btnSubmitDecision.Name = "KPI4_btnSubmitDecision";
            this.KPI4_btnSubmitDecision.Size = new System.Drawing.Size(91, 39);
            this.KPI4_btnSubmitDecision.TabIndex = 9;
            this.KPI4_btnSubmitDecision.Text = "Submit Decision";
            this.KPI4_btnSubmitDecision.UseVisualStyleBackColor = false;
            this.KPI4_btnSubmitDecision.Visible = false;
            // 
            // KPI4_groupDecision
            // 
            this.KPI4_groupDecision.BackColor = System.Drawing.Color.Transparent;
            this.KPI4_groupDecision.Controls.Add(this.KPI4_radioDecision3);
            this.KPI4_groupDecision.Controls.Add(this.KPI4_radioDecision2);
            this.KPI4_groupDecision.Controls.Add(this.KPI4_radioDecision1);
            this.KPI4_groupDecision.Location = new System.Drawing.Point(725, 23);
            this.KPI4_groupDecision.Name = "KPI4_groupDecision";
            this.KPI4_groupDecision.Size = new System.Drawing.Size(224, 156);
            this.KPI4_groupDecision.TabIndex = 8;
            this.KPI4_groupDecision.TabStop = false;
            this.KPI4_groupDecision.Visible = false;
            // 
            // KPI4_radioDecision3
            // 
            this.KPI4_radioDecision3.Location = new System.Drawing.Point(7, 108);
            this.KPI4_radioDecision3.Name = "KPI4_radioDecision3";
            this.KPI4_radioDecision3.Size = new System.Drawing.Size(200, 40);
            this.KPI4_radioDecision3.TabIndex = 2;
            this.KPI4_radioDecision3.TabStop = true;
            this.KPI4_radioDecision3.Text = "Choice 3";
            this.KPI4_radioDecision3.UseVisualStyleBackColor = true;
            // 
            // KPI4_radioDecision2
            // 
            this.KPI4_radioDecision2.Location = new System.Drawing.Point(7, 63);
            this.KPI4_radioDecision2.Name = "KPI4_radioDecision2";
            this.KPI4_radioDecision2.Size = new System.Drawing.Size(200, 40);
            this.KPI4_radioDecision2.TabIndex = 1;
            this.KPI4_radioDecision2.TabStop = true;
            this.KPI4_radioDecision2.Text = "Choice 2";
            this.KPI4_radioDecision2.UseVisualStyleBackColor = true;
            // 
            // KPI4_radioDecision1
            // 
            this.KPI4_radioDecision1.Location = new System.Drawing.Point(7, 20);
            this.KPI4_radioDecision1.Name = "KPI4_radioDecision1";
            this.KPI4_radioDecision1.Size = new System.Drawing.Size(200, 40);
            this.KPI4_radioDecision1.TabIndex = 0;
            this.KPI4_radioDecision1.TabStop = true;
            this.KPI4_radioDecision1.Text = "Choice 1";
            this.KPI4_radioDecision1.UseVisualStyleBackColor = true;
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.BackColor = System.Drawing.Color.Transparent;
            this.label74.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label74.Location = new System.Drawing.Point(724, 3);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(202, 17);
            this.label74.TabIndex = 7;
            this.label74.Text = "Business Knowledge Rules";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.BackColor = System.Drawing.Color.Transparent;
            this.label75.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label75.Location = new System.Drawing.Point(539, 3);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(117, 17);
            this.label75.TabIndex = 6;
            this.label75.Text = "State of Affairs";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.BackColor = System.Drawing.Color.Transparent;
            this.label76.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label76.Location = new System.Drawing.Point(203, 3);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(63, 17);
            this.label76.TabIndex = 5;
            this.label76.Text = "Change";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.BackColor = System.Drawing.Color.Transparent;
            this.label77.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label77.Location = new System.Drawing.Point(6, 3);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(103, 17);
            this.label77.TabIndex = 4;
            this.label77.Text = "KPI Summary";
            // 
            // label78
            // 
            this.label78.BackColor = System.Drawing.Color.Silver;
            this.label78.Location = new System.Drawing.Point(716, 0);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(4, 285);
            this.label78.TabIndex = 2;
            // 
            // label79
            // 
            this.label79.BackColor = System.Drawing.Color.Silver;
            this.label79.Location = new System.Drawing.Point(531, 0);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(4, 285);
            this.label79.TabIndex = 1;
            // 
            // label80
            // 
            this.label80.BackColor = System.Drawing.Color.Silver;
            this.label80.Location = new System.Drawing.Point(196, 0);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(4, 285);
            this.label80.TabIndex = 0;
            // 
            // BusinessIntelligenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::StrykerEIP.Properties.Resources.StrykerLoginBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1147, 602);
            this.Controls.Add(this.label49);
            this.Controls.Add(this.lblKPI4Name);
            this.Controls.Add(this.lblKPI3Name);
            this.Controls.Add(this.lblKPI2Name);
            this.Controls.Add(this.lblKPI1Name);
            this.Controls.Add(this.lblBusinessProcessName);
            this.Controls.Add(this.InnovationsChart);
            this.Controls.Add(this.OperationsChart);
            this.Controls.Add(this.FinancialChart);
            this.Controls.Add(this.CustomerChart);
            this.Controls.Add(this.KPI4_txtKPISummary);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BusinessIntelligenceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Business Intelligence Dashboard";
            this.Load += new System.EventHandler(this.BusinessIntelligenceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InnovationsChart)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FinancialChart)).EndInit();
            this.KPI1_tabPage.ResumeLayout(false);
            this.KPI1_tabPage.PerformLayout();
            this.KPI1_groupDecision.ResumeLayout(false);
            this.KPI4_txtKPISummary.ResumeLayout(false);
            this.KPI2_tabPage.ResumeLayout(false);
            this.KPI2_tabPage.PerformLayout();
            this.KPI2_groupDecision.ResumeLayout(false);
            this.KPI3_tabPage.ResumeLayout(false);
            this.KPI3_tabPage.PerformLayout();
            this.KPI3_groupDecision.ResumeLayout(false);
            this.KPI4_tabPage.ResumeLayout(false);
            this.KPI4_tabPage.PerformLayout();
            this.KPI4_groupDecision.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart CustomerChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart OperationsChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart InnovationsChart;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perspectivesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financialAccountingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materialsManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem humanResourcesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selfHelpPDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private Chart FinancialChart;
        private Label lblBusinessProcessName;
        private Label lblKPI1Name;
        private Label lblKPI2Name;
        private Label lblKPI3Name;
        private Label lblKPI4Name;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem globalIntellToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem sustainableIntelligencToolStripMenuItem;
        private Label label49;
        private TabPage KPI1_tabPage;
        private Label label54;
        private Label label44;
        private Label label43;
        private Label label42;
        private Label label34;
        private Label KPI1_lblDecisionFinal;
        private Label label53;
        private Label KPI1_lblResult;
        private Label label48;
        private Label label45;
        private TextBox KPI1_txtVar5;
        private TextBox KPI1_txtVar4;
        private TextBox KPI1_txtVar3;
        private TextBox KPI1_txtVar2;
        private TextBox KPI1_txtVar1;
        private RichTextBox KPI1_txtKPISummary;
        private Label KPI1_lblVar5;
        private Label KPI1_lblState;
        private Button KPI1_btnCalculate;
        private Label KPI1_lblVar4;
        private Label KPI1_lblVar3;
        private Label KPI1_lblVar2;
        private Label KPI1_lblVar1;
        private Button KPI1_btnSubmitDecision;
        private GroupBox KPI1_groupDecision;
        private RadioButton KPI1_radioDecision3;
        private RadioButton KPI1_radioDecision2;
        private RadioButton KPI1_radioDecision1;
        private Label KPI1_lblDecisionLogo;
        private Label KPI1_lblStateLogo;
        private Label KPI1_lblCalculateLogo;
        private Label KPI1_lblSummaryLogo;
        private Label label2;
        private Label label1;
        private Label lblColumn1;
        private TabControl KPI4_txtKPISummary;
        private TabPage KPI2_tabPage;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label KPI2_lblDecisionFinal;
        private Label label16;
        private Label KPI2_lblResult;
        private Label label36;
        private Label label37;
        private TextBox KPI2_txtVar5;
        private TextBox KPI2_txtVar4;
        private TextBox KPI2_txtVar3;
        private TextBox KPI2_txtVar2;
        private TextBox KPI2_txtVar1;
        private RichTextBox KPI2_txtKPISummary;
        private Label KPI2_lblVar5;
        private Label KPI2_lblState;
        private Button KPI2_btnCalculate;
        private Label KPI2_lblVar4;
        private Label KPI2_lblVar3;
        private Label KPI2_lblVar2;
        private Label KPI2_lblVar1;
        private Button KPI2_btnSubmitDecision;
        private GroupBox KPI2_groupDecision;
        private RadioButton KPI2_radioDecision3;
        private RadioButton KPI2_radioDecision2;
        private RadioButton KPI2_radioDecision1;
        private Label label57;
        private Label label58;
        private Label label59;
        private Label label60;
        private Label label61;
        private Label label62;
        private Label label63;
        private TabPage KPI3_tabPage;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label KPI3_lblDecisionFinal;
        private Label label15;
        private Label KPI3_lblResult;
        private Label label18;
        private Label label19;
        private TextBox KPI3_txtVar5;
        private TextBox KPI3_txtVar4;
        private TextBox KPI3_txtVar3;
        private TextBox KPI3_txtVar2;
        private TextBox KPI3_txtVar1;
        private RichTextBox KPI3_txtKPISummary;
        private Label KPI3_lblVar5;
        private Label KPI3_lblState;
        private Button KPI3_btnCalculate;
        private Label KPI3_lblVar4;
        private Label KPI3_lblVar3;
        private Label KPI3_lblVar2;
        private Label KPI3_lblVar1;
        private Button KPI3_btnSubmitDecision;
        private GroupBox KPI3_groupDecision;
        private RadioButton KPI3_radioDecision3;
        private RadioButton KPI3_radioDecision2;
        private RadioButton KPI3_radioDecision1;
        private Label label26;
        private Label label27;
        private Label label28;
        private Label label29;
        private Label label30;
        private Label label31;
        private Label label32;
        private TabPage KPI4_tabPage;
        private Label label33;
        private Label label46;
        private Label label47;
        private Label label50;
        private Label label51;
        private Label KPI4_lblDecisionFinal;
        private Label label64;
        private Label KPI4_lblResult;
        private Label label66;
        private Label label67;
        private TextBox KPI4_txtVar5;
        private TextBox KPI4_txtVar4;
        private TextBox KPI4_txtVar3;
        private TextBox KPI4_txtVar2;
        private TextBox KPI4_txtVar1;
        private RichTextBox richTextBox3;
        private Label KPI4_lblVar5;
        private Label KPI4_lblState;
        private Button KPI4_btnCalculate;
        private Label KPI4_lblVar4;
        private Label KPI4_lblVar3;
        private Label KPI4_lblVar2;
        private Label KPI4_lblVar1;
        private Button KPI4_btnSubmitDecision;
        private GroupBox KPI4_groupDecision;
        private RadioButton KPI4_radioDecision3;
        private RadioButton KPI4_radioDecision2;
        private RadioButton KPI4_radioDecision1;
        private Label label74;
        private Label label75;
        private Label label76;
        private Label label77;
        private Label label78;
        private Label label79;
        private Label label80;
    }
}

