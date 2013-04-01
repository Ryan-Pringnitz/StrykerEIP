namespace MainDashboard
{
    partial class dashboardForm
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
            this.globalIntelligenceButton = new System.Windows.Forms.Button();
            this.businessIntelligenceButton = new System.Windows.Forms.Button();
            this.sustainabilityIntelligenceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // globalIntelligenceButton
            // 
            this.globalIntelligenceButton.Location = new System.Drawing.Point(12, 319);
            this.globalIntelligenceButton.Name = "globalIntelligenceButton";
            this.globalIntelligenceButton.Size = new System.Drawing.Size(186, 37);
            this.globalIntelligenceButton.TabIndex = 0;
            this.globalIntelligenceButton.Text = "Global Intelligence";
            this.globalIntelligenceButton.UseVisualStyleBackColor = true;
            this.globalIntelligenceButton.Click += new System.EventHandler(this.globalIntelligenceButton_Click);
            // 
            // businessIntelligenceButton
            // 
            this.businessIntelligenceButton.Location = new System.Drawing.Point(267, 319);
            this.businessIntelligenceButton.Name = "businessIntelligenceButton";
            this.businessIntelligenceButton.Size = new System.Drawing.Size(186, 37);
            this.businessIntelligenceButton.TabIndex = 1;
            this.businessIntelligenceButton.Text = "Business Intelligence\r\n";
            this.businessIntelligenceButton.UseVisualStyleBackColor = true;
            this.businessIntelligenceButton.Click += new System.EventHandler(this.businessIntelligenceButton_Click);
            // 
            // sustainabilityIntelligenceButton
            // 
            this.sustainabilityIntelligenceButton.Location = new System.Drawing.Point(531, 319);
            this.sustainabilityIntelligenceButton.Name = "sustainabilityIntelligenceButton";
            this.sustainabilityIntelligenceButton.Size = new System.Drawing.Size(186, 37);
            this.sustainabilityIntelligenceButton.TabIndex = 2;
            this.sustainabilityIntelligenceButton.Text = "Sustainability Intelligence";
            this.sustainabilityIntelligenceButton.UseVisualStyleBackColor = true;
            this.sustainabilityIntelligenceButton.Click += new System.EventHandler(this.sustainabilityIntelligenceButton_Click);
            // 
            // dashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MainDashboard.Properties.Resources.BronsonERPMainInterfaceTemplate;
            this.ClientSize = new System.Drawing.Size(749, 540);
            this.Controls.Add(this.sustainabilityIntelligenceButton);
            this.Controls.Add(this.businessIntelligenceButton);
            this.Controls.Add(this.globalIntelligenceButton);
            this.Name = "dashboardForm";
            this.Text = "Bronson Overview";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button globalIntelligenceButton;
        private System.Windows.Forms.Button businessIntelligenceButton;
        private System.Windows.Forms.Button sustainabilityIntelligenceButton;
    }
}

