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
            this.labelEnergyTracker = new System.Windows.Forms.Label();
            this.btnLogAppliances = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEnergyTracker
            // 
            this.labelEnergyTracker.AutoSize = true;
            this.labelEnergyTracker.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelEnergyTracker.ForeColor = System.Drawing.SystemColors.HighlightText;
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
            // 
            // EnergyTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}