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
            this.labelAddGoals = new System.Windows.Forms.Label();
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
            // AddGoals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelAddGoals);
            this.Name = "AddGoals";
            this.Text = "AddGoals";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddGoals;
    }
}