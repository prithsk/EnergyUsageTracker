namespace EnergyUsageTracker
{
    partial class HomePage
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
            this.labelHome = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnEnergyTracker = new System.Windows.Forms.Button();
            this.btnRecommendations = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelHome.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelHome.Location = new System.Drawing.Point(369, 9);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(71, 26);
            this.labelHome.TabIndex = 0;
            this.labelHome.Text = "Home";
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAbout.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnAbout.Location = new System.Drawing.Point(85, 104);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(174, 52);
            this.btnAbout.TabIndex = 1;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click_1);
            // 
            // btnEnergyTracker
            // 
            this.btnEnergyTracker.BackColor = System.Drawing.Color.Coral;
            this.btnEnergyTracker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEnergyTracker.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEnergyTracker.Location = new System.Drawing.Point(521, 104);
            this.btnEnergyTracker.Name = "btnEnergyTracker";
            this.btnEnergyTracker.Size = new System.Drawing.Size(174, 52);
            this.btnEnergyTracker.TabIndex = 2;
            this.btnEnergyTracker.Text = "Energy Tracker";
            this.btnEnergyTracker.UseVisualStyleBackColor = false;
            this.btnEnergyTracker.Click += new System.EventHandler(this.btnEnergyTracker_Click_1);
            // 
            // btnRecommendations
            // 
            this.btnRecommendations.BackColor = System.Drawing.Color.Coral;
            this.btnRecommendations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRecommendations.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnRecommendations.Location = new System.Drawing.Point(85, 234);
            this.btnRecommendations.Name = "btnRecommendations";
            this.btnRecommendations.Size = new System.Drawing.Size(174, 52);
            this.btnRecommendations.TabIndex = 3;
            this.btnRecommendations.Text = "Recommendations";
            this.btnRecommendations.UseVisualStyleBackColor = false;
            this.btnRecommendations.Click += new System.EventHandler(this.btnRecommendations_Click_1);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Coral;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSettings.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnSettings.Location = new System.Drawing.Point(521, 234);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(174, 52);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click_1);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnRecommendations);
            this.Controls.Add(this.btnEnergyTracker);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.labelHome);
            this.Name = "HomePage";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHome;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnEnergyTracker;
        private System.Windows.Forms.Button btnRecommendations;
        private System.Windows.Forms.Button btnSettings;
    }
}