namespace EnergyUsageTracker
{
    partial class Recommendations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recommendations));
            this.labelRecommendations = new System.Windows.Forms.Label();
            this.btnSetGoals = new System.Windows.Forms.Button();
            this.btnPlanFutureEnergyUsage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnback2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRecommendations
            // 
            this.labelRecommendations.AutoSize = true;
            this.labelRecommendations.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelRecommendations.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelRecommendations.Location = new System.Drawing.Point(295, 9);
            this.labelRecommendations.Name = "labelRecommendations";
            this.labelRecommendations.Size = new System.Drawing.Size(195, 26);
            this.labelRecommendations.TabIndex = 2;
            this.labelRecommendations.Text = "Recommendations";
            // 
            // btnSetGoals
            // 
            this.btnSetGoals.BackColor = System.Drawing.Color.Coral;
            this.btnSetGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSetGoals.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSetGoals.Location = new System.Drawing.Point(532, 199);
            this.btnSetGoals.Name = "btnSetGoals";
            this.btnSetGoals.Size = new System.Drawing.Size(174, 52);
            this.btnSetGoals.TabIndex = 6;
            this.btnSetGoals.Text = "Set Goals";
            this.btnSetGoals.UseVisualStyleBackColor = false;
            this.btnSetGoals.Click += new System.EventHandler(this.btnSetGoals_Click_1);
            // 
            // btnPlanFutureEnergyUsage
            // 
            this.btnPlanFutureEnergyUsage.BackColor = System.Drawing.Color.Coral;
            this.btnPlanFutureEnergyUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPlanFutureEnergyUsage.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnPlanFutureEnergyUsage.Location = new System.Drawing.Point(95, 199);
            this.btnPlanFutureEnergyUsage.Name = "btnPlanFutureEnergyUsage";
            this.btnPlanFutureEnergyUsage.Size = new System.Drawing.Size(214, 52);
            this.btnPlanFutureEnergyUsage.TabIndex = 5;
            this.btnPlanFutureEnergyUsage.Text = "Plan Future Energy Usage";
            this.btnPlanFutureEnergyUsage.UseVisualStyleBackColor = false;
            this.btnPlanFutureEnergyUsage.Click += new System.EventHandler(this.btnPlanFutureEnergyUsage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(604, -42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(0, 0);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnback2
            // 
            this.btnback2.BackColor = System.Drawing.Color.Coral;
            this.btnback2.Image = ((System.Drawing.Image)(resources.GetObject("btnback2.Image")));
            this.btnback2.Location = new System.Drawing.Point(601, 9);
            this.btnback2.Name = "btnback2";
            this.btnback2.Size = new System.Drawing.Size(187, 64);
            this.btnback2.TabIndex = 8;
            this.btnback2.UseVisualStyleBackColor = false;
            this.btnback2.Click += new System.EventHandler(this.btnback2_Click);
            // 
            // Recommendations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnback2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSetGoals);
            this.Controls.Add(this.btnPlanFutureEnergyUsage);
            this.Controls.Add(this.labelRecommendations);
            this.Name = "Recommendations";
            this.Text = "Recommendations";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRecommendations;
        private System.Windows.Forms.Button btnSetGoals;
        private System.Windows.Forms.Button btnPlanFutureEnergyUsage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnback2;
    }
}