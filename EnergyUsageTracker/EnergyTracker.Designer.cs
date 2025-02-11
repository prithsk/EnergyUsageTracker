namespace EnergyUsageTracker
{
    partial class EnergyTracker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnergyTracker));
            this.labelEnergyTracker = new System.Windows.Forms.Label();
            this.btnLogAppliances = new System.Windows.Forms.Button();
            this.btnback1 = new System.Windows.Forms.Button();
            this.labllHome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelEnergyTracker
            // 
            this.labelEnergyTracker.AutoSize = true;
            this.labelEnergyTracker.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelEnergyTracker.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelEnergyTracker.Location = new System.Drawing.Point(324, 9);
            this.labelEnergyTracker.Name = "labelEnergyTracker";
            this.labelEnergyTracker.Size = new System.Drawing.Size(159, 26);
            this.labelEnergyTracker.TabIndex = 2;
            this.labelEnergyTracker.Text = "Energy Tracker";
            // 
            // btnLogAppliances
            // 
            this.btnLogAppliances.BackColor = System.Drawing.Color.Coral;
            this.btnLogAppliances.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLogAppliances.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogAppliances.Location = new System.Drawing.Point(289, 166);
            this.btnLogAppliances.Name = "btnLogAppliances";
            this.btnLogAppliances.Size = new System.Drawing.Size(222, 90);
            this.btnLogAppliances.TabIndex = 5;
            this.btnLogAppliances.Text = "Log Appliances";
            this.btnLogAppliances.UseVisualStyleBackColor = false;
            this.btnLogAppliances.Click += new System.EventHandler(this.btnLogAppliances_Click_1);
            // 
            // btnback1
            // 
            this.btnback1.BackColor = System.Drawing.Color.Coral;
            this.btnback1.Image = ((System.Drawing.Image)(resources.GetObject("btnback1.Image")));
            this.btnback1.Location = new System.Drawing.Point(601, 9);
            this.btnback1.Name = "btnback1";
            this.btnback1.Size = new System.Drawing.Size(187, 64);
            this.btnback1.TabIndex = 6;
            this.btnback1.UseVisualStyleBackColor = false;
            this.btnback1.Click += new System.EventHandler(this.btnback1_Click);
            // 
            // labllHome
            // 
            this.labllHome.AutoSize = true;
            this.labllHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labllHome.Location = new System.Drawing.Point(667, 76);
            this.labllHome.Name = "labllHome";
            this.labllHome.Size = new System.Drawing.Size(52, 20);
            this.labllHome.TabIndex = 7;
            this.labllHome.Text = "Home";
            // 
            // EnergyTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labllHome);
            this.Controls.Add(this.btnback1);
            this.Controls.Add(this.btnLogAppliances);
            this.Controls.Add(this.labelEnergyTracker);
            this.Name = "EnergyTracker";
            this.Text = "Energy Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEnergyTracker;
        private System.Windows.Forms.Button btnLogAppliances;
        private System.Windows.Forms.Button btnback1;
        private System.Windows.Forms.Label labllHome;
    }
}