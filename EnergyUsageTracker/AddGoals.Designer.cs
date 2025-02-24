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
            this.labeHome = new System.Windows.Forms.Label();
            this.labSetGoals = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblNameGoal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGoalName = new System.Windows.Forms.TextBox();
            this.txtProgress = new System.Windows.Forms.TextBox();
            this.txtDifficulty = new System.Windows.Forms.TextBox();
            this.btnAddGoal = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblEntryCount = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnback1212 = new System.Windows.Forms.Button();
            this.lrec = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAddGoals
            // 
            this.labelAddGoals.AutoSize = true;
            this.labelAddGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelAddGoals.Location = new System.Drawing.Point(356, 9);
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
            this.btnback12.Location = new System.Drawing.Point(643, 9);
            this.btnback12.Name = "btnback12";
            this.btnback12.Size = new System.Drawing.Size(175, 64);
            this.btnback12.TabIndex = 24;
            this.btnback12.UseVisualStyleBackColor = false;
            this.btnback12.Click += new System.EventHandler(this.btnback12_Click);
            // 
            // labeHome
            // 
            this.labeHome.AutoSize = true;
            this.labeHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labeHome.Location = new System.Drawing.Point(705, 76);
            this.labeHome.Name = "labeHome";
            this.labeHome.Size = new System.Drawing.Size(52, 20);
            this.labeHome.TabIndex = 26;
            this.labeHome.Text = "Home";
            // 
            // labSetGoals
            // 
            this.labSetGoals.AutoSize = true;
            this.labSetGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labSetGoals.Location = new System.Drawing.Point(63, 76);
            this.labSetGoals.Name = "labSetGoals";
            this.labSetGoals.Size = new System.Drawing.Size(80, 20);
            this.labSetGoals.TabIndex = 27;
            this.labSetGoals.Text = "Set Goals";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(207, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(418, 229);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblNameGoal
            // 
            this.lblNameGoal.AutoSize = true;
            this.lblNameGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNameGoal.Location = new System.Drawing.Point(35, 109);
            this.lblNameGoal.Name = "lblNameGoal";
            this.lblNameGoal.Size = new System.Drawing.Size(111, 20);
            this.lblNameGoal.TabIndex = 29;
            this.lblNameGoal.Text = "Name of Goal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(49, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Progress:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(52, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Difficulty:";
            // 
            // txtGoalName
            // 
            this.txtGoalName.Location = new System.Drawing.Point(27, 145);
            this.txtGoalName.Name = "txtGoalName";
            this.txtGoalName.Size = new System.Drawing.Size(140, 20);
            this.txtGoalName.TabIndex = 32;
            // 
            // txtProgress
            // 
            this.txtProgress.Location = new System.Drawing.Point(27, 213);
            this.txtProgress.Name = "txtProgress";
            this.txtProgress.Size = new System.Drawing.Size(140, 20);
            this.txtProgress.TabIndex = 33;
            // 
            // txtDifficulty
            // 
            this.txtDifficulty.Location = new System.Drawing.Point(27, 269);
            this.txtDifficulty.Name = "txtDifficulty";
            this.txtDifficulty.Size = new System.Drawing.Size(140, 20);
            this.txtDifficulty.TabIndex = 34;
            // 
            // btnAddGoal
            // 
            this.btnAddGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddGoal.Location = new System.Drawing.Point(39, 319);
            this.btnAddGoal.Name = "btnAddGoal";
            this.btnAddGoal.Size = new System.Drawing.Size(95, 34);
            this.btnAddGoal.TabIndex = 35;
            this.btnAddGoal.Text = "Add Goal";
            this.btnAddGoal.UseVisualStyleBackColor = true;
            this.btnAddGoal.Click += new System.EventHandler(this.btnAddGoal_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPrev.Location = new System.Drawing.Point(678, 109);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(95, 34);
            this.btnPrev.TabIndex = 36;
            this.btnPrev.Text = "Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnNext.Location = new System.Drawing.Point(678, 319);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(95, 34);
            this.btnNext.TabIndex = 37;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblEntryCount
            // 
            this.lblEntryCount.AutoSize = true;
            this.lblEntryCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblEntryCount.Location = new System.Drawing.Point(339, 51);
            this.lblEntryCount.Name = "lblEntryCount";
            this.lblEntryCount.Size = new System.Drawing.Size(169, 22);
            this.lblEntryCount.TabIndex = 38;
            this.lblEntryCount.Text = "Displaying 5 Entries";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(361, 357);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 39;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnback1212
            // 
            this.btnback1212.BackColor = System.Drawing.Color.Coral;
            this.btnback1212.Image = ((System.Drawing.Image)(resources.GetObject("btnback1212.Image")));
            this.btnback1212.Location = new System.Drawing.Point(643, 170);
            this.btnback1212.Name = "btnback1212";
            this.btnback1212.Size = new System.Drawing.Size(175, 75);
            this.btnback1212.TabIndex = 40;
            this.btnback1212.UseVisualStyleBackColor = false;
            this.btnback1212.Click += new System.EventHandler(this.btnback1212_Click);
            // 
            // lrec
            // 
            this.lrec.AutoSize = true;
            this.lrec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lrec.Location = new System.Drawing.Point(661, 246);
            this.lrec.Name = "lrec";
            this.lrec.Size = new System.Drawing.Size(143, 20);
            this.lrec.TabIndex = 41;
            this.lrec.Text = "Recommendations";
            // 
            // AddGoals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(830, 401);
            this.Controls.Add(this.lrec);
            this.Controls.Add(this.btnback1212);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblEntryCount);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnAddGoal);
            this.Controls.Add(this.txtDifficulty);
            this.Controls.Add(this.txtProgress);
            this.Controls.Add(this.txtGoalName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNameGoal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labSetGoals);
            this.Controls.Add(this.labeHome);
            this.Controls.Add(this.btnback13);
            this.Controls.Add(this.btnback12);
            this.Controls.Add(this.labelAddGoals);
            this.Name = "AddGoals";
            this.Text = "AddGoals";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddGoals;
        private System.Windows.Forms.Button btnback13;
        private System.Windows.Forms.Button btnback12;
        private System.Windows.Forms.Label labeHome;
        private System.Windows.Forms.Label labSetGoals;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblNameGoal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGoalName;
        private System.Windows.Forms.TextBox txtProgress;
        private System.Windows.Forms.TextBox txtDifficulty;
        private System.Windows.Forms.Button btnAddGoal;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblEntryCount;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnback1212;
        private System.Windows.Forms.Label lrec;
    }
}