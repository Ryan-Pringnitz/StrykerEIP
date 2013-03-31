﻿using System.Windows.Forms.DataVisualization.Charting;

namespace PfizerEIP
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.FinancialTabPage.Click += new System.EventHandler(this.tabPage2_Click);
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
            chartArea5.Name = "ChartArea1";
            this.CustomerChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.CustomerChart.Legends.Add(legend5);
            this.CustomerChart.Location = new System.Drawing.Point(7, 33);
            this.CustomerChart.Name = "CustomerChart";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "CustomerSeries";
            this.CustomerChart.Series.Add(series5);
            this.CustomerChart.Size = new System.Drawing.Size(285, 247);
            this.CustomerChart.TabIndex = 1;
            this.CustomerChart.Text = "chart1";
            // 
            // FinancialChart
            // 
            chartArea6.Name = "ChartArea1";
            this.FinancialChart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.FinancialChart.Legends.Add(legend6);
            this.FinancialChart.Location = new System.Drawing.Point(311, 33);
            this.FinancialChart.Name = "FinancialChart";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid;
            series6.Legend = "Legend1";
            series6.Name = "FinancialSeries";
            this.FinancialChart.Series.Add(series6);
            this.FinancialChart.Size = new System.Drawing.Size(285, 247);
            this.FinancialChart.TabIndex = 2;
            this.FinancialChart.Text = "chart2";
            // 
            // OperationsChart
            // 
            chartArea7.Name = "ChartArea1";
            this.OperationsChart.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.OperationsChart.Legends.Add(legend7);
            this.OperationsChart.Location = new System.Drawing.Point(615, 33);
            this.OperationsChart.Name = "OperationsChart";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series7.Legend = "Legend1";
            series7.Name = "OperationsSeries";
            this.OperationsChart.Series.Add(series7);
            this.OperationsChart.Size = new System.Drawing.Size(285, 247);
            this.OperationsChart.TabIndex = 3;
            this.OperationsChart.Text = "chart3";
            // 
            // InnovationsChart
            // 
            chartArea8.Name = "ChartArea1";
            this.InnovationsChart.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.InnovationsChart.Legends.Add(legend8);
            this.InnovationsChart.Location = new System.Drawing.Point(919, 33);
            this.InnovationsChart.Name = "InnovationsChart";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "InnovationsSeries";
            this.InnovationsChart.Series.Add(series8);
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
            this.toolStripMenuItem2,
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
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.calculateToolStripMenuItem.Text = "Calculate";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(159, 22);
            this.toolStripMenuItem2.Text = "-----------------";
            // 
            // clearFormToolStripMenuItem
            // 
            this.clearFormToolStripMenuItem.Name = "clearFormToolStripMenuItem";
            this.clearFormToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.clearFormToolStripMenuItem.Text = "Clear Form";
            // 
            // returnToMenuToolStripMenuItem
            // 
            this.returnToMenuToolStripMenuItem.Name = "returnToMenuToolStripMenuItem";
            this.returnToMenuToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.returnToMenuToolStripMenuItem.Text = "Return to Menu";
            // 
            // exitProgramToolStripMenuItem
            // 
            this.exitProgramToolStripMenuItem.Name = "exitProgramToolStripMenuItem";
            this.exitProgramToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.exitProgramToolStripMenuItem.Text = "Exit Program";
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
            this.perspectivesToolStripMenuItem.Click += new System.EventHandler(this.perspectivesToolStripMenuItem_Click);
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
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.contactToolStripMenuItem.Text = "Contact";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
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
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
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
    }
}

