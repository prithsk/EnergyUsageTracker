using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace EnergyUsageTracker
{
    public partial class LogAppliances : Form
    {
        private List<string> applianceHistory = new List<string>();

        public LogAppliances()
        {
            InitializeComponent();
            CenterToScreen();
            LoadHistory();

            comboBox1.Items.Add("Sort A → Z");
            comboBox1.Items.Add("Sort Z → A");
            comboBox1.Items.Add("Sort by Wattage (Low → High)");
            comboBox1.Items.Add("Sort by Wattage (High → Low)");
            comboBox1.Items.Add("Sort by Time (Short → Long)");
            comboBox1.Items.Add("Sort by Time (Long → Short)");

            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void LoadHistory()
        {
            applianceHistory.Add("Fridge - 200W - 5 hrs");
            applianceHistory.Add("Microwave - 1000W - 10 mins");
            UpdateHistoryDisplay();
        }

        private void UpdateHistoryDisplay()
        {
            listBoxHistory.DataSource = null;
            listBoxHistory.DataSource = new List<string>(applianceHistory);
        }
        private void btnback8_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(Threadbtnback8));
            t.Start();
        }

        private void Threadbtnback8()
        {
            Application.Run(new HomePage());
        }
        private void btnback9_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(Threadbtnback9));
            t.Start();
        }

        private void Threadbtnback9()
        {
            Application.Run(new EnergyTracker());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) return;

            string selectedOption = comboBox1.SelectedItem.ToString();

            if (selectedOption == "Sort A → Z")
            {
                applianceHistory.Sort();
            }
            else if (selectedOption == "Sort Z → A")
            {
                applianceHistory.Sort();
                applianceHistory.Reverse();
            }
            else if (selectedOption == "Sort by Wattage (Low → High)")
            {
                applianceHistory = applianceHistory.OrderBy(GetWattage).ToList();
            }
            else if (selectedOption == "Sort by Wattage (High → Low)")
            {
                applianceHistory = applianceHistory.OrderByDescending(GetWattage).ToList();
            }
            else if (selectedOption == "Sort by Time (Short → Long)")
            {
                applianceHistory = applianceHistory.OrderBy(GetUsageTime).ToList();
            }
            else if (selectedOption == "Sort by Time (Long → Short)")
            {
                applianceHistory = applianceHistory.OrderByDescending(GetUsageTime).ToList();
            }

            UpdateHistoryDisplay();
        }

        private int GetWattage(string entry)
        {
            Match match = Regex.Match(entry, @"(\d+)W");
            return match.Success ? int.Parse(match.Groups[1].Value) : 0;
        }

        private double GetUsageTime(string entry)
        {
            Match match = Regex.Match(entry, @"(\d+)\s*(hrs|min)");
            if (!match.Success) return 0;

            double value = double.Parse(match.Groups[1].Value);
            return match.Groups[2].Value == "min" ? value / 60.0 : value;
        }

        private void btnAddAppliance_Click_1(object sender, EventArgs e)
        {
            string applianceName = txtAppName.Text;
            string usageDuration = txtUseDur.Text;
            string wattage = txtEnergyUse.Text;

            if (string.IsNullOrWhiteSpace(applianceName) || string.IsNullOrWhiteSpace(usageDuration) || string.IsNullOrWhiteSpace(wattage))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string newEntry = $"{applianceName} - {wattage}W - {usageDuration} hrs";

            applianceHistory.Add(newEntry);
            UpdateHistoryDisplay();
        }
    }
}