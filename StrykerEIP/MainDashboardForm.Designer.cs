namespace StrykerEIP
{
    partial class MainDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDashboardForm));
            this.mdWelcomeLabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.mdHelpButton = new System.Windows.Forms.Button();
            this.mdExitButton = new System.Windows.Forms.Button();
            this.mdDateLabel = new System.Windows.Forms.Label();
            this.mdDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.mdMessageGroupBox = new System.Windows.Forms.GroupBox();
            this.mdOverviewsGroupBox = new System.Windows.Forms.GroupBox();
            this.mdSustainabilityIntelligence = new System.Windows.Forms.Button();
            this.mdGlobalIntelligenceButton = new System.Windows.Forms.Button();
            this.mdBusinessIntelligenceButton = new System.Windows.Forms.Button();
            this.mdMessageGroupBox.SuspendLayout();
            this.mdOverviewsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mdWelcomeLabel
            // 
            this.mdWelcomeLabel.AutoSize = true;
            this.mdWelcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.mdWelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdWelcomeLabel.Location = new System.Drawing.Point(12, 335);
            this.mdWelcomeLabel.Name = "mdWelcomeLabel";
            this.mdWelcomeLabel.Size = new System.Drawing.Size(403, 20);
            this.mdWelcomeLabel.TabIndex = 0;
            this.mdWelcomeLabel.Text = "Welcome to the Stryker Management Dashboard:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Maroon;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(17, 26);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(337, 62);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "Choose the Strategic Overview you wish to review.  For descriptions of Strategic " +
    "Overviews and/or general assistance choose the button labeled \"Help\".";
            // 
            // mdHelpButton
            // 
            this.mdHelpButton.Location = new System.Drawing.Point(198, 94);
            this.mdHelpButton.Name = "mdHelpButton";
            this.mdHelpButton.Size = new System.Drawing.Size(75, 23);
            this.mdHelpButton.TabIndex = 2;
            this.mdHelpButton.Text = "&Help";
            this.mdHelpButton.UseVisualStyleBackColor = true;
            // 
            // mdExitButton
            // 
            this.mdExitButton.Location = new System.Drawing.Point(279, 94);
            this.mdExitButton.Name = "mdExitButton";
            this.mdExitButton.Size = new System.Drawing.Size(75, 23);
            this.mdExitButton.TabIndex = 3;
            this.mdExitButton.Text = "E&xit";
            this.mdExitButton.UseVisualStyleBackColor = true;
            this.mdExitButton.Click += new System.EventHandler(this.mdExitButton_Click);
            // 
            // mdDateLabel
            // 
            this.mdDateLabel.AutoSize = true;
            this.mdDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.mdDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdDateLabel.Location = new System.Drawing.Point(69, 512);
            this.mdDateLabel.Name = "mdDateLabel";
            this.mdDateLabel.Size = new System.Drawing.Size(80, 13);
            this.mdDateLabel.TabIndex = 4;
            this.mdDateLabel.Text = "Last Update:";
            // 
            // mdDateTimePicker
            // 
            this.mdDateTimePicker.CalendarMonthBackground = System.Drawing.Color.Maroon;
            this.mdDateTimePicker.CalendarTitleForeColor = System.Drawing.Color.Maroon;
            this.mdDateTimePicker.CalendarTrailingForeColor = System.Drawing.Color.Maroon;
            this.mdDateTimePicker.Enabled = false;
            this.mdDateTimePicker.Location = new System.Drawing.Point(155, 508);
            this.mdDateTimePicker.Name = "mdDateTimePicker";
            this.mdDateTimePicker.Size = new System.Drawing.Size(205, 20);
            this.mdDateTimePicker.TabIndex = 5;
            // 
            // mdMessageGroupBox
            // 
            this.mdMessageGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.mdMessageGroupBox.Controls.Add(this.richTextBox1);
            this.mdMessageGroupBox.Controls.Add(this.mdHelpButton);
            this.mdMessageGroupBox.Controls.Add(this.mdExitButton);
            this.mdMessageGroupBox.ForeColor = System.Drawing.Color.Black;
            this.mdMessageGroupBox.Location = new System.Drawing.Point(29, 358);
            this.mdMessageGroupBox.Name = "mdMessageGroupBox";
            this.mdMessageGroupBox.Size = new System.Drawing.Size(369, 135);
            this.mdMessageGroupBox.TabIndex = 6;
            this.mdMessageGroupBox.TabStop = false;
            this.mdMessageGroupBox.Text = "Overview Navigation:";
            // 
            // mdOverviewsGroupBox
            // 
            this.mdOverviewsGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.mdOverviewsGroupBox.Controls.Add(this.mdSustainabilityIntelligence);
            this.mdOverviewsGroupBox.Controls.Add(this.mdGlobalIntelligenceButton);
            this.mdOverviewsGroupBox.Controls.Add(this.mdBusinessIntelligenceButton);
            this.mdOverviewsGroupBox.ForeColor = System.Drawing.Color.Black;
            this.mdOverviewsGroupBox.Location = new System.Drawing.Point(434, 358);
            this.mdOverviewsGroupBox.Name = "mdOverviewsGroupBox";
            this.mdOverviewsGroupBox.Size = new System.Drawing.Size(284, 135);
            this.mdOverviewsGroupBox.TabIndex = 7;
            this.mdOverviewsGroupBox.TabStop = false;
            this.mdOverviewsGroupBox.Text = "Stragic Overviews:";
            // 
            // mdSustainabilityIntelligence
            // 
            this.mdSustainabilityIntelligence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdSustainabilityIntelligence.Location = new System.Drawing.Point(40, 99);
            this.mdSustainabilityIntelligence.Name = "mdSustainabilityIntelligence";
            this.mdSustainabilityIntelligence.Size = new System.Drawing.Size(205, 30);
            this.mdSustainabilityIntelligence.TabIndex = 2;
            this.mdSustainabilityIntelligence.Text = "Sustainability Intelligence";
            this.mdSustainabilityIntelligence.UseVisualStyleBackColor = true;
            // 
            // mdGlobalIntelligenceButton
            // 
            this.mdGlobalIntelligenceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdGlobalIntelligenceButton.Location = new System.Drawing.Point(40, 58);
            this.mdGlobalIntelligenceButton.Name = "mdGlobalIntelligenceButton";
            this.mdGlobalIntelligenceButton.Size = new System.Drawing.Size(205, 30);
            this.mdGlobalIntelligenceButton.TabIndex = 1;
            this.mdGlobalIntelligenceButton.Text = "Global Intelligence";
            this.mdGlobalIntelligenceButton.UseVisualStyleBackColor = true;
            // 
            // mdBusinessIntelligenceButton
            // 
            this.mdBusinessIntelligenceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdBusinessIntelligenceButton.Location = new System.Drawing.Point(40, 19);
            this.mdBusinessIntelligenceButton.Name = "mdBusinessIntelligenceButton";
            this.mdBusinessIntelligenceButton.Size = new System.Drawing.Size(205, 30);
            this.mdBusinessIntelligenceButton.TabIndex = 0;
            this.mdBusinessIntelligenceButton.Text = "Business Intelligence";
            this.mdBusinessIntelligenceButton.UseVisualStyleBackColor = true;
            this.mdBusinessIntelligenceButton.Click += new System.EventHandler(this.mdBusinessIntelligenceButton_Click);
            // 
            // MainDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(751, 534);
            this.Controls.Add(this.mdOverviewsGroupBox);
            this.Controls.Add(this.mdMessageGroupBox);
            this.Controls.Add(this.mdDateTimePicker);
            this.Controls.Add(this.mdWelcomeLabel);
            this.Controls.Add(this.mdDateLabel);
            this.Name = "MainDashboardForm";
            this.Text = "MainDashboardForm";
            this.mdMessageGroupBox.ResumeLayout(false);
            this.mdOverviewsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mdWelcomeLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button mdHelpButton;
        private System.Windows.Forms.Button mdExitButton;
        private System.Windows.Forms.Label mdDateLabel;
        private System.Windows.Forms.DateTimePicker mdDateTimePicker;
        private System.Windows.Forms.GroupBox mdMessageGroupBox;
        private System.Windows.Forms.GroupBox mdOverviewsGroupBox;
        private System.Windows.Forms.Button mdSustainabilityIntelligence;
        private System.Windows.Forms.Button mdGlobalIntelligenceButton;
        private System.Windows.Forms.Button mdBusinessIntelligenceButton;
    }
}