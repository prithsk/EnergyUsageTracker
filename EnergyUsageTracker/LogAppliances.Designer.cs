namespace EnergyUsageTracker
{
    partial class LogAppliances
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
            this.labelLogAppliances = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.labelHist = new System.Windows.Forms.Label();
            this.labelEnergyUsageDesc = new System.Windows.Forms.Label();
            this.labelUsageDuration = new System.Windows.Forms.Label();
            this.labelApplianceName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLogAppliances
            // 
            this.labelLogAppliances.AutoSize = true;
            this.labelLogAppliances.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelLogAppliances.Location = new System.Drawing.Point(323, 9);
            this.labelLogAppliances.Name = "labelLogAppliances";
            this.labelLogAppliances.Size = new System.Drawing.Size(161, 26);
            this.labelLogAppliances.TabIndex = 0;
            this.labelLogAppliances.Text = "Log Appliances";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(116, 103);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(158, 53);
            this.textBox3.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 309);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(213, 79);
            this.textBox2.TabIndex = 20;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(116, 202);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(158, 57);
            this.textBox5.TabIndex = 19;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(483, 103);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(201, 285);
            this.textBox4.TabIndex = 17;
            // 
            // labelHist
            // 
            this.labelHist.AutoSize = true;
            this.labelHist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelHist.Location = new System.Drawing.Point(479, 80);
            this.labelHist.Name = "labelHist";
            this.labelHist.Size = new System.Drawing.Size(62, 20);
            this.labelHist.TabIndex = 16;
            this.labelHist.Text = "History:";
            // 
            // labelEnergyUsageDesc
            // 
            this.labelEnergyUsageDesc.AutoSize = true;
            this.labelEnergyUsageDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEnergyUsageDesc.Location = new System.Drawing.Point(112, 286);
            this.labelEnergyUsageDesc.Name = "labelEnergyUsageDesc";
            this.labelEnergyUsageDesc.Size = new System.Drawing.Size(226, 20);
            this.labelEnergyUsageDesc.TabIndex = 15;
            this.labelEnergyUsageDesc.Text = "Energy Usage Desc(Wattage):";
            // 
            // labelUsageDuration
            // 
            this.labelUsageDuration.AutoSize = true;
            this.labelUsageDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelUsageDuration.Location = new System.Drawing.Point(112, 179);
            this.labelUsageDuration.Name = "labelUsageDuration";
            this.labelUsageDuration.Size = new System.Drawing.Size(125, 20);
            this.labelUsageDuration.TabIndex = 14;
            this.labelUsageDuration.Text = "Usage Duration:";
            // 
            // labelApplianceName
            // 
            this.labelApplianceName.AutoSize = true;
            this.labelApplianceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelApplianceName.Location = new System.Drawing.Point(112, 80);
            this.labelApplianceName.Name = "labelApplianceName";
            this.labelApplianceName.Size = new System.Drawing.Size(129, 20);
            this.labelApplianceName.TabIndex = 13;
            this.labelApplianceName.Text = "Appliance Name:";
            // 
            // LogAppliances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.labelHist);
            this.Controls.Add(this.labelEnergyUsageDesc);
            this.Controls.Add(this.labelUsageDuration);
            this.Controls.Add(this.labelApplianceName);
            this.Controls.Add(this.labelLogAppliances);
            this.Name = "LogAppliances";
            this.Text = "LogAppliances";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogAppliances;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label labelHist;
        private System.Windows.Forms.Label labelEnergyUsageDesc;
        private System.Windows.Forms.Label labelUsageDuration;
        private System.Windows.Forms.Label labelApplianceName;
    }
}