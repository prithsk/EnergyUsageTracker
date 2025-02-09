namespace EnergyUsageTracker
{
    partial class AddGoals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGoals));
            this.labelAddGoals = new System.Windows.Forms.Label();
            this.btnback13 = new System.Windows.Forms.Button();
            this.btnback12 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAddGoals
            // 
            this.labelAddGoals.AutoSize = true;
            this.labelAddGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelAddGoals.Location = new System.Drawing.Point(338, 9);
            this.labelAddGoals.Name = "labelAddGoals";
            this.labelAddGoals.Size = new System.Drawing.Size(114, 26);
            this.labelAddGoals.TabIndex = 0;
            this.labelAddGoals.Text = "Add Goals";
            // 
            // btnback13
            // 
            this.btnback13.BackColor = System.Drawing.Color.Coral;
            this.btnback13.Image = ((System.Drawing.Image)(resources.GetObject("btnback13.Image")));
            this.btnback13.Location = new System.Drawing.Point(12, 9);
            this.btnback13.Name = "btnback13";
            this.btnback13.Size = new System.Drawing.Size(187, 64);
            this.btnback13.TabIndex = 25;
            this.btnback13.UseVisualStyleBackColor = false;
            this.btnback13.Click += new System.EventHandler(this.btnback13_Click);
            // 
            // btnback12
            // 
            this.btnback12.BackColor = System.Drawing.Color.Coral;
            this.btnback12.Image = ((System.Drawing.Image)(resources.GetObject("btnback12.Image")));
            this.btnback12.Location = new System.Drawing.Point(601, 9);
            this.btnback12.Name = "btnback12";
            this.btnback12.Size = new System.Drawing.Size(187, 64);
            this.btnback12.TabIndex = 24;
            this.btnback12.UseVisualStyleBackColor = false;
            this.btnback12.Click += new System.EventHandler(this.btnback12_Click);
            // 
            // AddGoals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnback13);
            this.Controls.Add(this.btnback12);
            this.Controls.Add(this.labelAddGoals);
            this.Name = "AddGoals";
            this.Text = "AddGoals";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddGoals;
        private System.Windows.Forms.Button btnback13;
        private System.Windows.Forms.Button btnback12;
    }
}