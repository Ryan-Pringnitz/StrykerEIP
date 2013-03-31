using System.Windows.Forms.DataVisualization.Charting;

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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series CustomerSeries = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series FinancialSeries = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series OperationsSeries = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series InnovationsSeries = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CustomerTabPage = new System.Windows.Forms.TabPage();
            this.FinancialTabPage = new System.Windows.Forms.TabPage();
            this.OperationsTabPage = new System.Windows.Forms.TabPage();
            this.InnovationsTabPage = new System.Windows.Forms.TabPage();
            this.CustomerChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.FinancialChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.OperationsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.InnovationsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinancialChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InnovationsChart)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CustomerTabPage);
            this.tabControl1.Controls.Add(this.FinancialTabPage);
            this.tabControl1.Controls.Add(this.OperationsTabPage);
            this.tabControl1.Controls.Add(this.InnovationsTabPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 265);
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
            this.FinancialTabPage.Size = new System.Drawing.Size(866, 257);
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
            this.OperationsTabPage.Size = new System.Drawing.Size(866, 257);
            this.OperationsTabPage.TabIndex = 2;
            this.OperationsTabPage.Text = "Operations";
            this.OperationsTabPage.UseVisualStyleBackColor = true;
            // 
            // InnovationsTabPage
            // 
            this.InnovationsTabPage.Location = new System.Drawing.Point(4, 22);
            this.InnovationsTabPage.Name = "InnovationsTabPage";
            this.InnovationsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.InnovationsTabPage.Size = new System.Drawing.Size(866, 257);
            this.InnovationsTabPage.TabIndex = 3;
            this.InnovationsTabPage.Text = "Innovations";
            this.InnovationsTabPage.UseVisualStyleBackColor = true;
            // 
            // CustomerChart
            // 
            chartArea1.Name = "ChartArea1";
            this.CustomerChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.CustomerChart.Legends.Add(legend1);
            this.CustomerChart.Location = new System.Drawing.Point(5, 12);
            this.CustomerChart.Name = "CustomerChart";
            CustomerSeries.ChartArea = "ChartArea1";
            CustomerSeries.Legend = "Legend1";
            CustomerSeries.Name = "CustomerSeries";
            this.CustomerChart.Series.Add(CustomerSeries);
            this.CustomerChart.Size = new System.Drawing.Size(285, 247);
            this.CustomerChart.TabIndex = 1;
            this.CustomerChart.Text = "chart1";
            // 
            // FinancialChart
            // 
            chartArea2.Name = "ChartArea1";
            this.FinancialChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.FinancialChart.Legends.Add(legend2);
            this.FinancialChart.Location = new System.Drawing.Point(309, 12);
            this.FinancialChart.Name = "FinancialChart";
            FinancialSeries.ChartArea = "ChartArea1";
            FinancialSeries.Legend = "Legend1";
            FinancialSeries.Name = "FinancialSeries";
            FinancialSeries.ChartType = SeriesChartType.Pyramid;
            this.FinancialChart.Series.Add(FinancialSeries);
            this.FinancialChart.Size = new System.Drawing.Size(285, 247);
            this.FinancialChart.TabIndex = 2;
            this.FinancialChart.Text = "chart2";
            // 
            // OperationsChart
            // 
            chartArea3.Name = "ChartArea1";
            this.OperationsChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.OperationsChart.Legends.Add(legend3);
            this.OperationsChart.Location = new System.Drawing.Point(613, 12);
            this.OperationsChart.Name = "OperationsChart";
            OperationsSeries.ChartArea = "ChartArea1";
            OperationsSeries.Legend = "Legend1";
            OperationsSeries.Name = "OperationsSeries";
            OperationsSeries.ChartType = SeriesChartType.Pie;
            this.OperationsChart.Series.Add(OperationsSeries);
            this.OperationsChart.Size = new System.Drawing.Size(285, 247);
            this.OperationsChart.TabIndex = 3;
            this.OperationsChart.Text = "chart3";
            // 
            // InnovationsChart
            // 
            chartArea4.Name = "ChartArea1";
            this.InnovationsChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.InnovationsChart.Legends.Add(legend4);
            this.InnovationsChart.Location = new System.Drawing.Point(917, 12);
            this.InnovationsChart.Name = "InnovationsChart";
            InnovationsSeries.ChartArea = "ChartArea1";
            InnovationsSeries.Legend = "Legend1";
            InnovationsSeries.Name = "InnovationsSeries";
            InnovationsSeries.ChartType = SeriesChartType.Line;
            this.InnovationsChart.Series.Add(InnovationsSeries);
            this.InnovationsChart.Size = new System.Drawing.Size(285, 247);
            this.InnovationsChart.TabIndex = 4;
            this.InnovationsChart.Text = "chart4";
            // 
            // BusinessIntelligenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 586);
            this.Controls.Add(this.InnovationsChart);
            this.Controls.Add(this.OperationsChart);
            this.Controls.Add(this.FinancialChart);
            this.Controls.Add(this.CustomerChart);
            this.Controls.Add(this.tabControl1);
            this.Name = "BusinessIntelligenceForm";
            this.Text = "Business Intelligence Dashboard";
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinancialChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InnovationsChart)).EndInit();
            this.ResumeLayout(false);

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
    }
}

