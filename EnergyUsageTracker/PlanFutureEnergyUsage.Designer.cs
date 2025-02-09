namespace EnergyUsageTracker
{
    partial class PlanFutureEnergyUsage
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
            this.labelPlanFutureEnergyUsage = new System.Windows.Forms.Label();
            this.labelStrength = new System.Windows.Forms.Label();
            this.labelWeakness = new System.Windows.Forms.Label();
            this.labelEnergySavingGoal = new System.Windows.Forms.Label();
            this.labelRec = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelPlanFutureEnergyUsage
            // 
            this.labelPlanFutureEnergyUsage.AutoSize = true;
            this.labelPlanFutureEnergyUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelPlanFutureEnergyUsage.Location = new System.Drawing.Point(286, 9);
            this.labelPlanFutureEnergyUsage.Name = "labelPlanFutureEnergyUsage";
            this.labelPlanFutureEnergyUsage.Size = new System.Drawing.Size(268, 26);
            this.labelPlanFutureEnergyUsage.TabIndex = 0;
            this.labelPlanFutureEnergyUsage.Text = "Plan Future Energy Usage";
            // 
            // labelStrength
            // 
            this.labelStrength.AutoSize = true;
            this.labelStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelStrength.Location = new System.Drawing.Point(149, 83);
            this.labelStrength.Name = "labelStrength";
            this.labelStrength.Size = new System.Drawing.Size(118, 20);
            this.labelStrength.TabIndex = 1;
            this.labelStrength.Text = "Enter Strength:";
            // 
            // labelWeakness
            // 
            this.labelWeakness.AutoSize = true;
            this.labelWeakness.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelWeakness.Location = new System.Drawing.Point(149, 182);
            this.labelWeakness.Name = "labelWeakness";
            this.labelWeakness.Size = new System.Drawing.Size(131, 20);
            this.labelWeakness.TabIndex = 2;
            this.labelWeakness.Text = "Enter Weakness:";
            // 
            // labelEnergySavingGoal
            // 
            this.labelEnergySavingGoal.AutoSize = true;
            this.labelEnergySavingGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEnergySavingGoal.Location = new System.Drawing.Point(149, 289);
            this.labelEnergySavingGoal.Name = "labelEnergySavingGoal";
            this.labelEnergySavingGoal.Size = new System.Drawing.Size(153, 20);
            this.labelEnergySavingGoal.TabIndex = 3;
            this.labelEnergySavingGoal.Text = "Energy Saving Goal:";
            // 
            // labelRec
            // 
            this.labelRec.AutoSize = true;
            this.labelRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelRec.Location = new System.Drawing.Point(522, 83);
            this.labelRec.Name = "labelRec";
            this.labelRec.Size = new System.Drawing.Size(147, 20);
            this.labelRec.TabIndex = 4;
            this.labelRec.Text = "Recommendations:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(526, 106);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(186, 267);
            this.textBox4.TabIndex = 8;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.DarkOrange;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnGenerate.Location = new System.Drawing.Point(361, 162);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(123, 102);
            this.btnGenerate.TabIndex = 9;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(144, 205);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(158, 57);
            this.textBox5.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(144, 312);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 61);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(144, 106);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(158, 53);
            this.textBox3.TabIndex = 12;
            // 
            // PlanFutureEnergyUsage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.labelRec);
            this.Controls.Add(this.labelEnergySavingGoal);
            this.Controls.Add(this.labelWeakness);
            this.Controls.Add(this.labelStrength);
            this.Controls.Add(this.labelPlanFutureEnergyUsage);
            this.Name = "PlanFutureEnergyUsage";
            this.Text = "PlanFutureEnergyUsage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPlanFutureEnergyUsage;
        private System.Windows.Forms.Label labelStrength;
        private System.Windows.Forms.Label labelWeakness;
        private System.Windows.Forms.Label labelEnergySavingGoal;
        private System.Windows.Forms.Label labelRec;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}