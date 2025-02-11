namespace EnergyUsageTracker
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.labelAbout = new System.Windows.Forms.Label();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnRationale = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.labellHome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAbout
            // 
            this.labelAbout.AutoSize = true;
            this.labelAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelAbout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelAbout.Location = new System.Drawing.Point(353, 9);
            this.labelAbout.Name = "labelAbout";
            this.labelAbout.Size = new System.Drawing.Size(69, 26);
            this.labelAbout.TabIndex = 1;
            this.labelAbout.Text = "About";
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.Coral;
            this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnHistory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHistory.Location = new System.Drawing.Point(531, 186);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(174, 52);
            this.btnHistory.TabIndex = 4;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click_1);
            // 
            // btnRationale
            // 
            this.btnRationale.BackColor = System.Drawing.Color.Coral;
            this.btnRationale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRationale.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnRationale.Location = new System.Drawing.Point(95, 186);
            this.btnRationale.Name = "btnRationale";
            this.btnRationale.Size = new System.Drawing.Size(174, 52);
            this.btnRationale.TabIndex = 3;
            this.btnRationale.Text = "Rationale";
            this.btnRationale.UseVisualStyleBackColor = false;
            this.btnRationale.Click += new System.EventHandler(this.btnRationale_Click_1);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Coral;
            this.btnback.Image = ((System.Drawing.Image)(resources.GetObject("btnback.Image")));
            this.btnback.Location = new System.Drawing.Point(601, 9);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(187, 64);
            this.btnback.TabIndex = 5;
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // labellHome
            // 
            this.labellHome.AutoSize = true;
            this.labellHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labellHome.Location = new System.Drawing.Point(669, 76);
            this.labellHome.Name = "labellHome";
            this.labellHome.Size = new System.Drawing.Size(52, 20);
            this.labellHome.TabIndex = 6;
            this.labellHome.Text = "Home";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labellHome);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnRationale);
            this.Controls.Add(this.labelAbout);
            this.Name = "About";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAbout;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnRationale;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label labellHome;
    }
}