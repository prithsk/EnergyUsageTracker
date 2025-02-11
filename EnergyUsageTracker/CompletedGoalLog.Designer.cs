namespace EnergyUsageTracker
{
    partial class CompletedGoalLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompletedGoalLog));
            this.labelCompGoalLog = new System.Windows.Forms.Label();
            this.btnback15 = new System.Windows.Forms.Button();
            this.btnback14 = new System.Windows.Forms.Button();
            this.laSetGoals = new System.Windows.Forms.Label();
            this.labHome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCompGoalLog
            // 
            this.labelCompGoalLog.AutoSize = true;
            this.labelCompGoalLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelCompGoalLog.Location = new System.Drawing.Point(301, 9);
            this.labelCompGoalLog.Name = "labelCompGoalLog";
            this.labelCompGoalLog.Size = new System.Drawing.Size(212, 26);
            this.labelCompGoalLog.TabIndex = 0;
            this.labelCompGoalLog.Text = "Completed Goal Log";
            // 
            // btnback15
            // 
            this.btnback15.BackColor = System.Drawing.Color.Coral;
            this.btnback15.Image = ((System.Drawing.Image)(resources.GetObject("btnback15.Image")));
            this.btnback15.Location = new System.Drawing.Point(12, 9);
            this.btnback15.Name = "btnback15";
            this.btnback15.Size = new System.Drawing.Size(187, 64);
            this.btnback15.TabIndex = 25;
            this.btnback15.UseVisualStyleBackColor = false;
            this.btnback15.Click += new System.EventHandler(this.btnback15_Click);
            // 
            // btnback14
            // 
            this.btnback14.BackColor = System.Drawing.Color.Coral;
            this.btnback14.Image = ((System.Drawing.Image)(resources.GetObject("btnback14.Image")));
            this.btnback14.Location = new System.Drawing.Point(601, 9);
            this.btnback14.Name = "btnback14";
            this.btnback14.Size = new System.Drawing.Size(187, 64);
            this.btnback14.TabIndex = 24;
            this.btnback14.UseVisualStyleBackColor = false;
            this.btnback14.Click += new System.EventHandler(this.btnback14_Click);
            // 
            // laSetGoals
            // 
            this.laSetGoals.AutoSize = true;
            this.laSetGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.laSetGoals.Location = new System.Drawing.Point(70, 76);
            this.laSetGoals.Name = "laSetGoals";
            this.laSetGoals.Size = new System.Drawing.Size(80, 20);
            this.laSetGoals.TabIndex = 29;
            this.laSetGoals.Text = "Set Goals";
            // 
            // labHome
            // 
            this.labHome.AutoSize = true;
            this.labHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labHome.Location = new System.Drawing.Point(673, 76);
            this.labHome.Name = "labHome";
            this.labHome.Size = new System.Drawing.Size(52, 20);
            this.labHome.TabIndex = 28;
            this.labHome.Text = "Home";
            // 
            // CompletedGoalLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.laSetGoals);
            this.Controls.Add(this.labHome);
            this.Controls.Add(this.btnback15);
            this.Controls.Add(this.btnback14);
            this.Controls.Add(this.labelCompGoalLog);
            this.Name = "CompletedGoalLog";
            this.Text = "CompletedGoalLog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCompGoalLog;
        private System.Windows.Forms.Button btnback15;
        private System.Windows.Forms.Button btnback14;
        private System.Windows.Forms.Label laSetGoals;
        private System.Windows.Forms.Label labHome;
    }
}