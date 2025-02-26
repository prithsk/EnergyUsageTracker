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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.labelSettings = new System.Windows.Forms.Label();
            this.labelNotifications = new System.Windows.Forms.Label();
            this.labelTotalEnergyUsageStored = new System.Windows.Forms.Label();
            this.txtBoxTotalEnergyUsageStored = new System.Windows.Forms.TextBox();
            this.btnback3 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.laellHome = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSettings
            // 
            this.labelSettings.AutoSize = true;
            this.labelSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelSettings.Location = new System.Drawing.Point(367, 9);
            this.labelSettings.Name = "labelSettings";
            this.labelSettings.Size = new System.Drawing.Size(91, 26);
            this.labelSettings.TabIndex = 3;
            this.labelSettings.Text = "Settings";
            // 
            // labelNotifications
            // 
            this.labelNotifications.AutoSize = true;
            this.labelNotifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelNotifications.ForeColor = System.Drawing.SystemColors.ControlText;
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
            this.labelTotalEnergyUsageStored.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelTotalEnergyUsageStored.Location = new System.Drawing.Point(228, 268);
            this.labelTotalEnergyUsageStored.Name = "labelTotalEnergyUsageStored";
            this.labelTotalEnergyUsageStored.Size = new System.Drawing.Size(265, 20);
            this.labelTotalEnergyUsageStored.TabIndex = 6;
            this.labelTotalEnergyUsageStored.Text = "Total Energy Usage Stored (Joules):";
            // 
            // txtBoxTotalEnergyUsageStored
            // 
            this.txtBoxTotalEnergyUsageStored.Location = new System.Drawing.Point(499, 270);
            this.txtBoxTotalEnergyUsageStored.Name = "txtBoxTotalEnergyUsageStored";
            this.txtBoxTotalEnergyUsageStored.Size = new System.Drawing.Size(106, 20);
            this.txtBoxTotalEnergyUsageStored.TabIndex = 9;
            // 
            // btnback3
            // 
            this.btnback3.BackColor = System.Drawing.Color.Coral;
            this.btnback3.Image = ((System.Drawing.Image)(resources.GetObject("btnback3.Image")));
            this.btnback3.Location = new System.Drawing.Point(629, 9);
            this.btnback3.Name = "btnback3";
            this.btnback3.Size = new System.Drawing.Size(159, 64);
            this.btnback3.TabIndex = 14;
            this.btnback3.UseVisualStyleBackColor = false;
            this.btnback3.Click += new System.EventHandler(this.btnback3_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(635, 150);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 16;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // laellHome
            // 
            this.laellHome.AutoSize = true;
            this.laellHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.laellHome.Location = new System.Drawing.Point(680, 76);
            this.laellHome.Name = "laellHome";
            this.laellHome.Size = new System.Drawing.Size(52, 20);
            this.laellHome.TabIndex = 17;
            this.laellHome.Text = "Home";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Light Mode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(232, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Dark Mode";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.laellHome);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.btnback3);
            this.Controls.Add(this.txtBoxTotalEnergyUsageStored);
            this.Controls.Add(this.labelTotalEnergyUsageStored);
            this.Controls.Add(this.labelNotifications);
            this.Controls.Add(this.labelSettings);
            this.Name = "Settings";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSettings;
        private System.Windows.Forms.Label labelNotifications;
        private System.Windows.Forms.Label labelTotalEnergyUsageStored;
        private System.Windows.Forms.TextBox txtBoxTotalEnergyUsageStored;
        private System.Windows.Forms.Button btnback3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label laellHome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}