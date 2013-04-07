namespace StrykerEIP
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.lfGroupBox = new System.Windows.Forms.GroupBox();
            this.lfLoginGroupBox = new System.Windows.Forms.GroupBox();
            this.lfPasswordTextBox = new System.Windows.Forms.TextBox();
            this.lfUserNameTextBox = new System.Windows.Forms.TextBox();
            this.lfClearButton = new System.Windows.Forms.Button();
            this.biPasswordLabel = new System.Windows.Forms.Label();
            this.biLoginButton = new System.Windows.Forms.Button();
            this.biUserNameLabel = new System.Windows.Forms.Label();
            this.lfMessageGroupBox = new System.Windows.Forms.GroupBox();
            this.biBoldedLoginLabel = new System.Windows.Forms.Label();
            this.biSplashScreenRichTextBox = new System.Windows.Forms.RichTextBox();
            this.lfHelpButton = new System.Windows.Forms.Button();
            this.lfExitButton = new System.Windows.Forms.Button();
            this.biWelcomeLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selfHelpPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lfGroupBox.SuspendLayout();
            this.lfLoginGroupBox.SuspendLayout();
            this.lfMessageGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lfGroupBox
            // 
            this.lfGroupBox.BackColor = System.Drawing.Color.Maroon;
            this.lfGroupBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lfGroupBox.BackgroundImage")));
            this.lfGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lfGroupBox.Controls.Add(this.lfLoginGroupBox);
            this.lfGroupBox.Controls.Add(this.lfMessageGroupBox);
            this.lfGroupBox.Controls.Add(this.biWelcomeLabel);
            this.lfGroupBox.ForeColor = System.Drawing.Color.Black;
            this.lfGroupBox.Location = new System.Drawing.Point(189, 68);
            this.lfGroupBox.Name = "lfGroupBox";
            this.lfGroupBox.Size = new System.Drawing.Size(856, 478);
            this.lfGroupBox.TabIndex = 8;
            this.lfGroupBox.TabStop = false;
            // 
            // lfLoginGroupBox
            // 
            this.lfLoginGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.lfLoginGroupBox.Controls.Add(this.lfPasswordTextBox);
            this.lfLoginGroupBox.Controls.Add(this.lfUserNameTextBox);
            this.lfLoginGroupBox.Controls.Add(this.lfClearButton);
            this.lfLoginGroupBox.Controls.Add(this.biPasswordLabel);
            this.lfLoginGroupBox.Controls.Add(this.biLoginButton);
            this.lfLoginGroupBox.Controls.Add(this.biUserNameLabel);
            this.lfLoginGroupBox.ForeColor = System.Drawing.Color.White;
            this.lfLoginGroupBox.Location = new System.Drawing.Point(546, 307);
            this.lfLoginGroupBox.Name = "lfLoginGroupBox";
            this.lfLoginGroupBox.Size = new System.Drawing.Size(244, 153);
            this.lfLoginGroupBox.TabIndex = 9;
            this.lfLoginGroupBox.TabStop = false;
            this.lfLoginGroupBox.Text = "Provide Login Information:";
            // 
            // lfPasswordTextBox
            // 
            this.lfPasswordTextBox.BackColor = System.Drawing.Color.Black;
            this.lfPasswordTextBox.ForeColor = System.Drawing.Color.White;
            this.lfPasswordTextBox.Location = new System.Drawing.Point(102, 61);
            this.lfPasswordTextBox.Name = "lfPasswordTextBox";
            this.lfPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.lfPasswordTextBox.TabIndex = 11;
            // 
            // lfUserNameTextBox
            // 
            this.lfUserNameTextBox.BackColor = System.Drawing.Color.Black;
            this.lfUserNameTextBox.ForeColor = System.Drawing.Color.White;
            this.lfUserNameTextBox.Location = new System.Drawing.Point(104, 25);
            this.lfUserNameTextBox.Name = "lfUserNameTextBox";
            this.lfUserNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lfUserNameTextBox.TabIndex = 10;
            // 
            // lfClearButton
            // 
            this.lfClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lfClearButton.ForeColor = System.Drawing.Color.Black;
            this.lfClearButton.Location = new System.Drawing.Point(128, 105);
            this.lfClearButton.Name = "lfClearButton";
            this.lfClearButton.Size = new System.Drawing.Size(85, 33);
            this.lfClearButton.TabIndex = 14;
            this.lfClearButton.Text = "C&lear";
            this.lfClearButton.UseVisualStyleBackColor = true;
            this.lfClearButton.Click += new System.EventHandler(this.lfClearButton_Click);
            // 
            // biPasswordLabel
            // 
            this.biPasswordLabel.AutoSize = true;
            this.biPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biPasswordLabel.ForeColor = System.Drawing.Color.White;
            this.biPasswordLabel.Location = new System.Drawing.Point(25, 63);
            this.biPasswordLabel.Name = "biPasswordLabel";
            this.biPasswordLabel.Size = new System.Drawing.Size(71, 16);
            this.biPasswordLabel.TabIndex = 10;
            this.biPasswordLabel.Text = "Password:";
            // 
            // biLoginButton
            // 
            this.biLoginButton.AccessibleDescription = "lfLoginButton";
            this.biLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biLoginButton.ForeColor = System.Drawing.Color.Black;
            this.biLoginButton.Location = new System.Drawing.Point(28, 105);
            this.biLoginButton.Name = "biLoginButton";
            this.biLoginButton.Size = new System.Drawing.Size(85, 33);
            this.biLoginButton.TabIndex = 13;
            this.biLoginButton.Text = "&Log in";
            this.biLoginButton.UseVisualStyleBackColor = true;
            this.biLoginButton.Click += new System.EventHandler(this.biLoginButton_Click);
            // 
            // biUserNameLabel
            // 
            this.biUserNameLabel.AutoSize = true;
            this.biUserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biUserNameLabel.ForeColor = System.Drawing.Color.White;
            this.biUserNameLabel.Location = new System.Drawing.Point(21, 28);
            this.biUserNameLabel.Name = "biUserNameLabel";
            this.biUserNameLabel.Size = new System.Drawing.Size(77, 16);
            this.biUserNameLabel.TabIndex = 0;
            this.biUserNameLabel.Text = "UserName:";
            // 
            // lfMessageGroupBox
            // 
            this.lfMessageGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.lfMessageGroupBox.Controls.Add(this.biBoldedLoginLabel);
            this.lfMessageGroupBox.Controls.Add(this.biSplashScreenRichTextBox);
            this.lfMessageGroupBox.Controls.Add(this.lfHelpButton);
            this.lfMessageGroupBox.Controls.Add(this.lfExitButton);
            this.lfMessageGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lfMessageGroupBox.ForeColor = System.Drawing.Color.White;
            this.lfMessageGroupBox.Location = new System.Drawing.Point(43, 307);
            this.lfMessageGroupBox.Name = "lfMessageGroupBox";
            this.lfMessageGroupBox.Size = new System.Drawing.Size(449, 153);
            this.lfMessageGroupBox.TabIndex = 8;
            this.lfMessageGroupBox.TabStop = false;
            this.lfMessageGroupBox.Text = "Please Log in";
            // 
            // biBoldedLoginLabel
            // 
            this.biBoldedLoginLabel.AutoSize = true;
            this.biBoldedLoginLabel.BackColor = System.Drawing.Color.Black;
            this.biBoldedLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biBoldedLoginLabel.ForeColor = System.Drawing.Color.White;
            this.biBoldedLoginLabel.Location = new System.Drawing.Point(265, 24);
            this.biBoldedLoginLabel.Name = "biBoldedLoginLabel";
            this.biBoldedLoginLabel.Size = new System.Drawing.Size(66, 18);
            this.biBoldedLoginLabel.TabIndex = 8;
            this.biBoldedLoginLabel.Text = "\"Log In\"";
            // 
            // biSplashScreenRichTextBox
            // 
            this.biSplashScreenRichTextBox.BackColor = System.Drawing.Color.Black;
            this.biSplashScreenRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biSplashScreenRichTextBox.ForeColor = System.Drawing.Color.White;
            this.biSplashScreenRichTextBox.Location = new System.Drawing.Point(16, 19);
            this.biSplashScreenRichTextBox.Name = "biSplashScreenRichTextBox";
            this.biSplashScreenRichTextBox.Size = new System.Drawing.Size(408, 67);
            this.biSplashScreenRichTextBox.TabIndex = 2;
            this.biSplashScreenRichTextBox.Text = "To review the conditions of Stryker                  by entering a valid User Nam" +
    "e and Password and press the button labeled \"Log In\"";
            // 
            // lfHelpButton
            // 
            this.lfHelpButton.ForeColor = System.Drawing.Color.Black;
            this.lfHelpButton.Location = new System.Drawing.Point(53, 107);
            this.lfHelpButton.Name = "lfHelpButton";
            this.lfHelpButton.Size = new System.Drawing.Size(93, 31);
            this.lfHelpButton.TabIndex = 5;
            this.lfHelpButton.Text = "&Help";
            this.lfHelpButton.UseVisualStyleBackColor = true;
            // 
            // lfExitButton
            // 
            this.lfExitButton.ForeColor = System.Drawing.Color.Black;
            this.lfExitButton.Location = new System.Drawing.Point(295, 107);
            this.lfExitButton.Name = "lfExitButton";
            this.lfExitButton.Size = new System.Drawing.Size(91, 31);
            this.lfExitButton.TabIndex = 7;
            this.lfExitButton.Text = "E&xit";
            this.lfExitButton.UseVisualStyleBackColor = true;
            this.lfExitButton.Click += new System.EventHandler(this.lfExitButton_Click);
            // 
            // biWelcomeLabel
            // 
            this.biWelcomeLabel.AutoSize = true;
            this.biWelcomeLabel.BackColor = System.Drawing.Color.Black;
            this.biWelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biWelcomeLabel.ForeColor = System.Drawing.Color.White;
            this.biWelcomeLabel.Location = new System.Drawing.Point(15, 271);
            this.biWelcomeLabel.Name = "biWelcomeLabel";
            this.biWelcomeLabel.Size = new System.Drawing.Size(466, 24);
            this.biWelcomeLabel.TabIndex = 4;
            this.biWelcomeLabel.Text = "Welcome to the Stryker Management Dashboard:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1276, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.clearFormToolStripMenuItem,
            this.exitProgramToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // clearFormToolStripMenuItem
            // 
            this.clearFormToolStripMenuItem.Name = "clearFormToolStripMenuItem";
            this.clearFormToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.clearFormToolStripMenuItem.Text = "Clear Form";
            this.clearFormToolStripMenuItem.Click += new System.EventHandler(this.clearFormToolStripMenuItem_Click);
            // 
            // exitProgramToolStripMenuItem
            // 
            this.exitProgramToolStripMenuItem.Name = "exitProgramToolStripMenuItem";
            this.exitProgramToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.exitProgramToolStripMenuItem.Text = "Exit Program";
            this.exitProgramToolStripMenuItem.Click += new System.EventHandler(this.exitProgramToolStripMenuItem_Click);
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
            this.contactToolStripMenuItem.Click += new System.EventHandler(this.contactToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1276, 674);
            this.Controls.Add(this.lfGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.lfGroupBox.ResumeLayout(false);
            this.lfGroupBox.PerformLayout();
            this.lfLoginGroupBox.ResumeLayout(false);
            this.lfLoginGroupBox.PerformLayout();
            this.lfMessageGroupBox.ResumeLayout(false);
            this.lfMessageGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox lfGroupBox;
        private System.Windows.Forms.GroupBox lfLoginGroupBox;
        private System.Windows.Forms.TextBox lfPasswordTextBox;
        private System.Windows.Forms.TextBox lfUserNameTextBox;
        private System.Windows.Forms.Label biPasswordLabel;
        private System.Windows.Forms.Label biUserNameLabel;
        private System.Windows.Forms.GroupBox lfMessageGroupBox;
        private System.Windows.Forms.Label biBoldedLoginLabel;
        private System.Windows.Forms.RichTextBox biSplashScreenRichTextBox;
        private System.Windows.Forms.Label biWelcomeLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selfHelpPDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button lfClearButton;
        private System.Windows.Forms.Button biLoginButton;
        private System.Windows.Forms.Button lfHelpButton;
        private System.Windows.Forms.Button lfExitButton;

    }
}