namespace EnergyUsageTracker
{
    partial class History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            this.labelHistory = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnback4 = new System.Windows.Forms.Button();
            this.btnback6 = new System.Windows.Forms.Button();
            this.laHome = new System.Windows.Forms.Label();
            this.laAbout = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHistory
            // 
            this.labelHistory.AutoSize = true;
            this.labelHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelHistory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelHistory.Location = new System.Drawing.Point(351, 9);
            this.labelHistory.Name = "labelHistory";
            this.labelHistory.Size = new System.Drawing.Size(80, 26);
            this.labelHistory.TabIndex = 5;
            this.labelHistory.Text = "History";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(36, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(734, 303);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnback4
            // 
            this.btnback4.BackColor = System.Drawing.Color.Coral;
            this.btnback4.Image = ((System.Drawing.Image)(resources.GetObject("btnback4.Image")));
            this.btnback4.Location = new System.Drawing.Point(601, 9);
            this.btnback4.Name = "btnback4";
            this.btnback4.Size = new System.Drawing.Size(187, 64);
            this.btnback4.TabIndex = 7;
            this.btnback4.UseVisualStyleBackColor = false;
            this.btnback4.Click += new System.EventHandler(this.btnback4_Click);
            // 
            // btnback6
            // 
            this.btnback6.BackColor = System.Drawing.Color.Coral;
            this.btnback6.Image = ((System.Drawing.Image)(resources.GetObject("btnback6.Image")));
            this.btnback6.Location = new System.Drawing.Point(12, 9);
            this.btnback6.Name = "btnback6";
            this.btnback6.Size = new System.Drawing.Size(187, 64);
            this.btnback6.TabIndex = 8;
            this.btnback6.UseVisualStyleBackColor = false;
            this.btnback6.Click += new System.EventHandler(this.btnback6_Click);
            // 
            // laHome
            // 
            this.laHome.AutoSize = true;
            this.laHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.laHome.Location = new System.Drawing.Point(671, 76);
            this.laHome.Name = "laHome";
            this.laHome.Size = new System.Drawing.Size(52, 20);
            this.laHome.TabIndex = 9;
            this.laHome.Text = "Home";
            // 
            // laAbout
            // 
            this.laAbout.AutoSize = true;
            this.laAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.laAbout.Location = new System.Drawing.Point(79, 76);
            this.laAbout.Name = "laAbout";
            this.laAbout.Size = new System.Drawing.Size(52, 20);
            this.laAbout.TabIndex = 10;
            this.laAbout.Text = "About";
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.laAbout);
            this.Controls.Add(this.laHome);
            this.Controls.Add(this.btnback6);
            this.Controls.Add(this.btnback4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelHistory);
            this.Name = "History";
            this.Text = "History";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHistory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnback4;
        private System.Windows.Forms.Button btnback6;
        private System.Windows.Forms.Label laHome;
        private System.Windows.Forms.Label laAbout;
    }
}