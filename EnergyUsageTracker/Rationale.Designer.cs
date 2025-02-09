namespace EnergyUsageTracker
{
    partial class Rationale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rationale));
            this.labelRationale = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnback5 = new System.Windows.Forms.Button();
            this.btnback7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRationale
            // 
            this.labelRationale.AutoSize = true;
            this.labelRationale.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelRationale.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelRationale.Location = new System.Drawing.Point(346, 9);
            this.labelRationale.Name = "labelRationale";
            this.labelRationale.Size = new System.Drawing.Size(104, 26);
            this.labelRationale.TabIndex = 4;
            this.labelRationale.Text = "Rationale";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(115, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(570, 225);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnback5
            // 
            this.btnback5.BackColor = System.Drawing.Color.Coral;
            this.btnback5.Image = ((System.Drawing.Image)(resources.GetObject("btnback5.Image")));
            this.btnback5.Location = new System.Drawing.Point(601, 8);
            this.btnback5.Name = "btnback5";
            this.btnback5.Size = new System.Drawing.Size(187, 64);
            this.btnback5.TabIndex = 6;
            this.btnback5.UseVisualStyleBackColor = false;
            this.btnback5.Click += new System.EventHandler(this.btnback5_Click);
            // 
            // btnback7
            // 
            this.btnback7.BackColor = System.Drawing.Color.Coral;
            this.btnback7.Image = ((System.Drawing.Image)(resources.GetObject("btnback7.Image")));
            this.btnback7.Location = new System.Drawing.Point(12, 8);
            this.btnback7.Name = "btnback7";
            this.btnback7.Size = new System.Drawing.Size(187, 64);
            this.btnback7.TabIndex = 7;
            this.btnback7.UseVisualStyleBackColor = false;
            this.btnback7.Click += new System.EventHandler(this.btnback7_Click);
            // 
            // Rationale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnback7);
            this.Controls.Add(this.btnback5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelRationale);
            this.Name = "Rationale";
            this.Text = "Rationale";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRationale;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnback5;
        private System.Windows.Forms.Button btnback7;
    }
}