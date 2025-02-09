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
            this.labelCompGoalLog = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCompGoalLog
            // 
            this.labelCompGoalLog.AutoSize = true;
            this.labelCompGoalLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelCompGoalLog.Location = new System.Drawing.Point(279, 9);
            this.labelCompGoalLog.Name = "labelCompGoalLog";
            this.labelCompGoalLog.Size = new System.Drawing.Size(212, 26);
            this.labelCompGoalLog.TabIndex = 0;
            this.labelCompGoalLog.Text = "Completed Goal Log";
            // 
            // CompletedGoalLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCompGoalLog);
            this.Name = "CompletedGoalLog";
            this.Text = "CompletedGoalLog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCompGoalLog;
    }
}