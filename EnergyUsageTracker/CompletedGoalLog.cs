using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace EnergyUsageTracker
{
    public partial class CompletedGoalLog : Form
    {
        private int currentPage = 0;
        private const int maxEntriesPerPage = 5;

        private List<CompletedEnergyGoal> completedGoals = new List<CompletedEnergyGoal>
        {
            new CompletedEnergyGoal { Goal = "Reduce Energy Usage by 10%", Details = "Achieved by monitoring appliance consumption.", CompletionDate = new DateTime(2024, 1, 10) },
            new CompletedEnergyGoal { Goal = "Replace Inefficient Appliances", Details = "Replaced old refrigerator with energy-efficient model.", CompletionDate = new DateTime(2024, 2, 5) },
            new CompletedEnergyGoal { Goal = "Track Peak-Hour Usage", Details = "Logged and minimized energy consumption during peak hours.", CompletionDate = new DateTime(2024, 3, 12) },
            new CompletedEnergyGoal { Goal = "Install LED Lighting", Details = "Installed energy-saving LED bulbs in the entire house.", CompletionDate = new DateTime(2024, 4, 20) },
            new CompletedEnergyGoal { Goal = "Reduce Monthly Energy Bill", Details = "Achieved 15% reduction in energy costs.", CompletionDate = new DateTime(2024, 5, 18) }
        };

        public CompletedGoalLog()
        {
            InitializeComponent();
            CenterToScreen();
            DisplayCurrentPage();
        }

        private void DisplayCurrentPage()
        {
            var pageGoals = completedGoals
                .Skip(currentPage * maxEntriesPerPage)
                .Take(maxEntriesPerPage)
                .ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = pageGoals;
        }

        private void btnAddGoal_Click(object sender, EventArgs e)
        {
            string goalName = txtGoalCompleName.Text;
            string details = txtDet.Text;
            DateTime completionDate = dateTimePicker1.Value.Date;

            if (string.IsNullOrWhiteSpace(goalName))
            {
                MessageBox.Show("Please enter a goal name.");
                return;
            }

            completedGoals.Add(new CompletedEnergyGoal
            {
                Goal = goalName,
                Details = details,
                CompletionDate = completionDate
            });

            DisplayCurrentPage();
            txtGoalCompleName.Clear();
            txtDet.Clear();
            dateTimePicker1.Value = DateTime.Today;
        }

        private void btnback14_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(() => Application.Run(new HomePage()));
            t.Start();
        }

        private void btnback15_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(() => Application.Run(new SetGoals()));
            t.Start();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                DisplayCurrentPage();
            }
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            if ((currentPage + 1) * maxEntriesPerPage < completedGoals.Count)
            {
                currentPage++;
                DisplayCurrentPage();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < completedGoals.Count)
            {
                var selectedGoal = completedGoals[e.RowIndex];
                MessageBox.Show($"Goal: {selectedGoal.Goal}\nDetails: {selectedGoal.Details}\nDate: {selectedGoal.CompletionDate.ToShortDateString()}",
                                "Completed Goal Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

    public class CompletedEnergyGoal
    {
        public string Goal { get; set; }
        public string Details { get; set; }
        public DateTime CompletionDate { get; set; }
    }
}