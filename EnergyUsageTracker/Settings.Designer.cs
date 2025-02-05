namespace EnergyUsageTracker
{
    partial class Settings
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
            this.labelSettings = new System.Windows.Forms.Label();
            this.labelDarkMode = new System.Windows.Forms.Label();
            this.labelNotifications = new System.Windows.Forms.Label();
            this.labelTotalEnergyUsageStored = new System.Windows.Forms.Label();
            this.labelClearAppData = new System.Windows.Forms.Label();
            this.btnClearAppData = new System.Windows.Forms.Button();
            this.txtBoxTotalEnergyUsageStored = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelSettings
            // 
            this.labelSettings.AutoSize = true;
            this.labelSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelSettings.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelSettings.Location = new System.Drawing.Point(360, 9);
            this.labelSettings.Name = "labelSettings";
            this.labelSettings.Size = new System.Drawing.Size(91, 26);
            this.labelSettings.TabIndex = 3;
            this.labelSettings.Text = "Settings";
            // 
            // labelDarkMode
            // 
            this.labelDarkMode.AutoSize = true;
            this.labelDarkMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelDarkMode.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelDarkMode.Location = new System.Drawing.Point(110, 144);
            this.labelDarkMode.Name = "labelDarkMode";
            this.labelDarkMode.Size = new System.Drawing.Size(91, 20);
            this.labelDarkMode.TabIndex = 4;
            this.labelDarkMode.Text = "Dark Mode:";
            // 
            // labelNotifications
            // 
            this.labelNotifications.AutoSize = true;
            this.labelNotifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelNotifications.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelNotifications.Location = new System.Drawing.Point(529, 144);
            this.labelNotifications.Name = "labelNotifications";
            this.labelNotifications.Size = new System.Drawing.Size(100, 20);
            this.labelNotifications.TabIndex = 5;
            this.labelNotifications.Text = "Notifications:";
            // 
            // labelTotalEnergyUsageStored
            // 
            this.labelTotalEnergyUsageStored.AutoSize = true;
            this.labelTotalEnergyUsageStored.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelTotalEnergyUsageStored.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelTotalEnergyUsageStored.Location = new System.Drawing.Point(110, 270);
            this.labelTotalEnergyUsageStored.Name = "labelTotalEnergyUsageStored";
            this.labelTotalEnergyUsageStored.Size = new System.Drawing.Size(265, 20);
            this.labelTotalEnergyUsageStored.TabIndex = 6;
            this.labelTotalEnergyUsageStored.Text = "Total Energy Usage Stored (Joules):";
            // 
            // labelClearAppData
            // 
            this.labelClearAppData.AutoSize = true;
            this.labelClearAppData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelClearAppData.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelClearAppData.Location = new System.Drawing.Point(529, 272);
            this.labelClearAppData.Name = "labelClearAppData";
            this.labelClearAppData.Size = new System.Drawing.Size(122, 20);
            this.labelClearAppData.TabIndex = 7;
            this.labelClearAppData.Text = "Clear App Data:";
            // 
            // btnClearAppData
            // 
            this.btnClearAppData.BackColor = System.Drawing.Color.Coral;
            this.btnClearAppData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClearAppData.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClearAppData.Location = new System.Drawing.Point(657, 256);
            this.btnClearAppData.Name = "btnClearAppData";
            this.btnClearAppData.Size = new System.Drawing.Size(101, 52);
            this.btnClearAppData.TabIndex = 8;
            this.btnClearAppData.Text = "Clear App Data";
            this.btnClearAppData.UseVisualStyleBackColor = false;
            // 
            // txtBoxTotalEnergyUsageStored
            // 
            this.txtBoxTotalEnergyUsageStored.Location = new System.Drawing.Point(381, 272);
            this.txtBoxTotalEnergyUsageStored.Name = "txtBoxTotalEnergyUsageStored";
            this.txtBoxTotalEnergyUsageStored.Size = new System.Drawing.Size(106, 20);
            this.txtBoxTotalEnergyUsageStored.TabIndex = 9;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxTotalEnergyUsageStored);
            this.Controls.Add(this.btnClearAppData);
            this.Controls.Add(this.labelClearAppData);
            this.Controls.Add(this.labelTotalEnergyUsageStored);
            this.Controls.Add(this.labelNotifications);
            this.Controls.Add(this.labelDarkMode);
            this.Controls.Add(this.labelSettings);
            this.Name = "Settings";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSettings;
        private System.Windows.Forms.Label labelDarkMode;
        private System.Windows.Forms.Label labelNotifications;
        private System.Windows.Forms.Label labelTotalEnergyUsageStored;
        private System.Windows.Forms.Label labelClearAppData;
        private System.Windows.Forms.Button btnClearAppData;
        private System.Windows.Forms.TextBox txtBoxTotalEnergyUsageStored;
    }
}