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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogAppliances));
            this.labelLogAppliances = new System.Windows.Forms.Label();
            this.txtAppName = new System.Windows.Forms.TextBox();
            this.txtEnergyUse = new System.Windows.Forms.TextBox();
            this.txtUseDur = new System.Windows.Forms.TextBox();
            this.txtHis = new System.Windows.Forms.TextBox();
            this.labelHist = new System.Windows.Forms.Label();
            this.labelEnergyUsageDesc = new System.Windows.Forms.Label();
            this.labelUsageDuration = new System.Windows.Forms.Label();
            this.labelApplianceName = new System.Windows.Forms.Label();
            this.btnback8 = new System.Windows.Forms.Button();
            this.btnback9 = new System.Windows.Forms.Button();
            this.listBoxHistory = new System.Windows.Forms.ListBox();
            this.btnAddAppliance = new System.Windows.Forms.Button();
            this.laEnergyTracker = new System.Windows.Forms.Label();
            this.labHome = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
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
            // txtAppName
            // 
            this.txtAppName.Location = new System.Drawing.Point(68, 138);
            this.txtAppName.Multiline = true;
            this.txtAppName.Name = "txtAppName";
            this.txtAppName.Size = new System.Drawing.Size(158, 53);
            this.txtAppName.TabIndex = 21;
            // 
            // txtEnergyUse
            // 
            this.txtEnergyUse.Location = new System.Drawing.Point(68, 344);
            this.txtEnergyUse.Multiline = true;
            this.txtEnergyUse.Name = "txtEnergyUse";
            this.txtEnergyUse.Size = new System.Drawing.Size(213, 79);
            this.txtEnergyUse.TabIndex = 20;
            // 
            // txtUseDur
            // 
            this.txtUseDur.Location = new System.Drawing.Point(68, 237);
            this.txtUseDur.Multiline = true;
            this.txtUseDur.Name = "txtUseDur";
            this.txtUseDur.Size = new System.Drawing.Size(158, 57);
            this.txtUseDur.TabIndex = 19;
            // 
            // txtHis
            // 
            this.txtHis.Location = new System.Drawing.Point(544, 138);
            this.txtHis.Multiline = true;
            this.txtHis.Name = "txtHis";
            this.txtHis.Size = new System.Drawing.Size(201, 285);
            this.txtHis.TabIndex = 17;
            // 
            // labelHist
            // 
            this.labelHist.AutoSize = true;
            this.labelHist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelHist.Location = new System.Drawing.Point(540, 115);
            this.labelHist.Name = "labelHist";
            this.labelHist.Size = new System.Drawing.Size(62, 20);
            this.labelHist.TabIndex = 16;
            this.labelHist.Text = "History:";
            // 
            // labelEnergyUsageDesc
            // 
            this.labelEnergyUsageDesc.AutoSize = true;
            this.labelEnergyUsageDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEnergyUsageDesc.Location = new System.Drawing.Point(64, 321);
            this.labelEnergyUsageDesc.Name = "labelEnergyUsageDesc";
            this.labelEnergyUsageDesc.Size = new System.Drawing.Size(226, 20);
            this.labelEnergyUsageDesc.TabIndex = 15;
            this.labelEnergyUsageDesc.Text = "Energy Usage Desc(Wattage):";
            // 
            // labelUsageDuration
            // 
            this.labelUsageDuration.AutoSize = true;
            this.labelUsageDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelUsageDuration.Location = new System.Drawing.Point(64, 214);
            this.labelUsageDuration.Name = "labelUsageDuration";
            this.labelUsageDuration.Size = new System.Drawing.Size(125, 20);
            this.labelUsageDuration.TabIndex = 14;
            this.labelUsageDuration.Text = "Usage Duration:";
            // 
            // labelApplianceName
            // 
            this.labelApplianceName.AutoSize = true;
            this.labelApplianceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelApplianceName.Location = new System.Drawing.Point(64, 115);
            this.labelApplianceName.Name = "labelApplianceName";
            this.labelApplianceName.Size = new System.Drawing.Size(129, 20);
            this.labelApplianceName.TabIndex = 13;
            this.labelApplianceName.Text = "Appliance Name:";
            // 
            // btnback8
            // 
            this.btnback8.BackColor = System.Drawing.Color.Coral;
            this.btnback8.Image = ((System.Drawing.Image)(resources.GetObject("btnback8.Image")));
            this.btnback8.Location = new System.Drawing.Point(601, 9);
            this.btnback8.Name = "btnback8";
            this.btnback8.Size = new System.Drawing.Size(187, 64);
            this.btnback8.TabIndex = 22;
            this.btnback8.UseVisualStyleBackColor = false;
            this.btnback8.Click += new System.EventHandler(this.btnback8_Click);
            // 
            // btnback9
            // 
            this.btnback9.BackColor = System.Drawing.Color.Coral;
            this.btnback9.Image = ((System.Drawing.Image)(resources.GetObject("btnback9.Image")));
            this.btnback9.Location = new System.Drawing.Point(12, 9);
            this.btnback9.Name = "btnback9";
            this.btnback9.Size = new System.Drawing.Size(187, 64);
            this.btnback9.TabIndex = 23;
            this.btnback9.UseVisualStyleBackColor = false;
            this.btnback9.Click += new System.EventHandler(this.btnback9_Click);
            // 
            // listBoxHistory
            // 
            this.listBoxHistory.FormattingEnabled = true;
            this.listBoxHistory.Location = new System.Drawing.Point(544, 138);
            this.listBoxHistory.Name = "listBoxHistory";
            this.listBoxHistory.Size = new System.Drawing.Size(201, 290);
            this.listBoxHistory.TabIndex = 24;
            // 
            // btnAddAppliance
            // 
            this.btnAddAppliance.BackColor = System.Drawing.Color.Coral;
            this.btnAddAppliance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddAppliance.Location = new System.Drawing.Point(360, 177);
            this.btnAddAppliance.Name = "btnAddAppliance";
            this.btnAddAppliance.Size = new System.Drawing.Size(108, 95);
            this.btnAddAppliance.TabIndex = 25;
            this.btnAddAppliance.Text = "Log";
            this.btnAddAppliance.UseVisualStyleBackColor = false;
            this.btnAddAppliance.Click += new System.EventHandler(this.btnAddAppliance_Click_1);
            // 
            // laEnergyTracker
            // 
            this.laEnergyTracker.AutoSize = true;
            this.laEnergyTracker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.laEnergyTracker.Location = new System.Drawing.Point(64, 76);
            this.laEnergyTracker.Name = "laEnergyTracker";
            this.laEnergyTracker.Size = new System.Drawing.Size(116, 20);
            this.laEnergyTracker.TabIndex = 29;
            this.laEnergyTracker.Text = "Energy Tracker";
            // 
            // labHome
            // 
            this.labHome.AutoSize = true;
            this.labHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labHome.Location = new System.Drawing.Point(667, 76);
            this.labHome.Name = "labHome";
            this.labHome.Size = new System.Drawing.Size(52, 20);
            this.labHome.TabIndex = 28;
            this.labHome.Text = "Home";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(338, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 30;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.Coral;
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPrev.Location = new System.Drawing.Point(789, 138);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(80, 56);
            this.btnPrev.TabIndex = 31;
            this.btnPrev.Text = "Previous";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click_1);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Coral;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNext.Location = new System.Drawing.Point(789, 365);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(80, 63);
            this.btnNext.TabIndex = 32;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
            // 
            // LogAppliances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(881, 450);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.laEnergyTracker);
            this.Controls.Add(this.labHome);
            this.Controls.Add(this.btnAddAppliance);
            this.Controls.Add(this.listBoxHistory);
            this.Controls.Add(this.btnback9);
            this.Controls.Add(this.btnback8);
            this.Controls.Add(this.txtAppName);
            this.Controls.Add(this.txtEnergyUse);
            this.Controls.Add(this.txtUseDur);
            this.Controls.Add(this.txtHis);
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
        private System.Windows.Forms.TextBox txtAppName;
        private System.Windows.Forms.TextBox txtEnergyUse;
        private System.Windows.Forms.TextBox txtUseDur;
        private System.Windows.Forms.TextBox txtHis;
        private System.Windows.Forms.Label labelHist;
        private System.Windows.Forms.Label labelEnergyUsageDesc;
        private System.Windows.Forms.Label labelUsageDuration;
        private System.Windows.Forms.Label labelApplianceName;
        private System.Windows.Forms.Button btnback8;
        private System.Windows.Forms.Button btnback9;
        private System.Windows.Forms.ListBox listBoxHistory;
        private System.Windows.Forms.Button btnAddAppliance;
        private System.Windows.Forms.Label laEnergyTracker;
        private System.Windows.Forms.Label labHome;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
    }
}