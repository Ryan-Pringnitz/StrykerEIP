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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea17 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend17 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea18 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend18 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea19 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend19 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea20 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend20 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CustomerTabPage = new System.Windows.Forms.TabPage();
            this.FinancialTabPage = new System.Windows.Forms.TabPage();
            this.OperationsTabPage = new System.Windows.Forms.TabPage();
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
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinancialChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InnovationsChart)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CustomerTabPage);
            this.tabControl1.Controls.Add(this.FinancialTabPage);
            this.tabControl1.Controls.Add(this.OperationsTabPage);
            this.tabControl1.Controls.Add(this.InnovationsTabPage);
            this.tabControl1.Location = new System.Drawing.Point(14, 286);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1182, 309);
            this.tabControl1.TabIndex = 0;
            // 
            // CustomerTabPage
            // 
            this.CustomerTabPage.Location = new System.Drawing.Point(4, 22);
            this.CustomerTabPage.Name = "CustomerTabPage";
            this.CustomerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CustomerTabPage.Size = new System.Drawing.Size(1174, 283);
            this.CustomerTabPage.TabIndex = 0;
            this.CustomerTabPage.Text = "Customer";
            this.CustomerTabPage.UseVisualStyleBackColor = true;
            // 
            // FinancialTabPage
            // 
            this.FinancialTabPage.Location = new System.Drawing.Point(4, 22);
            this.FinancialTabPage.Name = "FinancialTabPage";
            this.FinancialTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.FinancialTabPage.Size = new System.Drawing.Size(1174, 283);
            this.FinancialTabPage.TabIndex = 1;
            this.FinancialTabPage.Text = "Financial";
            this.FinancialTabPage.UseVisualStyleBackColor = true;
            // 
            // OperationsTabPage
            // 
            this.OperationsTabPage.Location = new System.Drawing.Point(4, 22);
            this.OperationsTabPage.Name = "OperationsTabPage";
            this.OperationsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.OperationsTabPage.Size = new System.Drawing.Size(1174, 283);
            this.OperationsTabPage.TabIndex = 2;
            this.OperationsTabPage.Text = "Operations";
            this.OperationsTabPage.UseVisualStyleBackColor = true;
            // 
            // InnovationsTabPage
            // 
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
            chartArea17.Name = "ChartArea1";
            this.CustomerChart.ChartAreas.Add(chartArea17);
            legend17.Name = "Legend1";
            this.CustomerChart.Legends.Add(legend17);
            this.CustomerChart.Location = new System.Drawing.Point(7, 33);
            this.CustomerChart.Name = "CustomerChart";
            series17.ChartArea = "ChartArea1";
            series17.Legend = "Legend1";
            series17.Name = "CustomerSeries";
            this.CustomerChart.Series.Add(series17);
            this.CustomerChart.Size = new System.Drawing.Size(285, 247);
            this.CustomerChart.TabIndex = 1;
            this.CustomerChart.Text = "chart1";
            // 
            // FinancialChart
            // 
            chartArea18.Name = "ChartArea1";
            this.FinancialChart.ChartAreas.Add(chartArea18);
            legend18.Name = "Legend1";
            this.FinancialChart.Legends.Add(legend18);
            this.FinancialChart.Location = new System.Drawing.Point(311, 33);
            this.FinancialChart.Name = "FinancialChart";
            series18.ChartArea = "ChartArea1";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid;
            series18.Legend = "Legend1";
            series18.Name = "FinancialSeries";
            this.FinancialChart.Series.Add(series18);
            this.FinancialChart.Size = new System.Drawing.Size(285, 247);
            this.FinancialChart.TabIndex = 2;
            this.FinancialChart.Text = "chart2";
            // 
            // OperationsChart
            // 
            chartArea19.Name = "ChartArea1";
            this.OperationsChart.ChartAreas.Add(chartArea19);
            legend19.Name = "Legend1";
            this.OperationsChart.Legends.Add(legend19);
            this.OperationsChart.Location = new System.Drawing.Point(615, 33);
            this.OperationsChart.Name = "OperationsChart";
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series19.Legend = "Legend1";
            series19.Name = "OperationsSeries";
            this.OperationsChart.Series.Add(series19);
            this.OperationsChart.Size = new System.Drawing.Size(285, 247);
            this.OperationsChart.TabIndex = 3;
            this.OperationsChart.Text = "chart3";
            // 
            // InnovationsChart
            // 
            chartArea20.Name = "ChartArea1";
            this.InnovationsChart.ChartAreas.Add(chartArea20);
            legend20.Name = "Legend1";
            this.InnovationsChart.Legends.Add(legend20);
            this.InnovationsChart.Location = new System.Drawing.Point(919, 33);
            this.InnovationsChart.Name = "InnovationsChart";
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series20.Legend = "Legend1";
            series20.Name = "InnovationsSeries";
            this.InnovationsChart.Series.Add(series20);
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
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.ClientSize = new System.Drawing.Size(1216, 609);
            this.Controls.Add(this.InnovationsChart);
            this.Controls.Add(this.OperationsChart);
            this.Controls.Add(this.FinancialChart);
            this.Controls.Add(this.CustomerChart);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BusinessIntelligenceForm";
            this.Text = "Business Intelligence Dashboard";
            this.Load += new System.EventHandler(this.BusinessIntelligenceForm_Load);
            this.tabControl1.ResumeLayout(false);
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

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CustomerTabPage;
        private System.Windows.Forms.TabPage FinancialTabPage;
        private System.Windows.Forms.TabPage OperationsTabPage;
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
    }
}

