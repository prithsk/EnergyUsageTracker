namespace EnergyUsageTracker
{
    partial class SetGoals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetGoals));
            this.labelSetGoals = new System.Windows.Forms.Label();
            this.btnCompletedGoalLog = new System.Windows.Forms.Button();
            this.btnAddGoals = new System.Windows.Forms.Button();
            this.btnback11 = new System.Windows.Forms.Button();
            this.btnback10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSetGoals
            // 
            this.labelSetGoals.AutoSize = true;
            this.labelSetGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelSetGoals.Location = new System.Drawing.Point(360, 9);
            this.labelSetGoals.Name = "labelSetGoals";
            this.labelSetGoals.Size = new System.Drawing.Size(108, 26);
            this.labelSetGoals.TabIndex = 0;
            this.labelSetGoals.Text = "Set Goals";
            // 
            // btnCompletedGoalLog
            // 
            this.btnCompletedGoalLog.BackColor = System.Drawing.Color.Coral;
            this.btnCompletedGoalLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCompletedGoalLog.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCompletedGoalLog.Location = new System.Drawing.Point(519, 168);
            this.btnCompletedGoalLog.Name = "btnCompletedGoalLog";
            this.btnCompletedGoalLog.Size = new System.Drawing.Size(174, 52);
            this.btnCompletedGoalLog.TabIndex = 6;
            this.btnCompletedGoalLog.Text = "Completed Goal Log";
            this.btnCompletedGoalLog.UseVisualStyleBackColor = false;
            this.btnCompletedGoalLog.Click += new System.EventHandler(this.btnCompletedGoalLog_Click);
            // 
            // btnAddGoals
            // 
            this.btnAddGoals.BackColor = System.Drawing.Color.Coral;
            this.btnAddGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddGoals.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnAddGoals.Location = new System.Drawing.Point(83, 168);
            this.btnAddGoals.Name = "btnAddGoals";
            this.btnAddGoals.Size = new System.Drawing.Size(174, 52);
            this.btnAddGoals.TabIndex = 5;
            this.btnAddGoals.Text = "Add Goals";
            this.btnAddGoals.UseVisualStyleBackColor = false;
            this.btnAddGoals.Click += new System.EventHandler(this.btnAddGoals_Click);
            // 
            // btnback11
            // 
            this.btnback11.BackColor = System.Drawing.Color.Coral;
            this.btnback11.Image = ((System.Drawing.Image)(resources.GetObject("btnback11.Image")));
            this.btnback11.Location = new System.Drawing.Point(12, 9);
            this.btnback11.Name = "btnback11";
            this.btnback11.Size = new System.Drawing.Size(187, 64);
            this.btnback11.TabIndex = 25;
            this.btnback11.UseVisualStyleBackColor = false;
            this.btnback11.Click += new System.EventHandler(this.btnback11_Click);
            // 
            // btnback10
            // 
            this.btnback10.BackColor = System.Drawing.Color.Coral;
            this.btnback10.Image = ((System.Drawing.Image)(resources.GetObject("btnback10.Image")));
            this.btnback10.Location = new System.Drawing.Point(601, 9);
            this.btnback10.Name = "btnback10";
            this.btnback10.Size = new System.Drawing.Size(187, 64);
            this.btnback10.TabIndex = 24;
            this.btnback10.UseVisualStyleBackColor = false;
            this.btnback10.Click += new System.EventHandler(this.btnback10_Click);
            // 
            // SetGoals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnback11);
            this.Controls.Add(this.btnback10);
            this.Controls.Add(this.btnCompletedGoalLog);
            this.Controls.Add(this.btnAddGoals);
            this.Controls.Add(this.labelSetGoals);
            this.Name = "SetGoals";
            this.Text = "SetGoals";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSetGoals;
        private System.Windows.Forms.Button btnCompletedGoalLog;
        private System.Windows.Forms.Button btnAddGoals;
        private System.Windows.Forms.Button btnback11;
        private System.Windows.Forms.Button btnback10;
    }
}