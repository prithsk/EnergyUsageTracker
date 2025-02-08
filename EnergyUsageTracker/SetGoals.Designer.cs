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
            this.labelSetGoals = new System.Windows.Forms.Label();
            this.btnCompletedGoalLog = new System.Windows.Forms.Button();
            this.btnAddGoals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSetGoals
            // 
            this.labelSetGoals.AutoSize = true;
            this.labelSetGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelSetGoals.Location = new System.Drawing.Point(342, 9);
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
            this.btnCompletedGoalLog.Location = new System.Drawing.Point(525, 154);
            this.btnCompletedGoalLog.Name = "btnCompletedGoalLog";
            this.btnCompletedGoalLog.Size = new System.Drawing.Size(174, 52);
            this.btnCompletedGoalLog.TabIndex = 4;
            this.btnCompletedGoalLog.Text = "Completed Goal Log";
            this.btnCompletedGoalLog.UseVisualStyleBackColor = false;
            // 
            // btnAddGoals
            // 
            this.btnAddGoals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAddGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddGoals.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnAddGoals.Location = new System.Drawing.Point(89, 154);
            this.btnAddGoals.Name = "btnAddGoals";
            this.btnAddGoals.Size = new System.Drawing.Size(174, 52);
            this.btnAddGoals.TabIndex = 3;
            this.btnAddGoals.Text = "Add Goals";
            this.btnAddGoals.UseVisualStyleBackColor = false;
            // 
            // SetGoals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}