﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace EnergyUsageTracker
{
    public partial class AddGoals : Form
    {
        private int currentPage = 0;
        private const int EntriesPerPage = 10;
        private List<GoalEntry> goalEntries = new List<GoalEntry>
        {
            new GoalEntry { PageNum = 0, Goal = "Reduce energy usage by 10%", Progress = "In Progress", Difficulty = "Medium" },
            new GoalEntry { PageNum = 0, Goal = "Track appliance energy consumption", Progress = "Completed", Difficulty = "Easy" },
            new GoalEntry { PageNum = 1, Goal = "Replace inefficient appliances", Progress = "Pending", Difficulty = "Hard" },
            new GoalEntry { PageNum = 1, Goal = "Reduce peak-hour usage", Progress = "In Progress", Difficulty = "Medium" },
            new GoalEntry { PageNum = 2, Goal = "Install energy-saving lighting", Progress = "Not Started", Difficulty = "Easy" }
        };

        public AddGoals()
        {
            InitializeComponent();
            CenterToScreen();
            LoadPageData();
            PopulateComboBox();
        }

        private void LoadPageData()
        {
            var paginatedGoals = goalEntries
                .Where(g => g.PageNum == currentPage)
                .ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = paginatedGoals;

            lblEntryCount.Text = $"Displaying {paginatedGoals.Count} Entries | Page {currentPage + 1}/{(goalEntries.Any() ? goalEntries.Max(g => g.PageNum) + 1 : 1)}";
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                LoadPageData();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int maxPageNum = goalEntries.Any() ? goalEntries.Max(g => g.PageNum) : 0;
            if (currentPage < maxPageNum)
            {
                currentPage++;
                LoadPageData();
            }
        }

        private void btnAddGoal_Click(object sender, EventArgs e)
        {
            try
            {
                string goalName = txtGoalName.Text.Trim();
                string progress = txtProgress.Text.Trim();
                string difficulty = txtDifficulty.Text.Trim();

                if (string.IsNullOrEmpty(goalName) || string.IsNullOrEmpty(progress) || string.IsNullOrEmpty(difficulty))
                {
                    MessageBox.Show("Please fill in all fields before adding a goal.");
                    return;
                }

                int pageNum = 0;
                SortedSet<int> uniquePageNumbers = new SortedSet<int>(goalEntries.Select(g => g.PageNum));

                bool assignedPage = false;
                foreach (int page in uniquePageNumbers)
                {
                    if (goalEntries.Count(g => g.PageNum == page) < EntriesPerPage)
                    {
                        pageNum = page;
                        assignedPage = true;
                        break;
                    }
                }

                if (!assignedPage)
                {
                    pageNum = uniquePageNumbers.Any() ? uniquePageNumbers.Max() + 1 : 0;
                }

                goalEntries.Add(new GoalEntry { PageNum = pageNum, Goal = goalName, Progress = progress, Difficulty = difficulty });

                LoadPageData();
                txtGoalName.Clear();
                txtProgress.Clear();
                txtDifficulty.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter valid data for all fields.");
            }
        }

        private void btnback12_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(Threadbtnback12);
            t.Start();
        }

        private void Threadbtnback12()
        {
            Application.Run(new HomePage());
        }

        private void btnback13_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(Threadbtnback13);
            t.Start();
        }

        private void Threadbtnback13()
        {
            Application.Run(new SetGoals());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var selectedGoal = (GoalEntry)dataGridView1.Rows[e.RowIndex].DataBoundItem;

                MessageBox.Show($"Goal: {selectedGoal.Goal}\nProgress: {selectedGoal.Progress}\nDifficulty: {selectedGoal.Difficulty}",
                    "Goal Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void BubbleSortGoals(bool ascending)
        {
            int n = goalEntries.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    bool swapCondition = ascending
                        ? string.Compare(goalEntries[j].Goal, goalEntries[j + 1].Goal, StringComparison.OrdinalIgnoreCase) > 0
                        : string.Compare(goalEntries[j].Goal, goalEntries[j + 1].Goal, StringComparison.OrdinalIgnoreCase) < 0;

                    if (swapCondition)
                    {
                        var temp = goalEntries[j];
                        goalEntries[j] = goalEntries[j + 1];
                        goalEntries[j + 1] = temp;
                    }
                }
            }
        }
        private void BubbleSortGoalsByProgress(bool ascending)
        {
            int n = goalEntries.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    bool swapCondition = ascending
                        ? string.Compare(goalEntries[j].Progress, goalEntries[j + 1].Progress, StringComparison.OrdinalIgnoreCase) > 0
                        : string.Compare(goalEntries[j].Progress, goalEntries[j + 1].Progress, StringComparison.OrdinalIgnoreCase) < 0;

                    if (swapCondition)
                    {
                        var temp = goalEntries[j];
                        goalEntries[j] = goalEntries[j + 1];
                        goalEntries[j + 1] = temp;
                    }
                }
            }
        }

        private void BubbleSortGoalsByDifficulty(bool ascending)
        {
            int n = goalEntries.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    bool swapCondition = ascending
                        ? string.Compare(goalEntries[j].Difficulty, goalEntries[j + 1].Difficulty, StringComparison.OrdinalIgnoreCase) > 0
                        : string.Compare(goalEntries[j].Difficulty, goalEntries[j + 1].Difficulty, StringComparison.OrdinalIgnoreCase) < 0;

                    if (swapCondition)
                    {
                        var temp = goalEntries[j];
                        goalEntries[j] = goalEntries[j + 1];
                        goalEntries[j + 1] = temp;
                    }
                }
            }
        }
        private void PopulateComboBox()
        {
            comboBox1.Items.Add("Sort by Goal Name (A-Z)");
            comboBox1.Items.Add("Sort by Goal Name (Z-A)");
            comboBox1.Items.Add("Sort by Progress (A-Z)");
            comboBox1.Items.Add("Sort by Progress (Z-A)");
            comboBox1.Items.Add("Sort by Difficulty (Easy → Hard)");
            comboBox1.Items.Add("Sort by Difficulty (Hard → Easy)");

            comboBox1.SelectedIndex = 0;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) return;

            string selectedOption = comboBox1.SelectedItem.ToString();

            if (selectedOption == "Sort by Goal Name (A-Z)")
            {
                BubbleSortGoals(true);
            }
            else if (selectedOption == "Sort by Goal Name (Z-A)")
            {
                BubbleSortGoals(false);
            }
            else if (selectedOption == "Sort by Progress (A-Z)")
            {
                BubbleSortGoalsByProgress(true);
            }
            else if (selectedOption == "Sort by Progress (Z-A)")
            {
                BubbleSortGoalsByProgress(false);
            }
            else if (selectedOption == "Sort by Difficulty (Easy → Hard)")
            {
                BubbleSortGoalsByDifficulty(true);
            }
            else if (selectedOption == "Sort by Difficulty (Hard → Easy)")
            {
                BubbleSortGoalsByDifficulty(false);
            }

            LoadPageData();
        }
        public class GoalEntry
        {
            public int PageNum { get; set; }
            public string Goal { get; set; }
            public string Progress { get; set; }
            public string Difficulty { get; set; }
        }

        private void btnback1212_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(Threadbtnback1212);
            t.Start();
        }
        private void Threadbtnback1212()
        {
            Application.Run(new Recommendations());
        }
    }
}