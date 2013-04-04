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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusinessIntelligenceForm));
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
            this.KPI4_tabPage = new System.Windows.Forms.TabControl();
            this.KPI1_tabPage = new System.Windows.Forms.TabPage();
            this.KPI1_txtVar5 = new System.Windows.Forms.TextBox();
            this.KPI1_lblVar5 = new System.Windows.Forms.Label();
            this.KPI1_lblState = new System.Windows.Forms.Label();
            this.KPI1_btnCalculate = new System.Windows.Forms.Button();
            this.KPI1_lblVar4 = new System.Windows.Forms.Label();
            this.KPI1_lblVar3 = new System.Windows.Forms.Label();
            this.KPI1_lblVar2 = new System.Windows.Forms.Label();
            this.KPI1_lblVar1 = new System.Windows.Forms.Label();
            this.KPI1_txtVar4 = new System.Windows.Forms.TextBox();
            this.KPI1_txtVar3 = new System.Windows.Forms.TextBox();
            this.KPI1_txtVar2 = new System.Windows.Forms.TextBox();
            this.KPI1_txtVar1 = new System.Windows.Forms.TextBox();
            this.KPI1_btnSubmitDecision = new System.Windows.Forms.Button();
            this.KPI1_groupDecision = new System.Windows.Forms.GroupBox();
            this.KPI1_txtDecisionSummary = new System.Windows.Forms.RichTextBox();
            this.KPI1_radioDecision3 = new System.Windows.Forms.RadioButton();
            this.KPI1_radioDecision2 = new System.Windows.Forms.RadioButton();
            this.KPI1_radioDecision1 = new System.Windows.Forms.RadioButton();
            this.KPI1_lblDecisionLogo = new System.Windows.Forms.Label();
            this.KPI1_lblStateLogo = new System.Windows.Forms.Label();
            this.KPI1_lblCalculateLogo = new System.Windows.Forms.Label();
            this.KPI1_lblSummaryLogo = new System.Windows.Forms.Label();
            this.KPI1_txtKPISummary = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblColumn1 = new System.Windows.Forms.Label();
            this.KPI2_tabPage = new System.Windows.Forms.TabPage();
            this.KPI3_tabPage = new System.Windows.Forms.TabPage();
            this.InnovationsTabPage = new System.Windows.Forms.TabPage();
            this.CustomerChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.FinancialChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selfHelpPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KPI4_tabPage.SuspendLayout();
            this.KPI1_tabPage.SuspendLayout();
            this.KPI1_groupDecision.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinancialChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InnovationsChart)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // KPI4_tabPage
            // 
            this.KPI4_tabPage.Controls.Add(this.KPI1_tabPage);
            this.KPI4_tabPage.Controls.Add(this.KPI2_tabPage);
            this.KPI4_tabPage.Controls.Add(this.KPI3_tabPage);
            this.KPI4_tabPage.Controls.Add(this.InnovationsTabPage);
            this.KPI4_tabPage.Location = new System.Drawing.Point(14, 286);
            this.KPI4_tabPage.Name = "KPI4_tabPage";
            this.KPI4_tabPage.SelectedIndex = 0;
            this.KPI4_tabPage.Size = new System.Drawing.Size(1182, 309);
            this.KPI4_tabPage.TabIndex = 0;
            // 
            // KPI1_tabPage
            // 
            this.KPI1_tabPage.Controls.Add(this.KPI1_txtVar5);
            this.KPI1_tabPage.Controls.Add(this.KPI1_lblVar5);
            this.KPI1_tabPage.Controls.Add(this.KPI1_lblState);
            this.KPI1_tabPage.Controls.Add(this.KPI1_btnCalculate);
            this.KPI1_tabPage.Controls.Add(this.KPI1_lblVar4);
            this.KPI1_tabPage.Controls.Add(this.KPI1_lblVar3);
            this.KPI1_tabPage.Controls.Add(this.KPI1_lblVar2);
            this.KPI1_tabPage.Controls.Add(this.KPI1_lblVar1);
            this.KPI1_tabPage.Controls.Add(this.KPI1_txtVar4);
            this.KPI1_tabPage.Controls.Add(this.KPI1_txtVar3);
            this.KPI1_tabPage.Controls.Add(this.KPI1_txtVar2);
            this.KPI1_tabPage.Controls.Add(this.KPI1_txtVar1);
            this.KPI1_tabPage.Controls.Add(this.KPI1_btnSubmitDecision);
            this.KPI1_tabPage.Controls.Add(this.KPI1_groupDecision);
            this.KPI1_tabPage.Controls.Add(this.KPI1_lblDecisionLogo);
            this.KPI1_tabPage.Controls.Add(this.KPI1_lblStateLogo);
            this.KPI1_tabPage.Controls.Add(this.KPI1_lblCalculateLogo);
            this.KPI1_tabPage.Controls.Add(this.KPI1_lblSummaryLogo);
            this.KPI1_tabPage.Controls.Add(this.KPI1_txtKPISummary);
            this.KPI1_tabPage.Controls.Add(this.label2);
            this.KPI1_tabPage.Controls.Add(this.label1);
            this.KPI1_tabPage.Controls.Add(this.lblColumn1);
            this.KPI1_tabPage.Location = new System.Drawing.Point(4, 22);
            this.KPI1_tabPage.Name = "KPI1_tabPage";
            this.KPI1_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.KPI1_tabPage.Size = new System.Drawing.Size(1174, 283);
            this.KPI1_tabPage.TabIndex = 0;
            this.KPI1_tabPage.Text = "Customer";
            this.KPI1_tabPage.UseVisualStyleBackColor = true;
            // 
            // KPI1_txtVar5
            // 
            this.KPI1_txtVar5.Location = new System.Drawing.Point(304, 170);
            this.KPI1_txtVar5.Name = "KPI1_txtVar5";
            this.KPI1_txtVar5.Size = new System.Drawing.Size(100, 20);
            this.KPI1_txtVar5.TabIndex = 21;
            // 
            // KPI1_lblVar5
            // 
            this.KPI1_lblVar5.AutoSize = true;
            this.KPI1_lblVar5.Location = new System.Drawing.Point(263, 174);
            this.KPI1_lblVar5.Name = "KPI1_lblVar5";
            this.KPI1_lblVar5.Size = new System.Drawing.Size(35, 13);
            this.KPI1_lblVar5.TabIndex = 20;
            this.KPI1_lblVar5.Text = "label7";
            // 
            // KPI1_lblState
            // 
            this.KPI1_lblState.AutoSize = true;
            this.KPI1_lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KPI1_lblState.Location = new System.Drawing.Point(637, 111);
            this.KPI1_lblState.Name = "KPI1_lblState";
            this.KPI1_lblState.Size = new System.Drawing.Size(66, 24);
            this.KPI1_lblState.TabIndex = 19;
            this.KPI1_lblState.Text = "label7";
            this.KPI1_lblState.Visible = false;
            // 
            // KPI1_btnCalculate
            // 
            this.KPI1_btnCalculate.Location = new System.Drawing.Point(412, 66);
            this.KPI1_btnCalculate.Name = "KPI1_btnCalculate";
            this.KPI1_btnCalculate.Size = new System.Drawing.Size(75, 124);
            this.KPI1_btnCalculate.TabIndex = 18;
            this.KPI1_btnCalculate.Text = "Calculate";
            this.KPI1_btnCalculate.UseVisualStyleBackColor = true;
            this.KPI1_btnCalculate.Click += new System.EventHandler(this.KPI1_btnCalculate_Click);
            // 
            // KPI1_lblVar4
            // 
            this.KPI1_lblVar4.AutoSize = true;
            this.KPI1_lblVar4.Location = new System.Drawing.Point(263, 147);
            this.KPI1_lblVar4.Name = "KPI1_lblVar4";
            this.KPI1_lblVar4.Size = new System.Drawing.Size(35, 13);
            this.KPI1_lblVar4.TabIndex = 17;
            this.KPI1_lblVar4.Text = "label6";
            // 
            // KPI1_lblVar3
            // 
            this.KPI1_lblVar3.AutoSize = true;
            this.KPI1_lblVar3.Location = new System.Drawing.Point(263, 122);
            this.KPI1_lblVar3.Name = "KPI1_lblVar3";
            this.KPI1_lblVar3.Size = new System.Drawing.Size(35, 13);
            this.KPI1_lblVar3.TabIndex = 16;
            this.KPI1_lblVar3.Text = "label5";
            // 
            // KPI1_lblVar2
            // 
            this.KPI1_lblVar2.AutoSize = true;
            this.KPI1_lblVar2.Location = new System.Drawing.Point(263, 97);
            this.KPI1_lblVar2.Name = "KPI1_lblVar2";
            this.KPI1_lblVar2.Size = new System.Drawing.Size(35, 13);
            this.KPI1_lblVar2.TabIndex = 15;
            this.KPI1_lblVar2.Text = "label4";
            // 
            // KPI1_lblVar1
            // 
            this.KPI1_lblVar1.AutoSize = true;
            this.KPI1_lblVar1.Location = new System.Drawing.Point(263, 70);
            this.KPI1_lblVar1.Name = "KPI1_lblVar1";
            this.KPI1_lblVar1.Size = new System.Drawing.Size(35, 13);
            this.KPI1_lblVar1.TabIndex = 14;
            this.KPI1_lblVar1.Text = "label3";
            // 
            // KPI1_txtVar4
            // 
            this.KPI1_txtVar4.Location = new System.Drawing.Point(304, 144);
            this.KPI1_txtVar4.Name = "KPI1_txtVar4";
            this.KPI1_txtVar4.Size = new System.Drawing.Size(100, 20);
            this.KPI1_txtVar4.TabIndex = 13;
            // 
            // KPI1_txtVar3
            // 
            this.KPI1_txtVar3.Location = new System.Drawing.Point(304, 118);
            this.KPI1_txtVar3.Name = "KPI1_txtVar3";
            this.KPI1_txtVar3.Size = new System.Drawing.Size(100, 20);
            this.KPI1_txtVar3.TabIndex = 12;
            // 
            // KPI1_txtVar2
            // 
            this.KPI1_txtVar2.Location = new System.Drawing.Point(304, 92);
            this.KPI1_txtVar2.Name = "KPI1_txtVar2";
            this.KPI1_txtVar2.Size = new System.Drawing.Size(100, 20);
            this.KPI1_txtVar2.TabIndex = 11;
            // 
            // KPI1_txtVar1
            // 
            this.KPI1_txtVar1.Location = new System.Drawing.Point(304, 66);
            this.KPI1_txtVar1.Name = "KPI1_txtVar1";
            this.KPI1_txtVar1.Size = new System.Drawing.Size(100, 20);
            this.KPI1_txtVar1.TabIndex = 10;
            // 
            // KPI1_btnSubmitDecision
            // 
            this.KPI1_btnSubmitDecision.Location = new System.Drawing.Point(1076, 237);
            this.KPI1_btnSubmitDecision.Name = "KPI1_btnSubmitDecision";
            this.KPI1_btnSubmitDecision.Size = new System.Drawing.Size(91, 40);
            this.KPI1_btnSubmitDecision.TabIndex = 9;
            this.KPI1_btnSubmitDecision.Text = "Submit Decision";
            this.KPI1_btnSubmitDecision.UseVisualStyleBackColor = true;
            this.KPI1_btnSubmitDecision.Visible = false;
            // 
            // KPI1_groupDecision
            // 
            this.KPI1_groupDecision.Controls.Add(this.KPI1_txtDecisionSummary);
            this.KPI1_groupDecision.Controls.Add(this.KPI1_radioDecision3);
            this.KPI1_groupDecision.Controls.Add(this.KPI1_radioDecision2);
            this.KPI1_groupDecision.Controls.Add(this.KPI1_radioDecision1);
            this.KPI1_groupDecision.Location = new System.Drawing.Point(835, 23);
            this.KPI1_groupDecision.Name = "KPI1_groupDecision";
            this.KPI1_groupDecision.Size = new System.Drawing.Size(333, 188);
            this.KPI1_groupDecision.TabIndex = 8;
            this.KPI1_groupDecision.TabStop = false;
            this.KPI1_groupDecision.Visible = false;
            // 
            // KPI1_txtDecisionSummary
            // 
            this.KPI1_txtDecisionSummary.Enabled = false;
            this.KPI1_txtDecisionSummary.Location = new System.Drawing.Point(172, 20);
            this.KPI1_txtDecisionSummary.Name = "KPI1_txtDecisionSummary";
            this.KPI1_txtDecisionSummary.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.KPI1_txtDecisionSummary.ShortcutsEnabled = false;
            this.KPI1_txtDecisionSummary.Size = new System.Drawing.Size(141, 136);
            this.KPI1_txtDecisionSummary.TabIndex = 3;
            this.KPI1_txtDecisionSummary.Text = "";
            // 
            // KPI1_radioDecision3
            // 
            this.KPI1_radioDecision3.AutoSize = true;
            this.KPI1_radioDecision3.Location = new System.Drawing.Point(7, 66);
            this.KPI1_radioDecision3.Name = "KPI1_radioDecision3";
            this.KPI1_radioDecision3.Size = new System.Drawing.Size(85, 17);
            this.KPI1_radioDecision3.TabIndex = 2;
            this.KPI1_radioDecision3.TabStop = true;
            this.KPI1_radioDecision3.Text = "radioButton3";
            this.KPI1_radioDecision3.UseVisualStyleBackColor = true;
            // 
            // KPI1_radioDecision2
            // 
            this.KPI1_radioDecision2.AutoSize = true;
            this.KPI1_radioDecision2.Location = new System.Drawing.Point(7, 43);
            this.KPI1_radioDecision2.Name = "KPI1_radioDecision2";
            this.KPI1_radioDecision2.Size = new System.Drawing.Size(85, 17);
            this.KPI1_radioDecision2.TabIndex = 1;
            this.KPI1_radioDecision2.TabStop = true;
            this.KPI1_radioDecision2.Text = "radioButton2";
            this.KPI1_radioDecision2.UseVisualStyleBackColor = true;
            // 
            // KPI1_radioDecision1
            // 
            this.KPI1_radioDecision1.AutoSize = true;
            this.KPI1_radioDecision1.Location = new System.Drawing.Point(7, 20);
            this.KPI1_radioDecision1.Name = "KPI1_radioDecision1";
            this.KPI1_radioDecision1.Size = new System.Drawing.Size(85, 17);
            this.KPI1_radioDecision1.TabIndex = 0;
            this.KPI1_radioDecision1.TabStop = true;
            this.KPI1_radioDecision1.Text = "radioButton1";
            this.KPI1_radioDecision1.UseVisualStyleBackColor = true;
            // 
            // KPI1_lblDecisionLogo
            // 
            this.KPI1_lblDecisionLogo.AutoSize = true;
            this.KPI1_lblDecisionLogo.BackColor = System.Drawing.Color.Transparent;
            this.KPI1_lblDecisionLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.KPI1_lblDecisionLogo.Location = new System.Drawing.Point(832, 3);
            this.KPI1_lblDecisionLogo.Name = "KPI1_lblDecisionLogo";
            this.KPI1_lblDecisionLogo.Size = new System.Drawing.Size(70, 17);
            this.KPI1_lblDecisionLogo.TabIndex = 7;
            this.KPI1_lblDecisionLogo.Text = "Decision";
            // 
            // KPI1_lblStateLogo
            // 
            this.KPI1_lblStateLogo.AutoSize = true;
            this.KPI1_lblStateLogo.BackColor = System.Drawing.Color.Transparent;
            this.KPI1_lblStateLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.KPI1_lblStateLogo.Location = new System.Drawing.Point(534, 3);
            this.KPI1_lblStateLogo.Name = "KPI1_lblStateLogo";
            this.KPI1_lblStateLogo.Size = new System.Drawing.Size(46, 17);
            this.KPI1_lblStateLogo.TabIndex = 6;
            this.KPI1_lblStateLogo.Text = "State";
            // 
            // KPI1_lblCalculateLogo
            // 
            this.KPI1_lblCalculateLogo.AutoSize = true;
            this.KPI1_lblCalculateLogo.BackColor = System.Drawing.Color.Transparent;
            this.KPI1_lblCalculateLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.KPI1_lblCalculateLogo.Location = new System.Drawing.Point(212, 3);
            this.KPI1_lblCalculateLogo.Name = "KPI1_lblCalculateLogo";
            this.KPI1_lblCalculateLogo.Size = new System.Drawing.Size(150, 17);
            this.KPI1_lblCalculateLogo.TabIndex = 5;
            this.KPI1_lblCalculateLogo.Text = "Perform Calculation";
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
            // KPI1_txtKPISummary
            // 
            this.KPI1_txtKPISummary.Enabled = false;
            this.KPI1_txtKPISummary.Location = new System.Drawing.Point(6, 66);
            this.KPI1_txtKPISummary.Name = "KPI1_txtKPISummary";
            this.KPI1_txtKPISummary.Size = new System.Drawing.Size(184, 211);
            this.KPI1_txtKPISummary.TabIndex = 3;
            this.KPI1_txtKPISummary.Text = "";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(816, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 285);
            this.label2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(518, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 285);
            this.label1.TabIndex = 1;
            // 
            // lblColumn1
            // 
            this.lblColumn1.BackColor = System.Drawing.Color.Silver;
            this.lblColumn1.Location = new System.Drawing.Point(196, 0);
            this.lblColumn1.Name = "lblColumn1";
            this.lblColumn1.Size = new System.Drawing.Size(10, 285);
            this.lblColumn1.TabIndex = 0;
            // 
            // KPI2_tabPage
            // 
            this.KPI2_tabPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("KPI2_tabPage.BackgroundImage")));
            this.KPI2_tabPage.Location = new System.Drawing.Point(4, 22);
            this.KPI2_tabPage.Name = "KPI2_tabPage";
            this.KPI2_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.KPI2_tabPage.Size = new System.Drawing.Size(1174, 283);
            this.KPI2_tabPage.TabIndex = 1;
            this.KPI2_tabPage.Text = "Financial";
            this.KPI2_tabPage.UseVisualStyleBackColor = true;
            // 
            // KPI3_tabPage
            // 
            this.KPI3_tabPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("KPI3_tabPage.BackgroundImage")));
            this.KPI3_tabPage.Location = new System.Drawing.Point(4, 22);
            this.KPI3_tabPage.Name = "KPI3_tabPage";
            this.KPI3_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.KPI3_tabPage.Size = new System.Drawing.Size(1174, 283);
            this.KPI3_tabPage.TabIndex = 2;
            this.KPI3_tabPage.Text = "Operations";
            this.KPI3_tabPage.UseVisualStyleBackColor = true;
            // 
            // InnovationsTabPage
            // 
            this.InnovationsTabPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InnovationsTabPage.BackgroundImage")));
            this.InnovationsTabPage.Location = new System.Drawing.Point(4, 22);
            this.InnovationsTabPage.Name = "InnovationsTabPage";
            this.InnovationsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.InnovationsTabPage.Size = new System.Drawing.Size(1174, 283);
            this.InnovationsTabPage.TabIndex = 3;
            this.InnovationsTabPage.Text = "Innovations";
            this.InnovationsTabPage.UseVisualStyleBackColor = true;
            // 
            // CustomerChart
            // 
            this.CustomerChart.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.CustomerChart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.CustomerChart.Legends.Add(legend1);
            this.CustomerChart.Location = new System.Drawing.Point(7, 33);
            this.CustomerChart.Name = "CustomerChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "CustomerSeries";
            this.CustomerChart.Series.Add(series1);
            this.CustomerChart.Size = new System.Drawing.Size(285, 247);
            this.CustomerChart.TabIndex = 1;
            this.CustomerChart.Text = "chart1";
            // 
            // FinancialChart
            // 
            this.FinancialChart.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.FinancialChart.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.FinancialChart.Legends.Add(legend2);
            this.FinancialChart.Location = new System.Drawing.Point(311, 33);
            this.FinancialChart.Name = "FinancialChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid;
            series2.Legend = "Legend1";
            series2.Name = "FinancialSeries";
            this.FinancialChart.Series.Add(series2);
            this.FinancialChart.Size = new System.Drawing.Size(285, 247);
            this.FinancialChart.TabIndex = 2;
            this.FinancialChart.Text = "chart2";
            // 
            // OperationsChart
            // 
            this.OperationsChart.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.OperationsChart.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.OperationsChart.Legends.Add(legend3);
            this.OperationsChart.Location = new System.Drawing.Point(615, 33);
            this.OperationsChart.Name = "OperationsChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "OperationsSeries";
            this.OperationsChart.Series.Add(series3);
            this.OperationsChart.Size = new System.Drawing.Size(285, 247);
            this.OperationsChart.TabIndex = 3;
            this.OperationsChart.Text = "chart3";
            // 
            // InnovationsChart
            // 
            this.InnovationsChart.BackColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "ChartArea1";
            this.InnovationsChart.ChartAreas.Add(chartArea4);
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.InnovationsChart.Legends.Add(legend4);
            this.InnovationsChart.Location = new System.Drawing.Point(919, 33);
            this.InnovationsChart.Name = "InnovationsChart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "InnovationsSeries";
            this.InnovationsChart.Series.Add(series4);
            this.InnovationsChart.Size = new System.Drawing.Size(285, 247);
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
            this.menuStrip1.Size = new System.Drawing.Size(1216, 24);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.calculateToolStripMenuItem.Text = "Calculate";
            this.calculateToolStripMenuItem.Click += new System.EventHandler(this.calculateToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(154, 6);
            // 
            // clearFormToolStripMenuItem
            // 
            this.clearFormToolStripMenuItem.Name = "clearFormToolStripMenuItem";
            this.clearFormToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.clearFormToolStripMenuItem.Text = "Clear Form";
            this.clearFormToolStripMenuItem.Click += new System.EventHandler(this.clearFormToolStripMenuItem_Click);
            // 
            // returnToMenuToolStripMenuItem
            // 
            this.returnToMenuToolStripMenuItem.Name = "returnToMenuToolStripMenuItem";
            this.returnToMenuToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.returnToMenuToolStripMenuItem.Text = "Return to Menu";
            this.returnToMenuToolStripMenuItem.Click += new System.EventHandler(this.returnToMenuToolStripMenuItem_Click);
            // 
            // exitProgramToolStripMenuItem
            // 
            this.exitProgramToolStripMenuItem.Name = "exitProgramToolStripMenuItem";
            this.exitProgramToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
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
            this.humanResourcesToolStripMenuItem});
            this.perspectivesToolStripMenuItem.Name = "perspectivesToolStripMenuItem";
            this.perspectivesToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.perspectivesToolStripMenuItem.Text = "Subsystem";
            // 
            // eServicesToolStripMenuItem
            // 
            this.eServicesToolStripMenuItem.Name = "eServicesToolStripMenuItem";
            this.eServicesToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.eServicesToolStripMenuItem.Text = "E-Services";
            // 
            // financialAccountingToolStripMenuItem
            // 
            this.financialAccountingToolStripMenuItem.Name = "financialAccountingToolStripMenuItem";
            this.financialAccountingToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.financialAccountingToolStripMenuItem.Text = "Financial Accounting";
            // 
            // materialsManagementToolStripMenuItem
            // 
            this.materialsManagementToolStripMenuItem.Name = "materialsManagementToolStripMenuItem";
            this.materialsManagementToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.materialsManagementToolStripMenuItem.Text = "Materials Management";
            // 
            // productionToolStripMenuItem
            // 
            this.productionToolStripMenuItem.Name = "productionToolStripMenuItem";
            this.productionToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.productionToolStripMenuItem.Text = "Production";
            // 
            // customerServiceToolStripMenuItem
            // 
            this.customerServiceToolStripMenuItem.Name = "customerServiceToolStripMenuItem";
            this.customerServiceToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.customerServiceToolStripMenuItem.Text = "Customer Service";
            // 
            // humanResourcesToolStripMenuItem
            // 
            this.humanResourcesToolStripMenuItem.Name = "humanResourcesToolStripMenuItem";
            this.humanResourcesToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.humanResourcesToolStripMenuItem.Text = "Human Resources";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selfHelpPDFToolStripMenuItem,
            this.contactToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // selfHelpPDFToolStripMenuItem
            // 
            this.selfHelpPDFToolStripMenuItem.Name = "selfHelpPDFToolStripMenuItem";
            this.selfHelpPDFToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.selfHelpPDFToolStripMenuItem.Text = "Self-Help PDF";
            this.selfHelpPDFToolStripMenuItem.Click += new System.EventHandler(this.selfHelpPDFToolStripMenuItem_Click);
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.contactToolStripMenuItem.Text = "Contact";
            this.contactToolStripMenuItem.Click += new System.EventHandler(this.contactToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // BusinessIntelligenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1216, 609);
            this.Controls.Add(this.InnovationsChart);
            this.Controls.Add(this.OperationsChart);
            this.Controls.Add(this.FinancialChart);
            this.Controls.Add(this.CustomerChart);
            this.Controls.Add(this.KPI4_tabPage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BusinessIntelligenceForm";
            this.Text = "Business Intelligence Dashboard";
            this.KPI4_tabPage.ResumeLayout(false);
            this.KPI1_tabPage.ResumeLayout(false);
            this.KPI1_tabPage.PerformLayout();
            this.KPI1_groupDecision.ResumeLayout(false);
            this.KPI1_groupDecision.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinancialChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InnovationsChart)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl KPI4_tabPage;
        private System.Windows.Forms.TabPage KPI1_tabPage;
        private System.Windows.Forms.TabPage KPI2_tabPage;
        private System.Windows.Forms.TabPage KPI3_tabPage;
        private System.Windows.Forms.TabPage InnovationsTabPage;
        private System.Windows.Forms.DataVisualization.Charting.Chart CustomerChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart FinancialChart;
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
        private System.Windows.Forms.Label KPI1_lblState;
        private System.Windows.Forms.Button KPI1_btnCalculate;
        private System.Windows.Forms.Label KPI1_lblVar4;
        private System.Windows.Forms.Label KPI1_lblVar3;
        private System.Windows.Forms.Label KPI1_lblVar2;
        private System.Windows.Forms.Label KPI1_lblVar1;
        private System.Windows.Forms.TextBox KPI1_txtVar4;
        private System.Windows.Forms.TextBox KPI1_txtVar3;
        private System.Windows.Forms.TextBox KPI1_txtVar2;
        private System.Windows.Forms.TextBox KPI1_txtVar1;
        private System.Windows.Forms.Button KPI1_btnSubmitDecision;
        private System.Windows.Forms.GroupBox KPI1_groupDecision;
        private System.Windows.Forms.RichTextBox KPI1_txtDecisionSummary;
        private System.Windows.Forms.RadioButton KPI1_radioDecision3;
        private System.Windows.Forms.RadioButton KPI1_radioDecision2;
        private System.Windows.Forms.RadioButton KPI1_radioDecision1;
        private System.Windows.Forms.Label KPI1_lblDecisionLogo;
        private System.Windows.Forms.Label KPI1_lblStateLogo;
        private System.Windows.Forms.Label KPI1_lblCalculateLogo;
        private System.Windows.Forms.Label KPI1_lblSummaryLogo;
        private System.Windows.Forms.RichTextBox KPI1_txtKPISummary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblColumn1;
        private System.Windows.Forms.TextBox KPI1_txtVar5;
        private System.Windows.Forms.Label KPI1_lblVar5;
    }
}

